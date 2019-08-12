using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NxBSEditApplicationWrapper;
namespace CS.Engine
{
    public class CNxProjectManager
    {

        private Guid clipGuid;
        private Guid footageGuid;
        public Guid sequenceGuid;

        public CNxProjectManager()
        {

        }

        private CBSEditApplication m_oBSEditApplication = null;
        public void Initianlize(CBSEditApplication in_oBSEditApplication)
        {
            m_oBSEditApplication = in_oBSEditApplication;
        }


        /// <summary>
        /// EditProject
        /// </summary>
        protected CBSEditProject _bsEditProject = null;
        public CBSEditProject BSEditProject
        {
            get
            {
                if (_bsEditProject == null)
                {
                    m_oBSEditApplication.GetBSEditProject(out _bsEditProject);
                }
                return _bsEditProject;
            }
        }
        /// <summary>
        /// EditBox
        /// </summary>
        protected CBSEditBox _bsEditBox = null;
        public CBSEditBox BSEditBox
        {
            get
            {
                if (_bsEditBox == null)
                {
                    m_oBSEditApplication.GetBSEditBox(out _bsEditBox);
                }
                return _bsEditBox;
            }
        }


        /// <summary>
        /// 获得工程文件名称，带路径的
        /// </summary>
        public string GetProjectName()
        {
            string strProjectName = "";
            if (BSEditProject != null)
            {
                BSEditProject.GetProjectName(out strProjectName);
                return strProjectName;
            }

            return null;
        }

        /// <summary>
        /// 保存工程
        /// </summary>
        public void SaveProject()
        {
            if (BSEditProject != null)
            {
                BSEditProject.SaveProject();
            }
        }

        /// <summary>
        /// 工程另存为
        /// </summary>
        public void SaveAsProject(string in_strProjectName)
        {
            if (BSEditProject != null)
            {
                BSEditProject.SaveAsProject(in_strProjectName);
            }
        }


        public void CloseProject()
        {
            if (m_oBSEditApplication != null)
            {
                m_oBSEditApplication.Close();
            }

        }


        /// <summary>
        /// 添加Clip
        /// </summary>
        /// <param name="lowVideoClipFile"></param>
        /// <param name="highVideoClipFile"></param>
        /// <param name="lowAudioClipFiles"></param>
        /// <param name="highAudioClipFiles"></param>
        /// <returns></returns>
        public void AddClip(string lowVideoClipFile, string highVideoClipFile, List<string> lowAudioClipFiles, List<string> highAudioClipFiles)
        {
            try
            {

                // BSEditBox.BeginAddClip();
                BSEditBox.BeginAddTwoChannelClip();

                if (!string.IsNullOrEmpty(lowVideoClipFile))
                {
                    BSEditBox.BeginAddLowVideoClip(lowVideoClipFile);
                }

                foreach (string audioClipFile in lowAudioClipFiles)
                {
                    if (!string.IsNullOrEmpty(audioClipFile))
                    {
                        BSEditBox.BeginAddLowAudioClip(audioClipFile);
                    }
                }

                if (!string.IsNullOrEmpty(highVideoClipFile))
                {
                    BSEditBox.BeginAddHighVideoClip(highVideoClipFile);
                }

                foreach (string audioClipFile in highAudioClipFiles)
                {
                    if (!string.IsNullOrEmpty(audioClipFile))
                    {
                        BSEditBox.BeginAddHighAudioClip(audioClipFile);
                    }
                }

                BSEditBox.EndAddTwoChannelClip(Guid.Empty, out clipGuid, out footageGuid);
                //BSEditBox.EndAddClip(Guid.Empty, out clipGuid, out footageGuid);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 添加Clip
        /// </summary>
        /// <param name="lowVideoClipFile"></param>
        /// <param name="highVideoClipFile"></param>
        /// <param name="lowAudioClipFiles"></param>
        /// <param name="highAudioClipFiles"></param>
        /// <returns></returns>
        public void AddClip(string lowVideoClipFile, string highVideoClipFile, List<string> lowAudioClipFiles, List<string> highAudioClipFiles, string displayName)
        {
            try
            {

                // BSEditBox.BeginAddClip();
                BSEditBox.BeginAddTwoChannelClip();

                if (!string.IsNullOrEmpty(lowVideoClipFile))
                {
                    BSEditBox.BeginAddLowVideoClip(lowVideoClipFile);
                }

                foreach (string audioClipFile in lowAudioClipFiles)
                {
                    if (!string.IsNullOrEmpty(audioClipFile))
                    {
                        BSEditBox.BeginAddLowAudioClip(audioClipFile);
                    }
                }

                if (!string.IsNullOrEmpty(highVideoClipFile))
                {
                    BSEditBox.BeginAddHighVideoClip(highVideoClipFile);
                }

                foreach (string audioClipFile in highAudioClipFiles)
                {
                    if (!string.IsNullOrEmpty(audioClipFile))
                    {
                        BSEditBox.BeginAddHighAudioClip(audioClipFile);
                    }
                }

                BSEditBox.EndAddTwoChannelClip(Guid.Empty, out clipGuid, out footageGuid, displayName);
                //BSEditBox.EndAddClip(Guid.Empty, out clipGuid, out footageGuid);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }



        /// <summary>
        /// 添加到序列
        /// </summary>
        /// <param name="in_guidSequence"></param>
        /// <param name="in_guidProjectFootage"></param>
        /// <param name="in_guidProjectClip"></param>
        /// <param name="in_ui64TrimIn"></param>
        /// <param name="in_ui64TrimOut"></param>
        /// <param name="in_ui64SequenceIn"></param>
        /// <param name="in_SequenceOut"></param>
        /// <param name="in_ulDestVideoTrackIndex"></param>
        /// <param name="in_ulDestAudioTrackIndex"></param>
        public void AddProjectCliptoSequence(Guid in_guidSequence, Guid in_guidProjectFootage, Guid in_guidProjectClip, long in_ui64TrimIn, long in_ui64TrimOut, long in_ui64SequenceIn, long in_SequenceOut, uint in_ulDestVideoTrackIndex, uint in_ulDestAudioTrackIndex)
        {
            BSEditBox.AddProjectCliptoSequence(in_guidSequence, in_guidProjectFootage, in_guidProjectClip, in_ui64TrimIn, in_ui64TrimOut, in_ui64SequenceIn, in_SequenceOut, in_ulDestVideoTrackIndex, in_ulDestAudioTrackIndex);
        }

        public void AddProjectCliptoSequence(long in_ui64TrimIn, long in_ui64TrimOut, long in_ui64SequenceIn, long in_SequenceOut, uint in_ulDestVideoTrackIndex, uint in_ulDestAudioTrackIndex, ENxCommandAddClipTypeIDL oENxCommandAddClipTypeIDL = ENxCommandAddClipTypeIDL.keNxCommandAddClipIDLOverwrite)
        {
            BSEditProject.GetSequenceByIndex(0, out sequenceGuid);

            if ((int)oENxCommandAddClipTypeIDL >= 1)
            {
                BSEditBox.AddProjectCliptoSequence(sequenceGuid, footageGuid, clipGuid, in_ui64TrimIn, in_ui64TrimOut, in_ui64SequenceIn, in_SequenceOut, in_ulDestVideoTrackIndex, in_ulDestAudioTrackIndex, oENxCommandAddClipTypeIDL);
            }
            else
            {
                BSEditBox.AddProjectCliptoSequence(sequenceGuid, footageGuid, clipGuid, in_ui64TrimIn, in_ui64TrimOut, in_ui64SequenceIn, in_SequenceOut, in_ulDestVideoTrackIndex, in_ulDestAudioTrackIndex);
            }
        }
    }
}
