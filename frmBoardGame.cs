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
    public partial class frmBoardGame : Form
    {
        public frmBoardGame()
        {
            InitializeComponent();
            foreach (BoardGame.GameType type in Enum.GetValues(typeof(BoardGame.GameType))) listTypes.Items.Add(type);
            foreach (BoardGame.GameCategory category in Enum.GetValues(typeof(BoardGame.GameCategory))) listCategories.Items.Add(category);
            foreach (BoardGame.GameMechanism mechanism in Enum.GetValues(typeof(BoardGame.GameMechanism))) listMechanisms.Items.Add(mechanism);
        }

        public BoardGame Value
        {
            get
            {
                return new BoardGame(txtName.Text.Trim(), (int)numMinPlayers.Value, (int)numMaxPlayers.Value, (int)numMinDuration.Value, (int)numMaxDuration.Value, (int)numAge.Value, listTypes.SelectedItems.Cast<BoardGame.GameType>().ToList(), listCategories.SelectedItems.Cast<BoardGame.GameCategory>().ToList(), listMechanisms.SelectedItems.Cast<BoardGame.GameMechanism>().ToList());
            }
            set
            {
                txtName.Text = value.Name.Trim();
                numMinPlayers.Value = value.MinNumOfPlayers;
                numMaxPlayers.Value = value.MaxNumOfPlayers;
                numMinDuration.Value = value.MinDuration;
                numMaxDuration.Value = value.MaxDuration;
                numAge.Value = value.MinAge;

                for (int i = 0; i < listTypes.Items.Count; i++) listTypes.SetSelected(i, value.Types.Contains((BoardGame.GameType)listTypes.Items[i]));
                for (int i = 0; i < listCategories.Items.Count; i++) listCategories.SetSelected(i, value.Categories.Contains((BoardGame.GameCategory)listCategories.Items[i]));
                for (int i = 0; i < listMechanisms.Items.Count; i++) listMechanisms.SetSelected(i, value.Mechanisms.Contains((BoardGame.GameMechanism)listMechanisms.Items[i]));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsInputValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool IsInputValid
        {
            get
            {
                if(txtName.Text.Trim().Count() <=0)
                {
                    MessageBox.Show("The board game must have a name.", "Error: No Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (numMinDuration.Value > numMaxDuration.Value || numMinDuration.Value == 0 || numMaxDuration.Value == 0)
                {
                    MessageBox.Show("The min and max duration have to be non zero and min must be less than or equal to max.", "Error: Invalid Duration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (numMinPlayers.Value > numMaxPlayers.Value || numMinPlayers.Value == 0 || numMaxPlayers.Value == 0)
                {
                    MessageBox.Show("The min and max player count have to be non zero and min must be less than or equal to max.", "Error: Invalid Player Count", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if(Form1.settings.BoardGames.Where(x=>x.Name.Trim().Equals(txtName.Text.Trim())).Count() > 0)
                {
                    MessageBox.Show("The board game must have a unique name.", "Error: Name Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
        }
    }
}
