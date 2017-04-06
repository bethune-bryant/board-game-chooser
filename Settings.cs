using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameChooser
{
    [Serializable]
    public class Settings
    {
        public List<BoardGame> BoardGames { get; set; }
        
        public Random rand = new Random();

        public Settings()
        {
            this.BoardGames = new List<BoardGameChooser.BoardGame>();
        }

        public Settings(string FileName)
            : this()
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());

                System.IO.StringReader read = new System.IO.StringReader(System.IO.File.ReadAllText(FileName));

                Settings setting = serializer.Deserialize(read) as Settings;

                this.BoardGames = setting.BoardGames;
            }
            catch (Exception exc)
            {
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }
        }

        public override string ToString()
        {
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());

            StringBuilder retval = new StringBuilder("");

            System.IO.StringWriter s = new System.IO.StringWriter(retval);

            serializer.Serialize(s, this);
            
            return retval.ToString();
        }
    }
}
