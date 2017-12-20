using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameChooser
{
    public partial class frmScrape : Form
    {
        List<BoardGame> games;

        public frmScrape()
        {
            InitializeComponent();
            games = new List<BoardGame>();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnScrape_Click(object sender, EventArgs e)
        {
            List<BoardGame> scrape = BGGInterface.GetBoardGames(txtUser.Text);

            games = new List<BoardGame>();

            foreach(BoardGame game in scrape)
            {
                string existing = Form1.settings.BoardGames.Where(old => old.Name.Similar(game.Name, 0)).Select(x => x.Name).Aggregate("", (x, y) => x + "," + y);
                if (existing.Length == 0)
                    //|| MessageBox.Show("Are " + game.Name + " and any of " + existing + " the same game?", game.ToString() + " may already exist.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    games.Add(game);
                }
            }

            RefreshGames();
        }

        private BoardGame selectedGame
        {
            get
            {
                return games.Find(x => x.Name.Equals(dataGames.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void dataGames_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmBoardGame dialog = new BoardGameChooser.frmBoardGame();
            BoardGame temp = selectedGame;
            dialog.Value = temp;
            games.Remove(temp);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                games.Add(dialog.Value);
                RefreshGames();
            }
            else
            {
                games.Add(temp);
            }
        }

        private void dataGames_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Do you really want to delete the game?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    games.Remove(selectedGame);
                    RefreshGames();
                }
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

            games.Sort();
            dataGames.DataSource = new SortableBinding.SortableBindingList<Object>(games.Select(x => x.AsRow).ToList());

            try
            {
                dataGames.FirstDisplayedScrollingRowIndex = temp;
                dataGames.Rows[selected].Selected = true;
            }
            catch
            {

            }
        }

        public List<BoardGame> Value { get { return this.games; } }
    }
}
