namespace UniverControl
{
    partial class University
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(University));
            this.panelView = new System.Windows.Forms.Panel();
            this.buttonSaveMarks = new System.Windows.Forms.Button();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSelectMode = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.dataGridViewBase = new System.Windows.Forms.DataGridView();
            this.ControlCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLoginPsw = new System.Windows.Forms.Panel();
            this.labelHelloName = new System.Windows.Forms.Label();
            this.labelWrong = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonChangeItem = new System.Windows.Forms.Button();
            this.timerBase = new System.Windows.Forms.Timer(this.components);
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase)).BeginInit();
            this.panelLoginPsw.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelView.Controls.Add(this.buttonSaveMarks);
            this.panelView.Controls.Add(this.comboBoxTable);
            this.panelView.Controls.Add(this.buttonDelete);
            this.panelView.Controls.Add(this.buttonAdd);
            this.panelView.Controls.Add(this.labelSelectMode);
            this.panelView.Controls.Add(this.comboBoxMode);
            this.panelView.Controls.Add(this.dataGridViewBase);
            this.panelView.Location = new System.Drawing.Point(12, 12);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(549, 425);
            this.panelView.TabIndex = 0;
            this.panelView.Visible = false;
            // 
            // buttonSaveMarks
            // 
            this.buttonSaveMarks.Location = new System.Drawing.Point(471, 403);
            this.buttonSaveMarks.Name = "buttonSaveMarks";
            this.buttonSaveMarks.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveMarks.TabIndex = 6;
            this.buttonSaveMarks.Text = "Save Marks";
            this.buttonSaveMarks.UseVisualStyleBackColor = true;
            this.buttonSaveMarks.Visible = false;
            this.buttonSaveMarks.Click += new System.EventHandler(this.buttonSaveMarks_Click);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(205, 3);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTable.TabIndex = 5;
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBoxTable_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(170, 402);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(89, 402);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSelectMode
            // 
            this.labelSelectMode.AutoSize = true;
            this.labelSelectMode.Location = new System.Drawing.Point(3, 7);
            this.labelSelectMode.Name = "labelSelectMode";
            this.labelSelectMode.Size = new System.Drawing.Size(69, 13);
            this.labelSelectMode.TabIndex = 2;
            this.labelSelectMode.Text = "Select mode:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(78, 3);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMode.TabIndex = 1;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // dataGridViewBase
            // 
            this.dataGridViewBase.AllowUserToAddRows = false;
            this.dataGridViewBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ControlCol});
            this.dataGridViewBase.Location = new System.Drawing.Point(0, 30);
            this.dataGridViewBase.Name = "dataGridViewBase";
            this.dataGridViewBase.Size = new System.Drawing.Size(546, 346);
            this.dataGridViewBase.TabIndex = 0;
            // 
            // ControlCol
            // 
            this.ControlCol.HeaderText = "Control";
            this.ControlCol.Name = "ControlCol";
            // 
            // panelLoginPsw
            // 
            this.panelLoginPsw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLoginPsw.Controls.Add(this.labelHelloName);
            this.panelLoginPsw.Controls.Add(this.labelWrong);
            this.panelLoginPsw.Controls.Add(this.textBoxPassword);
            this.panelLoginPsw.Controls.Add(this.labelPassword);
            this.panelLoginPsw.Controls.Add(this.textBoxLogin);
            this.panelLoginPsw.Controls.Add(this.buttonLogin);
            this.panelLoginPsw.Controls.Add(this.labelLogin);
            this.panelLoginPsw.Location = new System.Drawing.Point(567, 12);
            this.panelLoginPsw.Name = "panelLoginPsw";
            this.panelLoginPsw.Size = new System.Drawing.Size(221, 171);
            this.panelLoginPsw.TabIndex = 1;
            // 
            // labelHelloName
            // 
            this.labelHelloName.AutoSize = true;
            this.labelHelloName.Location = new System.Drawing.Point(4, 33);
            this.labelHelloName.Name = "labelHelloName";
            this.labelHelloName.Size = new System.Drawing.Size(81, 13);
            this.labelHelloName.TabIndex = 6;
            this.labelHelloName.Text = "labelHelloName";
            this.labelHelloName.Visible = false;
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWrong.Location = new System.Drawing.Point(88, 61);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(124, 13);
            this.labelWrong.TabIndex = 5;
            this.labelWrong.Text = "Wrong login or password";
            this.labelWrong.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(63, 30);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(155, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Enter you password!";
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            this.textBoxPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxPassword_MouseDown);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(4, 33);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(63, 4);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(155, 20);
            this.textBoxLogin.TabIndex = 2;
            this.textBoxLogin.Text = "Enter you login!";
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            this.textBoxLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            this.textBoxLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxLogin_MouseDown);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(7, 56);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(4, 7);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login:";
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfo.Location = new System.Drawing.Point(567, 191);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(221, 247);
            this.panelInfo.TabIndex = 2;
            // 
            // buttonChangeItem
            // 
            this.buttonChangeItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeItem.Location = new System.Drawing.Point(13, 414);
            this.buttonChangeItem.Name = "buttonChangeItem";
            this.buttonChangeItem.Size = new System.Drawing.Size(82, 23);
            this.buttonChangeItem.TabIndex = 3;
            this.buttonChangeItem.Text = "Change Save";
            this.buttonChangeItem.UseVisualStyleBackColor = true;
            this.buttonChangeItem.Visible = false;
            this.buttonChangeItem.Click += new System.EventHandler(this.button_ChangeItemClick);
            // 
            // timerBase
            // 
            this.timerBase.Enabled = true;
            this.timerBase.Tick += new System.EventHandler(this.timerBase_Tick);
            // 
            // University
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeItem);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelLoginPsw);
            this.Controls.Add(this.panelView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "University";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "University_Manager";
            this.panelView.ResumeLayout(false);
            this.panelView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase)).EndInit();
            this.panelLoginPsw.ResumeLayout(false);
            this.panelLoginPsw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panelLoginPsw;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.DataGridView dataGridViewBase;
        private System.Windows.Forms.Button buttonChangeItem;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Timer timerBase;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelHelloName;
        private System.Windows.Forms.Label labelSelectMode;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlCol;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Button buttonSaveMarks;
    }
}

