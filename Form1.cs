using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BoardGameChooser
{
    public partial class Form1 : Form
    {
        const string SETTINGS_FILE = "../../settings.xml";
        public static Settings settings = new Settings();

        public Form1()
        {
            InitializeComponent();

            if (File.Exists(SETTINGS_FILE))
            {
                settings = new Settings(SETTINGS_FILE);
            }

            RefreshGames();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            List<BoardGame> possibles = settings.BoardGames.Where(game => game.MinDuration >= numMinMinutes.Value && game.MaxDuration <= numMaxMinutes.Value)
                                                  .Where(game => game.MinNumOfPlayers <= numPlayers.Value && game.MaxNumOfPlayers >= numPlayers.Value)
                                                  .ToList();

            if (possibles.Count == 0)
            {
                MessageBox.Show("No possible Games!", "No Games!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(possibles[settings.rand.Next(0, possibles.Count)].ToString(), "Chosen Game");
            }
                      
        }

        private void RefreshGames()
        {
            int temp = dataGames.FirstDisplayedScrollingRowIndex;
            int selected;
            try
            {
                selected = dataGames.SelectedRows[0].Index;
            }
            catch
            {
                selected = 0;
            }

            settings.BoardGames.Sort();
            dataGames.DataSource = new SortableBinding.SortableBindingList<Object>(settings.BoardGames.Select(x => x.AsRow).ToList());

            this.numPlayers.Minimum = settings.BoardGames.Select(x => x.MinNumOfPlayers).Min();
            this.numPlayers.Maximum = settings.BoardGames.Select(x => x.MaxNumOfPlayers).Max();

            this.numMinMinutes.Minimum = settings.BoardGames.Select(x => x.MinDuration).Min();
            this.numMinMinutes.Maximum = settings.BoardGames.Select(x => x.MinDuration).Max();

            this.numMaxMinutes.Minimum = settings.BoardGames.Select(x => x.MaxDuration).Min();
            this.numMaxMinutes.Maximum = settings.BoardGames.Select(x => x.MaxDuration).Max();

            this.numMinMinutes.Value = this.numMinMinutes.Minimum;
            this.numMaxMinutes.Value = this.numMaxMinutes.Maximum;

            this.Text = "Board Game Chooser! | Total Games: " + settings.BoardGames.Count.ToString();

            try
            {
                dataGames.FirstDisplayedScrollingRowIndex = temp;
                dataGames.Rows[selected].Selected = true;
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(SETTINGS_FILE, settings.ToString());
        }

        private void addBoardgameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBoardGame dialog = new frmBoardGame();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                settings.BoardGames.Add(dialog.Value);
                RefreshGames();
            }
        }

        private BoardGame selectedGame
        {
            get
            {
                return settings.BoardGames.Find(x => x.Name.Equals(dataGames.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void dataGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBoardGame dialog = new BoardGameChooser.frmBoardGame();
            dialog.Value = selectedGame;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                settings.BoardGames.Remove(selectedGame);
                settings.BoardGames.Add(dialog.Value);
                RefreshGames();
            }
        }

        private void dataGames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you really want to delete the game?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    settings.BoardGames.Remove(selectedGame);
                    RefreshGames();
                }
            }
        }
    }
}
