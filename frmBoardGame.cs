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
        }

        public BoardGame Value
        {
            get
            {
                return new BoardGame(txtName.Text, (int)numMinPlayers.Value, (int)numMaxPlayers.Value, (int)numMinDuration.Value, (int)numMaxDuration.Value, listTypes.SelectedItems.Cast<BoardGame.GameType>().ToList());
            }
            set
            {
                txtName.Text = value.Name;
                numMinPlayers.Value = value.MinNumOfPlayers;
                numMaxPlayers.Value = value.MaxNumOfPlayers;
                numMinDuration.Value = value.MinDuration;
                numMaxDuration.Value = value.MaxDuration;

                for (int i = 0; i < listTypes.Items.Count; i++) listTypes.SetSelected(i, value.Types.Contains((BoardGame.GameType)listTypes.Items[i]));
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool IsInputValid
        {
            get
            {
                if(txtName.Text.Count() <=0)
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
                return true;
            }
        }
    }
}
