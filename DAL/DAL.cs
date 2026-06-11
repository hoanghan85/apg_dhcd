using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BenlyDAL.BenlyDAL
{
    public class DAL
    {
        private SqlConnection conn;
        public DAL(SqlConnection conn)
        {
            this.conn = conn;
        }
        public DataTable Meeting_getlist(string meetingcode)
        {
            var result = new DataTable();
            string strQuery = "Meetings_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public DataTable GetVoteSenate(string senateName, string workingmeeting)
        {
            var result = new DataTable();
            string query;
            query = "select distinct c.CandidateCode as Code,c.CandidateName as Name from Candidates c join Elections e on c.Electioncode = e.Electioncode and e.Meetingcode = c.Meetingcode  and (e.ElectionName like N'%HĐQT%' or e.ElectionName like N'%" + senateName + "%')" + "and e.Meetingcode = N'" + workingmeeting + "'";
            using var cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }
            return result;
        }

        public void meeting_insert(string meetingcode, string MeetingName, string CompanyName, string companyAddress, string MeetingAddress, DateTime Meetingtime, string period, string mettingType, string stockCode)
        {
            string strQuery = "Meetings_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("MeetingName", SqlDbType.NVarChar).Value = MeetingName;
            cmd.Parameters.Add("CompanyName", SqlDbType.NVarChar).Value = CompanyName;
            cmd.Parameters.Add("companyAddress", SqlDbType.NVarChar).Value = companyAddress;
            cmd.Parameters.Add("MeetingAddress", SqlDbType.NVarChar).Value = MeetingAddress;
            cmd.Parameters.Add("Meetingtime", SqlDbType.SmallDateTime).Value = Meetingtime;
            cmd.Parameters.Add("Period", SqlDbType.NVarChar).Value = period;
            cmd.Parameters.Add("MettingType", SqlDbType.NVarChar).Value = mettingType;
            cmd.Parameters.Add("YearMeeting", SqlDbType.NVarChar).Value = Meetingtime.Year.ToString();
            cmd.Parameters.Add("StockCode", SqlDbType.NVarChar).Value = stockCode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void meeting_update(string meetingcode, string MeetingName, string CompanyName, string companyAddress, string MeetingAddress, DateTime Meetingtime, string period, string mettingType, string stockCode)
        {
            string strQuery = "Meetings_update";
            using var cmd = new SqlCommand(strQuery     , conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("MeetingName", SqlDbType.NVarChar).Value = MeetingName;
            cmd.Parameters.Add("CompanyName", SqlDbType.NVarChar).Value = CompanyName;
            cmd.Parameters.Add("companyAddress", SqlDbType.NVarChar).Value = companyAddress;
            cmd.Parameters.Add("MeetingAddress", SqlDbType.NVarChar).Value = MeetingAddress;
            cmd.Parameters.Add("Meetingtime", SqlDbType.SmallDateTime).Value = Meetingtime;
            cmd.Parameters.Add("Period", SqlDbType.NVarChar).Value = period;
            cmd.Parameters.Add("MettingType", SqlDbType.NVarChar).Value = mettingType;
            cmd.Parameters.Add("YearMeeting", SqlDbType.NVarChar).Value = Meetingtime.Year.ToString();
            cmd.Parameters.Add("StockCode", SqlDbType.NVarChar).Value = stockCode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void meeting_delete(string meetingcode)
        {
            string strQuery = "Meetings_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public DataTable Holder_getlist(string meetingcode, string holdercode, string HolderIdentity)
        {
            var result = new DataTable();
            string strQuery = "Holders_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@holdercode", SqlDbType.VarChar).Value = holdercode;
            cmd.Parameters.Add("@HolderIdentity", SqlDbType.VarChar).Value = HolderIdentity;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public DataTable Holder_getListLimited(string meetingcode, decimal intFrom, decimal intTo)
        {
            var result = new DataTable();
            string strQuery = "Holders_getListLimited";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@intFrom", SqlDbType.VarChar).Value = intFrom;
            cmd.Parameters.Add("@intTo", SqlDbType.VarChar).Value = intTo;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }


        public void Holder_delete(string meetingcode, string Holdercode)
        {
            string strQuery = "Holders_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Holdercode", SqlDbType.VarChar).Value = Holdercode;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void holder_insert(string meetingcode, string Holdercode, string HolderIdentity, string HolderName, string HolderAddress, decimal Shares, decimal voterights, DateTime IdentityDate)
        {
            string strQuery = "Holders_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Holdercode", SqlDbType.NVarChar).Value = Holdercode;
            cmd.Parameters.Add("HolderIdentity", SqlDbType.NVarChar).Value = HolderIdentity;
            cmd.Parameters.Add("HolderName", SqlDbType.NVarChar).Value = HolderName;
            cmd.Parameters.Add("HolderAddress", SqlDbType.NVarChar).Value = HolderAddress;
            cmd.Parameters.Add("Shares", SqlDbType.Int).Value = Shares;
            cmd.Parameters.Add("voterights", SqlDbType.Int).Value = voterights;
            cmd.Parameters.Add("IdentityDate", SqlDbType.VarChar).Value = IdentityDate.ToString("dd/MM/yyyy");
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void holder_update(string meetingcode, string Holdercode, string HolderIdentity, string HolderName, string HolderAddress, decimal Shares, decimal voterights, DateTime IdentityDate)
        {
            string strQuery = "Holders_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Holdercode", SqlDbType.NVarChar).Value = Holdercode;
            cmd.Parameters.Add("HolderIdentity", SqlDbType.NVarChar).Value = HolderIdentity;
            cmd.Parameters.Add("HolderName", SqlDbType.NVarChar).Value = HolderName;
            cmd.Parameters.Add("HolderAddress", SqlDbType.NVarChar).Value = HolderAddress;
            cmd.Parameters.Add("Shares", SqlDbType.Int).Value = Shares;
            cmd.Parameters.Add("voterights", SqlDbType.Int).Value = voterights;
            cmd.Parameters.Add("IdentityDate", SqlDbType.VarChar).Value = IdentityDate.ToString("dd/MM/yyyy");
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public DataTable Delegate_getlist(string meetingcode, decimal Delegatecode, string IdentityCard)
        {
            var result = new DataTable();
            string strQuery = "Delegates_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@Delegatecode", SqlDbType.VarChar).Value = Delegatecode;
            cmd.Parameters.Add("@IdentityCard", SqlDbType.VarChar).Value = IdentityCard;
            cmd.Parameters.Add("@Delegatename", SqlDbType.VarChar).Value = "";
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public void Delegate_delete(string meetingcode, string Delegatecode)
        {
            string strQuery = "Delegates_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Delegatecode", SqlDbType.VarChar).Value = Delegatecode;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public decimal Delegate_insert(string meetingcode, string Delegatename, string IdentityCard, string DelegateAddress, out string warningMessage)
        {
            string strQuery = "Delegates_insert";
            using var cmd = new SqlCommand(strQuery, conn);

            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("DelegateName", SqlDbType.NVarChar).Value = Delegatename;
            cmd.Parameters.Add("IdentityCard", SqlDbType.NVarChar).Value = IdentityCard;
            cmd.Parameters.Add("DelegateAddress", SqlDbType.NVarChar).Value = DelegateAddress;
            
            var delegatecode = new SqlParameter();
            delegatecode = cmd.Parameters.Add("delegatecode", SqlDbType.Int);
            delegatecode.Direction = ParameterDirection.Output;

            var warningParam = new SqlParameter();
            warningParam = cmd.Parameters.Add("WarningMessage", SqlDbType.NVarChar, 500);
            warningParam.Direction = ParameterDirection.Output;

            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }

            warningMessage = warningParam.Value == DBNull.Value
                ? ""
                : warningParam.Value.ToString();

            return Conversions.ToDecimal(delegatecode.Value);
        }
        public void Delegate_update(string meetingcode, decimal delegatecode, string Delegatename, string IdentityCard, string DelegateAddress)
        {
            string strQuery = "Delegates_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("delegatecode", SqlDbType.Int).Value = delegatecode;
            cmd.Parameters.Add("DelegateName", SqlDbType.NVarChar).Value = Delegatename;
            cmd.Parameters.Add("IdentityCard", SqlDbType.NVarChar).Value = IdentityCard;
            cmd.Parameters.Add("DelegateAddress", SqlDbType.NVarChar).Value = DelegateAddress;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public string getAuthorizationByDelegateCode(string workingmeeting, string DelegateCode)
        {
            string strHolders;
            strHolders = "";
            var dt = new DataTable();
            try
            {
                dt = Authorizations_getlist(workingmeeting, Conversions.ToDecimal(DelegateCode), "", "", "");
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Lỗi :" + ex.Message);
            }

            // Nối danh sách thành chuỗi "A, B, C"
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["delegatename"].ToString().Trim() != dr["holdername"].ToString().Trim())
                {
                    strHolders += dr["holdername"].ToString() + ", ";
                }
            }

            return strHolders.Length > 2
                ? strHolders.Remove(strHolders.Length - 2, 2)
                : "";

        }

        public DataTable Authorizations_getlist(string meetingcode, decimal Delegatecode, string holdercode, string IdentityCard, string holderIdentity)
        {
            var result = new DataTable();
            string strQuery = "Authorizations_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@Delegatecode", SqlDbType.Int).Value = Delegatecode;
            cmd.Parameters.Add("@IdentityCard", SqlDbType.VarChar).Value = IdentityCard;
            cmd.Parameters.Add("@holdercode", SqlDbType.VarChar).Value = holdercode;
            cmd.Parameters.Add("@holderIdentity", SqlDbType.VarChar).Value = holderIdentity;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public decimal Holder_GetRemainingVoterights(string meetingcode, string holdercode)
        {
            string strQuery = "Holders_GetRemainingVoterights";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@HolderCode", SqlDbType.VarChar).Value = holdercode;

            try
            {
                object result = cmd.ExecuteScalar();
                if (result is null || result == DBNull.Value)
                {
                    return 0m;
                }

                return Conversions.ToDecimal(result);
            }
            catch
            {
                throw;
            }
        }
        public void Authorizations_insert(string meetingcode, string Holdercode, decimal delegatecode, decimal delegateright)
        {
            string strQuery = "Authorizations_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Holdercode", SqlDbType.VarChar).Value = Holdercode;
            cmd.Parameters.Add("delegatecode", SqlDbType.Int).Value = delegatecode;
            cmd.Parameters.Add("delegateright", SqlDbType.Int).Value = delegateright;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void Authorizations_delete(string meetingcode, decimal Delegatecode, string holdercode)
        {
            string strQuery = "Authorizations_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Delegatecode", SqlDbType.Int).Value = Delegatecode;
            cmd.Parameters.Add("holdercode", SqlDbType.VarChar).Value = holdercode;

            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void Authorizations_update(string meetingcode, string Holdercode, decimal delegatecode, decimal delegateright)
        {
            string strQuery = "Authorizations_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("Holdercode", SqlDbType.VarChar).Value = Holdercode;
            cmd.Parameters.Add("delegatecode", SqlDbType.Int).Value = delegatecode;
            cmd.Parameters.Add("delegateright", SqlDbType.Int).Value = delegateright;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public DataTable Matter_getlist(string meetingcode, decimal mattercode)
        {
            var result = new DataTable();
            string strQuery = "Matters_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@mattercode", SqlDbType.VarChar).Value = mattercode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }
        public void Matter_insert(string meetingcode, string Mattercode, string Mattername, string MatterDescription, int MatterApprovedPercent)
        {
            string strQuery = "Matters_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("mattercode", SqlDbType.Int).Value = Mattercode;
            cmd.Parameters.Add("Mattername", SqlDbType.NVarChar).Value = Mattername;
            cmd.Parameters.Add("MatterDescription", SqlDbType.NVarChar).Value = MatterDescription;
            cmd.Parameters.Add("MatterApprovedPercent", SqlDbType.Int).Value = MatterApprovedPercent;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void Matter_update(string meetingcode, string Mattercode, string Mattername, string MatterDescription, int MatterApprovedPercent)
        {
            string strQuery = "Matters_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("mattercode", SqlDbType.Int).Value = Mattercode;
            cmd.Parameters.Add("Mattername", SqlDbType.NVarChar).Value = Mattername;
            cmd.Parameters.Add("MatterDescription", SqlDbType.NVarChar).Value = MatterDescription;
            cmd.Parameters.Add("MatterApprovedPercent", SqlDbType.Int).Value = MatterApprovedPercent;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void Matter_delete(string meetingcode, string Mattercode)
        {
            string strQuery = "Matters_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("mattercode", SqlDbType.Int).Value = Mattercode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public DataTable Election_getlist(string meetingcode, decimal electioncode)
        {
            var result = new DataTable();
            string strQuery = "Elections_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.VarChar).Value = electioncode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public void Election_insert(string meetingcode, decimal electioncode, string electionname, string electionDescription, decimal numofcandidates)
        {
            string strQuery = "elections_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("electionname", SqlDbType.NVarChar).Value = electionname;
            cmd.Parameters.Add("electionDescription", SqlDbType.NVarChar).Value = electionDescription;
            cmd.Parameters.Add("numofcandidates", SqlDbType.NVarChar).Value = numofcandidates;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void Election_update(string meetingcode, decimal electioncode, string electionname, string electionDescription, decimal numofcandidates)
        {
            string strQuery = "elections_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("electionname", SqlDbType.NVarChar).Value = electionname;
            cmd.Parameters.Add("electionDescription", SqlDbType.NVarChar).Value = electionDescription;
            cmd.Parameters.Add("numofcandidates", SqlDbType.NVarChar).Value = numofcandidates;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void Election_delete(string meetingcode, decimal electioncode)
        {
            string strQuery = "elections_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public DataTable Candidates_getlist(string meetingcode, decimal electioncode, decimal candidatecode)
        {
            var result = new DataTable();
            string strQuery = "Candidates_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.VarChar).Value = electioncode;
            cmd.Parameters.Add("@candidatecode", SqlDbType.VarChar).Value = candidatecode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }
        public DataTable Candidates_getlist_4voteupdate(string meetingcode, decimal electioncode, decimal candidatecode, decimal delegatecode)
        {
            var result = new DataTable();
            string strQuery = "Candidates_getlist_4voteupdate";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.VarChar).Value = electioncode;
            cmd.Parameters.Add("@candidatecode", SqlDbType.VarChar).Value = candidatecode;
            cmd.Parameters.Add("@delegatecode", SqlDbType.VarChar).Value = delegatecode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }
        public void Candidate_insert(string meetingcode, decimal electioncode, decimal candidatecode, string candidatename, string candidateaddress)
        {
            string strQuery = "candidates_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("candidatecode", SqlDbType.Int).Value = candidatecode;
            cmd.Parameters.Add("candidatename", SqlDbType.NVarChar).Value = candidatename;
            cmd.Parameters.Add("candidateaddress", SqlDbType.NVarChar).Value = candidateaddress;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void Candidate_update(string meetingcode, decimal electioncode, decimal candidatecode, string candidatename, string candidateaddress)
        {
            string strQuery = "candidates_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("candidatecode", SqlDbType.Int).Value = candidatecode;
            cmd.Parameters.Add("candidatename", SqlDbType.NVarChar).Value = candidatename;
            cmd.Parameters.Add("candidateaddress", SqlDbType.NVarChar).Value = candidateaddress;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void Candidate_delete(string meetingcode, decimal electioncode, decimal candidatecode)
        {
            string strQuery = "candidates_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("candidatecode", SqlDbType.Int).Value = candidatecode;
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public void MatterVotes_insert(string meetingcode, decimal mattercode, //decimal HolderCode, 
            decimal DelegateCode, bool Agree, bool disAgree, bool noidea)
        {
            string strQuery = "Mattervotes_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("@meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@Mattercode", SqlDbType.Int).Value = mattercode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            // cmd.Parameters.Add("@HolderCode", SqlDbType.Int).Value = HolderCode
            cmd.Parameters.Add("@Agree", SqlDbType.Bit).Value = Agree;
            cmd.Parameters.Add("@Disagree", SqlDbType.Bit).Value = disAgree;
            cmd.Parameters.Add("@Noidea", SqlDbType.Bit).Value = noidea;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void MatterVotes_insert_remain(string meetingcode, decimal mattercode, decimal DelegateCode, bool Agree, bool disAgree, bool noidea)
        {
            string strQuery = "Mattervotes_insert_remain";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("@meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@Mattercode", SqlDbType.Int).Value = mattercode;
            cmd.Parameters.Add("@Agree", SqlDbType.Bit).Value = Agree;
            cmd.Parameters.Add("@Disagree", SqlDbType.Bit).Value = disAgree;
            cmd.Parameters.Add("@Noidea", SqlDbType.Bit).Value = noidea;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void MatterVotes_update(string meetingcode, decimal mattercode, decimal delegatecode, bool Agree, bool disAgree, bool noidea)
        {
            string strQuery = "Mattervotes_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("@meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@Mattercode", SqlDbType.Int).Value = mattercode;
            cmd.Parameters.Add("@delegatecode", SqlDbType.Int).Value = delegatecode;
            cmd.Parameters.Add("@Agree", SqlDbType.Bit).Value = Agree;
            cmd.Parameters.Add("@DisAgree", SqlDbType.Bit).Value = disAgree;
            cmd.Parameters.Add("@Noidea", SqlDbType.Bit).Value = noidea;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void MatterVotes_delete(string meetingcode, decimal mattercode, decimal delegatecode, decimal HolderCode)
        {
            string strQuery = "Mattervotes_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("@meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@Mattercode", SqlDbType.Int).Value = mattercode;
            cmd.Parameters.Add("@delegatecode", SqlDbType.Int).Value = delegatecode;
            // cmd.Parameters.Add("@HolderCode", SqlDbType.Int).Value = HolderCode
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }

        public DataTable MatterVotes_getlist(string meetingcode, decimal mattercode, string holderIdentify)
        {
            var result = new DataTable();
            string strQuery = "Mattervotes_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@mattercode", SqlDbType.VarChar).Value = mattercode;
            //cmd.Parameters.Add("@DelegateCode", SqlDbType.VarChar).Value = 0;
            cmd.Parameters.Add("@holderIdentify", SqlDbType.VarChar).Value = holderIdentify;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        ///summary
        /// <summary>
        /// Retrieves voting information for a specific matter within a meeting.
        /// </summary>
        /// <remarks>This method executes a stored procedure to obtain voting statistics for a matter.
        /// Ensure that the database connection is open before calling this method.</remarks>
        /// <param name="meetingcode">The unique code identifying the meeting for which to retrieve matter voting information. Cannot be null or
        /// empty.</param>
        /// <param name="mattercode">The unique code identifying the matter within the specified meeting.</param>
        /// <returns>A <see cref="MatterVoteInfo"/> object containing voting details for the specified matter. The object will
        /// have default values if no data is found. We should use SqlDataReader to return single fields, map to object.</returns>
        public MatterVoteInfo MatterVotes_Infor_get(string meetingcode, decimal mattercode)
        {
            var result = new MatterVoteInfo();
            string strQuery = "matters_VoteInfor_get";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@mattercode", SqlDbType.VarChar).Value = mattercode;

            SqlDataReader reader3;
            try
            {
                reader3 = cmd.ExecuteReader();
            }
            catch
            {
                throw;
            }
            while (reader3.Read())
            {
                result.sumofdelegates = Conversions.ToDecimal(reader3["sumofdelegates"]);
                result.enteredvotes = Conversions.ToDecimal(reader3["enteredvotes"]);
                result.remainvotes = Conversions.ToDecimal(reader3["remainvotes"]);
                result.AgreedDelegates = Conversions.ToDecimal(reader3["AgreedDelegates"]);
                result.DisAgreedDelegates = Conversions.ToDecimal(reader3["DisAgreedDelegates"]);
                result.Noideaddelegates = Conversions.ToDecimal(reader3["Noideaddelegates"]);
                result.mattername = reader3["mattername"] != DBNull.Value ? Conversions.ToString(reader3["mattername"]) : "";
            }
            reader3.Close();
            return result;
        }

        /// <summary>
        /// Retrieves a list of election votes for a specified meeting, election, delegate, and candidate.
        /// </summary>
        /// <param name="meetingcode">The unique code identifying the meeting for which to retrieve election votes. Cannot be null or empty.</param>
        /// <param name="electioncode">The code of the election to filter the votes by. Must be a valid election identifier.</param>
        /// <param name="DelegateCode">The code of the delegate whose votes are to be retrieved. Must be a valid delegate identifier.</param>
        /// <param name="candidatecode">The code of the candidate to filter the votes by. Must be a valid candidate identifier.</param>
        /// <returns>A DataTable containing the election votes that match the specified criteria. The table will be empty if no
        /// votes are found. We should use this SqlDataAdapter to returns a set of data using for Gridview.</returns>
        public DataTable ElectionVotes_getlist(string meetingcode, decimal electioncode, decimal DelegateCode, decimal candidatecode)
        {
            var result = new DataTable();
            string strQuery = "Electionvotes_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.Parameters.Add("@candidateCode", SqlDbType.Int).Value = candidatecode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }
        public void ElectionVotes_insert(string meetingcode, decimal electioncode, decimal DelegateCode, decimal CandidateCode, decimal Votes)
        {
            string strQuery = "Electionvotes_Insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.Parameters.Add("@CandidateCode", SqlDbType.Int).Value = CandidateCode;
            cmd.Parameters.Add("@votes", SqlDbType.Int).Value = Votes;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void ElectionVotes_update(string meetingcode, decimal electioncode, decimal DelegateCode, decimal CandidateCode, decimal Votes)
        {
            string strQuery = "Electionvotes_update";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.Parameters.Add("@CandidateCode", SqlDbType.Int).Value = CandidateCode;
            cmd.Parameters.Add("@votes", SqlDbType.Int).Value = Votes;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void ElectionVotes_delete(string meetingcode, decimal electioncode, decimal DelegateCode, decimal CandidateCode)
        {
            string strQuery = "Electionvotes_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.Parameters.Add("@CandidateCode", SqlDbType.Int).Value = CandidateCode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void ElectionVotes_delete_all(string meetingcode, decimal electioncode, decimal DelegateCode, decimal CandidateCode)
        {
            string strQuery = "Electionvotes_delete_all";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.Parameters.Add("@CandidateCode", SqlDbType.Int).Value = CandidateCode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void IllegalElectionVotes_insert(string meetingcode, decimal electioncode, decimal DelegateCode)
        {
            string strQuery = "IllegalElectionvotes_insert";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public void IllegalElectionVotes_delete(string meetingcode, decimal electioncode, decimal DelegateCode)
        {
            string strQuery = "IllegalElectionvotes_delete";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.Parameters.Add("meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
        }
        public DataTable IllegalElectionVotes_getlist(string meetingcode, decimal electioncode, decimal DelegateCode)
        {
            var result = new DataTable();
            string strQuery = "IllegalElectionvotes_getlist";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.Int).Value = electioncode;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.Int).Value = DelegateCode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }
        public struct MatterVoteInfo
        {
            public string mattername;
            public decimal sumofdelegates;
            public decimal enteredvotes;
            public decimal remainvotes;
            public decimal AgreedDelegates;
            public decimal DisAgreedDelegates;
            public decimal Noideaddelegates;
        }
        public struct ElectionVoteInfo
        {
            public decimal numberoflegalVote;
            public decimal numberofIllegalVote;
            public decimal LegalVoteRights;
            public decimal IllegalVoteRights;
            public decimal SummeetingVoteRight;
        }
        public ElectionVoteInfo ElectionVotes_Infor_get(string meetingcode, decimal electioncode)
        {
            var result = new ElectionVoteInfo();
            string strQuery = "Elections_VoteInfor_get";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.VarChar).Value = electioncode;

            SqlDataReader reader3;
            try
            {
                reader3 = cmd.ExecuteReader();
            }
            catch
            {
                throw;
            }
            while (reader3.Read())
            {
                result.numberoflegalVote = Conversions.ToDecimal(reader3["numberoflegalVote"]);
                result.numberofIllegalVote = Conversions.ToDecimal(reader3["numberofIllegalVote"]);
                result.LegalVoteRights = Conversions.ToDecimal(reader3["LegalVoteRights"]);
                result.IllegalVoteRights = Conversions.ToDecimal(reader3["IllegalVoteRights"]);
                result.SummeetingVoteRight = Conversions.ToDecimal(reader3["SummeetingVoteRight"]);
            }
            reader3.Close();
            return result;
        }
        public DataTable ElectionVotes_getresult(string meetingcode, decimal electioncode)
        {
            var result = new DataTable();
            string strQuery = "Electionvotes_Getresult";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;
            cmd.Parameters.Add("@electioncode", SqlDbType.Int).Value = electioncode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }
            return result;
        }
        public struct MeetingInfo
        {
            public string companyname;
            public string meetingname;
            public decimal sumofholders;
            public decimal sumofshares;
            public decimal sumofvoterights;
            public decimal numofdelegates;
            public decimal numofholderparticipated;
            public decimal numofholderAuthorised;
            public decimal sumofholderAndAuthorizatedUser;
            public decimal sumofparticipedVoterights;
        }

        public MeetingInfo Meeting_Infor_get(string meetingcode)
        {
            var result = new MeetingInfo();
            string strQuery = "Meetings_VoteInfor_get";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = meetingcode;

            SqlDataReader reader3;
            try
            {
                reader3 = cmd.ExecuteReader();
            }
            catch
            {
                throw;
            }
            while (reader3.Read())
            {
                result.companyname = Conversions.ToString(reader3["companyname"]);
                result.meetingname = Conversions.ToString(reader3["meetingname"]);
                result.sumofholders = Conversions.ToDecimal(reader3["sumofholders"]);
                result.sumofshares = Conversions.ToDecimal(reader3["sumofshares"]);
                result.sumofvoterights = Conversions.ToDecimal(reader3["sumofvoterights"]);
                result.numofdelegates = Conversions.ToDecimal(reader3["numofdelegates"]);
                result.numofholderparticipated = Conversions.ToDecimal(reader3["numofholderparticipated"]);
                result.numofholderAuthorised = Conversions.ToDecimal(reader3["numofholderAuthorised"]);
                result.sumofholderAndAuthorizatedUser = Conversions.ToDecimal(reader3["sumofholderAndAuthorizatedUser"]);
                result.sumofparticipedVoterights = Conversions.ToDecimal(reader3["sumofparticipedVoterights"]);
            }
            reader3.Close();
            return result;
        }

        public DataTable RP_Authorizations_List(string workingmeeting, string stockCode)
        {
            var result = new DataTable();
            string strQuery = "RP_Authorizations_List";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
            cmd.Parameters.Add("@Stockcode", SqlDbType.VarChar).Value = stockCode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public DataTable RP_Participation_Summary(string workingmeeting)
        {
            var result = new DataTable();
            string strQuery = "RP_Participation_Summary";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public DataTable RP_Vote_Report(string workingmeeting)
        {
            var result = new DataTable();
            string strQuery = "RP_Vote_Report";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }
        public DataTable RP_Election_Report(string workingmeeting)
        {
            var result = new DataTable();
            string strQuery = "RP_Election_Report";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }

            return result;
        }

        public DataTable GetMeetingSummary(string workingmeeting)
        {
            var result = new DataTable();
            string strQuery = "PRP_Meeting_Summary";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy dữ liệu GetMeetingSummary: " + ex.Message, ex); ;
            }
            return result;
        }

        public DataTable SP_Delegates_CheckAttendanceType(string workingmeeting, string DelegateCode)
        {
            var result = new DataTable();
            string strQuery = "SP_Delegates_CheckAttendanceType";
            using var cmd = new SqlCommand(strQuery, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MeetingCode", SqlDbType.VarChar).Value = workingmeeting;
            cmd.Parameters.Add("@DelegateCode", SqlDbType.VarChar).Value = DelegateCode;
            using var da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(result);
            }
            catch
            {
                throw;
            }
            return result;
        }

        // Lấy dữ liệu cho VoteCountingMinute Report
        public DataSet GetVoteCountingMinuteData(string workingmeeting)
        {
            var dsReport = new DataSet();

            try
            {
                // 1. Lấy Meeting Summary
                string qryMeeting = "PRP_Meeting_Summary";
                using var cmdMeeting = new SqlCommand(qryMeeting, conn);
                cmdMeeting.CommandType = CommandType.StoredProcedure;
                cmdMeeting.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
                using var daMeeting = new SqlDataAdapter(cmdMeeting);
                daMeeting.Fill(dsReport, "Meeting_Summary");

                // 2. Lấy Vote Matter Summary (Matters + Votes Join)
                string qryVoteSummary = "PRP_Vote_Summary";
                using var cmdVoteMatter = new SqlCommand(qryVoteSummary, conn);
                cmdVoteMatter.CommandType = CommandType.StoredProcedure;
                cmdVoteMatter.Parameters.Add("@Meetingcode", SqlDbType.VarChar).Value = workingmeeting;
                using var daVoteMatter = new SqlDataAdapter(cmdVoteMatter);
                daVoteMatter.Fill(dsReport, "Vote_Summary");

                // 3. Lấy Election Candidate Summary
                string qryCandidate = "PRP_Election_Candidate_Summary";
                using var cmdCandidate = new SqlCommand(qryCandidate, conn);
                cmdCandidate.CommandType = CommandType.StoredProcedure;
                cmdCandidate.Parameters.Add("@MeetingCode", SqlDbType.VarChar).Value = workingmeeting;
                cmdCandidate.Parameters.Add("@ElectionCode", SqlDbType.Int).Value = 1; // Đang mặc định lấy Bầu cử 1 - năm 2026 là HĐQT
                using var daCandidate = new SqlDataAdapter(cmdCandidate);
                daCandidate.Fill(dsReport, "Election_Candidate_Summary");

                // 4. Lấy Election Ballot Summary
                string qryBallot = "PRP_Election_Ballot_Summary";
                using var cmdBallot = new SqlCommand(qryBallot, conn);
                cmdBallot.CommandType = CommandType.StoredProcedure;
                cmdBallot.Parameters.Add("@MeetingCode", SqlDbType.VarChar).Value = workingmeeting;
                cmdBallot.Parameters.Add("@ElectionCode", SqlDbType.Int).Value = 1; // Đang mặc định lấy Bầu cử 1 - năm 2026 là HĐQT
                using var daBallot = new SqlDataAdapter(cmdBallot);
                daBallot.Fill(dsReport, "Election_Ballot_Summary");

                // 5. Lấy Matter Result Summary
                string qryAggredMatter = "PRP_Matter_Result_Summary";
                using var cmdAggredMatter = new SqlCommand(qryAggredMatter, conn);
                cmdAggredMatter.CommandType = CommandType.StoredProcedure;
                cmdAggredMatter.Parameters.Add("@MeetingCode", SqlDbType.VarChar).Value = workingmeeting;
                using var daAggredMatter = new SqlDataAdapter(cmdAggredMatter);
                daAggredMatter.Fill(dsReport, "Matter_Result_Summary");

               // 6. Lấy Matters List
                string qryMatters = "PRP_Matters_List";
                using var cmdMatters = new SqlCommand(qryMatters, conn);
                cmdMatters.CommandType = CommandType.StoredProcedure;
                cmdMatters.Parameters.Add("@MeetingCode", SqlDbType.VarChar).Value = workingmeeting;
                using var daMatters = new SqlDataAdapter(cmdMatters);
                daMatters.Fill(dsReport, "Matters_List");

                return dsReport;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi lấy dữ liệu VoteCountingMinute: " + ex.Message, ex);
            }
        }

    }
}