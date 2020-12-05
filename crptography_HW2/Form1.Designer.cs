namespace crptography_HW2
{
    partial class Form1
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
            this.labelLfsrStates = new System.Windows.Forms.Label();
            this.textBoxConnectionPoly = new System.Windows.Forms.TextBox();
            this.labelConnectionPoly = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.labelInitialState = new System.Windows.Forms.Label();
            this.textBoxInitialState = new System.Windows.Forms.TextBox();
            this.listBoxLfsrStates = new System.Windows.Forms.ListBox();
            this.buttonInitialize = new System.Windows.Forms.Button();
            this.buttonChangeState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLfsrStates
            // 
            this.labelLfsrStates.AutoSize = true;
            this.labelLfsrStates.Location = new System.Drawing.Point(12, 69);
            this.labelLfsrStates.Name = "labelLfsrStates";
            this.labelLfsrStates.Size = new System.Drawing.Size(37, 13);
            this.labelLfsrStates.TabIndex = 4;
            this.labelLfsrStates.Text = "States";
            // 
            // textBoxConnectionPoly
            // 
            this.textBoxConnectionPoly.Location = new System.Drawing.Point(15, 33);
            this.textBoxConnectionPoly.Name = "textBoxConnectionPoly";
            this.textBoxConnectionPoly.Size = new System.Drawing.Size(189, 20);
            this.textBoxConnectionPoly.TabIndex = 1;
            // 
            // labelConnectionPoly
            // 
            this.labelConnectionPoly.AutoSize = true;
            this.labelConnectionPoly.Location = new System.Drawing.Point(12, 17);
            this.labelConnectionPoly.Name = "labelConnectionPoly";
            this.labelConnectionPoly.Size = new System.Drawing.Size(192, 13);
            this.labelConnectionPoly.TabIndex = 0;
            this.labelConnectionPoly.Text = "Please enter the connection polynomial";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(325, 473);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(118, 36);
            this.buttonCalc.TabIndex = 6;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // labelInitialState
            // 
            this.labelInitialState.AutoSize = true;
            this.labelInitialState.Location = new System.Drawing.Point(246, 17);
            this.labelInitialState.Name = "labelInitialState";
            this.labelInitialState.Size = new System.Drawing.Size(136, 13);
            this.labelInitialState.TabIndex = 2;
            this.labelInitialState.Text = "Please enter the initial state";
            // 
            // textBoxInitialState
            // 
            this.textBoxInitialState.Location = new System.Drawing.Point(249, 33);
            this.textBoxInitialState.Name = "textBoxInitialState";
            this.textBoxInitialState.Size = new System.Drawing.Size(194, 20);
            this.textBoxInitialState.TabIndex = 3;
            // 
            // listBoxLfsrStates
            // 
            this.listBoxLfsrStates.FormattingEnabled = true;
            this.listBoxLfsrStates.Location = new System.Drawing.Point(15, 85);
            this.listBoxLfsrStates.Name = "listBoxLfsrStates";
            this.listBoxLfsrStates.Size = new System.Drawing.Size(428, 368);
            this.listBoxLfsrStates.TabIndex = 5;
            // 
            // buttonInitialize
            // 
            this.buttonInitialize.Location = new System.Drawing.Point(170, 473);
            this.buttonInitialize.Name = "buttonInitialize";
            this.buttonInitialize.Size = new System.Drawing.Size(118, 36);
            this.buttonInitialize.TabIndex = 7;
            this.buttonInitialize.Text = "Initialize";
            this.buttonInitialize.UseVisualStyleBackColor = true;
            this.buttonInitialize.Click += new System.EventHandler(this.ButtonInitialize_Click);
            // 
            // buttonChangeState
            // 
            this.buttonChangeState.Location = new System.Drawing.Point(15, 473);
            this.buttonChangeState.Name = "buttonChangeState";
            this.buttonChangeState.Size = new System.Drawing.Size(118, 36);
            this.buttonChangeState.TabIndex = 8;
            this.buttonChangeState.Text = "Change Initial State";
            this.buttonChangeState.UseVisualStyleBackColor = true;
            this.buttonChangeState.Click += new System.EventHandler(this.ButtonChangeState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 521);
            this.Controls.Add(this.buttonChangeState);
            this.Controls.Add(this.buttonInitialize);
            this.Controls.Add(this.listBoxLfsrStates);
            this.Controls.Add(this.labelInitialState);
            this.Controls.Add(this.textBoxInitialState);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelConnectionPoly);
            this.Controls.Add(this.textBoxConnectionPoly);
            this.Controls.Add(this.labelLfsrStates);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelLfsrStates;
        private System.Windows.Forms.TextBox textBoxConnectionPoly;
        private System.Windows.Forms.Label labelConnectionPoly;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label labelInitialState;
        private System.Windows.Forms.TextBox textBoxInitialState;
        private System.Windows.Forms.ListBox listBoxLfsrStates;
        private System.Windows.Forms.Button buttonInitialize;
        private System.Windows.Forms.Button buttonChangeState;
    }
}

