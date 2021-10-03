using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UchiHack
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public struct QuestAnswers{
            public string quest;
            public string answ1;
            public string answ2;
            public string answ3;
            public string answ4;

        }
        public HashSet<QuestAnswers> quests = new HashSet<QuestAnswers>();

        private void btnAddQuests_Click(object sender, EventArgs e)
        {
            string text = rtbQuests.Text.Trim();
            //пустая строка в начале указывает на начало первого вопроса
            text = "\n" + text;
            string[] tokens = text.Split('\n');

            QuestAnswers item;
            int i = 0;
            foreach (string token in tokens)
            {
                if (token=="")
                {
                    item.quest = tokens[i + 1];
                    item.answ1 = tokens[i + 2];
                    item.answ2 = tokens[i + 3];
                    item.answ3 = tokens[i + 4];
                    item.answ4 = tokens[i + 5];

                    quests.Add(item);
                }
                i++;
            }

            FormGame frmGame = new FormGame(quests);
            frmGame.Show();
            this.Hide();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
