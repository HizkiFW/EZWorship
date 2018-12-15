using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZWorship {
	public partial class RemoteControl : Form {

		TcpClient client;
		NetworkStream stream;
		Dictionary<string, string[]> macros;
		Queue<string> macroQueue;

		public RemoteControl() {
			InitializeComponent();
			macros = new Dictionary<string, string[]>();
			macroQueue = new Queue<string>();
		}

		private void connect() {
			try {
				Int32 port = Int32.Parse(textBox3.Text);
				client = new TcpClient(textBox1.Text, port);
				stream = client.GetStream();
			} catch(Exception ex) {
				Console.WriteLine(ex.StackTrace);
				MessageBox.Show("Failed to connect!");
			}
		}

		private void sendMessage(string message) {
			try {
				Byte[] data = System.Text.Encoding.ASCII.GetBytes(message.Trim() + '\n');
				stream.Write(data, 0, data.Length);
				Console.WriteLine("Sent: {0}", message);

				if(checkBox1.Checked) {
					textBox2.Text += message.Trim() + "\r\n";
					macroSave();
				}
			} catch(Exception ex) {
				Console.WriteLine(ex.StackTrace);
			}
		}

		private void RemoteControl_Load(object sender, EventArgs e) {
			connect();
		}

		private void button1_Click(object sender, EventArgs e) {
			connect();
		}

		private void button2_Click(object sender, EventArgs e) {
			sendMessage("MessageQueue INVERT_COLORS");
		}

		private void trackBar1_Scroll(object sender, EventArgs e) {
			sendMessage("MessageQueue GLITCHINESS " + (trackBar1.Value / 10.0f).ToString("0.0"));
		}

		private void button3_Click(object sender, EventArgs e) {
			sendMessage("MessageQueue GLITCH");
		}

		private void button9_Click(object sender, EventArgs e) {
			sendMessage("MessageQueue ULTRAGLITCH");
		}

		private void trackBar2_Scroll(object sender, EventArgs e) {
			sendMessage("MessageQueue FONT_SIZE " + trackBar2.Value.ToString());
		}

		private void button4_Click(object sender, EventArgs e) {
			trackBar2.Value = 70;
			sendMessage("MessageQueue FONT_SIZE 70");
		}

		private void button8_Click(object sender, EventArgs e) {
			sendMessage("MessageQueue TEXT_AUTOSIZE");
		}

		private void macroBoxPopulate() {
			comboBox1.Items.Clear();
			foreach(KeyValuePair<string, string[]> macro in macros) {
				comboBox1.Items.Add(macro.Key);
			}
		}

		private void macroSave() {
			if(macros.ContainsKey(comboBox1.Text))
				macros[comboBox1.Text] = textBox2.Text.Split('\n');
			else
				macros.Add(comboBox1.Text, textBox2.Text.Split('\n'));

			macroBoxPopulate();
		}
		
		private void button6_Click(object sender, EventArgs e) {
			macroSave();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
			textBox2.Text = string.Join("\n", macros[comboBox1.Text]);
		}

		private void button7_Click(object sender, EventArgs e) {
			// Stringify Dictionary
			string serialized = "";
			foreach(KeyValuePair<string, string[]> macro in macros) {
				serialized += macro.Key;
				serialized += "|";
				serialized += string.Join("/", macro.Value);
				serialized += "\r\n";
			}

			// Show box
			Form prompt = new Form() {
				Width = 500,
				Height = 320,
				FormBorderStyle = FormBorderStyle.FixedDialog,
				Text = "Import/Export",
				StartPosition = FormStartPosition.CenterScreen
			};
			Label textLabel = new Label() { Left = 50, Top = 20, Width = 450, Text = "Copy to a text file to save. Paste here to load." };
			TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400, Height = 150, Text = serialized, Multiline = true};
			Button confirmation = new Button() { Text = "Load", Left = 350, Width = 100, Top = 200, DialogResult = DialogResult.OK };
			confirmation.Click += (psender, pe) => { prompt.Close(); };
			prompt.Controls.Add(textBox);
			prompt.Controls.Add(confirmation);
			prompt.Controls.Add(textLabel);
			prompt.AcceptButton = confirmation;

			if(prompt.ShowDialog() != DialogResult.OK) return;

			// Deserialize
			serialized = textBox.Text;
			macros.Clear();
			foreach(string line in serialized.Split('\n')) {
				try {
					string[] keyval = line.Trim().Split('|');
					macros.Add(keyval[0], keyval[1].Split('/'));
				} catch(IndexOutOfRangeException) {
					// IGNORE HAHAHA
				}
			}

			macroBoxPopulate();
		}

		private void button5_Click(object sender, EventArgs e) {
			checkBox1.Checked = false;
			button5.Enabled = false;
			macroQueue.Clear();
			foreach(string command in textBox2.Text.Split('\n')) {
				macroQueue.Enqueue(command.Trim());
			}
			timer1.Interval = 5;
			timer1.Start();
		}

		private void timer1_Tick(object sender, EventArgs e) {
			if(macroQueue.Count == 0) {
				timer1.Stop();
				button5.Enabled = true;
				if(checkBox2.Checked)
					button5.PerformClick();
				return;
			}
			string message = macroQueue.Dequeue();
			if(message.Split(' ')[0].ToLower() == "wait") {
				try {
					timer1.Interval = int.Parse(message.Split(' ')[1].Trim());
				} catch(Exception) {
					timer1.Interval = 5;
				}
			} else {
				timer1.Interval = 5;
				sendMessage(message);
			}
		}

		private void textBox2_KeyDown(object sender, KeyEventArgs e) {
			if(e.Control && e.KeyCode == Keys.A) {
				textBox2.SelectAll();
				e.SuppressKeyPress = true;
			}
		}
	}
}
