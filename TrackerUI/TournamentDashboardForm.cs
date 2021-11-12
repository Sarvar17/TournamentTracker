﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        private void TournamentDashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void WireUpLists()
        {
            loadExistingTornamentDropDown.DataSource = tournaments;
            loadExistingTornamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTounamentForm frm = new CreateTounamentForm();
            frm.Show();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tm = (TournamentModel)loadExistingTornamentDropDown.SelectedItem;
            TournamentViewerForm frm = new TournamentViewerForm(tm);
            frm.Show();
        }
    }
}
