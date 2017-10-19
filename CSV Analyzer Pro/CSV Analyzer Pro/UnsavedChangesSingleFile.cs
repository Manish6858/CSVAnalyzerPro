﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Analyzer_Pro {

    public partial class UnsavedChangesSingleFile : Form {

        private int userAnswer;
        public const int saveAndClose = 1;
        public const int closeWithoutSaving = 2;
        public const int Cancel = 3;

        public UnsavedChangesSingleFile() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            userAnswer = saveAndClose;
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            userAnswer = closeWithoutSaving;
            Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            userAnswer = Cancel;
            Close();
        }

        public int GetUserAnswer() {
            return userAnswer;
        }

    }
}