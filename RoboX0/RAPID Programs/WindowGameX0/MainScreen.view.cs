//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ABB.Robotics.ScreenMaker.Windows.Forms;
using System;


namespace WindowGameX0
{
    
    
    public class MainScreen : ABB.Robotics.ScreenMaker.Windows.Forms.ScreenForm
    {
        
        private ABB.Robotics.Tps.Windows.Forms.Button button1;
        
        private ABB.Robotics.Tps.Windows.Forms.TpsLabel tpsLabel1;
        
        public MainScreen()
        {
            this.InitializeComponent();
        }
        
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tpsLabel1 = new ABB.Robotics.Tps.Windows.Forms.TpsLabel();
            this.button1 = new ABB.Robotics.Tps.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tpsLabel1
            // 
            this.tpsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", new ABB.Robotics.ScreenMaker.Windows.Forms.SingleBindingSource(new ABB.Robotics.DataBinding.RapidDataObject("T_ROB1", "Module1", "PlayerStr")), "Value", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.tpsLabel1.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.tpsLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpsLabel1.Location = new System.Drawing.Point(274, 48);
            this.tpsLabel1.Multiline = true;
            this.tpsLabel1.Name = "tpsLabel1";
            this.tpsLabel1.Size = new System.Drawing.Size(158, 79);
            this.tpsLabel1.Title = "tpsLabel1";
            this.tpsLabel1.Click += new System.EventHandler(this.tpsLabel1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = ABB.Robotics.Tps.Windows.Forms.TpsFont.Font12b;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(27, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 79);
            this.button1.Text = "button1";
            this.button1.TextAlign = ABB.Robotics.Tps.Windows.Forms.ContentAlignmentABB.MiddleCenter;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainScreen
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tpsLabel1);
            this.Controls.Add(this.button1);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.tpsLabel1, 0);
            this.ResumeLayout(false);
        }
        #endregion
        
        private void runRoutineButton1_BeforeRunRoutine(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["low"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/dxT").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_1 = this.ScreenServices.ApplicationVariables["low"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/dyT").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_1.Value));
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in runRoutineButton1_BeforeRunRoutine", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }
        
        private void runRoutineButton1_AfterRunRoutine(object sender, System.EventArgs e)
        {
            try
            {
                // Calling ApplicationVariableReadWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable read_0 = this.ScreenServices.ApplicationVariables["ULText"];
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["XText"];
                read_0.Value = write_0.Value;
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in runRoutineButton1_AfterRunRoutine", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void runRoutineButton1_BeforeRunRoutine_1(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["low"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/dxT").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_1 = this.ScreenServices.ApplicationVariables["low"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/dyT").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_1.Value));
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in runRoutineButton1_BeforeRunRoutine_1", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }
        
        private void runRoutineButton1_AfterRunRoutine_1(object sender, System.EventArgs e)
        {
            try
            {
                // Calling ApplicationVariableReadWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable read_0 = this.ScreenServices.ApplicationVariables["ULText"];
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["XText"];
                read_0.Value = write_0.Value;
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in runRoutineButton1_AfterRunRoutine_1", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void tpsLabel1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Calling ApplicationVariableReadWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable read_0 = this.ScreenServices.ApplicationVariables["ULText"];
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["OText"];
                read_0.Value = write_0.Value;
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in tpsLabel1_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_0 = this.ScreenServices.ApplicationVariables["low"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/dxT").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_0.Value));
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_1 = this.ScreenServices.ApplicationVariables["high"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/dyT").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_1.Value));
                // Calling RapidDataRead
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_2 = this.ScreenServices.ApplicationVariables["Action"];
                write_2.Value = ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/ActStep").Value;
                // Calling RapidDataWrite
                ABB.Robotics.ScreenMaker.Base.IApplicationVariable write_3 = this.ScreenServices.ApplicationVariables["Action"];
                ABB.Robotics.ScreenMaker.Windows.Forms.DataManager.GetRapidData(this, "RAPID/T_ROB1/Module1/Action").Value = ((ABB.Robotics.Controllers.RapidDomain.IRapidData)(write_3.Value));
            }
            catch (System.Exception ex)
            {
                ABB.Robotics.Tps.Windows.Forms.GTPUMessageBox.Show(this, null, ex.ToString(), "Unexpected Error in button1_Click", System.Windows.Forms.MessageBoxIcon.Hand, System.Windows.Forms.MessageBoxButtons.OK);
            }
        }
    }
}
