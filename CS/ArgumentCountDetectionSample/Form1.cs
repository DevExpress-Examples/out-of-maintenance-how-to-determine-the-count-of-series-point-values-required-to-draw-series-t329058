using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace ArgumentCountDetectionSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        #region #ValuesCount
        private void chartControl1_ObjectSelected(object sender, HotTrackEventArgs e) {
            if (e.HitInfo.InSeries) {
                int count = e.HitInfo.Series.View.ValuesCount;
                MessageBox.Show(this, String.Format("The selected series is ploted using {0} series point values.", count));
            }
        }
        #endregion #ValuesCount
    }
}
