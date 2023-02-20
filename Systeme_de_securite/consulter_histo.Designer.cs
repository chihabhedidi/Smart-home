
namespace Systeme_de_securite
{
    partial class consulter_histo
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.historiquesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.poc_projectDataSet = new Systeme_de_securite.poc_projectDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.historiquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historiquesTableAdapter = new Systeme_de_securite.poc_projectDataSetTableAdapters.historiquesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiquesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poc_projectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiquesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.historiquesBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(917, 485);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // historiquesBindingSource1
            // 
            this.historiquesBindingSource1.DataMember = "historiques";
            this.historiquesBindingSource1.DataSource = this.poc_projectDataSet;
            // 
            // poc_projectDataSet
            // 
            this.poc_projectDataSet.DataSetName = "poc_projectDataSet";
            this.poc_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.coldate,
            this.coluser_id,
            this.colusername});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(664, 394, 314, 265);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.MinWidth = 25;
            this.colid.Name = "colid";
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            this.colid.Width = 53;
            // 
            // coldate
            // 
            this.coldate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coldate.FieldName = "date";
            this.coldate.MinWidth = 25;
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 2;
            this.coldate.Width = 552;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.MinWidth = 25;
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.Width = 94;
            // 
            // colusername
            // 
            this.colusername.FieldName = "username";
            this.colusername.MinWidth = 25;
            this.colusername.Name = "colusername";
            this.colusername.Visible = true;
            this.colusername.VisibleIndex = 1;
            this.colusername.Width = 282;
            // 
            // historiquesBindingSource
            // 
            this.historiquesBindingSource.DataMember = "historiques";
            this.historiquesBindingSource.DataSource = this.poc_projectDataSet;
            // 
            // historiquesTableAdapter
            // 
            this.historiquesTableAdapter.ClearBeforeFill = true;
            // 
            // consulter_histo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 485);
            this.Controls.Add(this.gridControl1);
            this.Name = "consulter_histo";
            this.Text = "consulter_histo";
            this.Load += new System.EventHandler(this.consulter_histo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiquesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poc_projectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiquesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private poc_projectDataSet poc_projectDataSet;
        private System.Windows.Forms.BindingSource historiquesBindingSource;
        private poc_projectDataSetTableAdapters.historiquesTableAdapter historiquesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colusername;
        private System.Windows.Forms.BindingSource historiquesBindingSource1;
    }
}