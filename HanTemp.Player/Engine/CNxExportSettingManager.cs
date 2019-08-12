using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NxBSEditApplicationWrapper;

namespace CS.Engine
{
    public class CNxExportSettingManager
    {
        public static void GetCaptureFormat(string in_pwszConfigFilePath, out CNxFormatDetailModel out_FormatDetailModel)
        {
            out_FormatDetailModel = null;

            try
            {
   
                __SNxCaptureFormatIDL formatidl = new __SNxCaptureFormatIDL();
                CNxEngineManager.Instance.ExportSettingManager.GetCaptureFormat(in_pwszConfigFilePath, out formatidl);

                out_FormatDetailModel = new CNxFormatDetailModel();

                out_FormatDetailModel.AudioChannelCount = formatidl.ulAudioChannelCount.ToString();
                out_FormatDetailModel.AudioSamplingFrequency = formatidl.ulSamplingFrequency.ToString() + "k";

                string VideoCodecType = "MPEG2I";
                switch (formatidl.ulVideoCodecType)
                {
                    case 1:
                        VideoCodecType = "MPEG2I";
                        break;
                    case 2:
                        VideoCodecType = "AvidDNxHD";
                        break;
                    case 3:
                        VideoCodecType = "DVCPROHD";
                        break;
                    case 4:
                        VideoCodecType = "AppleProRes422";
                        break;
                    case 5:
                        VideoCodecType = "PD MXF";
                        break;
                    case 6:
                        VideoCodecType = "H.264";
                        break;
                }
                out_FormatDetailModel.VideoCodecType = VideoCodecType;
                string VideoFileExt = "avi";
                switch (formatidl.ulFileExt)
                {
                    case 1:
                        VideoFileExt = "avi";
                        break;
                    case 2:
                        VideoFileExt = "mxf";
                        break;
                    case 3:
                        VideoFileExt = "mov";
                        break;
                    case 4:
                        VideoFileExt = "mp4";
                        break;

                }
                out_FormatDetailModel.VideoFileExt = VideoFileExt;
                out_FormatDetailModel.VideoDataRate = (formatidl.ulVideoDataRate / (1024 * 1024)).ToString() + "Mbps";
                out_FormatDetailModel.VideoResloution = formatidl.ulVideoWidth.ToString() + "*" + formatidl.ulVideoHeight.ToString();
                
                if(formatidl.ulVideoWidth>=1280)
                {
                    out_FormatDetailModel.IsHD = true;
                }
                else
                {
                    out_FormatDetailModel.IsHD = false;
                }

                
            }
            catch (System.Exception ex)
            {
                
            }
        }
    }

    public class CNxFormatDetailModel
    {
        public string VideoCodecType
        {
            get;
            set;
        }


        public string VideoDataRate
        {
            get;
            set;
        }

        public string VideoResloution
        {
            get;
            set;
        }

        public string VideoFileExt
        {
            get;
            set;
        }

        public string AudioSamplingFrequency
        {
            get;
            set;
        }

        public string AudioChannelCount
        {
            get;
            set;
        }

        public bool IsHD
        {
            get;
            set;
        }

    }
}
