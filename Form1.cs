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
                                                .Where(game => listTypes.SelectedItems.Count == 0 || listTypes.SelectedItems.Cast<BoardGame.GameType>().Intersect(game.Types).Count() > 0)
                                                .Where(game => listCategories.SelectedItems.Count == 0 || listCategories.SelectedItems.Cast<BoardGame.GameCategory>().Intersect(game.Categories).Count() > 0)
                                                .Where(game => listMechanisms.SelectedItems.Count == 0 || listMechanisms.SelectedItems.Cast<BoardGame.GameMechanism>().Intersect(game.Mechanisms).Count() > 0)
                                                .ToList();

            if (possibles.Count == 0)
            {
                MessageBox.Show("No possible Games!", "No Games!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (possibles.Count == 1)
            {
                MessageBox.Show(possibles[0].ToString(), "Chosen Game");
            }
            else
            {
                MessageBox.Show(possibles[RandOrgInterface.RandInt(0, possibles.Count)].ToString(), "Chosen Game");
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

            this.numPlayers.Minimum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MinNumOfPlayers).Min() : 0;
            this.numPlayers.Maximum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MaxNumOfPlayers).Max() : 0;

            this.numMinMinutes.Minimum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MinDuration).Min() : 0;
            this.numMinMinutes.Maximum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MinDuration).Max() : 0;

            this.numMaxMinutes.Minimum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MaxDuration).Min() : 0;
            this.numMaxMinutes.Maximum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MaxDuration).Max() : 0;

            this.numMinMinutes.Value = this.numMinMinutes.Minimum;
            this.numMaxMinutes.Value = this.numMaxMinutes.Maximum;

            this.numAge.Minimum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MinAge).Min() : 0;
            this.numAge.Maximum = settings.BoardGames.Count > 0 ? settings.BoardGames.Select(x => x.MinAge).Max() : 0;

            this.numAge.Value = this.numAge.Minimum;

            this.Text = "Board Game Chooser! | Total Games: " + settings.BoardGames.Count.ToString();

            listTypes.Items.Clear();
            foreach (BoardGame.GameType type in settings.BoardGames.Select(x => x.Types).Aggregate(new List<BoardGame.GameType>(), (i, j) => i.Concat(j).ToList()).Distinct().OrderBy(x => x))
            {
                listTypes.Items.Add(type);
                listTypes.SetSelected(listTypes.Items.Count - 1, false);
            }

            listCategories.Items.Clear();
            foreach (BoardGame.GameCategory type in settings.BoardGames.Select(x => x.Categories).Aggregate(new List<BoardGame.GameCategory>(), (i, j) => i.Concat(j).ToList()).Distinct().OrderBy(x => x))
            {
                listCategories.Items.Add(type);
                listCategories.SetSelected(listCategories.Items.Count - 1, false);
            }

            listMechanisms.Items.Clear();
            foreach (BoardGame.GameMechanism type in settings.BoardGames.Select(x => x.Mechanisms).Aggregate(new List<BoardGame.GameMechanism>(), (i, j) => i.Concat(j).ToList()).Distinct().OrderBy(x => x))
            {
                listMechanisms.Items.Add(type);
                listMechanisms.SetSelected(listMechanisms.Items.Count - 1, false);
            }

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
            BoardGame temp = selectedGame;
            dialog.Value = temp;
            settings.BoardGames.Remove(temp);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                settings.BoardGames.Add(dialog.Value);
                RefreshGames();
            }
            else
            {
                settings.BoardGames.Add(temp);
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

        private void viewSourceCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bethune-bryant/board-game-chooser");
        }

        private void scrapeFromBGGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScrape scrape = new frmScrape();
            if (scrape.ShowDialog() == DialogResult.OK)
            {
                settings.BoardGames.AddRange(scrape.Value);
                RefreshGames();
            }
        }
    }
}
