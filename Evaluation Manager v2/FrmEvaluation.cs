using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {
        private StudentRepository selectedStudent;

        public FrmEvaluation() {
            InitializeComponent();
        }

        public FrmEvaluation(StudentRepository selectedStudent) {
            this.selectedStudent = selectedStudent;
        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {
            SetFormText();
            var activities = Activity()

        }

        private void SetFormText() {
            Text = student.FirstName + " " + student.LastName;
        }

        private void 
    }
}
