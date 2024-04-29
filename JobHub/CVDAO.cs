using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobHub
{
    internal class CVDAO
    {
        public CVDAO() { }
        private CV myCV;
        DBConection db = new DBConection();
        Function function = new Function();
        
        public DataTable ReadData(string cmd)
        {
            return function.ReadData(cmd);
        }

        public void Insert(string cmd )
        {
            function.Insert(cmd);   
        }
        public void WriteData(DataTable dt, FlowLayoutPanel fpn, Label lblNameCandidate, Guna2CirclePictureBox picAvarta)
        {
             function.WriteData(dt, fpn, lblNameCandidate, picAvarta);
        }

        public string SelectImageButton(string pathRoot, string dir)
        {
            return function.SelectImageButton(pathRoot, dir);
        }

        public void Update(string cmd)
        {
            function.Update(cmd);
        }
        internal CV MyCV { get => myCV; set => myCV = value; }

        public DataTable GetIdBeforeSaveNew()
        {
            string sql = $@"select max(idCV)
                                   from ImageCV";
            return db.CheckExists(sql);
        }
        public void AddImageCVIntoDB(string nameImage, int idCandiate, int idCV, string nameCV)
        {
            string sql = $@"insert into ImageCV (image, idCandidate, idCV, CVName)
                                 values (N'{nameImage}', {idCandiate}, {idCV}, N'{nameCV}')";
            db.ExcuteNoMess(sql);
        }
        public void DeleteImageCV(int idCV)
        {
            string sql = $@"delete from ImageCV where idCV = {idCV}";
            db.ExcuteNoMess(sql);
        }
        public SqlDataReader GetImageCV(int idCandidate)
        {
            string sql = $@"SELECT ImageCV.image, idCV, CVName, Candidate.idCandidate
                            FROM ImageCV
                            INNER JOIN Candidate ON ImageCV.idCandidate = Candidate.idCandidate
                            where Candidate.idCandidate = {idCandidate}";
            return db.loadData(sql);
        }
        
    }
}
