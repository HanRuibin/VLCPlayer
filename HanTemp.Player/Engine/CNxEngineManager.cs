using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NxBSEditApplicationWrapper;
using System.Configuration;

namespace CS.Engine
{
    public class CNxEngineManager
    {
        private string projectPath;//工程路径

        public string ProjectPath
        {
            get
            {
                return projectPath;
            }
            set
            {
                projectPath = value;
            }
        }

        public CNxEngineManager()
        {
        }

        private static CNxEngineManager m_CNxEngineManager = null;
        public static CNxEngineManager Instance
        {
            get
            {
                if (m_CNxEngineManager == null)
                {
                    m_CNxEngineManager = new CNxEngineManager(@"C:\test.nxproj");
                    m_CNxEngineManager.Initianlize(true);
                }

                return m_CNxEngineManager;
            }
        }


        public CNxEngineManager(string in_ProjectPath)
        {
            this.projectPath = in_ProjectPath;
        }

        private CBSEditApplication _bsEditApplication = null;
        public void Initianlize(bool in_bHDResolution)
        {
            if (_bsEditApplication == null)
            {
                _bsEditApplication = new CBSEditApplication();
                //string strSignleCaputre=ConfigurationManager.AppSettings["IsSignleCaputre"].ToString();
                string strSignleCaputre = "1";
                int uiSignleCaputre;
                int.TryParse(strSignleCaputre, out uiSignleCaputre);
                _bsEditApplication.SetClientServerInSameMachineFlag(uiSignleCaputre);
                _bsEditApplication.Initialize(ENxBSEditApplicationType.keNxBSEditApplicationType_BSEdit);
                _bsEditApplication.StartWork();
            }

            //StringBuilder resolutionType = new StringBuilder(512);
            //StringBuilder resolutionDecription = new StringBuilder(512);

            //if (in_bHDResolution == false)
            //{
            //    _bsEditApplication.GetEditResolutionByIndex(0, 512, resolutionType, 512, resolutionDecription);
            //}
            //else
            //{
            //    _bsEditApplication.GetEditResolutionByIndex(1, 512, resolutionType, 512, resolutionDecription);
            //}

            //BSEditProject.NewProject2(ProjectPath, resolutionType.ToString(), 1, 8);

        }


        public void NewProject2(bool in_bHDResolution)
        {
            StringBuilder resolutionType = new StringBuilder(512);
            StringBuilder resolutionDecription = new StringBuilder(512);

            if (in_bHDResolution == false)
            {
                _bsEditApplication.GetEditResolutionByIndex(0, 512, resolutionType, 512, resolutionDecription);
            }
            else
            {
                _bsEditApplication.GetEditResolutionByIndex(1, 512, resolutionType, 512, resolutionDecription);
            }

            BSEditProject.NewProject2(ProjectPath, resolutionType.ToString(), 1, 8);
        }
        public CBSEditApplication EditApplication 
        {
            get { return _bsEditApplication; }
        }

        public int GetResolutionCount()
        {
            uint uiResolutionCount;

            _bsEditApplication.GetSupportEditResolutionCount(out uiResolutionCount);

            return (int)uiResolutionCount;

        }

        public string GetResolution(bool in_bHD)
        {
            StringBuilder resolutionType = new StringBuilder(512);
            StringBuilder resolutionDecription = new StringBuilder(512);
            if (in_bHD)
            {

                _bsEditApplication.GetEditResolutionByIndex(1, 512, resolutionType, 512, resolutionDecription);
            }
            else
            {
                _bsEditApplication.GetEditResolutionByIndex(0, 512, resolutionType, 512, resolutionDecription);
            }

            return resolutionType.ToString();
        }

        public void AddLiveWindow(int in_nType, ref _RemotableHandle in_hParent, tagRECT in_rcRect)
        {
            _bsEditApplication.AddLiveWindow(in_nType, ref in_hParent, in_rcRect);
        }

        private CBSSequenceMonitor m_oSequenceMonitor;
        public CBSSequenceMonitor CBSSequenceMonitor 
        {
            get 
            {
                if (m_oSequenceMonitor == null)
                {
                    CBSSequenceMonitor cm;
                    _bsEditApplication.GetBSEditSequenceMonitor(out cm);
                    m_oSequenceMonitor = cm;
                }
                return m_oSequenceMonitor;
            }
        }

        
        private CBSClipMonitor m_oClipMonitor;
        public CBSClipMonitor CBSClipMonitor
        {
            get
            {
                if (m_oClipMonitor == null)
                {
                    CBSClipMonitor cm;
                    _bsEditApplication.GetBSEditClipMonitor(out cm);
                    m_oClipMonitor = cm;
                }
                return m_oClipMonitor;
            }
        }

        /// <summary>
        /// EditProject
        /// </summary>
        private CBSEditProject _bsEditProject = null;
        public CBSEditProject BSEditProject
        {
            get
            {
                if (_bsEditProject == null)
                {
                    _bsEditApplication.GetBSEditProject(out _bsEditProject);
                }
                return _bsEditProject;
            }
        }

        private CBSEditBox m_oEditBox;
        public CBSEditBox CBSEditBox
        {
            get
            {
                if (m_oEditBox == null)
                {
                    _bsEditApplication.GetBSEditBox(out m_oEditBox);
                }
                return m_oEditBox;
            }
        }

        private BSMEdiaFileReader m_ppMediaFileReader;
        public BSMEdiaFileReader BSMEdiaFileReader
        {
            get
            {
                if (m_ppMediaFileReader == null)
                {
                    _bsEditApplication.GetMediaFileReader(out m_ppMediaFileReader);
                }
                return m_ppMediaFileReader;
            }
        }

        private CNxProjectManager m_oProjectManager = null;
        public CNxProjectManager ProjectManager
        {
            get
            {
                if (m_oProjectManager == null)
                {
                    m_oProjectManager = new CNxProjectManager();
                    m_oProjectManager.Initianlize(_bsEditApplication);
                }

                return m_oProjectManager;
            }
        }

        private CNxMultipleChannelLiveWindows m_oCNxMultipleChannelLiveWindows = null;
        public CNxMultipleChannelLiveWindows CNxMultipleChannelLiveWindows
        {
            get
            {
                if (m_oCNxMultipleChannelLiveWindows == null)
                {
                    _bsEditApplication.GetMultipleChannelLiveWindows(out m_oCNxMultipleChannelLiveWindows);
                }
                return m_oCNxMultipleChannelLiveWindows;
            }
        }

        private CNxMultipleChannelDeviceManager m_oCNxMultipleChannelDeviceManager = null;
        public CNxMultipleChannelDeviceManager CNxMultipleChannelDeviceManager
        {
            get
            {

                if (m_oCNxMultipleChannelDeviceManager == null)
                {
                    _bsEditApplication.GetMultipleChannelDeviceManager(out m_oCNxMultipleChannelDeviceManager);

                }
                return m_oCNxMultipleChannelDeviceManager;
            }
        }

        private CExportSettingManager exportSettingManager;
        public CExportSettingManager ExportSettingManager
        {
            get
            {
                if (exportSettingManager == null)
                {
                    _bsEditApplication.GetExportManager(out exportSettingManager);
                }
                return exportSettingManager;
            }
        }

        public void StopWork()
        {
            if (BSEditProject != null)
            {
                BSEditProject.CloseProject();
            }
            if (_bsEditApplication != null)
            {
                _bsEditApplication.StopWork();
            }

        }
    }

}
