using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardiologyClinic.Bean;

namespace CardiologyClinic.View.PatientView.InfoRoom
{
    public partial class InfoRoomForm : Form
    {
        private Room room;

        public InfoRoomForm()
        {
            InitializeComponent();
        }

        public InfoRoomForm(Room room) :
            this()
        {
            this.room = room;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoRoomForm_Load(object sender, EventArgs e)
        {
            this.numberLabel.Text = this.room.Number.ToString();
            this.roomLabel.Text = this.room.Size.ToString();
        }
    }
}
