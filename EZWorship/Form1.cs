using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EZWorship {
	public partial class Form1 : Form {

		private string outputFile = "D:/EZWorship.txt";

		public Form1() {
			InitializeComponent();
		}

		public void GoLive() {
			listLive.Items.Clear();
			listLive.Items.AddRange(listPreview.Items);
			btnClear.Checked = false;
			listLive.Focus();
			if(listLive.SelectedIndex == -1)
				listLive.SelectedIndex = 0;
		}

		public void UpdateOutput() {
			string outputString;
			if(btnClear.Checked || listLive.SelectedItem == null) {
				outputString = "";
			} else {
				outputString = listLive.SelectedItem.ToString().Trim();
			}

			if(outputString.StartsWith("[")) {
				outputString = outputString.Substring(outputString.IndexOf('\n')).Trim();
			}

			File.WriteAllText(outputFile, outputString);
		}

		public void SelectOutput() {
			DialogResult dialogResult = saveFileDialog1.ShowDialog();
			if(dialogResult == DialogResult.OK) {
				outputFile = saveFileDialog1.FileName;
			}
		}

		public void UpdatePreview() {
			listPreview.Items.Clear();

			foreach(string line in ((Song)listSongs.SelectedItem).getLyrics()) {
				// Populate preview panel
				listPreview.Items.Add(line);
			}
		}

		private void Form1_Load(object sender, EventArgs e) {
			try {
				File.WriteAllText(outputFile, "");
			} catch(Exception ex) {
				Console.WriteLine(ex);
				MessageBox.Show("Please select an output directory!");
				SelectOutput();
			}
			//listPreview.Items.Add("test\nmultiline\nitem");
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			DialogResult exitConfirm = MessageBox.Show("Exit EZWorship?", "Confirm", MessageBoxButtons.YesNo);
			if(exitConfirm == DialogResult.Yes) {
				Application.Exit();
			}
		}

		private void LoadLyricsButton_Click(object sender, EventArgs e) {
			DialogResult fileDialog = openFileDialog1.ShowDialog();
			Console.WriteLine(fileDialog.ToString());
			Console.WriteLine(openFileDialog1.FileNames);

			if(fileDialog == DialogResult.OK) {
				foreach(String fileName in openFileDialog1.FileNames) {
					Song song = new Song(Path.GetFileNameWithoutExtension(fileName));
					song.loadLyrics(fileName);
					listSongs.Items.Add(song);
				}
			}
		}

		private void listSongs_SelectedIndexChanged(object sender, EventArgs e) {
			// Song Selection
			if(listSongs.SelectedItem == null) return;

			UpdatePreview();
		}

		private void ListBox_MeasureItem(object sender, MeasureItemEventArgs e) {
			e.ItemHeight = 13 + ((ListBox)sender).Items[e.Index].ToString().Split('\n').Length * 13;
		}

		private void ListBox_DrawItem(object sender, DrawItemEventArgs e) {
			e.DrawBackground();
			if(e.Index >= 0)
				e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
		}

		private void btnGoLive_Click(object sender, EventArgs e) {
			GoLive();
			if(listSongs.SelectedIndex < listSongs.Items.Count - 1)
				listSongs.SelectedIndex++;
		}

		private void listSongs_DoubleClick(object sender, EventArgs e) {
			GoLive();
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			UpdateOutput();
		}

		private void listLive_DoubleClick(object sender, EventArgs e) {
			btnClear.Checked = false;
			UpdateOutput();
		}

		private void listLive_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateOutput();
		}

		private void setOutputToolStripMenuItem_Click(object sender, EventArgs e) {
			SelectOutput();
		}

		private void listPreview_DoubleClick(object sender, EventArgs e) {
			GoLive();
			listLive.SelectedIndex = listPreview.SelectedIndex;
		}

		private void listSongs_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Delete) {
				listSongs.Items.RemoveAt(listSongs.SelectedIndex);
			}
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {
			if(e.Control && e.KeyCode == Keys.C) {
				// Clear screen
				btnClear.Checked = !btnClear.Checked;
				UpdateOutput();
				e.SuppressKeyPress = true;
			} else if(e.KeyCode == Keys.PageDown) {
				// Next Song
				GoLive();
				if(listSongs.SelectedIndex < listSongs.Items.Count - 1)
					listSongs.SelectedIndex++;
				e.SuppressKeyPress = true;
			}
		}

		private void ListBox_DragOver(object sender, DragEventArgs e) {
			e.Effect = DragDropEffects.Move;
		}

		private void ListBox_DragDrop(object sender, DragEventArgs e) {
			Point point = ((ListBox)sender).PointToClient(new Point(e.X, e.Y));
			int index = ((ListBox)sender).IndexFromPoint(point);
			if(index < 0) index = ((ListBox)sender).Items.Count - 1;
			object data = e.Data.GetData(typeof(Song));
			((ListBox)sender).Items.Remove(data);
			((ListBox)sender).Items.Insert(index, data);
		}

		private Point lastMouseDownPoint = new Point(0, 0);

		private void listSongs_MouseDown(object sender, MouseEventArgs e) {
			lastMouseDownPoint = e.Location;
		}

		private void listSongs_MouseMove(object sender, MouseEventArgs e) {
			double dist = Math.Sqrt(Math.Pow(e.Location.X - lastMouseDownPoint.X, 2) + Math.Pow(e.Location.Y - lastMouseDownPoint.Y, 2));
			if(e.Button == MouseButtons.Left && dist >= 10) {
				if(((ListBox)sender).SelectedItem == null) return;
				((ListBox)sender).DoDragDrop(((ListBox)sender).SelectedItem, DragDropEffects.Move);

				if(listSongs.SelectedItem != null)
					UpdatePreview();
			}
		}

		private void remoteControlToolStripMenuItem_Click(object sender, EventArgs e) {
			new RemoteControl().Show();
		}
	}
}
