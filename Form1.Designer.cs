namespace Tumbledryer_2D
{
    partial class Tumbledryer_2D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnStartStopServer = new System.Windows.Forms.Button();
            this.txtbx_IP = new System.Windows.Forms.TextBox();
            this.lbl_usingIP = new System.Windows.Forms.Label();
            this.grpbx_Input = new System.Windows.Forms.GroupBox();
            this.lbl_usingPort = new System.Windows.Forms.Label();
            this.txtbxPort = new System.Windows.Forms.TextBox();
            this.rdbtn_OtherMachine = new System.Windows.Forms.RadioButton();
            this.rdbtn_ThisMachine = new System.Windows.Forms.RadioButton();
            this.grpbx_Output = new System.Windows.Forms.GroupBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_COMport = new System.Windows.Forms.Label();
            this.cmbbx_COMport = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbx_Status = new System.Windows.Forms.TextBox();
            this.Timer_UpdateServerStatus = new System.Windows.Forms.Timer(this.components);
            this.Timer_ReadAirlock = new System.Windows.Forms.Timer(this.components);
            this.lbl_Statusbox = new System.Windows.Forms.Label();
            this.grpbx_Input.SuspendLayout();
            this.grpbx_Output.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartStopServer
            // 
            this.btnStartStopServer.Location = new System.Drawing.Point(30, 205);
            this.btnStartStopServer.Name = "btnStartStopServer";
            this.btnStartStopServer.Size = new System.Drawing.Size(302, 41);
            this.btnStartStopServer.TabIndex = 0;
            this.btnStartStopServer.Text = "Start/Stop Server";
            this.btnStartStopServer.UseVisualStyleBackColor = true;
            this.btnStartStopServer.Click += new System.EventHandler(this.btnStartStopServer_Click);
            // 
            // txtbx_IP
            // 
            this.txtbx_IP.Enabled = false;
            this.txtbx_IP.Location = new System.Drawing.Point(30, 134);
            this.txtbx_IP.Name = "txtbx_IP";
            this.txtbx_IP.Size = new System.Drawing.Size(140, 26);
            this.txtbx_IP.TabIndex = 1;
            this.txtbx_IP.Text = "127.0.0.1";
            this.txtbx_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_usingIP
            // 
            this.lbl_usingIP.AutoSize = true;
            this.lbl_usingIP.Enabled = false;
            this.lbl_usingIP.Location = new System.Drawing.Point(26, 111);
            this.lbl_usingIP.Name = "lbl_usingIP";
            this.lbl_usingIP.Size = new System.Drawing.Size(73, 20);
            this.lbl_usingIP.TabIndex = 2;
            this.lbl_usingIP.Text = "Using IP:";
            // 
            // grpbx_Input
            // 
            this.grpbx_Input.Controls.Add(this.lbl_usingPort);
            this.grpbx_Input.Controls.Add(this.txtbxPort);
            this.grpbx_Input.Controls.Add(this.rdbtn_OtherMachine);
            this.grpbx_Input.Controls.Add(this.rdbtn_ThisMachine);
            this.grpbx_Input.Controls.Add(this.btnStartStopServer);
            this.grpbx_Input.Controls.Add(this.lbl_usingIP);
            this.grpbx_Input.Controls.Add(this.txtbx_IP);
            this.grpbx_Input.Location = new System.Drawing.Point(31, 28);
            this.grpbx_Input.Name = "grpbx_Input";
            this.grpbx_Input.Size = new System.Drawing.Size(355, 267);
            this.grpbx_Input.TabIndex = 3;
            this.grpbx_Input.TabStop = false;
            this.grpbx_Input.Text = "Input";
            // 
            // lbl_usingPort
            // 
            this.lbl_usingPort.AutoSize = true;
            this.lbl_usingPort.Location = new System.Drawing.Point(188, 111);
            this.lbl_usingPort.Name = "lbl_usingPort";
            this.lbl_usingPort.Size = new System.Drawing.Size(87, 20);
            this.lbl_usingPort.TabIndex = 6;
            this.lbl_usingPort.Text = "Using Port:";
            // 
            // txtbxPort
            // 
            this.txtbxPort.Location = new System.Drawing.Point(192, 134);
            this.txtbxPort.Name = "txtbxPort";
            this.txtbxPort.Size = new System.Drawing.Size(140, 26);
            this.txtbxPort.TabIndex = 5;
            this.txtbxPort.Text = "31090";
            this.txtbxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbtn_OtherMachine
            // 
            this.rdbtn_OtherMachine.AutoSize = true;
            this.rdbtn_OtherMachine.Location = new System.Drawing.Point(30, 71);
            this.rdbtn_OtherMachine.Name = "rdbtn_OtherMachine";
            this.rdbtn_OtherMachine.Size = new System.Drawing.Size(271, 24);
            this.rdbtn_OtherMachine.TabIndex = 4;
            this.rdbtn_OtherMachine.Text = "DCS runs on ANOTHER machine";
            this.rdbtn_OtherMachine.UseVisualStyleBackColor = true;
            this.rdbtn_OtherMachine.CheckedChanged += new System.EventHandler(this.rdbtn_OtherMachine_CheckedChanged);
            // 
            // rdbtn_ThisMachine
            // 
            this.rdbtn_ThisMachine.AutoSize = true;
            this.rdbtn_ThisMachine.Checked = true;
            this.rdbtn_ThisMachine.Location = new System.Drawing.Point(30, 41);
            this.rdbtn_ThisMachine.Name = "rdbtn_ThisMachine";
            this.rdbtn_ThisMachine.Size = new System.Drawing.Size(230, 24);
            this.rdbtn_ThisMachine.TabIndex = 3;
            this.rdbtn_ThisMachine.TabStop = true;
            this.rdbtn_ThisMachine.Text = "DCS runs on THIS machine";
            this.rdbtn_ThisMachine.UseVisualStyleBackColor = true;
            this.rdbtn_ThisMachine.CheckedChanged += new System.EventHandler(this.rdbtn_ThisMachine_CheckedChanged);
            // 
            // grpbx_Output
            // 
            this.grpbx_Output.Controls.Add(this.btn_Refresh);
            this.grpbx_Output.Controls.Add(this.lbl_COMport);
            this.grpbx_Output.Controls.Add(this.cmbbx_COMport);
            this.grpbx_Output.Controls.Add(this.button1);
            this.grpbx_Output.Location = new System.Drawing.Point(31, 357);
            this.grpbx_Output.Name = "grpbx_Output";
            this.grpbx_Output.Size = new System.Drawing.Size(355, 227);
            this.grpbx_Output.TabIndex = 5;
            this.grpbx_Output.TabStop = false;
            this.grpbx_Output.Text = "Output";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(157, 59);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(175, 28);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // lbl_COMport
            // 
            this.lbl_COMport.AutoSize = true;
            this.lbl_COMport.Location = new System.Drawing.Point(26, 36);
            this.lbl_COMport.Name = "lbl_COMport";
            this.lbl_COMport.Size = new System.Drawing.Size(81, 20);
            this.lbl_COMport.TabIndex = 7;
            this.lbl_COMport.Text = "COM port:";
            // 
            // cmbbx_COMport
            // 
            this.cmbbx_COMport.FormattingEnabled = true;
            this.cmbbx_COMport.Location = new System.Drawing.Point(30, 59);
            this.cmbbx_COMport.Name = "cmbbx_COMport";
            this.cmbbx_COMport.Size = new System.Drawing.Size(121, 28);
            this.cmbbx_COMport.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send Commands";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbx_Status
            // 
            this.txtbx_Status.Location = new System.Drawing.Point(404, 48);
            this.txtbx_Status.Multiline = true;
            this.txtbx_Status.Name = "txtbx_Status";
            this.txtbx_Status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbx_Status.Size = new System.Drawing.Size(694, 536);
            this.txtbx_Status.TabIndex = 6;
            // 
            // Timer_UpdateServerStatus
            // 
            this.Timer_UpdateServerStatus.Enabled = true;
            this.Timer_UpdateServerStatus.Tick += new System.EventHandler(this.UpdateServerStatus_Tick);
            // 
            // Timer_ReadAirlock
            // 
            this.Timer_ReadAirlock.Enabled = true;
            this.Timer_ReadAirlock.Interval = 10;
            this.Timer_ReadAirlock.Tick += new System.EventHandler(this.Timer_ReadAirlock_Tick);
            // 
            // lbl_Statusbox
            // 
            this.lbl_Statusbox.AutoSize = true;
            this.lbl_Statusbox.Location = new System.Drawing.Point(400, 25);
            this.lbl_Statusbox.Name = "lbl_Statusbox";
            this.lbl_Statusbox.Size = new System.Drawing.Size(166, 20);
            this.lbl_Statusbox.TabIndex = 7;
            this.lbl_Statusbox.Text = "Bank  -  Pitch  -  Gload";
            // 
            // Tumbledryer_2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1124, 719);
            this.Controls.Add(this.lbl_Statusbox);
            this.Controls.Add(this.txtbx_Status);
            this.Controls.Add(this.grpbx_Output);
            this.Controls.Add(this.grpbx_Input);
            this.Name = "Tumbledryer_2D";
            this.Text = "Tumbledryer_2D";
            this.grpbx_Input.ResumeLayout(false);
            this.grpbx_Input.PerformLayout();
            this.grpbx_Output.ResumeLayout(false);
            this.grpbx_Output.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartStopServer;
        private System.Windows.Forms.TextBox txtbx_IP;
        private System.Windows.Forms.Label lbl_usingIP;
        private System.Windows.Forms.GroupBox grpbx_Input;
        private System.Windows.Forms.RadioButton rdbtn_OtherMachine;
        private System.Windows.Forms.RadioButton rdbtn_ThisMachine;
        private System.Windows.Forms.GroupBox grpbx_Output;
        private System.Windows.Forms.Label lbl_COMport;
        private System.Windows.Forms.ComboBox cmbbx_COMport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txtbx_Status;
        private System.Windows.Forms.Timer Timer_UpdateServerStatus;
        private System.Windows.Forms.Label lbl_usingPort;
        private System.Windows.Forms.TextBox txtbxPort;
        private System.Windows.Forms.Timer Timer_ReadAirlock;
        private System.Windows.Forms.Label lbl_Statusbox;
    }
}

