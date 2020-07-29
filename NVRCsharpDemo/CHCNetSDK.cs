using System;
using System.Runtime.InteropServices;
namespace NVRCsharpDemo
{
	/// <summary>
	/// CHCNetSDK ��ժҪ˵����
	/// </summary>
    public class CHCNetSDK
    {
        public CHCNetSDK()
        {
            //
            // TODO: �ڴ˴���ӹ��캯���߼�
            //
        }
        
        //SDK����
        public const int SDK_PLAYMPEG4 = 1;//���ſ�
        public const int SDK_HCNETSDK = 2;//�����

        public const int NAME_LEN = 32;//�û�������
        public const int PASSWD_LEN = 16;//���볤��
        public const int GUID_LEN = 16;      //GUID����
        public const int DEV_TYPE_NAME_LEN = 24;      //�豸�������Ƴ���
        public const int MAX_NAMELEN = 16;//DVR���ص�½��
        public const int MAX_RIGHT = 32;//�豸֧�ֵ�Ȩ�ޣ�1-12��ʾ����Ȩ�ޣ�13-32��ʾԶ��Ȩ�ޣ�
        public const int SERIALNO_LEN = 48;//���кų���
        public const int MACADDR_LEN = 6;//mac��ַ����
        public const int MAX_ETHERNET = 2;//�豸������̫����
        public const int MAX_NETWORK_CARD = 4; //�豸�������������Ŀ
        public const int PATHNAME_LEN = 128;//·������

        public const int MAX_NUMBER_LEN = 32;	//������󳤶�
        public const int MAX_NAME_LEN = 128; //�豸������󳤶�

        public const int MAX_TIMESEGMENT_V30 = 8;//9000�豸���ʱ�����
        public const int MAX_TIMESEGMENT = 4;//8000�豸���ʱ�����
        public const int MAX_ICR_NUM = 8;   //ץ�Ļ������˹�ƬԤ�õ���

        public const int MAX_SHELTERNUM = 4;//8000�豸����ڵ�������
        public const int PHONENUMBER_LEN = 32;//pppoe���ź�����󳤶�

        public const int MAX_DISKNUM = 16;//8000�豸���Ӳ����
        public const int MAX_DISKNUM_V10 = 8;//1.2�汾֮ǰ�汾

        public const int MAX_WINDOW_V30 = 32;//9000�豸������ʾ��󲥷Ŵ�����
        public const int MAX_WINDOW = 16;//8000�豸���Ӳ����
        public const int MAX_VGA_V30 = 4;//9000�豸���ɽ�VGA��
        public const int MAX_VGA = 1;//8000�豸���ɽ�VGA��

        public const int MAX_USERNUM_V30 = 32;//9000�豸����û���
        public const int MAX_USERNUM = 16;//8000�豸����û���
        public const int MAX_EXCEPTIONNUM_V30 = 32;//9000�豸����쳣������
        public const int MAX_EXCEPTIONNUM = 16;//8000�豸����쳣������
        public const int MAX_LINK = 6;//8000�豸��ͨ�������Ƶ��������
        public const int MAX_ITC_EXCEPTIONOUT = 32;//ץ�Ļ���󱨾����

        public const int MAX_DECPOOLNUM = 4;//��·������ÿ������ͨ������ѭ��������
        public const int MAX_DECNUM = 4;//��·��������������ͨ������ʵ��ֻ��һ������������������
        public const int MAX_TRANSPARENTNUM = 2;//��·���������������͸��ͨ����
        public const int MAX_CYCLE_CHAN = 16; //��·�����������ѭͨ����
        public const int MAX_CYCLE_CHAN_V30 = 64;//�����ѯͨ��������չ��
        public const int MAX_DIRNAME_LENGTH = 80;//���Ŀ¼����

        public const int MAX_STRINGNUM_V30 = 8;//9000�豸���OSD�ַ�������
        public const int MAX_STRINGNUM = 4;//8000�豸���OSD�ַ�������
        public const int MAX_STRINGNUM_EX = 8;//8000������չ
        public const int MAX_AUXOUT_V30 = 16;//9000�豸����������
        public const int MAX_AUXOUT = 4;//8000�豸����������
        public const int MAX_HD_GROUP = 16;//9000�豸���Ӳ������
        public const int MAX_NFS_DISK = 8; //8000�豸���NFSӲ����

        public const int IW_ESSID_MAX_SIZE = 32;//WIFI��SSID�ų���
        public const int IW_ENCODING_TOKEN_MAX = 32;//WIFI��������ֽ���
        public const int WIFI_WEP_MAX_KEY_COUNT = 4;
        public const int WIFI_WEP_MAX_KEY_LENGTH = 33;
        public const int WIFI_WPA_PSK_MAX_KEY_LENGTH = 63;
        public const int WIFI_WPA_PSK_MIN_KEY_LENGTH = 8;
        public const int WIFI_MAX_AP_COUNT = 20;
        public const int MAX_SERIAL_NUM = 64;//���֧�ֵ�͸��ͨ��·��
        public const int MAX_DDNS_NUMS = 10;//9000�豸������ddns��
        public const int MAX_EMAIL_ADDR_LEN = 48;//���email��ַ����
        public const int MAX_EMAIL_PWD_LEN = 32;//���email���볤��

        public const int MAXPROGRESS = 100;//�ط�ʱ�����ٷ���
        public const int MAX_SERIALNUM = 2;//8000�豸֧�ֵĴ����� 1-232�� 2-485
        public const int CARDNUM_LEN = 20;//���ų���
        public const int CARDNUM_LEN_OUT = 32; //�ⲿ�ṹ�忨�ų���
        public const int MAX_VIDEOOUT_V30 = 4;//9000�豸����Ƶ�����
        public const int MAX_VIDEOOUT = 2;//8000�豸����Ƶ�����

        public const int MAX_PRESET_V30 = 256;// 9000�豸֧�ֵ���̨Ԥ�õ���
        public const int MAX_TRACK_V30 = 256;// 9000�豸֧�ֵ���̨�켣��
        public const int MAX_CRUISE_V30 = 256;// 9000�豸֧�ֵ���̨Ѳ����
        public const int MAX_PRESET = 128;// 8000�豸֧�ֵ���̨Ԥ�õ��� 
        public const int MAX_TRACK = 128;// 8000�豸֧�ֵ���̨�켣��
        public const int MAX_CRUISE = 128;// 8000�豸֧�ֵ���̨Ѳ���� 

        public const int CRUISE_MAX_PRESET_NUMS = 32;// һ��Ѳ������Ѳ���� 

        public const int MAX_SERIAL_PORT = 8;//9000�豸֧��232������
        public const int MAX_PREVIEW_MODE = 8;// �豸֧�����Ԥ��ģʽ��Ŀ 1����,4����,9����,16����.... 
        public const int MAX_MATRIXOUT = 16;// ���ģ������������ 
        public const int LOG_INFO_LEN = 11840; // ��־������Ϣ 
        public const int DESC_LEN = 16;// ��̨�����ַ������� 
        public const int PTZ_PROTOCOL_NUM = 200;// 9000���֧�ֵ���̨Э���� 

        public const int MAX_AUDIO = 1;//8000�����Խ�ͨ����
        public const int MAX_AUDIO_V30 = 2;//9000�����Խ�ͨ����
        public const int MAX_CHANNUM = 16;//8000�豸���ͨ����
        public const int MAX_ALARMIN = 16;//8000�豸��󱨾�������
        public const int MAX_ALARMOUT = 4;//8000�豸��󱨾������
        //9000 IPC����
        public const int MAX_ANALOG_CHANNUM = 32;//���32��ģ��ͨ��
        public const int MAX_ANALOG_ALARMOUT = 32; //���32·ģ�ⱨ����� 
        public const int MAX_ANALOG_ALARMIN = 32;//���32·ģ�ⱨ������

        public const int MAX_IP_DEVICE = 32;//�����������IP�豸��
        public const int MAX_IP_DEVICE_V40 = 64;//�����������IP�豸��
        public const int MAX_IP_CHANNEL = 32;//�����������IPͨ����
        public const int MAX_IP_ALARMIN = 128;//����������౨��������
        public const int MAX_IP_ALARMOUT = 64;//����������౨�������
        public const int MAX_IP_ALARMIN_V40 = 4096;    //����������౨��������
        public const int MAX_IP_ALARMOUT_V40 = 4096;    //����������౨�������

        public const int MAX_RECORD_FILE_NUM = 20;      // ÿ��ɾ�����߿�¼������ļ���

        //SDK_V31 ATM
        public const int MAX_ATM_NUM = 1;
        public const int MAX_ACTION_TYPE = 12;
        public const int ATM_FRAMETYPE_NUM = 4;
        public const int MAX_ATM_PROTOCOL_NUM = 1025;
        public const int ATM_PROTOCOL_SORT = 4;
        public const int ATM_DESC_LEN = 32;
        // SDK_V31 ATM

        /* ���֧�ֵ�ͨ���� ���ģ��������IP֧�� */
        public const int MAX_CHANNUM_V30 = MAX_ANALOG_CHANNUM + MAX_IP_CHANNEL;//64
        public const int MAX_ALARMOUT_V30 = MAX_ANALOG_ALARMOUT + MAX_IP_ALARMOUT;//96
        public const int MAX_ALARMIN_V30 = MAX_ANALOG_ALARMIN + MAX_IP_ALARMIN;//160

        public const int MAX_CHANNUM_V40 = 512;
        public const int MAX_ALARMOUT_V40 = MAX_IP_ALARMOUT_V40 + MAX_ANALOG_ALARMOUT;//4128
        public const int MAX_ALARMIN_V40 = MAX_IP_ALARMIN_V40 + MAX_ANALOG_ALARMOUT;//4128

        public const int MAX_HUMAN_PICTURE_NUM = 10;   //�����Ƭ��
        public const int MAX_HUMAN_BIRTHDATE_LEN = 10;

        public const int MAX_LAYERNUMS = 32;

        public const int MAX_ROIDETECT_NUM = 8;    //֧�ֵ�ROI������
        public const int MAX_LANERECT_NUM   =     5;    //�����ʶ��������
        public const int MAX_FORTIFY_NUM   =      10;   //��󲼷�����
        public const int MAX_INTERVAL_NUM  =      4;    //���ʱ��������
        public const int MAX_CHJC_NUM     =       3;    //�����ʡ�ݼ���ַ�����
        public const int MAX_VL_NUM        =      5;    //���������Ȧ����
        public const int MAX_DRIVECHAN_NUM =      16;   //��󳵵���
        public const int MAX_COIL_NUM      =      3;    //�����Ȧ����
        public const int MAX_SIGNALLIGHT_NUM =    6;   //����źŵƸ���
        public const int LEN_32				=	32;
        public const int LEN_31				=	31; 
        public const int MAX_CABINET_COUNT  =     8;    //���֧�ֻ�������
        public const int MAX_ID_LEN         =     48;
        public const int MAX_PARKNO_LEN    =      16;
        public const int MAX_ALARMREASON_LEN =    32;
        public const int MAX_UPGRADE_INFO_LEN=    48; //��ȡ�����ļ�ƥ����Ϣ(ģ������)
        public const int MAX_CUSTOMDIR_LEN  =     32; //�Զ���Ŀ¼����

        public const int MAX_TRANSPARENT_CHAN_NUM  =    4;   //ÿ�����������������͸��ͨ����
        public const int MAX_TRANSPARENT_ACCESS_NUM =   4;   //ÿ�������˿������������������

        //ITS
        public const int MAX_PARKING_STATUS  =     8;    //��λ״̬ 0�����޳���1�����г���2����ѹ��(���ȼ����), 3���⳵λ 
        public const int MAX_PARKING_NUM	   =      4;    //һ��ͨ�����4����λ (�����ҳ�λ ����0��3)

        public const int MAX_ITS_SCENE_NUM    =    16;   //��󳡾�����
        public const int MAX_SCENE_TIMESEG_NUM =   16;   //��󳡾�ʱ�������
        public const int MAX_IVMS_IP_CHANNEL  =    128;  //���IPͨ����
        public const int DEVICE_ID_LEN      =      48;   //�豸��ų���
        public const int MONITORSITE_ID_LEN  =     48;   //�����ų���
        public const int MAX_AUXAREA_NUM       =   16;   //�������������Ŀ
        public const int MAX_SLAVE_CHANNEL_NUM =   16;   //����ͨ������

        public const int MAX_SCH_TASKS_NUM = 10;

        public const int MAX_SERVERID_LEN   =         64; //��������ID�ĳ���
        public const int MAX_SERVERDOMAIN_LEN =       128; //������������󳤶�
        public const int MAX_AUTHENTICATEID_LEN =     64; //��֤ID��󳤶�
        public const int MAX_AUTHENTICATEPASSWD_LEN = 32; //��֤������󳤶�
        public const int MAX_SERVERNAME_LEN =         64; //���������û��� 
        public const int MAX_COMPRESSIONID_LEN =      64; //����ID����󳤶�
        public const int MAX_SIPSERVER_ADDRESS_LEN =  128; //SIP��������ַ֧��������IP��ַ
        //ѹ�߱���
        public const int MAX_PlATE_NO_LEN =        32;   //���ƺ�����󳤶� 2013-09-27
        public const int UPNP_PORT_NUM	=		12;	  //upnp�˿�ӳ��˿���Ŀ

        
        public const int MAX_LOCAL_ADDR_LEN	= 96;		//SOCKS��󱾵����θ���
        public const int MAX_COUNTRY_NAME_LEN = 4;		//���Ҽ�д���Ƴ���

        //�������ӷ�ʽ
        public const int NORMALCONNECT = 1;
        public const int MEDIACONNECT = 2;

        //�豸�ͺ�(����)
        public const int HCDVR = 1;
        public const int MEDVR = 2;
        public const int PCDVR = 3;
        public const int HC_9000 = 4;
        public const int HF_I = 5;
        public const int PCNVR = 6;
        public const int HC_76NVR = 8;

        //NVR����
        public const int DS8000HC_NVR = 0;
        public const int DS9000HC_NVR = 1;
        public const int DS8000ME_NVR = 2;

        /*******************ȫ�ִ����� begin**********************/
        public const int NET_DVR_NOERROR = 0;//û�д���
        public const int NET_DVR_PASSWORD_ERROR = 1;//�û����������
        public const int NET_DVR_NOENOUGHPRI = 2;//Ȩ�޲���
        public const int NET_DVR_NOINIT = 3;//û�г�ʼ��
        public const int NET_DVR_CHANNEL_ERROR = 4;//ͨ���Ŵ���
        public const int NET_DVR_OVER_MAXLINK = 5;//���ӵ�DVR�Ŀͻ��˸����������
        public const int NET_DVR_VERSIONNOMATCH = 6;//�汾��ƥ��
        public const int NET_DVR_NETWORK_FAIL_CONNECT = 7;//���ӷ�����ʧ��
        public const int NET_DVR_NETWORK_SEND_ERROR = 8;//�����������ʧ��
        public const int NET_DVR_NETWORK_RECV_ERROR = 9;//�ӷ�������������ʧ��
        public const int NET_DVR_NETWORK_RECV_TIMEOUT = 10;//�ӷ������������ݳ�ʱ
        public const int NET_DVR_NETWORK_ERRORDATA = 11;//���͵���������
        public const int NET_DVR_ORDER_ERROR = 12;//���ô������
        public const int NET_DVR_OPERNOPERMIT = 13;//�޴�Ȩ��
        public const int NET_DVR_COMMANDTIMEOUT = 14;//DVR����ִ�г�ʱ
        public const int NET_DVR_ERRORSERIALPORT = 15;//���ںŴ���
        public const int NET_DVR_ERRORALARMPORT = 16;//�����˿ڴ���
        public const int NET_DVR_PARAMETER_ERROR = 17;//��������
        public const int NET_DVR_CHAN_EXCEPTION = 18;//������ͨ�����ڴ���״̬
        public const int NET_DVR_NODISK = 19;//û��Ӳ��
        public const int NET_DVR_ERRORDISKNUM = 20;//Ӳ�̺Ŵ���
        public const int NET_DVR_DISK_FULL = 21;//������Ӳ����
        public const int NET_DVR_DISK_ERROR = 22;//������Ӳ�̳���
        public const int NET_DVR_NOSUPPORT = 23;//��������֧��
        public const int NET_DVR_BUSY = 24;//������æ
        public const int NET_DVR_MODIFY_FAIL = 25;//�������޸Ĳ��ɹ�
        public const int NET_DVR_PASSWORD_FORMAT_ERROR = 26;//���������ʽ����ȷ
        public const int NET_DVR_DISK_FORMATING = 27;//Ӳ�����ڸ�ʽ����������������
        public const int NET_DVR_DVRNORESOURCE = 28;//DVR��Դ����
        public const int NET_DVR_DVROPRATEFAILED = 29;//DVR����ʧ��
        public const int NET_DVR_OPENHOSTSOUND_FAIL = 30;//��PC����ʧ��
        public const int NET_DVR_DVRVOICEOPENED = 31;//�����������Խ���ռ��
        public const int NET_DVR_TIMEINPUTERROR = 32;//ʱ�����벻��ȷ
        public const int NET_DVR_NOSPECFILE = 33;//�ط�ʱ������û��ָ�����ļ�
        public const int NET_DVR_CREATEFILE_ERROR = 34;//�����ļ�����
        public const int NET_DVR_FILEOPENFAIL = 35;//���ļ�����
        public const int NET_DVR_OPERNOTFINISH = 36; //�ϴεĲ�����û�����
        public const int NET_DVR_GETPLAYTIMEFAIL = 37;//��ȡ��ǰ���ŵ�ʱ�����
        public const int NET_DVR_PLAYFAIL = 38;//���ų���
        public const int NET_DVR_FILEFORMAT_ERROR = 39;//�ļ���ʽ����ȷ
        public const int NET_DVR_DIR_ERROR = 40;//·������
        public const int NET_DVR_ALLOC_RESOURCE_ERROR = 41;//��Դ�������
        public const int NET_DVR_AUDIO_MODE_ERROR = 42;//����ģʽ����
        public const int NET_DVR_NOENOUGH_BUF = 43;//������̫С
        public const int NET_DVR_CREATESOCKET_ERROR = 44;//����SOCKET����
        public const int NET_DVR_SETSOCKET_ERROR = 45;//����SOCKET����
        public const int NET_DVR_MAX_NUM = 46;//�����ﵽ���
        public const int NET_DVR_USERNOTEXIST = 47;//�û�������
        public const int NET_DVR_WRITEFLASHERROR = 48;//дFLASH����
        public const int NET_DVR_UPGRADEFAIL = 49;//DVR����ʧ��
        public const int NET_DVR_CARDHAVEINIT = 50;//���뿨�Ѿ���ʼ����
        public const int NET_DVR_PLAYERFAILED = 51;//���ò��ſ���ĳ������ʧ��
        public const int NET_DVR_MAX_USERNUM = 52;//�豸���û����ﵽ���
        public const int NET_DVR_GETLOCALIPANDMACFAIL = 53;//��ÿͻ��˵�IP��ַ�������ַʧ��
        public const int NET_DVR_NOENCODEING = 54;//��ͨ��û�б���
        public const int NET_DVR_IPMISMATCH = 55;//IP��ַ��ƥ��
        public const int NET_DVR_MACMISMATCH = 56;//MAC��ַ��ƥ��
        public const int NET_DVR_UPGRADELANGMISMATCH = 57;//�����ļ����Բ�ƥ��
        public const int NET_DVR_MAX_PLAYERPORT = 58;//������·���ﵽ���
        public const int NET_DVR_NOSPACEBACKUP = 59;//�����豸��û���㹻�ռ���б���
        public const int NET_DVR_NODEVICEBACKUP = 60;//û���ҵ�ָ���ı����豸
        public const int NET_DVR_PICTURE_BITS_ERROR = 61;//ͼ����λ����������24ɫ
        public const int NET_DVR_PICTURE_DIMENSION_ERROR = 62;//ͼƬ��*���ޣ� ��128*256
        public const int NET_DVR_PICTURE_SIZ_ERROR = 63;//ͼƬ��С���ޣ���100K
        public const int NET_DVR_LOADPLAYERSDKFAILED = 64;//���뵱ǰĿ¼��Player Sdk����
        public const int NET_DVR_LOADPLAYERSDKPROC_ERROR = 65;//�Ҳ���Player Sdk��ĳ���������
        public const int NET_DVR_LOADDSSDKFAILED = 66;//���뵱ǰĿ¼��DSsdk����
        public const int NET_DVR_LOADDSSDKPROC_ERROR = 67;//�Ҳ���DsSdk��ĳ���������
        public const int NET_DVR_DSSDK_ERROR = 68;//����Ӳ�����DsSdk��ĳ������ʧ��
        public const int NET_DVR_VOICEMONOPOLIZE = 69;//��������ռ
        public const int NET_DVR_JOINMULTICASTFAILED = 70;//����ಥ��ʧ��
        public const int NET_DVR_CREATEDIR_ERROR = 71;//������־�ļ�Ŀ¼ʧ��
        public const int NET_DVR_BINDSOCKET_ERROR = 72;//���׽���ʧ��
        public const int NET_DVR_SOCKETCLOSE_ERROR = 73;//socket�����жϣ��˴���ͨ�������������жϻ�Ŀ�ĵز��ɴ�
        public const int NET_DVR_USERID_ISUSING = 74;//ע��ʱ�û�ID���ڽ���ĳ����
        public const int NET_DVR_SOCKETLISTEN_ERROR = 75;//����ʧ��
        public const int NET_DVR_PROGRAM_EXCEPTION = 76;//�����쳣
        public const int NET_DVR_WRITEFILE_FAILED = 77;//д�ļ�ʧ��
        public const int NET_DVR_FORMAT_READONLY = 78;//��ֹ��ʽ��ֻ��Ӳ��
        public const int NET_DVR_WITHSAMEUSERNAME = 79;//�û����ýṹ�д�����ͬ���û���
        public const int NET_DVR_DEVICETYPE_ERROR = 80;//�������ʱ�豸�ͺŲ�ƥ��
        public const int NET_DVR_LANGUAGE_ERROR = 81;//�������ʱ���Բ�ƥ��
        public const int NET_DVR_PARAVERSION_ERROR = 82;//�������ʱ����汾��ƥ��
        public const int NET_DVR_IPCHAN_NOTALIVE = 83; //Ԥ��ʱ���IPͨ��������
        public const int NET_DVR_RTSP_SDK_ERROR = 84;//���ظ���IPCͨѶ��StreamTransClient.dllʧ��
        public const int NET_DVR_CONVERT_SDK_ERROR = 85;//����ת���ʧ��
        public const int NET_DVR_IPC_COUNT_OVERFLOW = 86;//��������ip����ͨ����

        public const int NET_PLAYM4_NOERROR = 500;//no error
        public const int NET_PLAYM4_PARA_OVER = 501;//input parameter is invalid
        public const int NET_PLAYM4_ORDER_ERROR = 502;//The order of the function to be called is error
        public const int NET_PLAYM4_TIMER_ERROR = 503;//Create multimedia clock failed
        public const int NET_PLAYM4_DEC_VIDEO_ERROR = 504;//Decode video data failed
        public const int NET_PLAYM4_DEC_AUDIO_ERROR = 505;//Decode audio data failed
        public const int NET_PLAYM4_ALLOC_MEMORY_ERROR = 506;//Allocate memory failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR = 507;//Open the file failed
        public const int NET_PLAYM4_CREATE_OBJ_ERROR = 508;//Create thread or event failed
        public const int NET_PLAYM4_CREATE_DDRAW_ERROR = 509;//Create DirectDraw object failed
        public const int NET_PLAYM4_CREATE_OFFSCREEN_ERROR = 510;//failed when creating off-screen surface
        public const int NET_PLAYM4_BUF_OVER = 511;//buffer is overflow
        public const int NET_PLAYM4_CREATE_SOUND_ERROR = 512;//failed when creating audio device
        public const int NET_PLAYM4_SET_VOLUME_ERROR = 513;//Set volume failed
        public const int NET_PLAYM4_SUPPORT_FILE_ONLY = 514;//The function only support play file
        public const int NET_PLAYM4_SUPPORT_STREAM_ONLY = 515;//The function only support play stream
        public const int NET_PLAYM4_SYS_NOT_SUPPORT = 516;//System not support
        public const int NET_PLAYM4_FILEHEADER_UNKNOWN = 517;//No file header
        public const int NET_PLAYM4_VERSION_INCORRECT = 518;//The version of decoder and encoder is not adapted
        public const int NET_PALYM4_INIT_DECODER_ERROR = 519;//Initialize decoder failed
        public const int NET_PLAYM4_CHECK_FILE_ERROR = 520;//The file data is unknown
        public const int NET_PLAYM4_INIT_TIMER_ERROR = 521;//Initialize multimedia clock failed
        public const int NET_PLAYM4_BLT_ERROR = 522;//Blt failed
        public const int NET_PLAYM4_UPDATE_ERROR = 523;//Update failed
        public const int NET_PLAYM4_OPEN_FILE_ERROR_MULTI = 524;//openfile error, streamtype is multi
        public const int NET_PLAYM4_OPEN_FILE_ERROR_VIDEO = 525;//openfile error, streamtype is video
        public const int NET_PLAYM4_JPEG_COMPRESS_ERROR = 526;//JPEG compress error
        public const int NET_PLAYM4_EXTRACT_NOT_SUPPORT = 527;//Don't support the version of this file
        public const int NET_PLAYM4_EXTRACT_DATA_ERROR = 528;//extract video data failed
        /*******************ȫ�ִ����� end**********************/

        /*************************************************
        NET_DVR_IsSupport()����ֵ
        1��9λ�ֱ��ʾ������Ϣ��λ����TRUE)��ʾ֧�֣�
        **************************************************/
        public const int NET_DVR_SUPPORT_DDRAW = 1;//֧��DIRECTDRAW�������֧�֣��򲥷������ܹ���
        public const int NET_DVR_SUPPORT_BLT = 2;//�Կ�֧��BLT�����������֧�֣��򲥷������ܹ���
        public const int NET_DVR_SUPPORT_BLTFOURCC = 4;//�Կ�BLT֧����ɫת���������֧�֣��������������������RGBת��
        public const int NET_DVR_SUPPORT_BLTSHRINKX = 8;//�Կ�BLT֧��X����С�������֧�֣�ϵͳ�����������ת��
        public const int NET_DVR_SUPPORT_BLTSHRINKY = 16;//�Կ�BLT֧��Y����С�������֧�֣�ϵͳ�����������ת��
        public const int NET_DVR_SUPPORT_BLTSTRETCHX = 32;//�Կ�BLT֧��X��Ŵ������֧�֣�ϵͳ�����������ת��
        public const int NET_DVR_SUPPORT_BLTSTRETCHY = 64;//�Կ�BLT֧��Y��Ŵ������֧�֣�ϵͳ�����������ת��
        public const int NET_DVR_SUPPORT_SSE = 128;//CPU֧��SSEָ�Intel Pentium3����֧��SSEָ��
        public const int NET_DVR_SUPPORT_MMX = 256;//CPU֧��MMXָ���Intel Pentium3����֧��SSEָ��

        /**********************��̨�������� begin*************************/
        public const int LIGHT_PWRON = 2;// ��ͨ�ƹ��Դ
        public const int WIPER_PWRON = 3;// ��ͨ��ˢ���� 
        public const int FAN_PWRON = 4;// ��ͨ���ȿ���
        public const int HEATER_PWRON = 5;// ��ͨ����������
        public const int AUX_PWRON1 = 6;// ��ͨ�����豸����
        public const int AUX_PWRON2 = 7;// ��ͨ�����豸���� 
        public const int SET_PRESET = 8;// ����Ԥ�õ� 
        public const int CLE_PRESET = 9;// ���Ԥ�õ� 

        public const int ZOOM_IN = 11;// �������ٶ�SS���(���ʱ��)
        public const int ZOOM_OUT = 12;// �������ٶ�SS��С(���ʱ�С)
        public const int FOCUS_NEAR = 13;// �������ٶ�SSǰ�� 
        public const int FOCUS_FAR = 14;// �������ٶ�SS���
        public const int IRIS_OPEN = 15;// ��Ȧ���ٶ�SS����
        public const int IRIS_CLOSE = 16;// ��Ȧ���ٶ�SS��С 

        public const int TILT_UP = 21;/* ��̨��SS���ٶ����� */
        public const int TILT_DOWN = 22;/* ��̨��SS���ٶ��¸� */
        public const int PAN_LEFT = 23;/* ��̨��SS���ٶ���ת */
        public const int PAN_RIGHT = 24;/* ��̨��SS���ٶ���ת */
        public const int UP_LEFT = 25;/* ��̨��SS���ٶ���������ת */
        public const int UP_RIGHT = 26;/* ��̨��SS���ٶ���������ת */
        public const int DOWN_LEFT = 27;/* ��̨��SS���ٶ��¸�����ת */
        public const int DOWN_RIGHT = 28;/* ��̨��SS���ٶ��¸�����ת */
        public const int PAN_AUTO = 29;/* ��̨��SS���ٶ������Զ�ɨ�� */

        public const int FILL_PRE_SEQ = 30;/* ��Ԥ�õ����Ѳ������ */
        public const int SET_SEQ_DWELL = 31;/* ����Ѳ����ͣ��ʱ�� */
        public const int SET_SEQ_SPEED = 32;/* ����Ѳ���ٶ� */
        public const int CLE_PRE_SEQ = 33;/* ��Ԥ�õ��Ѳ��������ɾ�� */
        public const int STA_MEM_CRUISE = 34;/* ��ʼ��¼�켣 */
        public const int STO_MEM_CRUISE = 35;/* ֹͣ��¼�켣 */
        public const int RUN_CRUISE = 36;/* ��ʼ�켣 */
        public const int RUN_SEQ = 37;/* ��ʼѲ�� */
        public const int STOP_SEQ = 38;/* ֹͣѲ�� */
        public const int GOTO_PRESET = 39;/* ����ת��Ԥ�õ� */
        /**********************��̨�������� end*************************/

        /*************************************************
        �ط�ʱ���ſ�������궨�� 
        NET_DVR_PlayBackControl
        NET_DVR_PlayControlLocDisplay
        NET_DVR_DecPlayBackCtrl�ĺ궨��
        ����֧�ֲ鿴����˵���ʹ���
        **************************************************/
        public const int NET_DVR_PLAYSTART = 1;//��ʼ����
        public const int NET_DVR_PLAYSTOP = 2;//ֹͣ����
        public const int NET_DVR_PLAYPAUSE = 3;//��ͣ����
        public const int NET_DVR_PLAYRESTART = 4;//�ָ�����
        public const int NET_DVR_PLAYFAST = 5;//���
        public const int NET_DVR_PLAYSLOW = 6;//����
        public const int NET_DVR_PLAYNORMAL = 7;//�����ٶ�
        public const int NET_DVR_PLAYFRAME = 8;//��֡��
        public const int NET_DVR_PLAYSTARTAUDIO = 9;//������
        public const int NET_DVR_PLAYSTOPAUDIO = 10;//�ر�����
        public const int NET_DVR_PLAYAUDIOVOLUME = 11;//��������
        public const int NET_DVR_PLAYSETPOS = 12;//�ı��ļ��طŵĽ���
        public const int NET_DVR_PLAYGETPOS = 13;//��ȡ�ļ��طŵĽ���
        public const int NET_DVR_PLAYGETTIME = 14;//��ȡ��ǰ�Ѿ����ŵ�ʱ��(���ļ��طŵ�ʱ����Ч)
        public const int NET_DVR_PLAYGETFRAME = 15;//��ȡ��ǰ�Ѿ����ŵ�֡��(���ļ��طŵ�ʱ����Ч)
        public const int NET_DVR_GETTOTALFRAMES = 16;//��ȡ��ǰ�����ļ��ܵ�֡��(���ļ��طŵ�ʱ����Ч)
        public const int NET_DVR_GETTOTALTIME = 17;//��ȡ��ǰ�����ļ��ܵ�ʱ��(���ļ��طŵ�ʱ����Ч)
        public const int NET_DVR_THROWBFRAME = 20;//��B֡
        public const int NET_DVR_SETSPEED = 24;//���������ٶ�
        public const int NET_DVR_KEEPALIVE = 25;//�������豸������(����ص�����������2�뷢��һ��)
        public const int NET_DVR_PLAYSETTIME = 26;//������ʱ�䶨λ
        public const int NET_DVR_PLAYGETTOTALLEN = 27;//��ȡ��ʱ��طŶ�Ӧʱ����ڵ������ļ����ܳ���
        public const int NET_DVR_PLAY_FORWARD = 29;//�����л�Ϊ����
        public const int NET_DVR_PLAY_REVERSE = 30;//�����л�Ϊ����
        public const int NET_DVR_SET_TRANS_TYPE = 32;//����ת��װ����
        public const int NET_DVR_PLAY_CONVERT = 33;//�����л�Ϊ����

        //Զ�̰����������£�
        /* key value send to CONFIG program */
        public const int KEY_CODE_1 = 1;
        public const int KEY_CODE_2 = 2;
        public const int KEY_CODE_3 = 3;
        public const int KEY_CODE_4 = 4;
        public const int KEY_CODE_5 = 5;
        public const int KEY_CODE_6 = 6;
        public const int KEY_CODE_7 = 7;
        public const int KEY_CODE_8 = 8;
        public const int KEY_CODE_9 = 9;
        public const int KEY_CODE_0 = 10;
        public const int KEY_CODE_POWER = 11;
        public const int KEY_CODE_MENU = 12;
        public const int KEY_CODE_ENTER = 13;
        public const int KEY_CODE_CANCEL = 14;
        public const int KEY_CODE_UP = 15;
        public const int KEY_CODE_DOWN = 16;
        public const int KEY_CODE_LEFT = 17;
        public const int KEY_CODE_RIGHT = 18;
        public const int KEY_CODE_EDIT = 19;
        public const int KEY_CODE_ADD = 20;
        public const int KEY_CODE_MINUS = 21;
        public const int KEY_CODE_PLAY = 22;
        public const int KEY_CODE_REC = 23;
        public const int KEY_CODE_PAN = 24;
        public const int KEY_CODE_M = 25;
        public const int KEY_CODE_A = 26;
        public const int KEY_CODE_F1 = 27;
        public const int KEY_CODE_F2 = 28;

        /* for PTZ control */
        public const int KEY_PTZ_UP_START = KEY_CODE_UP;
        public const int KEY_PTZ_UP_STOP = 32;

        public const int KEY_PTZ_DOWN_START = KEY_CODE_DOWN;
        public const int KEY_PTZ_DOWN_STOP = 33;


        public const int KEY_PTZ_LEFT_START = KEY_CODE_LEFT;
        public const int KEY_PTZ_LEFT_STOP = 34;

        public const int KEY_PTZ_RIGHT_START = KEY_CODE_RIGHT;
        public const int KEY_PTZ_RIGHT_STOP = 35;

        public const int KEY_PTZ_AP1_START = KEY_CODE_EDIT;/* ��Ȧ+ */
        public const int KEY_PTZ_AP1_STOP = 36;

        public const int KEY_PTZ_AP2_START = KEY_CODE_PAN;/* ��Ȧ- */
        public const int KEY_PTZ_AP2_STOP = 37;

        public const int KEY_PTZ_FOCUS1_START = KEY_CODE_A;/* �۽�+ */
        public const int KEY_PTZ_FOCUS1_STOP = 38;

        public const int KEY_PTZ_FOCUS2_START = KEY_CODE_M;/* �۽�- */
        public const int KEY_PTZ_FOCUS2_STOP = 39;

        public const int KEY_PTZ_B1_START = 40;/* �䱶+ */
        public const int KEY_PTZ_B1_STOP = 41;

        public const int KEY_PTZ_B2_START = 42;/* �䱶- */
        public const int KEY_PTZ_B2_STOP = 43;

        //9000����
        public const int KEY_CODE_11 = 44;
        public const int KEY_CODE_12 = 45;
        public const int KEY_CODE_13 = 46;
        public const int KEY_CODE_14 = 47;
        public const int KEY_CODE_15 = 48;
        public const int KEY_CODE_16 = 49;

        /*************************������������ begin*******************************/
        //����NET_DVR_SetDVRConfig��NET_DVR_GetDVRConfig,ע�����Ӧ�����ýṹ
        public const int NET_DVR_GET_DEVICECFG = 100;//��ȡ�豸����
        public const int NET_DVR_SET_DEVICECFG = 101;//�����豸����
        public const int NET_DVR_GET_NETCFG = 102;//��ȡ�������
        public const int NET_DVR_SET_NETCFG = 103;//�����������
        public const int NET_DVR_GET_PICCFG = 104;//��ȡͼ�����
        public const int NET_DVR_SET_PICCFG = 105;//����ͼ�����
        public const int NET_DVR_GET_COMPRESSCFG = 106;//��ȡѹ������
        public const int NET_DVR_SET_COMPRESSCFG = 107;//����ѹ������
        public const int NET_DVR_GET_RECORDCFG = 108;//��ȡ¼��ʱ�����
        public const int NET_DVR_SET_RECORDCFG = 109;//����¼��ʱ�����
        public const int NET_DVR_GET_DECODERCFG = 110;//��ȡ����������
        public const int NET_DVR_SET_DECODERCFG = 111;//���ý���������
        public const int NET_DVR_GET_RS232CFG = 112;//��ȡ232���ڲ���
        public const int NET_DVR_SET_RS232CFG = 113;//����232���ڲ���
        public const int NET_DVR_GET_ALARMINCFG = 114;//��ȡ�����������
        public const int NET_DVR_SET_ALARMINCFG = 115;//���ñ����������
        public const int NET_DVR_GET_ALARMOUTCFG = 116;//��ȡ�����������
        public const int NET_DVR_SET_ALARMOUTCFG = 117;//���ñ����������
        public const int NET_DVR_GET_TIMECFG = 118;//��ȡDVRʱ��
        public const int NET_DVR_SET_TIMECFG = 119;//����DVRʱ��
        public const int NET_DVR_GET_PREVIEWCFG = 120;//��ȡԤ������
        public const int NET_DVR_SET_PREVIEWCFG = 121;//����Ԥ������
        public const int NET_DVR_GET_VIDEOOUTCFG = 122;//��ȡ��Ƶ�������
        public const int NET_DVR_SET_VIDEOOUTCFG = 123;//������Ƶ�������
        public const int NET_DVR_GET_USERCFG = 124;//��ȡ�û�����
        public const int NET_DVR_SET_USERCFG = 125;//�����û�����
        public const int NET_DVR_GET_EXCEPTIONCFG = 126;//��ȡ�쳣����
        public const int NET_DVR_SET_EXCEPTIONCFG = 127;//�����쳣����
        public const int NET_DVR_GET_ZONEANDDST = 128;//��ȡʱ������ʱ�Ʋ���
        public const int NET_DVR_SET_ZONEANDDST = 129;//����ʱ������ʱ�Ʋ���
        public const int NET_DVR_GET_SHOWSTRING = 130;//��ȡ�����ַ�����
        public const int NET_DVR_SET_SHOWSTRING = 131;//���õ����ַ�����
        public const int NET_DVR_GET_EVENTCOMPCFG = 132;//��ȡ�¼�����¼�����
        public const int NET_DVR_SET_EVENTCOMPCFG = 133;//�����¼�����¼�����

        public const int NET_DVR_GET_AUXOUTCFG = 140;//��ȡ�������������������(HS�豸�������2006-02-28)
        public const int NET_DVR_SET_AUXOUTCFG = 141;//���ñ������������������(HS�豸�������2006-02-28)
        public const int NET_DVR_GET_PREVIEWCFG_AUX = 142;//��ȡ-sϵ��˫���Ԥ������(-sϵ��˫���2006-04-13)
        public const int NET_DVR_SET_PREVIEWCFG_AUX = 143;//����-sϵ��˫���Ԥ������(-sϵ��˫���2006-04-13)

        public const int NET_DVR_GET_PICCFG_EX = 200;//��ȡͼ�����(SDK_V14��չ����)
        public const int NET_DVR_SET_PICCFG_EX = 201;//����ͼ�����(SDK_V14��չ����)
        public const int NET_DVR_GET_USERCFG_EX = 202;//��ȡ�û�����(SDK_V15��չ����)
        public const int NET_DVR_SET_USERCFG_EX = 203;//�����û�����(SDK_V15��չ����)
        public const int NET_DVR_GET_COMPRESSCFG_EX = 204;//��ȡѹ������(SDK_V15��չ����2006-05-15)
        public const int NET_DVR_SET_COMPRESSCFG_EX = 205;//����ѹ������(SDK_V15��չ����2006-05-15)

        public const int NET_DVR_GET_NETAPPCFG = 222;//��ȡ����Ӧ�ò��� NTP/DDNS/EMAIL
        public const int NET_DVR_SET_NETAPPCFG = 223;//��������Ӧ�ò��� NTP/DDNS/EMAIL
        public const int NET_DVR_GET_NTPCFG = 224;//��ȡ����Ӧ�ò��� NTP
        public const int NET_DVR_SET_NTPCFG = 225;//��������Ӧ�ò��� NTP
        public const int NET_DVR_GET_DDNSCFG = 226;//��ȡ����Ӧ�ò��� DDNS
        public const int NET_DVR_SET_DDNSCFG = 227;//��������Ӧ�ò��� DDNS
        //��ӦNET_DVR_EMAILPARA
        public const int NET_DVR_GET_EMAILCFG = 228;//��ȡ����Ӧ�ò��� EMAIL
        public const int NET_DVR_SET_EMAILCFG = 229;//��������Ӧ�ò��� EMAIL

        public const int NET_DVR_GET_NFSCFG = 230;/* NFS disk config */
        public const int NET_DVR_SET_NFSCFG = 231;/* NFS disk config */

        public const int NET_DVR_GET_SHOWSTRING_EX = 238;//��ȡ�����ַ�������չ(֧��8���ַ�)
        public const int NET_DVR_SET_SHOWSTRING_EX = 239;//���õ����ַ�������չ(֧��8���ַ�)
        public const int NET_DVR_GET_NETCFG_OTHER = 244;//��ȡ�������
        public const int NET_DVR_SET_NETCFG_OTHER = 245;//�����������

        //��ӦNET_DVR_EMAILCFG�ṹ
        public const int NET_DVR_GET_EMAILPARACFG = 250;//Get EMAIL parameters
        public const int NET_DVR_SET_EMAILPARACFG = 251;//Setup EMAIL parameters

        public const int NET_DVR_GET_DDNSCFG_EX = 274;//��ȡ��չDDNS����
        public const int NET_DVR_SET_DDNSCFG_EX = 275;//������չDDNS����

        public const int NET_DVR_SET_PTZPOS = 292;//��̨����PTZλ��
        public const int NET_DVR_GET_PTZPOS = 293;//��̨��ȡPTZλ��
        public const int NET_DVR_GET_PTZSCOPE = 294;//��̨��ȡPTZ��Χ

        public const int NET_DVR_GET_AP_INFO_LIST = 305;//��ȡ����������Դ����
        public const int NET_DVR_SET_WIFI_CFG = 306;//����IP����豸���߲���
        public const int NET_DVR_GET_WIFI_CFG = 307;//��ȡIP����豸���߲���
        public const int NET_DVR_SET_WIFI_WORKMODE = 308;//����IP����豸���ڹ���ģʽ����
        public const int NET_DVR_GET_WIFI_WORKMODE = 309;//��ȡIP����豸���ڹ���ģʽ���� 
        public const int NET_DVR_GET_WIFI_STATUS = 310;	//��ȡ�豸��ǰwifi����״̬
        /***************************DS9000��������(_V30) begin *****************************/
        //����(NET_DVR_NETCFG_V30�ṹ)
        public const int NET_DVR_GET_NETCFG_V30 = 1000;//��ȡ�������
        public const int NET_DVR_SET_NETCFG_V30 = 1001;//�����������

        //ͼ��(NET_DVR_PICCFG_V30�ṹ)
        public const int NET_DVR_GET_PICCFG_V30 = 1002;//��ȡͼ�����
        public const int NET_DVR_SET_PICCFG_V30 = 1003;//����ͼ�����

        //¼��ʱ��(NET_DVR_RECORD_V30�ṹ)
        public const int NET_DVR_GET_RECORDCFG_V30 = 1004;//��ȡ¼�����
        public const int NET_DVR_SET_RECORDCFG_V30 = 1005;//����¼�����

        //�û�(NET_DVR_USER_V30�ṹ)
        public const int NET_DVR_GET_USERCFG_V30 = 1006;//��ȡ�û�����
        public const int NET_DVR_SET_USERCFG_V30 = 1007;//�����û�����

        //9000DDNS��������(NET_DVR_DDNSPARA_V30�ṹ)
        public const int NET_DVR_GET_DDNSCFG_V30 = 1010;//��ȡDDNS(9000��չ)
        public const int NET_DVR_SET_DDNSCFG_V30 = 1011;//����DDNS(9000��չ)

        //EMAIL����(NET_DVR_EMAILCFG_V30�ṹ)
        public const int NET_DVR_GET_EMAILCFG_V30 = 1012;//��ȡEMAIL���� 
        public const int NET_DVR_SET_EMAILCFG_V30 = 1013;//����EMAIL���� 

        //Ѳ������ (NET_DVR_CRUISE_PARA�ṹ)
        public const int NET_DVR_GET_CRUISE = 1020;
        public const int NET_DVR_SET_CRUISE = 1021;

        //��������ṹ���� (NET_DVR_ALARMINCFG_V30�ṹ)
        public const int NET_DVR_GET_ALARMINCFG_V30 = 1024;
        public const int NET_DVR_SET_ALARMINCFG_V30 = 1025;

        //��������ṹ���� (NET_DVR_ALARMOUTCFG_V30�ṹ)
        public const int NET_DVR_GET_ALARMOUTCFG_V30 = 1026;
        public const int NET_DVR_SET_ALARMOUTCFG_V30 = 1027;

        //��Ƶ����ṹ���� (NET_DVR_VIDEOOUT_V30�ṹ)
        public const int NET_DVR_GET_VIDEOOUTCFG_V30 = 1028;
        public const int NET_DVR_SET_VIDEOOUTCFG_V30 = 1029;

        //�����ַ��ṹ���� (NET_DVR_SHOWSTRING_V30�ṹ)
        public const int NET_DVR_GET_SHOWSTRING_V30 = 1030;
        public const int NET_DVR_SET_SHOWSTRING_V30 = 1031;

        //�쳣�ṹ���� (NET_DVR_EXCEPTION_V30�ṹ)
        public const int NET_DVR_GET_EXCEPTIONCFG_V30 = 1034;
        public const int NET_DVR_SET_EXCEPTIONCFG_V30 = 1035;

        //����232�ṹ���� (NET_DVR_RS232CFG_V30�ṹ)
        public const int NET_DVR_GET_RS232CFG_V30 = 1036;
        public const int NET_DVR_SET_RS232CFG_V30 = 1037;

        //����Ӳ�̽���ṹ���� (NET_DVR_NET_DISKCFG�ṹ)
        public const int NET_DVR_GET_NET_DISKCFG = 1038;//����Ӳ�̽����ȡ
        public const int NET_DVR_SET_NET_DISKCFG = 1039;//����Ӳ�̽�������

        //ѹ������ (NET_DVR_COMPRESSIONCFG_V30�ṹ)
        public const int NET_DVR_GET_COMPRESSCFG_V30 = 1040;
        public const int NET_DVR_SET_COMPRESSCFG_V30 = 1041;

        //��ȡ485���������� (NET_DVR_DECODERCFG_V30�ṹ)
        public const int NET_DVR_GET_DECODERCFG_V30 = 1042;//��ȡ����������
        public const int NET_DVR_SET_DECODERCFG_V30 = 1043;//���ý���������

        //��ȡԤ������ (NET_DVR_PREVIEWCFG_V30�ṹ)
        public const int NET_DVR_GET_PREVIEWCFG_V30 = 1044;//��ȡԤ������
        public const int NET_DVR_SET_PREVIEWCFG_V30 = 1045;//����Ԥ������

        //����Ԥ������ (NET_DVR_PREVIEWCFG_AUX_V30�ṹ)
        public const int NET_DVR_GET_PREVIEWCFG_AUX_V30 = 1046;//��ȡ����Ԥ������
        public const int NET_DVR_SET_PREVIEWCFG_AUX_V30 = 1047;//���ø���Ԥ������

        //IP�������ò��� ��NET_DVR_IPPARACFG�ṹ��
        public const int NET_DVR_GET_IPPARACFG = 1048; //��ȡIP����������Ϣ 
        public const int NET_DVR_SET_IPPARACFG = 1049;//����IP����������Ϣ

        //IP�������ò��� ��NET_DVR_IPPARACFG_V40�ṹ��
        public const int NET_DVR_GET_IPPARACFG_V40 = 1062; //��ȡIP����������Ϣ 
        public const int NET_DVR_SET_IPPARACFG_V40 = 1063;//����IP����������Ϣ

        //IP��������������ò��� ��NET_DVR_IPALARMINCFG�ṹ��
        public const int NET_DVR_GET_IPALARMINCFG = 1050; //��ȡIP�����������������Ϣ 
        public const int NET_DVR_SET_IPALARMINCFG = 1051; //����IP�����������������Ϣ

        //IP��������������ò��� ��NET_DVR_IPALARMOUTCFG�ṹ��
        public const int NET_DVR_GET_IPALARMOUTCFG = 1052;//��ȡIP�����������������Ϣ 
        public const int NET_DVR_SET_IPALARMOUTCFG = 1053;//����IP�����������������Ϣ

        //Ӳ�̹���Ĳ�����ȡ (NET_DVR_HDCFG�ṹ)
        public const int NET_DVR_GET_HDCFG = 1054;//��ȡӲ�̹������ò���
        public const int NET_DVR_SET_HDCFG = 1055;//����Ӳ�̹������ò���

        //�������Ĳ�����ȡ (NET_DVR_HDGROUP_CFG�ṹ)
        public const int NET_DVR_GET_HDGROUP_CFG = 1056;//��ȡ����������ò���
        public const int NET_DVR_SET_HDGROUP_CFG = 1057;//��������������ò���

        //�豸������������(NET_DVR_COMPRESSION_AUDIO�ṹ)
        public const int NET_DVR_GET_COMPRESSCFG_AUD = 1058;//��ȡ�豸�����Խ��������
        public const int NET_DVR_SET_COMPRESSCFG_AUD = 1059;//�����豸�����Խ��������

        //IP�������ò��� ��NET_DVR_IPPARACFG_V31�ṹ��
        public const int NET_DVR_GET_IPPARACFG_V31 = 1060;//��ȡIP����������Ϣ 
        public const int NET_DVR_SET_IPPARACFG_V31 = 1061; //����IP����������Ϣ

        //�豸�������� ��NET_DVR_DEVICECFG_V40�ṹ��
        public const int NET_DVR_GET_DEVICECFG_V40 = 1100;//��ȡ�豸����
        public const int NET_DVR_SET_DEVICECFG_V40 = 1101;//�����豸����

        //����������(NET_DVR_NETCFG_MULTI�ṹ)
        public const int NET_DVR_GET_NETCFG_MULTI = 1161;
        public const int NET_DVR_SET_NETCFG_MULTI = 1162;

        //BONDING����(NET_DVR_NETWORK_BONDING�ṹ)
        public const int NET_DVR_GET_NETWORK_BONDING = 1254;
        public const int NET_DVR_SET_NETWORK_BONDING = 1255;

        //NATӳ�����ò��� ��NET_DVR_NAT_CFG�ṹ��
        public const int NET_DVR_GET_NAT_CFG = 6111;    //��ȡNATӳ�����
        public const int NET_DVR_SET_NAT_CFG = 6112;    //����NATӳ�����  
        /*************************������������ end*******************************/

        /************************DVR��־ begin***************************/
        /* ���� */
        //������
        public const int MAJOR_ALARM = 1;
        //������
        public const int MINOR_ALARM_IN = 1;/* �������� */
        public const int MINOR_ALARM_OUT = 2;/* ������� */
        public const int MINOR_MOTDET_START = 3; /* �ƶ���ⱨ����ʼ */
        public const int MINOR_MOTDET_STOP = 4; /* �ƶ���ⱨ������ */
        public const int MINOR_HIDE_ALARM_START = 5;/* �ڵ�������ʼ */
        public const int MINOR_HIDE_ALARM_STOP = 6;/* �ڵ��������� */
        public const int MINOR_VCA_ALARM_START = 7;/*���ܱ�����ʼ*/
        public const int MINOR_VCA_ALARM_STOP = 8;/*���ܱ���ֹͣ*/

        /* �쳣 */
        //������
        public const int MAJOR_EXCEPTION = 2;
        //������
        public const int MINOR_VI_LOST = 33;/* ��Ƶ�źŶ�ʧ */
        public const int MINOR_ILLEGAL_ACCESS = 34;/* �Ƿ����� */
        public const int MINOR_HD_FULL = 35;/* Ӳ���� */
        public const int MINOR_HD_ERROR = 36;/* Ӳ�̴��� */
        public const int MINOR_DCD_LOST = 37;/* MODEM ����(������ʹ��) */
        public const int MINOR_IP_CONFLICT = 38;/* IP��ַ��ͻ */
        public const int MINOR_NET_BROKEN = 39;/* ����Ͽ�*/
        public const int MINOR_REC_ERROR = 40;/* ¼����� */
        public const int MINOR_IPC_NO_LINK = 41;/* IPC�����쳣 */
        public const int MINOR_VI_EXCEPTION = 42;/* ��Ƶ�����쳣(ֻ���ģ��ͨ��) */
        public const int MINOR_IPC_IP_CONFLICT = 43;/*ipc ip ��ַ ��ͻ*/

        //��Ƶ�ۺ�ƽ̨
        public const int MINOR_FANABNORMAL = 49;/* ��Ƶ�ۺ�ƽ̨������״̬�쳣 */
        public const int MINOR_FANRESUME = 50;/* ��Ƶ�ۺ�ƽ̨������״̬�ָ����� */
        public const int MINOR_SUBSYSTEM_ABNORMALREBOOT = 51;/* ��Ƶ�ۺ�ƽ̨��6467�쳣���� */
        public const int MINOR_MATRIX_STARTBUZZER = 52;/* ��Ƶ�ۺ�ƽ̨��dm6467�쳣������������ */

        /* ���� */
        //������
        public const int MAJOR_OPERATION = 3;
        //������
        public const int MINOR_START_DVR = 65;/* ���� */
        public const int MINOR_STOP_DVR = 66;/* �ػ� */
        public const int MINOR_STOP_ABNORMAL = 67;/* �쳣�ػ� */
        public const int MINOR_REBOOT_DVR = 68;/*���������豸*/

        public const int MINOR_LOCAL_LOGIN = 80;/* ���ص�½ */
        public const int MINOR_LOCAL_LOGOUT = 81;/* ����ע����½ */
        public const int MINOR_LOCAL_CFG_PARM = 82;/* �������ò��� */
        public const int MINOR_LOCAL_PLAYBYFILE = 83;/* ���ذ��ļ��طŻ����� */
        public const int MINOR_LOCAL_PLAYBYTIME = 84;/* ���ذ�ʱ��طŻ�����*/
        public const int MINOR_LOCAL_START_REC = 85;/* ���ؿ�ʼ¼�� */
        public const int MINOR_LOCAL_STOP_REC = 86;/* ����ֹͣ¼�� */
        public const int MINOR_LOCAL_PTZCTRL = 87;/* ������̨���� */
        public const int MINOR_LOCAL_PREVIEW = 88;/* ����Ԥ�� (������ʹ��)*/
        public const int MINOR_LOCAL_MODIFY_TIME = 89;/* �����޸�ʱ��(������ʹ��) */
        public const int MINOR_LOCAL_UPGRADE = 90;/* �������� */
        public const int MINOR_LOCAL_RECFILE_OUTPUT = 91;/* ���ر���¼���ļ� */
        public const int MINOR_LOCAL_FORMAT_HDD = 92;/* ���س�ʼ��Ӳ�� */
        public const int MINOR_LOCAL_CFGFILE_OUTPUT = 93;/* �������������ļ� */
        public const int MINOR_LOCAL_CFGFILE_INPUT = 94;/* ���뱾�������ļ� */
        public const int MINOR_LOCAL_COPYFILE = 95;/* ���ر����ļ� */
        public const int MINOR_LOCAL_LOCKFILE = 96;/* ��������¼���ļ� */
        public const int MINOR_LOCAL_UNLOCKFILE = 97;/* ���ؽ���¼���ļ� */
        public const int MINOR_LOCAL_DVR_ALARM = 98;/* �����ֶ�����ʹ�������*/
        public const int MINOR_IPC_ADD = 99;/* �������IPC */
        public const int MINOR_IPC_DEL = 100;/* ����ɾ��IPC */
        public const int MINOR_IPC_SET = 101;/* ��������IPC */
        public const int MINOR_LOCAL_START_BACKUP = 102;/* ���ؿ�ʼ���� */
        public const int MINOR_LOCAL_STOP_BACKUP = 103;/* ����ֹͣ����*/
        public const int MINOR_LOCAL_COPYFILE_START_TIME = 104;/* ���ر��ݿ�ʼʱ��*/
        public const int MINOR_LOCAL_COPYFILE_END_TIME = 105;/* ���ر��ݽ���ʱ��*/
        public const int MINOR_LOCAL_ADD_NAS = 106;/*�����������Ӳ��*/
        public const int MINOR_LOCAL_DEL_NAS = 107;/* ����ɾ��nas��*/
        public const int MINOR_LOCAL_SET_NAS = 108;/* ��������nas��*/

        public const int MINOR_REMOTE_LOGIN = 112;/* Զ�̵�¼ */
        public const int MINOR_REMOTE_LOGOUT = 113;/* Զ��ע����½ */
        public const int MINOR_REMOTE_START_REC = 114;/* Զ�̿�ʼ¼�� */
        public const int MINOR_REMOTE_STOP_REC = 115;/* Զ��ֹͣ¼�� */
        public const int MINOR_START_TRANS_CHAN = 116;/* ��ʼ͸������ */
        public const int MINOR_STOP_TRANS_CHAN = 117;/* ֹͣ͸������ */
        public const int MINOR_REMOTE_GET_PARM = 118;/* Զ�̻�ȡ���� */
        public const int MINOR_REMOTE_CFG_PARM = 119;/* Զ�����ò��� */
        public const int MINOR_REMOTE_GET_STATUS = 120;/* Զ�̻�ȡ״̬ */
        public const int MINOR_REMOTE_ARM = 121;/* Զ�̲��� */
        public const int MINOR_REMOTE_DISARM = 122;/* Զ�̳��� */
        public const int MINOR_REMOTE_REBOOT = 123;/* Զ������ */
        public const int MINOR_START_VT = 124;/* ��ʼ�����Խ� */
        public const int MINOR_STOP_VT = 125;/* ֹͣ�����Խ� */
        public const int MINOR_REMOTE_UPGRADE = 126;/* Զ������ */
        public const int MINOR_REMOTE_PLAYBYFILE = 127;/* Զ�̰��ļ��ط� */
        public const int MINOR_REMOTE_PLAYBYTIME = 128;/* Զ�̰�ʱ��ط� */
        public const int MINOR_REMOTE_PTZCTRL = 129;/* Զ����̨���� */
        public const int MINOR_REMOTE_FORMAT_HDD = 130;/* Զ�̸�ʽ��Ӳ�� */
        public const int MINOR_REMOTE_STOP = 131;/* Զ�̹ػ� */
        public const int MINOR_REMOTE_LOCKFILE = 132;/* Զ�������ļ� */
        public const int MINOR_REMOTE_UNLOCKFILE = 133;/* Զ�̽����ļ� */
        public const int MINOR_REMOTE_CFGFILE_OUTPUT = 134;/* Զ�̵��������ļ� */
        public const int MINOR_REMOTE_CFGFILE_INTPUT = 135;/* Զ�̵��������ļ� */
        public const int MINOR_REMOTE_RECFILE_OUTPUT = 136;/* Զ�̵���¼���ļ� */
        public const int MINOR_REMOTE_DVR_ALARM = 137;/* Զ���ֶ�����ʹ�������*/
        public const int MINOR_REMOTE_IPC_ADD = 138;/* Զ�����IPC */
        public const int MINOR_REMOTE_IPC_DEL = 139;/* Զ��ɾ��IPC */
        public const int MINOR_REMOTE_IPC_SET = 140;/* Զ������IPC */
        public const int MINOR_REBOOT_VCA_LIB = 141;/*�������ܿ�*/
        public const int MINOR_REMOTE_ADD_NAS = 142;/* Զ�����nas��*/
        public const int MINOR_REMOTE_DEL_NAS = 143;/* Զ��ɾ��nas��*/
        public const int MINOR_REMOTE_SET_NAS = 144;/* Զ������nas��*/

        //2009-12-16 ������Ƶ�ۺ�ƽ̨��־����
        public const int MINOR_SUBSYSTEMREBOOT = 160;/*��Ƶ�ۺ�ƽ̨��dm6467 ��������*/
        public const int MINOR_MATRIX_STARTTRANSFERVIDEO = 161;	/*��Ƶ�ۺ�ƽ̨�������л���ʼ����ͼ��*/
        public const int MINOR_MATRIX_STOPTRANSFERVIDEO = 162;	/*��Ƶ�ۺ�ƽ̨�������л�ֹͣ����ͼ��*/
        public const int MINOR_REMOTE_SET_ALLSUBSYSTEM = 163;	/*��Ƶ�ۺ�ƽ̨����������6467��ϵͳ��Ϣ*/
        public const int MINOR_REMOTE_GET_ALLSUBSYSTEM = 164;	/*��Ƶ�ۺ�ƽ̨����ȡ����6467��ϵͳ��Ϣ*/
        public const int MINOR_REMOTE_SET_PLANARRAY = 165;	/*��Ƶ�ۺ�ƽ̨�����üƻ���ѯ��*/
        public const int MINOR_REMOTE_GET_PLANARRAY = 166;	/*��Ƶ�ۺ�ƽ̨����ȡ�ƻ���ѯ��*/
        public const int MINOR_MATRIX_STARTTRANSFERAUDIO = 167;	/*��Ƶ�ۺ�ƽ̨�������л���ʼ������Ƶ*/
        public const int MINOR_MATRIX_STOPRANSFERAUDIO = 168;	/*��Ƶ�ۺ�ƽ̨�������л�ֹͣ������Ƶ*/
        public const int MINOR_LOGON_CODESPITTER = 169;	/*��Ƶ�ۺ�ƽ̨����½�����*/
        public const int MINOR_LOGOFF_CODESPITTER = 170;	/*��Ƶ�ۺ�ƽ̨���˳������*/

        /*��־������Ϣ*/
        //������
        public const int MAJOR_INFORMATION = 4;/*������Ϣ*/
        //������
        public const int MINOR_HDD_INFO = 161;/*Ӳ����Ϣ*/
        public const int MINOR_SMART_INFO = 162;/*SMART��Ϣ*/
        public const int MINOR_REC_START = 163;/*��ʼ¼��*/
        public const int MINOR_REC_STOP = 164;/*ֹͣ¼��*/
        public const int MINOR_REC_OVERDUE = 165;/*����¼��ɾ��*/
        public const int MINOR_LINK_START = 166;//����ǰ���豸
        public const int MINOR_LINK_STOP = 167;//�Ͽ�ǰ���豸��
        public const int MINOR_NET_DISK_INFO = 168;//����Ӳ����Ϣ

        //����־��������ΪMAJOR_OPERATION=03��������ΪMINOR_LOCAL_CFG_PARM=0x52����MINOR_REMOTE_GET_PARM=0x76����MINOR_REMOTE_CFG_PARM=0x77ʱ��dwParaType:����������Ч���京�����£�
        public const int PARA_VIDEOOUT = 1;
        public const int PARA_IMAGE = 2;
        public const int PARA_ENCODE = 4;
        public const int PARA_NETWORK = 8;
        public const int PARA_ALARM = 16;
        public const int PARA_EXCEPTION = 32;
        public const int PARA_DECODER = 64;/*������*/
        public const int PARA_RS232 = 128;
        public const int PARA_PREVIEW = 256;
        public const int PARA_SECURITY = 512;
        public const int PARA_DATETIME = 1024;
        public const int PARA_FRAMETYPE = 2048;/*֡��ʽ*/
        //vca
        public const int PARA_VCA_RULE = 4096;//��Ϊ����
        /************************DVR��־ End***************************/


        /*******************�����ļ�����־��������ֵ*************************/
        public const int NET_DVR_FILE_SUCCESS = 1000;//����ļ���Ϣ
        public const int NET_DVR_FILE_NOFIND = 1001;//û���ļ�
        public const int NET_DVR_ISFINDING = 1002;//���ڲ����ļ�
        public const int NET_DVR_NOMOREFILE = 1003;//�����ļ�ʱû�и�����ļ�
        public const int NET_DVR_FILE_EXCEPTION = 1004;//�����ļ�ʱ�쳣

        /*********************�ص��������� begin************************/
        public const int COMM_ALARM = 0x1100;//8000������Ϣ�����ϴ�����ӦNET_DVR_ALARMINFO
        public const int COMM_ALARM_RULE = 0x1102;//��Ϊ����������Ϣ����ӦNET_VCA_RULE_ALARM
        public const int COMM_ALARM_PDC = 0x1103;//������ͳ�Ʊ����ϴ�����ӦNET_DVR_PDC_ALRAM_INFO
        public const int COMM_ALARM_ALARMHOST = 0x1105;//���籨�����������ϴ�����ӦNET_DVR_ALARMHOST_ALARMINFO
        public const int COMM_ALARM_FACE = 0x1106;//�������ʶ�𱨾���Ϣ����ӦNET_DVR_FACEDETECT_ALARM
        public const int COMM_RULE_INFO_UPLOAD = 0x1107;  // �¼�������Ϣ�ϴ�
        public const int COMM_ALARM_AID = 0x1110;  //��ͨ�¼�������Ϣ
        public const int COMM_ALARM_TPS = 0x1111;  //��ͨ����ͳ�Ʊ�����Ϣ
        public const int COMM_UPLOAD_FACESNAP_RESULT = 0x1112;  //����ʶ�����ϴ�
        public const int COMM_ALARM_TFS = 0x1113;  //��ͨȡ֤������Ϣ
        public const int COMM_ALARM_TPS_V41 = 0x1114;  //��ͨ����ͳ�Ʊ�����Ϣ��չ
        public const int COMM_ALARM_AID_V41 = 0x1115;  //��ͨ�¼�������Ϣ��չ
        public const int COMM_ALARM_VQD_EX =  0x1116;	 //��Ƶ������ϱ���
        public const int COMM_SENSOR_VALUE_UPLOAD = 0x1120;  //ģ��������ʵʱ�ϴ�
        public const int COMM_SENSOR_ALARM  = 0x1121;  //ģ���������ϴ�
        public const int COMM_SWITCH_ALARM   = 0x1122;	 //����������
        public const int COMM_ALARMHOST_EXCEPTION   =  0x1123; //�����������ϱ���
        public const int COMM_ALARMHOST_OPERATEEVENT_ALARM  = 0x1124;  //�����¼������ϴ�
        public const int COMM_ALARMHOST_SAFETYCABINSTATE = 0x1125;	 //������״̬
        public const int COMM_ALARMHOST_ALARMOUTSTATUS  = 0x1126;	 //���������/����״̬
        public const int COMM_ALARMHOST_CID_ALARM 	 = 0x1127;	 //���汨���ϴ�
        public const int COMM_ALARMHOST_EXTERNAL_DEVICE_ALARM = 0x1128;	 //������������豸�����ϴ�
        public const int COMM_ALARMHOST_DATA_UPLOAD    = 0x1129;	 //���������ϴ�
        public const int COMM_ALARM_AUDIOEXCEPTION	 =  0x1150;	 //����������Ϣ
        public const int COMM_ALARM_DEFOCUS    =      0x1151;	 //�齹������Ϣ
        public const int COMM_ALARM_BUTTON_DOWN_EXCEPTION =  0x1152;	 //��ť���±�����Ϣ
        public const int COMM_ALARM_ALARMGPS   =    0x1202; //GPS������Ϣ�ϴ�
        public const int COMM_TRADEINFO      =  0x1500;  //ATMDVR�����ϴ�������Ϣ
        public const int COMM_UPLOAD_PLATE_RESULT  =   0x2800;	 //�ϴ�������Ϣ
        public const int COMM_ITC_STATUS_DETECT_RESULT  = 0x2810;  //ʵʱ״̬������ϴ�(���ܸ���IPC)
        public const int COMM_IPC_AUXALARM_RESULT  = 0x2820;  //PIR���������߱��������ȱ����ϴ�
        public const int COMM_UPLOAD_PICTUREINFO    = 0x2900;	 //�ϴ�ͼƬ��Ϣ
        public const int COMM_SNAP_MATCH_ALARM   = 0x2902;  //�������ȶԽ���ϴ�
        public const int COMM_ITS_PLATE_RESULT   =  0x3050;  //�ն�ͼƬ�ϴ�
        public const int COMM_ITS_TRAFFIC_COLLECT  = 0x3051;  //�ն�ͳ�������ϴ�
        public const int COMM_ITS_GATE_VEHICLE = 0x3052;  //����ڳ���ץ�������ϴ�
        public const int COMM_ITS_GATE_FACE  = 0x3053 ; //���������ץ�������ϴ�
        public const int COMM_ITS_GATE_COSTITEM = 0x3054;  //����ڹ����շ���ϸ 2013-11-19
        public const int COMM_ITS_GATE_HANDOVER = 0x3055 ; //����ڽ��Ӱ����� 2013-11-19
        public const int COMM_ITS_PARK_VEHICLE  = 0x3056;  //ͣ���������ϴ�
        public const int COMM_ITS_BLACKLIST_ALARM  = 0x3057;  //�����������ϴ�
        public const int COMM_ALARM_V30	 =  0x4000;	 //9000������Ϣ�����ϴ�
        public const int COMM_IPCCFG	 =  0x4001;	 //9000�豸IPC�������øı䱨����Ϣ�����ϴ�
        public const int COMM_IPCCFG_V31 = 0x4002;	 //9000�豸IPC�������øı䱨����Ϣ�����ϴ���չ 9000_1.1
        public const int COMM_IPCCFG_V40 =  0x4003; // IVMS 2000 ��������� NVR IPC�������øı�ʱ������Ϣ�ϴ�
        public const int COMM_ALARM_DEVICE = 0x4004;  //�豸�������ݣ�����ͨ��ֵ����256����չ
        public const int COMM_ALARM_CVR	 =  0x4005;  //CVR 2.0.X�ⲿ��������
        public const int COMM_ALARM_HOT_SPARE = 0x4006;  //�ȱ��쳣������N+1ģʽ�쳣������
        public const int COMM_ALARM_V40 = 0x4007;	//�ƶ���⣬��Ƶ��ʧ���ڵ���IO�ź����ȱ�����Ϣ�����ϴ�����������Ϊ�ɱ䳤

        public const int COMM_ITS_ROAD_EXCEPTION = 0x4500;	 //·���豸�쳣����
        public const int COMM_ITS_EXTERNAL_CONTROL_ALARM = 0x4520;  //��ر���
        public const int COMM_SCREEN_ALARM    =  0x5000;  //������������������
        public const int COMM_DVCS_STATE_ALARM = 0x5001;  //�ֲ�ʽ���������������ϴ�
        public const int COMM_ALARM_VQD		 = 0x6000;  //VQD���������ϴ� 
        public const int COMM_PUSH_UPDATE_RECORD_INFO  = 0x6001;  //��ģʽ¼����Ϣ�ϴ�
        public const int COMM_DIAGNOSIS_UPLOAD = 0x5100;  //��Ϸ�����VQD�����ϴ�

        /*************�����쳣����(��Ϣ��ʽ, �ص���ʽ(����))****************/
        public const int EXCEPTION_EXCHANGE = 32768;//�û�����ʱ�쳣
        public const int EXCEPTION_AUDIOEXCHANGE = 32769;//�����Խ��쳣
        public const int EXCEPTION_ALARM = 32770;//�����쳣
        public const int EXCEPTION_PREVIEW = 32771;//����Ԥ���쳣
        public const int EXCEPTION_SERIAL = 32772;//͸��ͨ���쳣
        public const int EXCEPTION_RECONNECT = 32773;//Ԥ��ʱ����
        public const int EXCEPTION_ALARMRECONNECT = 32774;//����ʱ����
        public const int EXCEPTION_SERIALRECONNECT = 32775;//͸��ͨ������
        public const int EXCEPTION_PLAYBACK = 32784;//�ط��쳣
        public const int EXCEPTION_DISKFMT = 32785;//Ӳ�̸�ʽ��

        /********************Ԥ���ص�����*********************/
        public const int NET_DVR_SYSHEAD = 1;//ϵͳͷ����
        public const int NET_DVR_STREAMDATA = 2;//��Ƶ�����ݣ�����������������Ƶ�ֿ�����Ƶ�����ݣ�
        public const int NET_DVR_AUDIOSTREAMDATA = 3;//��Ƶ������
        public const int NET_DVR_STD_VIDEODATA = 4;//��׼��Ƶ������
        public const int NET_DVR_STD_AUDIODATA = 5;//��׼��Ƶ������

        //�ص�Ԥ���е�״̬����Ϣ
        public const int NET_DVR_REALPLAYEXCEPTION = 111;//Ԥ���쳣
        public const int NET_DVR_REALPLAYNETCLOSE = 112;//Ԥ��ʱ���ӶϿ�
        public const int NET_DVR_REALPLAY5SNODATA = 113;//Ԥ��5sû���յ�����
        public const int NET_DVR_REALPLAYRECONNECT = 114;//Ԥ������

        /********************�طŻص�����*********************/
        public const int NET_DVR_PLAYBACKOVER = 101;//�ط����ݲ������
        public const int NET_DVR_PLAYBACKEXCEPTION = 102;//�ط��쳣
        public const int NET_DVR_PLAYBACKNETCLOSE = 103;//�ط�ʱ�����ӶϿ�
        public const int NET_DVR_PLAYBACK5SNODATA = 104;//�ط�5sû���յ�����

        /*********************�ص��������� end************************/
        //�豸�ͺ�(DVR����)
        /* �豸���� */
        public const int DVR = 1;/*����δ�����dvr���ͷ���NETRET_DVR*/
        public const int ATMDVR = 2;/*atm dvr*/
        public const int DVS = 3;/*DVS*/
        public const int DEC = 4;/* 6001D */
        public const int ENC_DEC = 5;/* 6001F */
        public const int DVR_HC = 6;/*8000HC*/
        public const int DVR_HT = 7;/*8000HT*/
        public const int DVR_HF = 8;/*8000HF*/
        public const int DVR_HS = 9;/* 8000HS DVR(no audio) */
        public const int DVR_HTS = 10; /* 8016HTS DVR(no audio) */
        public const int DVR_HB = 11; /* HB DVR(SATA HD) */
        public const int DVR_HCS = 12; /* 8000HCS DVR */
        public const int DVS_A = 13; /* ��ATAӲ�̵�DVS */
        public const int DVR_HC_S = 14; /* 8000HC-S */
        public const int DVR_HT_S = 15;/* 8000HT-S */
        public const int DVR_HF_S = 16;/* 8000HF-S */
        public const int DVR_HS_S = 17; /* 8000HS-S */
        public const int ATMDVR_S = 18;/* ATM-S */
        public const int LOWCOST_DVR = 19;/*7000Hϵ��*/
        public const int DEC_MAT = 20; /*��·������*/
        public const int DVR_MOBILE = 21;/* mobile DVR */
        public const int DVR_HD_S = 22;   /* 8000HD-S */
        public const int DVR_HD_SL = 23;/* 8000HD-SL */
        public const int DVR_HC_SL = 24;/* 8000HC-SL */
        public const int DVR_HS_ST = 25;/* 8000HS_ST */
        public const int DVS_HW = 26; /* 6000HW */
        public const int DS630X_D = 27; /* ��·������ */
        public const int IPCAM = 30;/*IP �����*/
        public const int MEGA_IPCAM = 31;/*X52MFϵ��,752MF,852MF*/
        public const int IPCAM_X62MF = 32;/*X62MFϵ�пɽ���9000�豸,762MF,862MF*/
        public const int IPDOME = 40; /*IP �������*/
        public const int IPDOME_MEGA200 = 41;/*IP 200��������*/
        public const int IPDOME_MEGA130 = 42;/*IP 130��������*/
        public const int IPMOD = 50;/*IP ģ��*/
        public const int DS71XX_H = 71;/* DS71XXH_S */
        public const int DS72XX_H_S = 72;/* DS72XXH_S */
        public const int DS73XX_H_S = 73;/* DS73XXH_S */
        public const int DS76XX_H_S = 76;/* DS76XX_H_S */
        public const int DS81XX_HS_S = 81;/* DS81XX_HS_S */
        public const int DS81XX_HL_S = 82;/* DS81XX_HL_S */
        public const int DS81XX_HC_S = 83;/* DS81XX_HC_S */
        public const int DS81XX_HD_S = 84;/* DS81XX_HD_S */
        public const int DS81XX_HE_S = 85;/* DS81XX_HE_S */
        public const int DS81XX_HF_S = 86;/* DS81XX_HF_S */
        public const int DS81XX_AH_S = 87;/* DS81XX_AH_S */
        public const int DS81XX_AHF_S = 88;/* DS81XX_AHF_S */
        public const int DS90XX_HF_S = 90;  /*DS90XX_HF_S*/
        public const int DS91XX_HF_S = 91;  /*DS91XX_HF_S*/
        public const int DS91XX_HD_S = 92; /*91XXHD-S(MD)*/
        /**********************�豸���� end***********************/

        /*************************************************
        �������ýṹ������(����_V30Ϊ9000����)
        **************************************************/
        //Уʱ�ṹ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME
        {
            public uint dwYear;
            public uint dwMonth;
            public uint dwDay;
            public uint dwHour;
            public uint dwMinute;
            public uint dwSecond;
        }

        //ʱ�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_V30
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
            public ushort wMilliSec;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_EX
        {
            public ushort wYear;
            public byte byMonth;
            public byte byDay;
            public byte byHour;
            public byte byMinute;
            public byte bySecond;
            public byte byRes;
        }

        //ʱ���(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHEDTIME
        {
            public byte byStartHour;//��ʼʱ��
            public byte byStartMin;//��ʼʱ��
            public byte byStopHour;//����ʱ��
            public byte byStopMin;//����ʱ��
        }

        /*�豸�������쳣����ʽ*/
        public const int NOACTION = 0x0;/*����Ӧ*/
        public const int WARNONMONITOR = 0x1;/*�������Ͼ���*/
        public const int WARNONAUDIOOUT = 0x2;/*��������*/
        public const int UPTOCENTER = 0x4;/*�ϴ�����*/
        public const int TRIGGERALARMOUT = 0x8;/*�����������*/
        public const int TRIGGERCATPIC = 0x10;/*����ץͼ���ϴ�E-mail*/
        public const int SEND_PIC_FTP = 0x200;  /*ץͼ���ϴ�ftp*/        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STRUCTHEAD
        {
            public ushort wLength;  //�ṹ����
            public byte byVersion;	/*�ߵ�4λ�ֱ����ߵͰ汾���������ݰ汾�ͳ��Ƚ�����չ����ͬ�İ汾�ĳ��Ƚ�������*/
            public byte byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V41
        {
            public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
            /*0x00: ����Ӧ*/
            /*0x01: �������Ͼ���*/
            /*0x02: ��������*/
            /*0x04: �ϴ�����*/
            /*0x08: �����������*/
            /*0x10: ����JPRGץͼ���ϴ�Email*/
            /*0x20: �������ⱨ��������*/
            /*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
            /*0x200: ץͼ���ϴ�FTP*/ 
            public uint dwMaxRelAlarmOutChanNum; //�����ı������ͨ������ֻ�������֧����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //��������ͨ��      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V40
        {
            public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
            /*0x00: ����Ӧ*/
            /*0x01: �������Ͼ���*/
            /*0x02: ��������*/
            /*0x04: �ϴ�����*/
            /*0x08: �����������*/
            /*0x10: ����JPRGץͼ���ϴ�Email*/
            /*0x20: �������ⱨ��������*/
            /*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
            /*0x200: ץͼ���ϴ�FTP*/ 
            public uint dwMaxRelAlarmOutChanNum; //�����ı������ͨ������ֻ�������֧����
            public uint dwRelAlarmOutChanNum; //�����ı������ͨ���� ʵ��֧����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //��������ͨ��      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //����
        }

        //�������쳣����ṹ(�ӽṹ)(�ദʹ��)(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION_V30
        {
            public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
            /*0x00: ����Ӧ*/
            /*0x01: �������Ͼ���*/
            /*0x02: ��������*/
            /*0x04: �ϴ�����*/
            /*0x08: �����������*/
            /*0x10: ����JPRGץͼ���ϴ�Email*/
            /*0x20: �������ⱨ��������*/
            /*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
            /*0x200: ץͼ���ϴ�FTP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//�������������ͨ��,�������������,Ϊ1��ʾ���������
        }

        //�������쳣����ṹ(�ӽṹ)(�ദʹ��)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HANDLEEXCEPTION
        {
            public uint dwHandleType;/*����ʽ,����ʽ��"��"���*/
            /*0x00: ����Ӧ*/
            /*0x01: �������Ͼ���*/
            /*0x02: ��������*/
            /*0x04: �ϴ�����*/
            /*0x08: �����������*/
            /*0x10: Jpegץͼ���ϴ�EMail*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelAlarmOut;//�������������ͨ��,�������������,Ϊ1��ʾ���������
        }

        //DVR�豸����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;//DVR����
            public uint dwDVRID;//DVR ID,����ң���� //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;//�Ƿ�ѭ��¼��,0:����; 1:��
            //���²��ɸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//���к�
            public uint dwSoftwareVersion;//����汾��,��16λ�����汾,��16λ�Ǵΰ汾
            public uint dwSoftwareBuildDate;//�����������,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;//DSP����汾,��16λ�����汾,��16λ�Ǵΰ汾
            public uint dwDSPSoftwareBuildDate;// DSP�����������,0xYYYYMMDD
            public uint dwPanelVersion;// ǰ���汾,��16λ�����汾,��16λ�Ǵΰ汾
            public uint dwHardwareVersion;// Ӳ���汾,��16λ�����汾,��16λ�Ǵΰ汾
            public byte byAlarmInPortNum;//DVR�����������
            public byte byAlarmOutPortNum;//DVR�����������
            public byte byRS232Num;//DVR 232���ڸ���
            public byte byRS485Num;//DVR 485���ڸ���
            public byte byNetworkPortNum;//����ڸ���
            public byte byDiskCtrlNum;//DVR Ӳ�̿���������
            public byte byDiskNum;//DVR Ӳ�̸���
            public byte byDVRType;//DVR����, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR ͨ������
            public byte byStartChan;//��ʼͨ����,����DVS-1,DVR - 1
            public byte byDecordChans;//DVR ����·��
            public byte byVGANum;//VGA�ڵĸ���
            public byte byUSBNum;//USB�ڵĸ���
            public byte byAuxoutNum;//���ڵĸ���
            public byte byAudioNum;//�����ڵĸ���
            public byte byIPChanNum;//�������ͨ����
        }

        /*IP��ַ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IPADDR
        {

            /// char[16]
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpV4;

            /// BYTE[128]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes = new byte[128];
            }
        }

        /*�������ݽṹ(�ӽṹ)(9000��չ)*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_V30
        {
            public NET_DVR_IPADDR struDVRIP;//DVR IP��ַ
            public NET_DVR_IPADDR struDVRIPMask;//DVR IP��ַ����
            public uint dwNetInterface;//����ӿڣ�1-10MBase-T��2-10MBase-Tȫ˫����3-100MBase-TX��4-100Mȫ˫����5-10M/100M/1000M����Ӧ��6-1000Mȫ˫��
            public ushort wDVRPort;//�˿ں�
            public ushort wMTU;//����MTU���ã�Ĭ��1500��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;// �����ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*�������ݽṹ(�ӽṹ)*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;//DVR IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIPMask;//DVR IP��ַ����
            public uint dwNetInterface;//����ӿ� 1-10MBase-T 2-10MBase-Tȫ˫�� 3-100MBase-TX 4-100Mȫ˫�� 5-10M/100M����Ӧ
            public ushort wDVRPort;//�˿ں�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;//�������������ַ
        }

        //pppoe�ṹ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPOECFG
        {
            public uint dwPPPOE;//0-������,1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoE�û���
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoE����
            public NET_DVR_IPADDR struPPPoEIP;//PPPoE IP��ַ
        }

        //�������ýṹ(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_V30[] struEtherNet;//��̫����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struRes1;/*����*/
            public NET_DVR_IPADDR struAlarmHostIpAddr;/* ��������IP��ַ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public ushort wAlarmHostIpPort;
            public byte byUseDhcp;
            public byte byRes3;
            public NET_DVR_IPADDR struDnsServer1IpAddr;/* ����������1��IP��ַ */
            public NET_DVR_IPADDR struDnsServer2IpAddr;/* ����������2��IP��ַ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wHttpPortNo;
            public NET_DVR_IPADDR struMulticastIpAddr;/* �ಥ���ַ */
            public NET_DVR_IPADDR struGatewayIpAddr;/* ���ص�ַ */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��������������Ϣ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ETHERNET_MULTI
        {
            public NET_DVR_IPADDR struDVRIP;
            public NET_DVR_IPADDR struDVRIPMask;
            public uint dwNetInterface;
            public byte byCardType;  //�������ͣ�0-��ͨ������1-����������2-��������
            public byte byRes1;
            public ushort wMTU;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public byte byUseDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_IPADDR struGatewayIpAddr;
            public NET_DVR_IPADDR struDnsServer1IpAddr;
            public NET_DVR_IPADDR struDnsServer2IpAddr;
        }

        //�������������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NETCFG_MULTI
        {
            public uint dwSize;
            public byte byDefaultRoute;
            public byte byNetworkCardNum;
            public byte byWorkMode;   //0-��ͨ������ģʽ��1-����������ģʽ
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET_MULTI[] struEtherNet;//��̫����
            public NET_DVR_IPADDR struManageHost1IpAddr;
            public NET_DVR_IPADDR struManageHost2IpAddr;
            public NET_DVR_IPADDR struAlarmHostIpAddr;
            public ushort wManageHost1Port;
            public ushort wManageHost2Port;
            public ushort wAlarmHostIpPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byIpResolver;
            public ushort wIpResolverPort;
            public ushort wDvrPort;
            public ushort wHttpPortNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struMulticastIpAddr;/* �ಥ���ַ */
            public NET_DVR_PPPOECFG struPPPoE;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //�������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ETHERNET, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ETHERNET[] struEtherNet;/* ��̫���� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sManageHostIP;//Զ�̹���������ַ
            public ushort wManageHostPort;//Զ�̹��������˿ں�
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIPServerIP;//IPServer��������ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sMultiCastIP;//�ಥ���ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIP;//���ص�ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNFSIP;//NFS����IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNFSDirectory;//NFSĿ¼
            public uint dwPPPOE;//0-������,1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPPPoEUser;//PPPoE�û���
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sPPPoEPassword;// PPPoE����
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sPPPoEIP;//PPPoE IP��ַ(ֻ��)
            public ushort wHttpPort;//HTTP�˿ں�
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SIP_CFG
        {
            public uint dwSize;
            public byte byEnableAutoLogin;    //ʹ���Զ�ע�ᣬ0-��ʹ�ܣ�1-ʹ��
            public byte byLoginStatus;  //ע��״̬��0-δע�ᣬ1-��ע�ᣬ�˲���ֻ�ܻ�ȡ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR stuServerIP;  //SIP������IP
            public ushort wServerPort;    //SIP�������˿�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;  //ע���û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord; //ע������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispalyName; //�豸��ʾ����
            public ushort wLocalPort;     //���ض˿�
            public byte byLoginCycle;   //ע�����ڣ�1-99����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 129, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IP���ӶԽ��ֻ�����
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_DEVCFG
        {
            public uint dwSize;
            public byte byDefaultRing; //Ĭ����������Χ1-6
            public byte byRingVolume;  //������������Χ0-9
            public byte byInputVolume; //��������ֵ����Χ0-6
            public byte byOutputVolume; //�������ֵ����Χ0-9	
            public ushort wRtpPort;  //Rtp�˿�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPreviewDelayTime; //Ԥ����ʱ���ã�0-30��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        //Ip���ӶԽ���Ƶ��ز�������
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_AUDIO_CFG
        {
            public uint dwSize;	
            public byte byAudioEncPri1; //��Ƶ�������ȼ�1��0-OggVorbis��1-G711_U��2-G711_A�� 5-MPEG2,6-G726��7-AAC
            public byte byAudioEncPri2; //��Ƶ�������ȼ�2����sip��������֧����Ƶ����1ʱ��ʹ����Ƶ����2��0-OggVorbis��1-G711_U��2-G711_A�� 5-MPEG2,6-G726��7-AAC
            public ushort wAudioPacketLen1; //��Ƶ����1���ݰ�����
            public ushort wAudioPacketLen2; //��Ƶ����2���ݰ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        //IP�ֻ����жԽ��������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_IP_VIEW_CALL_CFG
        {
            public uint dwSize ;
            public byte byEnableAutoResponse; //ʹ���Զ�Ӧ��,0-��ʹ�ܣ�1-ʹ��
            public byte byAudoResponseTime; //�Զ�Ӧ��ʱ�䣬0-30��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byEnableAlarmNumber1; //������������1��0-��������1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber1; //���к���1
            public byte byEnableAlarmNumber2; //������������2��0-��������1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NUMBER_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmNumber2; //���к���2�����к���1ʧ�᳢ܻ�Ժ��к���2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }
        
        //ͨ��ͼ��ṹ
        //�ƶ����(�ӽṹ)(���鷽ʽ��չ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDCHAN
        {    
            public uint dwMaxRecordChanNum;   //�豸֧�ֵ�������¼��ͨ����-ֻ��
            public uint dwCurRecordChanNum;   //��ǰʵ�������õĹ���¼��ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint dwRelRecordChan;	 /* ʵ�ʴ���¼��ͨ������ֵ��ʾ,���ý��������У����±�0 - MAX_CHANNUM_V30-1��Ч������м�����0xffffffff,�������Ч*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //����
        }             

        //ͨ��ͼ��ṹ
        //�ƶ����(�ӽṹ)(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOTION_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 96*64, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*�������,0-96λ,��ʾ64��,����96*64��С���,Ϊ1��ʾ���ƶ��������,0-��ʾ����*/
            public byte byMotionSensitive;/*�ƶ����������, 0 - 5,Խ��Խ����,oxff�ر�*/
            public byte byEnableHandleMotion;/* �Ƿ����ƶ���� 0���� 1����*/
            public byte byEnableDisplay;/* �����ƶ���������ʾ��0- ��1- �� */
            public byte reservedData;
            public NET_DVR_HANDLEEXCEPTION_V30 struMotionHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;/*����ʱ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;/* ����������¼��ͨ��*/
        }

        //�ƶ����(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MOTION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 396, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope;/*�������,����22*18��С���,Ϊ1��ʾ�ĺ�����ƶ��������,0-��ʾ����*/
            public byte byMotionSensitive;/*�ƶ����������, 0 - 5,Խ��Խ����,0xff�ر�*/
            public byte byEnableHandleMotion;/* �Ƿ����ƶ���� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 2)]
            public string reservedData;
            public NET_DVR_HANDLEEXCEPTION strMotionHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
        }

        //�ڵ�����(�ӽṹ)(9000��չ)  �����С704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM_V30
        {
            public uint dwEnableHideAlarm;/* �Ƿ������ڵ����� ,0-��,1-�������� 2-�������� 3-��������*/
            public ushort wHideAlarmAreaTopLeftX;/* �ڵ������x���� */
            public ushort wHideAlarmAreaTopLeftY;/* �ڵ������y���� */
            public ushort wHideAlarmAreaWidth;/* �ڵ�����Ŀ� */
            public ushort wHideAlarmAreaHeight;/*�ڵ�����ĸ�*/
            public NET_DVR_HANDLEEXCEPTION_V30 strHideAlarmHandleType;	/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
        }

        //�ڵ�����(�ӽṹ)  �����С704*576
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HIDEALARM
        {
            public uint dwEnableHideAlarm;/* �Ƿ������ڵ����� ,0-��,1-�������� 2-�������� 3-��������*/
            public ushort wHideAlarmAreaTopLeftX;/* �ڵ������x���� */
            public ushort wHideAlarmAreaTopLeftY;/* �ڵ������y���� */
            public ushort wHideAlarmAreaWidth;/* �ڵ�����Ŀ� */
            public ushort wHideAlarmAreaHeight;/*�ڵ�����ĸ�*/
            public NET_DVR_HANDLEEXCEPTION strHideAlarmHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
        }

        //�źŶ�ʧ����(�ӽṹ)(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST_V30
        {
            public byte byEnableHandleVILost;/* �Ƿ����źŶ�ʧ���� */
            public NET_DVR_HANDLEEXCEPTION_V30 strVILostHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
        }

        //�źŶ�ʧ����(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VILOST
        {
            public byte byEnableHandleVILost;/* �Ƿ����źŶ�ʧ���� */
            public NET_DVR_HANDLEEXCEPTION strVILostHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
        }

        //�ڵ�����(�ӽṹ)
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct NET_DVR_SHELTER
        {
            public ushort wHideAreaTopLeftX;/* �ڵ������x���� */
            public ushort wHideAreaTopLeftY;/* �ڵ������y���� */
            public ushort wHideAreaWidth;/* �ڵ�����Ŀ� */
            public ushort wHideAreaHeight;/*�ڵ�����ĸ�*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COLOR
        {
            public byte byBrightness;/*����,0-255*/
            public byte byContrast;/*�Աȶ�,0-255*/
            public byte bySaturation;/*���Ͷ�,0-255*/
            public byte byHue;/*ɫ��,0-255*/
        }

        //ͨ��ͼ��ṹ(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PICCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byReservedData;/*����*/
            //��ʾͨ����
            public uint dwShowChanName;// Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ �����С704*576
            public ushort wShowNameTopLeftX;/* ͨ��������ʾλ�õ�x���� */
            public ushort wShowNameTopLeftY;/* ͨ��������ʾλ�õ�y���� */
            //��Ƶ�źŶ�ʧ����
            public NET_DVR_VILOST_V30 struVILost;
            public NET_DVR_VILOST_V30 struRes;/*����*/
            //�ƶ����
            public NET_DVR_MOTION_V30 struMotion;
            //�ڵ�����
            public NET_DVR_HIDEALARM_V30 struHideAlarm;
            //�ڵ�  �����С704*576
            public uint dwEnableHide;/* �Ƿ������ڵ� ,0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ �����С704*576
            public ushort wOSDTopLeftX;/* OSD��x���� */
            public ushort wOSDTopLeftY;/* OSD��y���� */
            public byte byOSDType;/* OSD����(��Ҫ�������ո�ʽ) */
            /* 0: XXXX-XX-XX ������ */
            /* 1: XX-XX-XXXX ������ */
            /* 2: XXXX��XX��XX�� */
            /* 3: XX��XX��XXXX�� */
            /* 4: XX-XX-XXXX ������*/
            /* 5: XX��XX��XXXX�� */
            public byte byDispWeek;/* �Ƿ���ʾ���� */
            public byte byOSDAttrib;/* OSD����:͸������˸ */
            /* 0: ����ʾOSD */
            /* 1: ͸��,��˸ */
            /* 2: ͸��,����˸ */
            /* 3: ��˸,��͸�� */
            /* 4: ��͸��,����˸ */
            public byte byHourOSDType;/* OSDСʱ��:0-24Сʱ��,1-12Сʱ�� */
            public byte byFontSize;//�����С��16*16(��)/8*16(Ӣ)��1-32*32(��)/16*32(Ӣ)��2-64*64(��)/32*64(Ӣ)  3-48*48(��)/24*48(Ӣ) 0xff-����Ӧ(adaptive)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ͨ��ͼ��ṹSDK_V14��չ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL*/
            public byte byBrightness;/*����,0-255*/
            public byte byContrast;/*�Աȶ�,0-255*/
            public byte bySaturation;/*���Ͷ�,0-255 */
            public byte byHue;/*ɫ��,0-255*/
            //��ʾͨ����
            public uint dwShowChanName;// Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ �����С704*576
            public ushort wShowNameTopLeftX;/* ͨ��������ʾλ�õ�x���� */
            public ushort wShowNameTopLeftY;/* ͨ��������ʾλ�õ�y���� */
            //�źŶ�ʧ����
            public NET_DVR_VILOST struVILost;
            //�ƶ����
            public NET_DVR_MOTION struMotion;
            //�ڵ�����
            public NET_DVR_HIDEALARM struHideAlarm;
            //�ڵ�  �����С704*576
            public uint dwEnableHide;/* �Ƿ������ڵ� ,0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SHELTERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHELTER[] struShelter;
            //OSD
            public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ �����С704*576
            public ushort wOSDTopLeftX;/* OSD��x���� */
            public ushort wOSDTopLeftY;/* OSD��y���� */
            public byte byOSDType;/* OSD����(��Ҫ�������ո�ʽ) */
            /* 0: XXXX-XX-XX ������ */
            /* 1: XX-XX-XXXX ������ */
            /* 2: XXXX��XX��XX�� */
            /* 3: XX��XX��XXXX�� */
            /* 4: XX-XX-XXXX ������*/
            /* 5: XX��XX��XXXX�� */
            public byte byDispWeek;/* �Ƿ���ʾ���� */
            public byte byOSDAttrib;/* OSD����:͸������˸ */
            /* 0: ����ʾOSD */
            /* 1: ͸��,��˸ */
            /* 2: ͸��,����˸ */
            /* 3: ��˸,��͸�� */
            /* 4: ��͸��,����˸ */
            public byte byHourOsdType;/* OSDСʱ��:0-24Сʱ��,1-12Сʱ�� */
        }

        //ͨ��ͼ��ṹ(SDK_V13��֮ǰ�汾)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sChanName;
            public uint dwVideoFormat;/* ֻ�� ��Ƶ��ʽ 1-NTSC 2-PAL*/
            public byte byBrightness;/*����,0-255*/
            public byte byContrast;/*�Աȶ�,0-255*/
            public byte bySaturation;/*���Ͷ�,0-255 */
            public byte byHue;/*ɫ��,0-255*/
            //��ʾͨ����
            public uint dwShowChanName;// Ԥ����ͼ�����Ƿ���ʾͨ������,0-����ʾ,1-��ʾ �����С704*576
            public ushort wShowNameTopLeftX;/* ͨ��������ʾλ�õ�x���� */
            public ushort wShowNameTopLeftY;/* ͨ��������ʾλ�õ�y���� */
            //�źŶ�ʧ����
            public NET_DVR_VILOST struVILost;
            //�ƶ����
            public NET_DVR_MOTION struMotion;
            //�ڵ�����
            public NET_DVR_HIDEALARM struHideAlarm;
            //�ڵ�  �����С704*576
            public uint dwEnableHide;/* �Ƿ������ڵ� ,0-��,1-��*/
            public ushort wHideAreaTopLeftX;/* �ڵ������x���� */
            public ushort wHideAreaTopLeftY;/* �ڵ������y���� */
            public ushort wHideAreaWidth;/* �ڵ�����Ŀ� */
            public ushort wHideAreaHeight;/*�ڵ�����ĸ�*/
            //OSD
            public uint dwShowOsd;// Ԥ����ͼ�����Ƿ���ʾOSD,0-����ʾ,1-��ʾ �����С704*576
            public ushort wOSDTopLeftX;/* OSD��x���� */
            public ushort wOSDTopLeftY;/* OSD��y���� */
            public byte byOSDType;/* OSD����(��Ҫ�������ո�ʽ) */
            /* 0: XXXX-XX-XX ������ */
            /* 1: XX-XX-XXXX ������ */
            /* 2: XXXX��XX��XX�� */
            /* 3: XX��XX��XXXX�� */
            /* 4: XX-XX-XXXX ������*/
            /* 5: XX��XX��XXXX�� */
            public byte byDispWeek;/* �Ƿ���ʾ���� */
            public byte byOSDAttrib;/* OSD����:͸������˸ */
            /* 0: ����ʾOSD */
            /* 1: ͸��,��˸ */
            /* 2: ͸��,����˸ */
            /* 3: ��˸,��͸�� */
            /* 4: ��͸��,����˸ */
            public byte reservedData2;
        }

        //����ѹ������(�ӽṹ)(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_V30
        {
            public byte byStreamType;//�������� 0-��Ƶ��, 1-������, ��ʾ�¼�ѹ������ʱ���λ��ʾ�Ƿ�����ѹ������
            public byte byResolution;//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5��������16-VGA��640*480�� 17-UXGA��1600*1200�� 18-SVGA ��800*600��19-HD720p��1280*720��20-XVGA  21-HD900p
            public byte byBitrateType;//�������� 0:������, 1:������
            public byte byPicQuality;//ͼ������ 0-��� 1-�κ� 2-�Ϻ� 3-һ�� 4-�ϲ� 5-��
            public uint dwVideoBitrate;//��Ƶ���� 0-���� 1-16K 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ��
            public uint dwVideoFrameRate;//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; V2.0�汾���¼�14-15; 15-18; 16-22;
            public ushort wIntervalFrameI;//I֡���
            //2006-08-11 ���ӵ�P֡�����ýӿڣ����Ը���ʵʱ����ʱ����
            public byte byIntervalBPFrame;//0-BBP֡; 1-BP֡; 2-��P֡
            public byte byres1; //����
            public byte byVideoEncType;//��Ƶ�������� 0 hik264;1��׼h264; 2��׼mpeg4;
            public byte byAudioEncType; //��Ƶ�������� 0��OggVorbis
            public byte byVideoEncComplexity; //��Ƶ���븴�Ӷȣ�0-�ͣ�1-�У�2��,0xfe:�Զ�����Դһ��
            public byte byEnableSvc; //0 - ������SVC���ܣ�1- ����SVC����
            public byte byFormatType; //��װ���ͣ�1-������2-RTP��װ��3-PS��װ��4-TS��װ��5-˽�У�6-FLV��7-ASF��8-3GP,9-RTP+PS�����꣺GB28181����0xff-��Ч
            public byte byAudioBitRate; //��Ƶ����0-Ĭ�ϣ�1-8Kbps, 2- 16Kbps, 3-32Kbps��4-64Kbps��5-128Kbps��6-192Kbps��(IPC5.1.0Ĭ��4-64Kbps)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//���ﱣ����Ƶ��ѹ������
        }

        //ͨ��ѹ������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_V30
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_V30 struNormHighRecordPara;//¼�� ��Ӧ8000����ͨ
            public NET_DVR_COMPRESSION_INFO_V30 struRes;//���� char reserveData[28];
            public NET_DVR_COMPRESSION_INFO_V30 struEventRecordPara;//�¼�����ѹ������
            public NET_DVR_COMPRESSION_INFO_V30 struNetPara;//����(������)
        }

        //����ѹ������(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO
        {
            public byte byStreamType;//��������0-��Ƶ��,1-������,��ʾѹ������ʱ���λ��ʾ�Ƿ�����ѹ������
            public byte byResolution;//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(����ר��)
            public byte byBitrateType;//��������0:�����ʣ�1:������
            public byte byPicQuality;//ͼ������ 0-��� 1-�κ� 2-�Ϻ� 3-һ�� 4-�ϲ� 5-��
            public uint dwVideoBitrate; //��Ƶ���� 0-���� 1-16K(����) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ(MIN-32K MAX-8192K)��
            public uint dwVideoFrameRate;//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20;
        }

        //ͨ��ѹ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO struRecordPara;//¼��/�¼�����¼��
            public NET_DVR_COMPRESSION_INFO struNetPara;//����/����
        }

        //����ѹ������(�ӽṹ)(��չ) ����I֡���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_INFO_EX
        {
            public byte byStreamType;//��������0-��Ƶ��, 1-������
            public byte byResolution;//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF, 5-2QCIF(352X144)(����ר��)
            public byte byBitrateType;//��������0:�����ʣ�1:������
            public byte byPicQuality;//ͼ������ 0-��� 1-�κ� 2-�Ϻ� 3-һ�� 4-�ϲ� 5-��
            public uint dwVideoBitrate;//��Ƶ���� 0-���� 1-16K(����) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 12-320K
            // 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K 23-2048K
            //���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ(MIN-32K MAX-8192K)��
            public uint dwVideoFrameRate;//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, //V2.0����14-15, 15-18, 16-22;
            public ushort wIntervalFrameI;//I֡���
            //2006-08-11 ���ӵ�P֡�����ýӿڣ����Ը���ʵʱ����ʱ����
            public byte byIntervalBPFrame;//0-BBP֡; 1-BP֡; 2-��P֡
            public byte byRes;
        }

        //ͨ��ѹ������(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_EX
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struRecordPara;//¼��
            public NET_DVR_COMPRESSION_INFO_EX struNetPara;//����
        }

        //ʱ���¼���������(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_RECORDSCHED
        {
            public NET_DVR_SCHEDTIME struRecordTime;
            public byte byRecordType;//0:��ʱ¼��1:�ƶ���⣬2:����¼��3:����|������4:����&����, 5:�����, 6: ����¼��
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 3)]
            public string reservedData;
        }

        //ȫ��¼���������(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORDDAY
        {
            public ushort wAllDayRecord;/* �Ƿ�ȫ��¼�� 0-�� 1-��*/
            public byte byRecordType;/* ¼������ 0:��ʱ¼��1:�ƶ���⣬2:����¼��3:����|������4:����&���� 5:�����, 6: ����¼��*/
            public byte reservedData;
        }

        //ͨ��¼���������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_V30
        {
            public uint dwSize;
            public uint dwRecord;/*�Ƿ�¼�� 0-�� 1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* ¼����ʱ���� 0-5�룬 1-20�룬 2-30�룬 3-1���ӣ� 4-2���ӣ� 5-5���ӣ� 6-10����*/
            public uint dwPreRecordTime;/* Ԥ¼ʱ�� 0-��Ԥ¼ 1-5�� 2-10�� 3-15�� 4-20�� 5-25�� 6-30�� 7-0xffffffff(������Ԥ¼) */
            public uint dwRecorderDuration;/* ¼�񱣴���ʱ�� */
            public byte byRedundancyRec;/*�Ƿ�����¼��,��Ҫ����˫���ݣ�0/1*/
            public byte byAudioRec;/*¼��ʱ����������ʱ�Ƿ��¼��Ƶ���ݣ������д˷���*/
            public byte byStreamType;  // 0:������ 1��������
            public byte byPassbackRecord;  // 0:���ش�¼�� 1���ش�¼��
            public ushort wLockDuration;  // ¼������ʱ������λСʱ 0��ʾ��������0xffff��ʾ����������¼��ε�ʱ�����������ĳ���ʱ����¼�񣬽���������
            public byte byRecordBackup;  // 0:¼�񲻴浵 1��¼��浵
            public byte bySVCLevel;	//SVC��֡���ͣ�0-���飬1-�����֮һ 2-���ķ�֮��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;
        }

        //ͨ��¼���������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD
        {
            public uint dwSize;
            public uint dwRecord;/*�Ƿ�¼�� 0-�� 1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDDAY[] struRecAllDay;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched;
            public uint dwRecordTime;/* ¼��ʱ�䳤�� */
            public uint dwPreRecordTime;/* Ԥ¼ʱ�� 0-��Ԥ¼ 1-5�� 2-10�� 3-15�� 4-20�� 5-25�� 6-30�� 7-0xffffffff(������Ԥ¼) */
        }

        //��̨Э���ṹ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_PROTOCOL
        {
            public uint dwType;/*����������ֵ����1��ʼ��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe;/*������������������8000�е�һ��*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PTZ_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZ_PROTOCOL[] struPtz;/*���200��PTZЭ��*/
            public uint dwPtzNum;/*��Ч��ptzЭ����Ŀ����0��ʼ(������ʱ��1)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************��̨����(end)******************************/

        //ͨ��������(��̨)��������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG_V30
        {
            public uint dwSize;
            public uint dwBaudRate;//������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;
            public byte byDataBit;// �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ;
            public byte byStopBit;// ֹͣλ 0��1λ��1��2λ
            public byte byParity;// У�� 0����У�飬1����У�飬2��żУ��;
            public byte byFlowcontrol;// 0���ޣ�1��������,2-Ӳ����
            public ushort wDecoderType;//����������, ��0��ʼ����ӦptzЭ���б�
            public ushort wDecoderAddress;/*��������ַ:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* Ԥ�õ��Ƿ�����,0-û������,1-����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* Ѳ���Ƿ�����: 0-û������,1-���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* �켣�Ƿ�����,0-û������,1-����*/
        }

        //ͨ��������(��̨)��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERCFG
        {
            public uint dwSize;
            public uint dwBaudRate; //������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;
            public byte byDataBit; // �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ;
            public byte byStopBit;// ֹͣλ 0��1λ��1��2λ;
            public byte byParity; // У�� 0����У�飬1����У�飬2��żУ��;
            public byte byFlowcontrol;// 0���ޣ�1��������,2-Ӳ����
            public ushort wDecoderType;//����������, 0��YouLi��1��LiLin-1016��2��LiLin-820��3��Pelco-p��4��DM DynaColor��5��HD600��6��JC-4116��7��Pelco-d WX��8��Pelco-d PICO
            public ushort wDecoderAddress;/*��������ַ:0 - 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PRESET, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetPreset;/* Ԥ�õ��Ƿ�����,0-û������,1-����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CRUISE, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetCruise;/* Ѳ���Ƿ�����: 0-û������,1-���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRACK, ArraySubType = UnmanagedType.I1)]
            public byte[] bySetTrack;/* �켣�Ƿ�����,0-û������,1-����*/
        }

        //ppp��������(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG_V30
        {
            public NET_DVR_IPADDR struRemoteIP;//Զ��IP��ַ
            public NET_DVR_IPADDR struLocalIP;//����IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//����IP��ַ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            public byte byPPPMode;//PPPģʽ, 0��������1������
            public byte byRedial;//�Ƿ�ز� ��0-��,1-��
            public byte byRedialMode;//�ز�ģʽ,0-�ɲ�����ָ��,1-Ԥ�ûز�����
            public byte byDataEncrypt;//���ݼ���,0-��,1-��
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//�绰����
        }

        //ppp��������(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PPPCFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteIP;//Զ��IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIP;//����IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sLocalIPMask;//����IP��ַ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            public byte byPPPMode;//PPPģʽ, 0��������1������
            public byte byRedial;//�Ƿ�ز� ��0-��,1-��
            public byte byRedialMode;//�ز�ģʽ,0-�ɲ�����ָ��,1-Ԥ�ûز�����
            public byte byDataEncrypt;//���ݼ���,0-��,1-��
            public uint dwMTU;//MTU
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PHONENUMBER_LEN)]
            public string sTelephoneNumber;//�绰����
        }

        //RS232���ڲ�������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_RS232
        {
            public uint dwBaudRate;/*������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;*/
            public byte byDataBit;/* �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ */
            public byte byStopBit;/* ֹͣλ 0��1λ��1��2λ */
            public byte byParity;/* У�� 0����У�飬1����У�飬2��żУ�� */
            public byte byFlowcontrol;/* 0���ޣ�1��������,2-Ӳ���� */
            public uint dwWorkMode; /* ����ģʽ��0��232��������PPP���ţ�1��232�������ڲ������ƣ�2��͸��ͨ�� */
        }

        //RS232���ڲ�������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG_V30
        {
            public uint dwSize;
            public NET_DVR_SINGLE_RS232 struRs232;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 84, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_PPPCFG_V30 struPPPConfig;
        }

        //RS232���ڲ�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RS232CFG
        {
            public uint dwSize;
            public uint dwBaudRate;//������(bps)��0��50��1��75��2��110��3��150��4��300��5��600��6��1200��7��2400��8��4800��9��9600��10��19200�� 11��38400��12��57600��13��76800��14��115.2k;
            public byte byDataBit;// �����м�λ 0��5λ��1��6λ��2��7λ��3��8λ;
            public byte byStopBit;// ֹͣλ 0��1λ��1��2λ;
            public byte byParity;// У�� 0����У�飬1����У�飬2��żУ��;
            public byte byFlowcontrol;// 0���ޣ�1��������,2-Ӳ����
            public uint dwWorkMode;// ����ģʽ��0��խ������(232��������PPP����)��1������̨(232�������ڲ�������)��2��͸��ͨ��
            public NET_DVR_PPPCFG struPPPConfig;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PRESETCHAN_INFO
        {
            public uint dwEnablePresetChan;	/*����Ԥ�õ��ͨ��*/
            public uint dwPresetPointNo;		/*����Ԥ�õ�ͨ����Ӧ��Ԥ�õ����, 0xfffffff��ʾ������Ԥ�õ㡣*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISECHAN_INFO
        {
            public uint dwEnableCruiseChan;	/*����Ѳ����ͨ��*/
            public uint dwCruiseNo;		/*Ѳ��ͨ����Ӧ��Ѳ�����, 0xfffffff��ʾ��Ч*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZTRACKCHAN_INFO
        {
            public uint dwEnablePtzTrackChan;	/*������̨�켣��ͨ��*/
            public uint dwPtzTrackNo;		/*��̨�켣ͨ����Ӧ�ı��, 0xfffffff��ʾ��Ч*/
        }

        //���������������(256·NVR��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;	/* ���� */
            public byte byAlarmType;	            //����������,0������,1������
            public byte byAlarmInHandle;	        /* �Ƿ��� 0-������ 1-����*/
            public byte byChannel;                 // �������봥������ʶ��ͨ��
            public byte byRes1;                    //����			
            public uint dwHandleType;        //�쳣����,�쳣����ʽ��"��"���   
            /*0x00: ����Ӧ*/
            /*0x01: �������Ͼ���*/
            /*0x02: ��������*/
            /*0x04: �ϴ�����*/
            /*0x08: �����������*/
            /*0x10: ����JPRGץͼ���ϴ�Email*/
            /*0x20: �������ⱨ��������*/
            /*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
            /*0x200: ץͼ���ϴ�FTP*/ 
            public uint dwMaxRelAlarmOutChanNum ; //�����ı������ͨ������ֻ�������֧������
            public uint dwRelAlarmOutChanNum; //�����ı������ͨ���� ʵ��֧����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelAlarmOut; //��������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            /*������¼��ͨ��*/
            public uint dwMaxRecordChanNum;   //�豸֧�ֵ�������¼��ͨ����-ֻ��
            public uint dwCurRecordChanNum;    //��ǰʵ�������õĹ���¼��ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;	 /* ʵ�ʴ���¼��ͨ������ֵ��ʾ,���ý��������У����±�0 - dwCurRecordChanNum -1��Ч������м�����0xffffffff,�������Ч*/ 
            public uint dwMaxEnablePtzCtrlNun; //�������õ���̨��������(ֻ��)
            public uint dwEnablePresetChanNum;  //��ǰ������Ԥ�õ����Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PRESETCHAN_INFO[] struPresetChanInfo; //���õ�Ԥ�õ���Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 516, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;					/*����*/
            public uint dwEnableCruiseChanNum;  //��ǰ������Ѳ����ͨ����Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISECHAN_INFO[] struCruiseChanInfo; //����Ѳ������ͨ������Ϣ
            public uint dwEnablePtzTrackChanNum;  //��ǰ������Ѳ����ͨ����Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PTZTRACKCHAN_INFO[] struPtzTrackInfo; //������̨�켣��ͨ����Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���������������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* ���� */
            public byte byAlarmType; //����������,0������,1������
            public byte byAlarmInHandle; /* �Ƿ��� 0-������ 1-����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* �Ƿ����Ԥ�õ� 0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* ���õ���̨Ԥ�õ����,һ������������Ե��ö��ͨ������̨Ԥ�õ�, 0xff��ʾ������Ԥ�õ㡣*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 192, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* �Ƿ����Ѳ�� 0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* Ѳ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* �Ƿ���ù켣 0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* ���õ���̨�Ĺ켣��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_IO_ALARM
        {
            public uint	dwAlarmInputNo;		//���������ı�������ͨ���ţ�һ��ֻ��һ��
            public uint	dwTrigerAlarmOutNum;	/*�����ı���������������ں������䳤���ݲ��������д����ı������ͨ���ţ����ֽڱ�ʾһ��*/
            public uint	dwTrigerRecordChanNum;	/*������¼��ͨ�����������ں������䳤���ݲ��������д�����¼��ͨ���ţ����ֽڱ�ʾһ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_CHANNEL
        {
            public uint	dwAlarmChanNum;	/*��������ͨ�����ݸ��������ں������䳤���ݲ��������з����ı���ͨ���ţ����ֽڱ�ʾһ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARM_HD
        {
            public uint	dwAlarmHardDiskNum;	/*����������Ӳ�����ݳ��ȣ����ں������䳤���ݲ��������з���������Ӳ�̺ţ��Ľڱ�ʾһ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ALARMINFO_FIXED
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnionLen;
            [FieldOffset(0)]
            public STRUCT_IO_ALARM struIOAlarm;// ��������dwAlarmTypeΪ0ʱ��Ч
            [FieldOffset(0)]
            public STRUCT_ALARM_CHANNEL struAlarmChannel; // dwAlarmTypeΪ2��3��6��9��10��13ʱ��Ч
            [FieldOffset(0)]
            public STRUCT_ALARM_HD struAlarmHardDisk; // dwAlarmTypeΪ1,4,5ʱ��Ч           
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALRAM_FIXED_HEADER
        {
            public uint dwAlarmType;              /*0-�ź�������,1-Ӳ����,2-�źŶ�ʧ��3���ƶ���⣬4��Ӳ��δ��ʽ��,5-дӲ�̳���,6-�ڵ�������7-��ʽ��ƥ��, 8-�Ƿ����ʣ�9-��Ƶ�ź��쳣��10-¼���쳣��11-���ܳ����仯��12-�����쳣��13-ǰ��/¼��ֱ��ʲ�ƥ��*/
            public NET_DVR_TIME_EX struAlarmTime;	//����������ʱ��
            public UNION_ALARMINFO_FIXED uStruAlarm;
        }

       [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V40
       {
            public NET_DVR_ALRAM_FIXED_HEADER struAlarmFixedHeader;	//�����̶�����
            public IntPtr pAlarmData;	//�����ɱ䲿������
       }

        //���������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmInName;/* ���� */
            public byte byAlarmType;//����������,0������,1������
            public byte byAlarmInHandle;/* �Ƿ��� 0-������ 1-����*/
            public byte byChannel;     // �������봥������ʶ��ͨ��
            public byte byRes;                     
            public NET_DVR_HANDLEEXCEPTION struAlarmHandleType;/* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePreset;/* �Ƿ����Ԥ�õ� 0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* ���õ���̨Ԥ�õ����,һ������������Ե��ö��ͨ������̨Ԥ�õ�, 0xff��ʾ������Ԥ�õ㡣*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnableCruise;/* �Ƿ����Ѳ�� 0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseNo;/* Ѳ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byEnablePtzTrack;/* �Ƿ���ù켣 0-��,1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byPTZTrack;/* ���õ���̨�Ĺ켣��� */
        }

        //ģ�ⱨ�������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOG_ALARMINCFG
        {
            public uint dwSize;
            public byte	byEnableAlarmHandle; //����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInName; //ģ�ⱨ����������
            public ushort wAlarmInUpper; //ģ�������ѹ���ޣ�ʵ��ֵ��10����Χ0~360
            public ushort wAlarmInLower; //ģ�������ѹ���ޣ�ʵ��ֵ��10����Χ0~360 
            public NET_DVR_HANDLEEXCEPTION_V30 struAlarmHandleType;	/* ����ʽ */ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //��������¼��ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //�ϴ�������Ϣ(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_V30
        {
            public uint dwAlarmType;/*0-�ź�������,1-Ӳ����,2-�źŶ�ʧ,3���ƶ����,4��Ӳ��δ��ʽ��,5-��дӲ�̳���,6-�ڵ�����,7-��ʽ��ƥ��, 8-�Ƿ�����, 0xa-GPS��λ��Ϣ(���ض���)*/
            public uint dwAlarmInputNumber;/*��������˿�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutputNumber;/*����������˿ڣ�Ϊ1��ʾ��Ӧ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmRelateChannel;/*������¼��ͨ����Ϊ1��ʾ��Ӧ¼��, dwAlarmRelateChannel[0]��Ӧ��1��ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*dwAlarmTypeΪ2��3,6ʱ����ʾ�ĸ�ͨ����dwChannel[0]��Ӧ��1��ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskNumber;/*dwAlarmTypeΪ1,4,5ʱ,��ʾ�ĸ�Ӳ��, dwDiskNumber[0]��Ӧ��1��Ӳ��*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                byAlarmRelateChannel = new byte[MAX_CHANNUM_V30];
                byChannel = new byte[MAX_CHANNUM_V30];
                byAlarmOutputNumber = new byte[MAX_ALARMOUT_V30];
                byDiskNumber = new byte[MAX_DISKNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    byAlarmRelateChannel[i] = Convert.ToByte(0);
                    byChannel[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_ALARMOUT_V30; i++)
                {
                    byAlarmOutputNumber[i] = Convert.ToByte(0);
                }
                for (int i = 0; i < MAX_DISKNUM_V30; i++)
                {
                    byDiskNumber[i] = Convert.ToByte(0);
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_HOT_SPARE
        {
            public uint dwSize;   //�ṹ��
            public uint dwExceptionCase;   //����ԭ��   0-�����쳣
            public NET_DVR_IPADDR  struDeviceIP;    //�����쳣���豸IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO
        {
            public int dwAlarmType;/*0-�ź�������,1-Ӳ����,2-�źŶ�ʧ,3���ƶ����,4��Ӳ��δ��ʽ��,5-��дӲ�̳���,6-�ڵ�����,7-��ʽ��ƥ��, 8-�Ƿ�����, 9-����״̬, 0xa-GPS��λ��Ϣ(���ض���)*/
            public int dwAlarmInputNumber;/*��������˿�, ����������Ϊ9ʱ�ñ�����ʾ����״̬0��ʾ������ -1��ʾ����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmOutputNumber;/*����������˿ڣ���һλΪ1��ʾ��Ӧ��һ�����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwAlarmRelateChannel;/*������¼��ͨ������һλΪ1��ʾ��Ӧ��һ·¼��, dwAlarmRelateChannel[0]��Ӧ��1��ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwChannel;/*dwAlarmTypeΪ2��3,6ʱ����ʾ�ĸ�ͨ����dwChannel[0]λ��Ӧ��1��ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.U4)]
            public int[] dwDiskNumber;/*dwAlarmTypeΪ1,4,5ʱ,��ʾ�ĸ�Ӳ��, dwDiskNumber[0]λ��Ӧ��1��Ӳ��*/
            public void Init()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;
                dwAlarmOutputNumber = new int[MAX_ALARMOUT];
                dwAlarmRelateChannel = new int[MAX_CHANNUM];
                dwChannel = new int[MAX_CHANNUM];
                dwDiskNumber = new int[MAX_DISKNUM];
                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
            public void Reset()
            {
                dwAlarmType = 0;
                dwAlarmInputNumber = 0;

                for (int i = 0; i < MAX_ALARMOUT; i++)
                {
                    dwAlarmOutputNumber[i] = 0;
                }
                for (int i = 0; i < MAX_CHANNUM; i++)
                {
                    dwAlarmRelateChannel[i] = 0;
                    dwChannel[i] = 0;
                }
                for (int i = 0; i < MAX_DISKNUM; i++)
                {
                    dwDiskNumber[i] = 0;
                }
            }
        }


        //////////////////////////////////////////////////////////////////////////////////////
        //IPC�����������
        /* IP�豸�ṹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO
        {
            public uint dwEnable;/* ��IP�豸�Ƿ����� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /* ���� */
            public NET_DVR_IPADDR struIP;/* IP��ַ */
            public ushort wDVRPort;/* �˿ں� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ���� */

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byRes = new byte[34];
            }
        }

        //ipc�����豸��Ϣ��չ��֧��ip�豸���������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPDEVINFO_V31
        {
            public byte byEnable;//��IP�豸�Ƿ���Ч
            public byte byProType;
            public byte byEnableQuickAdd;
            public byte byRes1;//�����ֶΣ���0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;//�û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;//����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;//�豸����
            public NET_DVR_IPADDR struIP;//IP��ַ
            public ushort wDVRPort;// �˿ں�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//�����ֶΣ���0

            public void Init()
            {
                sUserName = new byte[NAME_LEN];
                sPassword = new byte[PASSWD_LEN];
                byDomain = new byte[MAX_DOMAIN_NAME];
                byRes2 = new byte[34];
            }
        }

        /* IPͨ��ƥ����� */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO
        {
            public byte byEnable;/* ��ͨ���Ƿ����� */
            public byte byIPID;/* IP�豸ID ȡֵ1- MAX_IP_DEVICE */
            public byte byChannel;/* ͨ���� */
            public byte byIPIDHigh; // IP�豸ID�ĸ�8λ
            public byte byTransProtocol;//����Э������0-TCP/auto(�������豸����)��1-UDP 2-�ಥ 3-��TCP 4-auto
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����,��0
            public void Init()
            {
                byRes = new byte[31];
            }
        }

        /* IP�������ýṹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG
        {
            public uint dwSize;/* �ṹ��С */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo;/* IP�豸 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPͨ�� */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        /* ��չIP�������ýṹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V31
        {
            public uint dwSize;/* �ṹ��С */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IP�豸 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPͨ�� */

            public void Init()
            {
                int i = 0;
                struIPDevInfo = new NET_DVR_IPDEVINFO_V31[MAX_IP_DEVICE];

                for (i = 0; i < MAX_IP_DEVICE; i++)
                {
                    struIPDevInfo[i].Init();
                }
                byAnalogChanEnable = new byte[MAX_ANALOG_CHANNUM];
                struIPChanInfo = new NET_DVR_IPCHANINFO[MAX_IP_CHANNEL];
                for (i = 0; i < MAX_IP_CHANNEL; i++)
                {
                    struIPChanInfo[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSERVER_STREAM
        {
            public byte  byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_IPADDR struIPServer;
            public ushort  wPort;
            public ushort  wDvrNameLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRName;
            public ushort  wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public ushort[]  byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[]  byPassWord;
            public byte  byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDVRName = new byte[NAME_LEN];
                byRes1 = new ushort[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        /*��ý���������������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG
        {
            public byte byValid;/*�Ƿ�������ý�������ȡ��,0��ʾ��Ч����0��ʾ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;
            public ushort wDevPort;/*��ý��������˿�*/
            public byte byTransmitType;/*����Э������ 0-TCP��1-UDP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        //�豸ͨ����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO
        {
            public NET_DVR_IPADDR struIP;		    //DVR IP��ַ
            public ushort wDVRPort;			 	//�˿ں�
            public byte byChannel;				//ͨ����
            public byte byTransProtocol;		//����Э������0-TCP��1-UDP
            public byte byTransMode;			//��������ģʽ 0�������� 1��������
            public byte byFactoryType;			/*ǰ���豸��������,ͨ���ӿڻ�ȡ*/
            public byte byDeviceType; //�豸����(��Ƶ�ۺ�ƽ̨���ܰ�ʹ��)��1-����������ʱ������Ƶ�ۺ�ƽ̨��������byVcaSupportChanMode�ֶ���������ʹ�ý���ͨ��������ʾͨ������2-������
            public byte byDispChan;//��ʾͨ����,��������ʹ��
            public byte bySubDispChan;//��ʾͨ����ͨ���ţ���������ʱʹ��
            public byte byResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500w����������ʹ�ã���������������ݸò������������Դ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byDomain;	//�豸����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//���������½�ʺ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//�����������
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG struStreamMediaSvrCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNS_STREAM_CFG
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struStreamServer;
            public ushort wStreamServerPort;
            public byte byStreamServerTransmitType;
            public byte byRes2;
            public NET_DVR_IPADDR struIPServer;
            public ushort wIPServerPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName;
            public ushort wDVRNameLen;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassWord;
            public ushort wDVRPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
            public byte byChannel;
            public byte byTransProtocol;
            public byte byTransMode;
            public byte byFactoryType;
            public void Init()
            {
                byRes1 = new byte[3];
                byRes3 = new byte[2];
                sDVRName = new byte[NAME_LEN];
                sDVRSerialNumber = new byte[SERIALNO_LEN];
                sUserName = new byte[NAME_LEN];
                sPassWord = new byte[PASSWD_LEN];
                byRes4 = new byte[2];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_URL
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] strURL;
            public byte   byTransPortocol;
            public ushort wIPID;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void Init()
            {
                strURL = new byte[240];
                byRes = new byte[7];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HKDDNS_STREAM
        {
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byDDNSDomain;
            public ushort wPort;
            public ushort wAliasLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlias;
            public ushort wDVRSerialLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVRSerialNumber;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassWord;
            public byte byChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public void Init()
            {
                byRes = new byte[3];
                byDDNSDomain = new byte[64];
                byAlias = new byte[NAME_LEN];
                byRes1 = new byte[2];
                byDVRSerialNumber = new byte[SERIALNO_LEN];
                byUserName = new byte[NAME_LEN];
                byPassWord = new byte[PASSWD_LEN];
                byRes2 = new byte[11];
            }
        }

        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPCHANINFO_V40
        {
            public byte byEnable;				/* ��ͨ���Ƿ����� */
            public byte byRes1;
            public ushort wIPID;                  //IP�豸ID
            public uint dwChannel;				//ͨ����
            public byte byTransProtocol;		//����Э������0-TCP��1-UDP
            public byte byTransMode;			//��������ģʽ 0�������� 1��������
            public byte byFactoryType;			/*ǰ���豸��������,ͨ���ӿڻ�ȡ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 241, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_GET_STREAM_UNION
        {
            [FieldOffset(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 492, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnion;           
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MODE
        {
            public byte byGetStreamType;/*ȡ����ʽ��0- ֱ�Ӵ��豸ȡ����1- ����ý��ȡ����2- ͨ��IPServer���IP��ַ��ȡ����
                                          * 3- ͨ��IPServer�ҵ��豸����ͨ����ý��ȡ�豸������ 4- ͨ����ý����URLȥȡ����
                                          * 5- ͨ��hiDDNS���������豸Ȼ����豸ȡ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[]  byRes;
            public NET_DVR_GET_STREAM_UNION uGetStream;
            public void Init()
            {
                byGetStreamType = 0;
                byRes = new byte[3];
                //uGetStream.Init();
            }
        }

        /* V40��չIP�������ýṹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPPARACFG_V40
        {
            public uint dwSize;/* �ṹ��С */
            public uint dwGroupNum;
            public uint dwAChanNum;
            public uint dwDChanNum;
            public uint dwStartDChan;

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IP�豸 */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_STREAM_MODE[] struStreamMode;/* IPͨ�� */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; /* ģ��ͨ���Ƿ����ã��ӵ͵��߱�ʾ1-32ͨ����0��ʾ��Ч 1��Ч */
        }

        //ΪCVR��չ�ı�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMINFO_DEV
        {
            public uint dwAlarmType;  //0-������(ͨ��)�ź���������1-˽�о���𻵣�2- NVR�����˳���
	        //3-������״̬�쳣��4-ϵͳʱ���쳣��5-¼���ʣ���������ͣ�
	        //6-������(ͨ��)�ƶ���ⱨ����7-������(ͨ��)�ڵ�������
            public NET_DVR_TIME   struTime;     //����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //����
            public uint dwNumber;     //��Ŀ
            public IntPtr pNO;  //dwNumber��WORD; ÿ��WORD��ʾһ��ͨ���ţ����ߴ��̺�, ��ЧʱΪ0
        }

        /* ����������� */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO
        {
            public byte byIPID;/* IP�豸IDȡֵ1- MAX_IP_DEVICE */
            public byte byAlarmOut;/* ��������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ���� */

            public void Init()
            {
                byRes = new byte[18];
            }
        }

        /* IP����������ýṹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG
        {
            public uint dwSize; /* �ṹ��С */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP������� */

            public void Init()
            {
                struIPAlarmOutInfo = new NET_DVR_IPALARMOUTINFO[MAX_IP_ALARMOUT];
                for (int i = 0; i < MAX_IP_ALARMOUT; i++)
                {
                    struIPAlarmOutInfo[i].Init();
                }
            }
        }
        /* IP����������� */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTINFO_V40
        {
            public uint dwIPID;					/* IP�豸ID */
            public uint dwAlarmOut;				/* IP�豸ID��Ӧ�ı�������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ���� */
        }

        /*IP�������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMOUTCFG_V40
        {
            public uint dwSize;  //�ṹ�峤��
            public uint dwCurIPAlarmOutNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO_V40[] struIPAlarmOutInfo;/*IP�������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /* ����������� */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO
        {
            public byte byIPID;/* IP�豸IDȡֵ1- MAX_IP_DEVICE */
            public byte byAlarmIn;/* ��������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;/* ���� */
        }

        /* IP�����������ýṹ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG
        {
            public uint dwSize;/* �ṹ��С */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP�������� */
        }
        /* IP����������� */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMININFO_V40
        {
            public uint dwIPID;					/* IP�豸ID */
            public uint dwAlarmIn;				/* IP�豸ID��Ӧ�ı�������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ���� */
        }
         /*IP����������Դ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINCFG_V40
        {
            public uint dwSize;  //�ṹ�峤��
            public uint dwCurIPAlarmInNum;  //��ǰ�����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN_V40, ArraySubType = UnmanagedType.I1)]
            public NET_DVR_IPALARMININFO_V40[] struIPAlarmInInfo;/* IP��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ipc alarm info
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO[] struIPDevInfo; /* IP�豸 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable; /* ģ��ͨ���Ƿ����ã�0-δ���� 1-���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPͨ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;/* IP�������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP������� */
        }

        //ipc���øı䱨����Ϣ��չ 9000_1.1
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V31
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo; /* IP�豸 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;/* ģ��ͨ���Ƿ����ã�0-δ���� 1-���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;/* IPͨ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo; /* IP�������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo;/* IP������� */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPALARMINFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_DEVICE_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPDEVINFO_V31[] struIPDevInfo;           // IP�豸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnalogChanEnable;           /* ģ��ͨ���Ƿ����ã�0-δ���� 1-���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPCHANINFO[] struIPChanInfo;	        /* IPͨ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMIN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMININFO[] struIPAlarmInInfo;    /* IP�������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IP_ALARMOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPALARMOUTINFO[] struIPAlarmOutInfo; /* IP������� */   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                          // �����ֽ�
        }

        public enum HD_STAT
        {
            HD_STAT_OK = 0,/* ���� */
            HD_STAT_UNFORMATTED = 1,/* δ��ʽ�� */
            HD_STAT_ERROR = 2,/* ���� */
            HD_STAT_SMART_FAILED = 3,/* SMART״̬ */
            HD_STAT_MISMATCH = 4,/* ��ƥ�� */
            HD_STAT_IDLE = 5, /* ����*/
            NET_HD_STAT_OFFLINE = 6,/*�����̴���δ����״̬ */
            HD_RIADVD_EXPAND = 7,    /* ������̿����� */
            HD_STAT_REPARING = 10,   /* Ӳ�������޸�(9000 2.0) */
            HD_STAT_FORMATING = 11,   /* Ӳ�����ڸ�ʽ��(9000 2.0) */ 
        }

        //����Ӳ����Ϣ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HD
        {
            public uint dwHDNo;/*Ӳ�̺�, ȡֵ0~MAX_DISKNUM_V30-1*/
            public uint dwCapacity;/*Ӳ������(��������)*/
            public uint dwFreeSpace;/*Ӳ��ʣ��ռ�(��������)*/
            public uint dwHdStatus;/*Ӳ��״̬(��������) HD_STAT*/
            public byte byHDAttr;/*0-Ĭ��, 1-����; 2-ֻ��*/
            public byte byHDType;/*0-����Ӳ��,1-ESATAӲ��,2-NASӲ��*/
            public byte byDiskDriver;   // ֵ ������ASCII�ַ� 
            public byte byRes1;
            public uint dwHdGroup; /*�����ĸ����� 1-MAX_HD_GROUP*/
            public byte byRecycling;   // �Ƿ�ѭ������ 0����ѭ�����ã�1��ѭ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwStorageType;    //��λ��ʾ 0-��֧�� ��0-֧��
							// dwStorageType & 0x1 ��ʾ�Ƿ�����ͨ¼��ר�ô洢��     
							// dwStorageType & 0x2  ��ʾ�Ƿ��ǳ�֡¼��ר�ô洢��
							// dwStorageType & 0x4 ��ʾ�Ƿ���ͼƬ¼��ר�ô洢��

            public uint dwPictureCapacity; //Ӳ��ͼƬ����(��������)����λ:MB
            public uint dwFreePictureSpace; //ʣ��ͼƬ�ռ�(��������)����λ:MB
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 104, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDCFG
        {
            public uint dwSize;
            public uint dwHDCount;/*Ӳ����(��������)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HD[] struHDInfo;//Ӳ����ز�������Ҫ����������Ч��
        }

        //����������Ϣ������չ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP_V40
        {
            public uint dwHDGroupNo;       /*�����(��������) 1-MAX_HD_GROUP*/    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRelRecordChan;  //������¼��ͨ������ֵ��ʾ������0xffffffffʱ������Ϊ��Ч    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				/* ���� */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG_V40
        {
            public uint dwSize;                //�ṹ���С
            public uint dwMaxHDGroupNum; 		  //�豸֧�ֵ����������-ֻ��
            public uint dwCurHDGroupNum;       /*��ǰ���õ�������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP_V40[] struHDGroupAttr; //Ӳ����ز�������Ҫ����������Ч��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        //����������Ϣ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_HDGROUP
        {
            public uint dwHDGroupNo;/*�����(��������) 1-MAX_HD_GROUP*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDGroupChans;/*�����Ӧ��¼��ͨ��, 0-��ʾ��ͨ����¼�󵽸����飬1-��ʾ¼�󵽸�����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HDGROUP_CFG
        {
            public uint dwSize;
            public uint dwHDGroupCount;/*��������(��������)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HD_GROUP, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_HDGROUP[] struHDGroupAttr;//Ӳ����ز�������Ҫ����������Ч
        }

        //�������Ų����Ľṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCALECFG
        {
            public uint dwSize;
            public uint dwMajorScale;/* ����ʾ 0-�����ţ�1-����*/
            public uint dwMinorScale;/* ����ʾ 0-�����ţ�1-����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //DVR�������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* ���� */
            public uint dwAlarmOutDelay;/* �������ʱ��(-1Ϊ���ޣ��ֶ��ر�) */
            //0-5��,1-10��,2-30��,3-1����,4-2����,5-5����,6-10����,7-�ֶ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* �����������ʱ��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAlarmOutName;/* ���� */
            public uint dwAlarmOutDelay;/* �������ʱ��(-1Ϊ���ޣ��ֶ��ر�) */
            //0-5��,1-10��,2-30��,3-1����,4-2����,5-5����,6-10����,7-�ֶ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmOutTime;/* �����������ʱ��� */
        }

        //DVR����Ԥ������(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG_V30
        {
            public uint dwSize;
            public byte byPreviewNumber;//Ԥ����Ŀ,0-1����,1-4����,2-9����,3-16����,0xff:�����
            public byte byEnableAudio;//�Ƿ�����Ԥ��,0-��Ԥ��,1-Ԥ��
            public ushort wSwitchTime;//�л�ʱ��,0-���л�,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PREVIEW_MODE * MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//�л�˳��,���lSwitchSeq[i]Ϊ 0xff��ʾ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR����Ԥ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWCFG
        {
            public uint dwSize;
            public byte byPreviewNumber;//Ԥ����Ŀ,0-1����,1-4����,2-9����,3-16����,0xff:�����
            public byte byEnableAudio;//�Ƿ�����Ԥ��,0-��Ԥ��,1-Ԥ��
            public ushort wSwitchTime;//�л�ʱ��,0-���л�,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] bySwitchSeq;//�л�˳��,���lSwitchSeq[i]Ϊ 0xff��ʾ����
        }

        //DVR��Ƶ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGAPARA
        {
            public ushort wResolution;/* �ֱ��� */
            public ushort wFreq;/* ˢ��Ƶ�� */
            public uint dwBrightness;/* ���� */
        }

        //MATRIX��������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_CHANNUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOrder;/* Ԥ��˳��, 0xff��ʾ��Ӧ�Ĵ��ڲ�Ԥ�� */
            public ushort wSwitchTime;// Ԥ���л�ʱ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXPARA
        {
            public ushort wDisplayLogo;/* ��ʾ��Ƶͨ���� */
            public ushort wDisplayOsd;/* ��ʾʱ�� */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOOUT
        {
            public byte byVideoFormat;/* �����ʽ,0-PAL,1-NTSC */
            public byte byMenuAlphaValue;/* �˵��뱳��ͼ��Աȶ� */
            public ushort wScreenSaveTime;/* ��Ļ����ʱ�� 0-�Ӳ�,1-1����,2-2����,3-5����,4-10����,5-20����,6-30���� */
            public ushort wVOffset;/* ��Ƶ���ƫ�� */
            public ushort wBrightness;/* ��Ƶ������� */
            public byte byStartMode;/* ��������Ƶ���ģʽ(0:�˵�,1:Ԥ��)*/
            public byte byEnableScaler;/* �Ƿ��������� (0-������, 1-����)*/
        }

        //DVR��Ƶ���(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;/* VGA���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MATRIXOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIXPARA_V30[] struMatrixPara;/* MATRIX���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR��Ƶ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOOUT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VOOUT[] struVOOut;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VGA, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VGAPARA[] struVGAPara;	/* VGA���� */
            public NET_DVR_MATRIXPARA struMatrixPara;/* MATRIX���� */
        }

        //���û�����(�ӽṹ)(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;			/* �û���ֻ����16�ֽ� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;			/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;	/* ����Ȩ�� */
            /*����0: ���ؿ�����̨*/
            /*����1: �����ֶ�¼��*/
            /*����2: ���ػط�*/
            /*����3: �������ò���*/
            /*����4: ���ز鿴״̬����־*/
            /*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
            /*����6: ���ز鿴���� */
            /*����7: ���ع���ģ���IP camera */
            /*����8: ���ر��� */
            /*����9: ���عػ�/���� */    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* Զ��Ȩ�� */	
            /*����0: Զ�̿�����̨*/
            /*����1: Զ���ֶ�¼��*/
            /*����2: Զ�̻ط� */
            /*����3: Զ�����ò���*/
            /*����4: Զ�̲鿴״̬����־*/
            /*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
            /*����6: Զ�̷��������Խ�*/
            /*����7: Զ��Ԥ��*/
            /*����8: Զ�����󱨾��ϴ����������*/
            /*����9: Զ�̿��ƣ��������*/
            /*����10: Զ�̿��ƴ���*/
            /*����11: Զ�̲鿴���� */
            /*����12: Զ�̹���ģ���IP camera */
            /*����13: Զ�̹ػ�/���� */	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPreviewRight;			/* Զ�̿���Ԥ����ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRecordRight;			/* ���ؿ���¼���ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetRecordRight;			/* Զ�̿���¼���ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPlaybackRight;			/* ���ؿ��Իطŵ�ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPlaybackRight;			/* Զ�̿��Իطŵ�ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalPTZRight;				/* ���ؿ���PTZ��ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwNetPTZRight;				/* Զ�̿���PTZ��ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalBackupRight;			/* ���ر���Ȩ��ͨ������ǰ����˳�����У�����0xffffffff������Ϊ��Ч*/
            public NET_DVR_IPADDR	struUserIP;				/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;	/* �����ַ */
            public byte byPriority;				/* ���ȼ���0xff-�ޣ�0--�ͣ�1--�У�2--�� */
                                    /* �ޡ�����ʾ��֧�����ȼ�������
                                    �͡���Ĭ��Ȩ��:�������غ�Զ�̻ط�,���غ�Զ�̲鿴��־��״̬,���غ�Զ�̹ػ�/����
                                    �С����������غ�Զ�̿�����̨,���غ�Զ���ֶ�¼��,���غ�Զ�̻ط�,�����Խ���Զ��Ԥ�������ر���,����/Զ�̹ػ�/����
                                    �ߡ�������Ա */
            public byte byAlarmOnRight;         // ��������ڲ���Ȩ�� 1-��Ȩ�ޣ�0-��Ȩ��
            public byte byAlarmOffRight;         // ��������ڳ���Ȩ�� 1-��Ȩ�ޣ�0-��Ȩ��
            public byte byBypassRight;           // �����������·Ȩ�� 1-��Ȩ�ޣ�0-��Ȩ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 118, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        //���û�����(�ӽṹ)(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_INFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRight;/* ����Ȩ�� */
            /*����0: ���ؿ�����̨*/
            /*����1: �����ֶ�¼��*/
            /*����2: ���ػط�*/
            /*����3: �������ò���*/
            /*����4: ���ز鿴״̬����־*/
            /*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
            /*����6: ���ز鿴���� */
            /*����7: ���ع���ģ���IP camera */
            /*����8: ���ر��� */
            /*����9: ���عػ�/���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemoteRight;/* Զ��Ȩ�� */
            /*����0: Զ�̿�����̨*/
            /*����1: Զ���ֶ�¼��*/
            /*����2: Զ�̻ط� */
            /*����3: Զ�����ò���*/
            /*����4: Զ�̲鿴״̬����־*/
            /*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
            /*����6: Զ�̷��������Խ�*/
            /*����7: Զ��Ԥ��*/
            /*����8: Զ�����󱨾��ϴ����������*/
            /*����9: Զ�̿��ƣ��������*/
            /*����10: Զ�̿��ƴ���*/
            /*����11: Զ�̲鿴���� */
            /*����12: Զ�̹���ģ���IP camera */
            /*����13: Զ�̹ػ�/���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPreviewRight;/* Զ�̿���Ԥ����ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPlaybackRight;/* ���ؿ��Իطŵ�ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPlaybackRight;/* Զ�̿��Իطŵ�ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalRecordRight;/* ���ؿ���¼���ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetRecordRight;/* Զ�̿���¼���ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalPTZRight;/* ���ؿ���PTZ��ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byNetPTZRight;/* Զ�̿���PTZ��ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalBackupRight;/* ���ر���Ȩ��ͨ�� 0-��Ȩ�ޣ�1-��Ȩ��*/
            public NET_DVR_IPADDR struUserIP;/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* �����ַ */
            public byte byPriority;/* ���ȼ���0xff-�ޣ�0--�ͣ�1--�У�2--�� */
            /*
            �ޡ�����ʾ��֧�����ȼ�������
            �͡���Ĭ��Ȩ��:�������غ�Զ�̻ط�,���غ�Զ�̲鿴��־��״̬,���غ�Զ�̹ػ�/����
            �С����������غ�Զ�̿�����̨,���غ�Զ���ֶ�¼��,���غ�Զ�̻ط�,�����Խ���Զ��Ԥ��
                  ���ر���,����/Զ�̹ػ�/����
            �ߡ�������Ա
            */
            public byte byAlarmOnRight;         // ��������ڲ���Ȩ��
            public byte byAlarmOffRight;        // ��������ڳ���Ȩ��
            public byte byBypassRight;          // �����������·Ȩ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���û�����(SDK_V15��չ)(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* Ȩ�� */
            /*����0: ���ؿ�����̨*/
            /*����1: �����ֶ�¼��*/
            /*����2: ���ػط�*/
            /*����3: �������ò���*/
            /*����4: ���ز鿴״̬����־*/
            /*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
            public uint dwLocalPlaybackRight;/* ���ؿ��Իطŵ�ͨ�� bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* Ȩ�� */
            /*����0: Զ�̿�����̨*/
            /*����1: Զ���ֶ�¼��*/
            /*����2: Զ�̻ط� */
            /*����3: Զ�����ò���*/
            /*����4: Զ�̲鿴״̬����־*/
            /*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
            /*����6: Զ�̷��������Խ�*/
            /*����7: Զ��Ԥ��*/
            /*����8: Զ�����󱨾��ϴ����������*/
            /*����9: Զ�̿��ƣ��������*/
            /*����10: Զ�̿��ƴ���*/
            public uint dwNetPreviewRight;/* Զ�̿���Ԥ����ͨ�� bit0 -- channel 1*/
            public uint dwNetPlaybackRight;/* Զ�̿��Իطŵ�ͨ�� bit0 -- channel 1*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* �����ַ */
        }

        //���û�����(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_USER_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLocalRight;/* Ȩ�� */
            /*����0: ���ؿ�����̨*/
            /*����1: �����ֶ�¼��*/
            /*����2: ���ػط�*/
            /*����3: �������ò���*/
            /*����4: ���ز鿴״̬����־*/
            /*����5: ���ظ߼�����(��������ʽ�����������ػ�)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RIGHT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRemoteRight;/* Ȩ�� */
            /*����0: Զ�̿�����̨*/
            /*����1: Զ���ֶ�¼��*/
            /*����2: Զ�̻ط� */
            /*����3: Զ�����ò���*/
            /*����4: Զ�̲鿴״̬����־*/
            /*����5: Զ�̸߼�����(��������ʽ�����������ػ�)*/
            /*����6: Զ�̷��������Խ�*/
            /*����7: Զ��Ԥ��*/
            /*����8: Զ�����󱨾��ϴ����������*/
            /*����9: Զ�̿��ƣ��������*/
            /*����10: Զ�̿��ƴ���*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sUserIP;/* �û�IP��ַ(Ϊ0ʱ��ʾ�����κε�ַ) */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/* �����ַ */
        }

        //DVR�û�����(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V40
        {
            public uint dwSize;  //�ṹ���С
            public uint dwMaxUserNum; //�豸֧�ֵ�����û���-ֻ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V40[] struUser;  /* �û����� */
        }

        //DVR�û�����(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_V30[] struUser;
        }

        //DVR�û�����(SDK_V15��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO_EX[] struUser;
        }

        //DVR�û�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_USER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_USERNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_USER_INFO[] struUser;
        }

        //�쳣����������չ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V40
        {
            public uint dwSize ;             //�ṹ���С
            public uint dwMaxGroupNum ;    //�豸֧�ֵ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V41[] struExceptionHandle;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //����
        } 

        //DVR�쳣����(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION_V30[] struExceptionHandleType;
            /*����0-����,1- Ӳ�̳���,2-���߶�,3-��������IP ��ַ��ͻ, 4-�Ƿ�����, 5-����/�����Ƶ��ʽ��ƥ��, 6-��Ƶ�ź��쳣, 7-¼���쳣*/
        }

        //DVR�쳣����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HANDLEEXCEPTION[] struExceptionHandleType;
            /*����0-����,1- Ӳ�̳���,2-���߶�,3-��������IP ��ַ��ͻ,4-�Ƿ�����, 5-����/�����Ƶ��ʽ��ƥ��, 6-��Ƶ�ź��쳣*/
        }

        //ͨ��״̬(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE_V30
        {
            public byte byRecordStatic;//ͨ���Ƿ���¼��,0-��¼��,1-¼��
            public byte bySignalStatic;//���ӵ��ź�״̬,0-����,1-�źŶ�ʧ
            public byte byHardwareStatic;//ͨ��Ӳ��״̬,0-����,1-�쳣,����DSP����
            public byte byRes1;//����
            public uint dwBitRate;//ʵ������
            public uint dwLinkNum;//�ͻ������ӵĸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struClientIP;//�ͻ��˵�IP��ַ
            public uint dwIPLinkNum;//�����ͨ��ΪIP���룬��ô��ʾIP���뵱ǰ��������
            public byte byExceedMaxLink;		// �Ƿ񳬳��˵�·6·������ 0 - δ����, 1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwChannelNo;    //��ǰ��ͨ���ţ�0xffffffff��ʾ��Ч

            public void Init()
            {
                struClientIP = new NET_DVR_IPADDR[MAX_LINK];

                for (int i = 0; i < MAX_LINK; i++)
                {
                    struClientIP[i].Init();
                }
                byRes = new byte[12];
            }
        }

        //ͨ��״̬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNELSTATE
        {
            public byte byRecordStatic;//ͨ���Ƿ���¼��,0-��¼��,1-¼��
            public byte bySignalStatic;//���ӵ��ź�״̬,0-����,1-�źŶ�ʧ
            public byte byHardwareStatic;//ͨ��Ӳ��״̬,0-����,1-�쳣,����DSP����
            public byte reservedData;//����
            public uint dwBitRate;//ʵ������
            public uint dwLinkNum;//�ͻ������ӵĸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.U4)]
            public uint[] dwClientIP;//�ͻ��˵�IP��ַ
        }

        //Ӳ��״̬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKSTATE
        {
            public uint dwVolume;//Ӳ�̵�����
            public uint dwFreeSpace;//Ӳ�̵�ʣ��ռ�
            public uint dwHardDiskStatic;//Ӳ�̵�״̬,0-�,1-����,2-������
        }

        //�豸����״̬��չ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V40
        { 
            public uint dwSize ;            //�ṹ���С
            public uint dwDeviceStatic; 	 //�豸��״̬,0-����,1-CPUռ����̫��,����85%,2-Ӳ������,���紮������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[]  struHardDiskStatic;   //Ӳ��״̬,һ�����ֻ�ܻ�ȡ33��Ӳ����Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//ͨ����״̬����ǰ����˳������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmInStatic; //�б����ı�������ڣ���ֵ��ʾ�����±�ֵ˳�����У�ֵΪ0xffffffffʱ��ǰ������ֵ��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwHasAlarmOutStatic; //�б�������ı�������ڣ���ֵ��ʾ�����±�ֵ˳�����У�ֵΪ0xffffffffʱ��ǰ������ֵ��Ч
            public uint dwLocalDisplay;			//������ʾ״̬,0-����,1-������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byAudioInChanStatus;		//��λ��ʾ����ͨ����״̬ 0-δʹ�ã�1-ʹ���У���0λ��ʾ��1������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 				//����
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GETWORKSTATE_COND
        {
            public uint dwSize ;  //�ṹ�峤��
            public byte byFindHardByCond; /*0-����ȫ������(��һ�����ֻ�ܲ���33��)����ʱdwFindHardStatusNum��Ч*/
            public byte byFindChanByCond ;  /*0-����ȫ��ͨ������ʱdwFindChanNum��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindHardStatus ; /*Ҫ���ҵ�Ӳ�̺ţ���ֵ��ʾ����ֵ����˳�����У� ����0xffffffff����Ϊ������Ч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwFindChanNo; /*Ҫ���ҵ�ͨ���ţ���ֵ��ʾ����ֵ����˳�����У� ����0xffffffff����Ϊ������Ч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        //DVR����״̬(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE_V30
        {
            public uint dwDeviceStatic;//�豸��״̬,0-����,1-CPUռ����̫��,����85%,2-Ӳ������,���紮������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE_V30[] struChanStatic;//ͨ����״̬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//�����˿ڵ�״̬,0-û�б���,1-�б���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//��������˿ڵ�״̬,0-û�����,1-�б������
            public uint dwLocalDisplay;//������ʾ״̬,0-����,1-������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUDIO_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAudioChanStatus;//��ʾ����ͨ����״̬ 0-δʹ�ã�1-ʹ����, 0xff��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM_V30];
                struChanStatic = new NET_DVR_CHANNELSTATE_V30[MAX_CHANNUM_V30];
                for (int i = 0; i < MAX_CHANNUM_V30; i++)
                {
                    struChanStatic[i].Init();
                }
                byAlarmInStatic = new byte[MAX_ALARMOUT_V30];
                byAlarmOutStatic = new byte[MAX_ALARMOUT_V30];
                byAudioChanStatus = new byte[MAX_AUDIO_V30];
                byRes = new byte[10];
            }
        }

        //DVR����״̬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WORKSTATE
        {
            public uint dwDeviceStatic;//�豸��״̬,0-����,1-CPUռ����̫��,����85%,2-Ӳ������,���紮������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISKSTATE[] struHardDiskStatic;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANNELSTATE[] struChanStatic;//ͨ����״̬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatic;//�����˿ڵ�״̬,0-û�б���,1-�б���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatic;//��������˿ڵ�״̬,0-û�����,1-�б������
            public uint dwLocalDisplay;//������ʾ״̬,0-����,1-������

            public void Init()
            {
                struHardDiskStatic = new NET_DVR_DISKSTATE[MAX_DISKNUM];
                struChanStatic = new NET_DVR_CHANNELSTATE[MAX_CHANNUM];
                byAlarmInStatic = new byte[MAX_ALARMIN];
                byAlarmOutStatic = new byte[MAX_ALARMOUT];
            }
        }        

        //��־��Ϣ(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG_V30
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//������ 1-����; 2-�쳣; 3-����; 0xff-ȫ��
            public uint dwMinorType;//������ 0-ȫ��;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//���������û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//����������û���
            public NET_DVR_IPADDR struRemoteHostAddr;//Զ��������ַ
            public uint dwParaType;//��������
            public uint dwChannel;//ͨ����
            public uint dwDiskNumber;//Ӳ�̺�
            public uint dwAlarmInPort;//��������˿�
            public uint dwAlarmOutPort;//��������˿�
            public uint dwInfoLen;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;
        }

        //��־��Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_LOG
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;//������ 1-����; 2-�쳣; 3-����; 0xff-ȫ��
            public uint dwMinorType;//������ 0-ȫ��;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;//���������û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;//����������û���
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteHostAddr;//Զ��������ַ
            public uint dwParaType;//��������
            public uint dwChannel;//ͨ����
            public uint dwDiskNumber;//Ӳ�̺�
            public uint dwAlarmInPort;//��������˿�
            public uint dwAlarmOutPort;//��������˿�
        }

        /************************������������������־���� begin************************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_SEARCH_LOG_PARAM
        {
            public ushort wMajorType;		// ������
            public ushort wMinorType;		// ������ 
            public NET_DVR_TIME    struStartTime;	// ��ʼʱ�� 
            public NET_DVR_TIME    struEndTime;	// ����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMHOST_LOG_RET
        {
            public NET_DVR_TIME	struLogTime;                //  ��־ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;     // �����û�
            public NET_DVR_IPADDR	struIPAddr;                 // ����IP��ַ
            public ushort wMajorType;                 // ������ 
            public ushort wMinorType;                 // ������
            public ushort wParam;	                    // ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwInfoLen;	                // ������Ϣ����
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN)]
            public string sInfo;       // ������Ϣ
        }
        /*************************������������������־���� end***********************************************/

        //�������״̬(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMOUT_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;

            public void Init()
            {
                Output = new byte[MAX_ALARMOUT_V30];
            }
        }

        //�������״̬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMOUTSTATUS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] Output;
        }        

        //ATMר��
        /****************************ATM(begin)***************************/
        public const int NCR = 0;
        public const int DIEBOLD = 1;
        public const int WINCOR_NIXDORF = 2;
        public const int SIEMENS = 3;
        public const int OLIVETTI = 4;
        public const int FUJITSU = 5;
        public const int HITACHI = 6;
        public const int SMI = 7;
        public const int IBM = 8;
        public const int BULL = 9;
        public const int YiHua = 10;
        public const int LiDe = 11;
        public const int GDYT = 12;
        public const int Mini_Banl = 13;
        public const int GuangLi = 14;
        public const int DongXin = 15;
        public const int ChenTong = 16;
        public const int NanTian = 17;
        public const int XiaoXing = 18;
        public const int GZYY = 19;
        public const int QHTLT = 20;
        public const int DRS918 = 21;
        public const int KALATEL = 22;
        public const int NCR_2 = 23;
        public const int NXS = 24;

        //������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_TRADEINFO
        {
            public ushort m_Year;
            public ushort m_Month;
            public ushort m_Day;
            public ushort m_Hour;
            public ushort m_Minute;
            public ushort m_Second;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] DeviceName;//�豸����
            public uint dwChannelNumer;//ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] CardNumber;//����
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string cTradeType;//��������
            public uint dwCash;//���׽��
        }

        /*֡��ʽ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FRAMETYPECODE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] code;/* ���� */
        }
        
        //ATM����
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FRAMEFORMAT
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sATMIP;/* ATM IP��ַ */
            public uint dwATMType;/* ATM���� */
            public uint dwInputMode;/* ���뷽ʽ	0-�������� 1-������� 2-����ֱ������ 3-����ATM��������*/
            public uint dwFrameSignBeginPos;/* ���ı�־λ����ʼλ��*/
            public uint dwFrameSignLength;/* ���ı�־λ�ĳ��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byFrameSignContent;/* ���ı�־λ������ */
            public uint dwCardLengthInfoBeginPos;/* ���ų�����Ϣ����ʼλ�� */
            public uint dwCardLengthInfoLength;/* ���ų�����Ϣ�ĳ��� */
            public uint dwCardNumberInfoBeginPos;/* ������Ϣ����ʼλ�� */
            public uint dwCardNumberInfoLength;/* ������Ϣ�ĳ��� */
            public uint dwBusinessTypeBeginPos;/* �������͵���ʼλ�� */
            public uint dwBusinessTypeLength;/* �������͵ĳ��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FRAMETYPECODE[] frameTypeCode;/* ���� */
        }

        //SDK_V31 ATM
        /*��������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILTER
        {
            public byte byEnable;/*0,������;1,����*/
            public byte byMode;/*0,ASCII;1,HEX*/
            public byte byFrameBeginPos;// ���ı�־λ����ʼλ��     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byFilterText;/*�����ַ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*��ʼ��ʶ����*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICAT
        {
            public byte byStartMode;/*0,ASCII;1,HEX*/
            public byte byEndMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_FRAMETYPECODE struStartCode;/*��ʼ�ַ�*/
            public NET_DVR_FRAMETYPECODE struEndCode;/*�����ַ�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        /*������Ϣλ��*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LOCATION
        {
            public byte byOffsetMode;/*0,token;1,fix*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwOffsetPos;/*modeΪ1��ʱ��ʹ��*/
            public NET_DVR_FRAMETYPECODE struTokenCode;/*��־λ*/
            public byte byMultiplierValue;/*��־λ���ٴγ���*/
            public byte byEternOffset;/*���ӵ�ƫ����*/
            public byte byCodeMode;/*0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*������Ϣ����*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PACKAGE_LENGTH
        {
            public byte byLengthMode;/*�������ͣ�0,variable;1,fix;2,get from package(���ÿ��ų���ʹ��)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFixLength;/*modeΪ1��ʱ��ʹ��*/
            public uint dwMaxLength;
            public uint dwMinLength;
            public byte byEndMode;/*�ս��0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_FRAMETYPECODE struEndCode;/*�ս��*/
            public uint dwLengthPos;/*lengthModeΪ2��ʱ��ʹ�ã����ų����ڱ����е�λ��*/
            public uint dwLengthLen;/*lengthModeΪ2��ʱ��ʹ�ã����ų��ȵĳ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*OSD ���ӵ�λ��*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSD_POSITION
        {
            public byte byPositionMode;/*���ӷ�񣬹�2�֣�0������ʾ��1��Custom*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPos_x;/*x���꣬positionmodeΪCustomʱʹ��*/
            public uint dwPos_y;/*y���꣬positionmodeΪCustomʱʹ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*������ʾ��ʽ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DATE_FORMAT
        {
            public byte byItem1;/*Month,0.mm;1.mmm;2.mmmm*/
            public byte byItem2;/*Day,0.dd;*/
            public byte byItem3;/*Year,0.yy;1.yyyy*/
            public byte byDateForm;/*0~5��3��item���������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*�ָ���*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*��ʾ�ָ���*/
            public byte byDisplayForm;/*0~5��3��item���������*///lili mode by lili
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 27, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        /*ʱ����ʾ��ʽ*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVRT_TIME_FORMAT
        {
            public byte byTimeForm;/*1. HH MM SS;0. HH MM*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chSeprator;/*���ķָ�������ʱû��*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string chDisplaySeprator;/*��ʾ�ָ���*/
            public byte byDisplayForm;/*0~5��3��item���������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public byte byDisplayHourMode;/*0,12;1,24*/ //lili mode
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes4;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OVERLAY_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byChannel;/*���ӵ�ͨ��*/
            public uint dwDelayTime;/*������ʱʱ��*/
            public byte byEnableDelayTime;/*�Ƿ����õ�����ʱ�������˿�����ʱ����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_ACTION
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struActionCode;/*�������͵ȶ�Ӧ����*/
            public NET_DVR_FRAMETYPECODE struPreCode;/*�����ַ�ǰ���ַ�*/
            public byte byActionCodeMode;/*�������͵ȶ�Ӧ����0,ASCII;1,HEX*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_DATE
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_DATE_FORMAT struDateForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_TIME
        {
            public NET_DVR_PACKAGE_LOCATION location;
            public NET_DVRT_TIME_FORMAT struTimeForm;
            public NET_DVR_OSD_POSITION struOsdPosition;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PACKAGE_OTHERS
        {
            public NET_DVR_PACKAGE_LOCATION struPackageLocation;
            public NET_DVR_PACKAGE_LENGTH struPackageLength;
            public NET_DVR_OSD_POSITION struOsdPosition;
            public NET_DVR_FRAMETYPECODE struPreCode;/*�����ַ�ǰ���ַ�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //�û��Զ���Э��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_USER_DEFINE_PROTOCOL
        {
            public NET_DVR_IDENTIFICAT        struIdentification;  //���ı�־
            public NET_DVR_FILTER             struFilter; //���ݰ���������
            public NET_DVR_ATM_PACKAGE_OTHERS struCardNoPara; //���ӿ�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ACTION_TYPE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PACKAGE_ACTION[] struTradeActionPara; //���ӽ�����Ϊ���� 0-9 ���ζ�ӦInCard OutCard OverLay SetTime GetStatus Query WithDraw Deposit ChanPass Transfer
            public NET_DVR_ATM_PACKAGE_OTHERS struAmountPara; //���ӽ��׽������
            public NET_DVR_ATM_PACKAGE_OTHERS struSerialNoPara; //���ӽ����������
            public NET_DVR_OVERLAY_CHANNEL    struOverlayChan; //����ͨ������
            public NET_DVR_ATM_PACKAGE_DATE   struRes1; //�������ڣ�����
            public NET_DVR_ATM_PACKAGE_TIME   struRes2; //����ʱ�䣬����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;        //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_FRAMEFORMAT_V30
        {		
            public uint dwSize;                 //�ṹ��С
            public byte byEnable;				/*�Ƿ�����0,������;1,����*/
            public byte byInputMode;			/**���뷽ʽ:0-���������1����Э�顢2-���ڼ�����3-����Э��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //�����ֽ� 
            public NET_DVR_IPADDR struAtmIp;				/*ATM ��IP �������ʱʹ�� */
            public ushort wAtmPort;				/* ����Э�鷽ʽʱ��ʹ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;              // �����ֽ�
            public uint dwAtmType;				/*ATMЭ�����ͣ���NET_DVR_ATM_PROTOCOL�ṹ�л�ȡ���������Ϊ�Զ���ʱʹ���û��Զ���Э��*/
            public NET_DVR_ATM_USER_DEFINE_PROTOCOL  struAtmUserDefineProtocol; //�û��Զ���Э�飬��ATM����Ϊ�Զ�ʱ��Ҫʹ�øö���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        //Э����Ϣ���ݽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTO_TYPE
        {
            public uint dwAtmType; //ATMЭ�����ͣ�ͬʱ��Ϊ������� ATM �����е�dwAtmType �Զ���ʱΪ1025
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = ATM_DESC_LEN)]
            public string chDesc; //ATMЭ�������
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ATM_PROTO_LIST
        {
            public uint dwAtmProtoNum;/*Э���б�ĸ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ATM_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ATM_PROTO_TYPE[] struAtmProtoType;/*Э���б���Ϣ*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATM_PROTOCOL
        {
            public uint dwSize;
            public NET_DVR_ATM_PROTO_LIST struNetListenList;     // �������Э������
            public NET_DVR_ATM_PROTO_LIST struSerialListenList; //���ڼ���Э������
            public NET_DVR_ATM_PROTO_LIST struNetProtoList;     //����Э������
            public NET_DVR_ATM_PROTO_LIST struSerialProtoList;   //����Э������
            public NET_DVR_ATM_PROTO_TYPE struCustomProto;      //�Զ���Э��            
        }

        /*****************************DS-6001D/F(begin)***************************/
        //DS-6001D Decoder
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//�����豸���ӵķ�����IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//�����豸���ӵķ��������û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//�����豸���ӵķ�����������
            public byte bySendMode;//�����豸���ӷ�����������ģʽ
            public byte byEncoderChannel;//�����豸���ӵķ�������ͨ����
            public ushort wEncoderPort;//�����豸���ӵķ������Ķ˿ں�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODERSTATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderIP;//�����豸���ӵķ�����IP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderUser;//�����豸���ӵķ��������û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byEncoderPasswd;//�����豸���ӵķ�����������
            public byte byEncoderChannel;//�����豸���ӵķ�������ͨ����
            public byte bySendMode;//�����豸���ӵķ�����������ģʽ
            public ushort wEncoderPort;//�����豸���ӵķ������Ķ˿ں�
            public uint dwConnectState;//�����豸���ӷ�������״̬
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] reservedData;//����
        }

        /*�����豸�����붨��*/
        public const int NET_DEC_STARTDEC = 1;
        public const int NET_DEC_STOPDEC = 2;
        public const int NET_DEC_STOPCYCLE = 3;
        public const int NET_DEC_CONTINUECYCLE = 4;

        /*���ӵ�ͨ������*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IP��ַ */
            public ushort wDVRPort;/* �˿ں� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            public byte byChannel;/* ͨ���� */
            public byte byLinkMode;/* ����ģʽ */
            public byte byLinkType;/* �������� 0�������� 1�������� */
        }

        /*ÿ������ͨ��������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECINFO
        {
            public byte byPoolChans;/*ÿ·����ͨ���ϵ�ѭ��ͨ������, ���4ͨ�� 0��ʾû�н���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECPOOLNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANINFO[] struchanConInfo;
            public byte byEnablePoll;/*�Ƿ���Ѳ 0-�� 1-��*/
            public byte byPoolTime;/*��Ѳʱ�� 0-���� 1-10�� 2-15�� 3-20�� 4-30�� 5-45�� 6-1���� 7-2���� 8-5���� */
        }

        /*�����豸��������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECCFG
        {
            public uint dwSize;
            public uint dwDecChanNum;/*����ͨ��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECINFO[] struDecInfo;
        }

        //2005-08-01
        /* �����豸͸��ͨ������ */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PORTINFO
        {
            public uint dwEnableTransPort;/* �Ƿ�����͸��ͨ�� 0�������� 1������*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IP��ַ */
            public ushort wDecoderPort;/* �˿ں� */
            public ushort wDVRTransPort;/* ����ǰ��DVR�Ǵ�485/232�����1��ʾ232����,2��ʾ485���� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string cReserve;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PORTCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TRANSPARENTNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PORTINFO[] struTransPortInfo;/* ����0��ʾ232 ����1��ʾ485 */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]               
        public struct bytime
        {
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/*������Ƶ�û���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            public NET_DVR_TIME struStartTime;/* ��ʱ��طŵĿ�ʼʱ�� */
            public NET_DVR_TIME struStopTime;/* ��ʱ��طŵĽ���ʱ�� */
        }

        /* ���������ļ��ط� */
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_PLAYREMOTEFILE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDecoderIP;/* DVR IP��ַ */
            public ushort wDecoderPort;/* �˿ں� */
            public ushort wLoadMode;/* �ط�����ģʽ 1�������� 2����ʱ�� */

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct mode_size
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]             
                public byte[] byFile;/* �طŵ��ļ��� */
                [FieldOffsetAttribute(0)]
                public bytime bytime;
            }
        }



        /*��ǰ�豸��������״̬*/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_DECCHANSTATUS
        {
            public uint dwWorkType;/*������ʽ��1����Ѳ��2����̬���ӽ��롢3���ļ��ط����� 4����ʱ��ط�����*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/*���ӵ��豸ip*/
            public ushort wDVRPort;/*���Ӷ˿ں�*/
            public byte byChannel;/* ͨ���� */
            public byte byLinkMode;/* ����ģʽ */
            public uint dwLinkType;/*�������� 0�������� 1��������*/

            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct objectInfo
            {
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct userInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*������Ƶ�û���*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* ���� */
                    [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 52)]
                    public string cReserve;
                }

                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct fileInfo
                {
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
                    public byte[] fileName;
                }
                [StructLayoutAttribute(LayoutKind.Sequential)]
                public struct timeInfo
                {
                    public uint dwChannel;
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
                    public byte[] sUserName;/*������Ƶ�û���*/
                    [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                    public byte[] sPassword;/* ���� */
                    public NET_DVR_TIME struStartTime;/* ��ʱ��طŵĿ�ʼʱ�� */
                    public NET_DVR_TIME struStopTime;/* ��ʱ��طŵĽ���ʱ�� */
                }
            }
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DECCHANSTATUS[] struTransPortInfo;
        }
        /*****************************DS-6001D/F(end)***************************/

        //���ַ�����(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SHOWSTRINGINFO
        {
            public ushort wShowString;// Ԥ����ͼ�����Ƿ���ʾ�ַ�,0-����ʾ,1-��ʾ �����С704*576,�����ַ��Ĵ�СΪ32*32
            public ushort wStringSize;/* �����ַ��ĳ��ȣ����ܴ���44���ַ� */
            public ushort wShowStringTopLeftX;/* �ַ���ʾλ�õ�x���� */
            public ushort wShowStringTopLeftY;/* �ַ�������ʾλ�õ�y���� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 44)]
            public string sString;/* Ҫ��ʾ���ַ����� */
        }

        //�����ַ�(9000��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* Ҫ��ʾ���ַ����� */
        }

        //�����ַ���չ(8���ַ�)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING_EX
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* Ҫ��ʾ���ַ����� */
        }

        //�����ַ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SHOWSTRING
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_STRINGNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SHOWSTRINGINFO[] struStringInfo;/* Ҫ��ʾ���ַ����� */
        }

        /****************************DS9000�����ṹ(begin)******************************/
        /*EMAIL�����ṹ*/
        //��ԭ�ṹ���в���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struReceiver
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sName;/* �ռ������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAddress;/* �ռ��˵�ַ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sAccount;/* �˺�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_PWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*���� */

            [StructLayoutAttribute(LayoutKind.Sequential)]
            public struct struSender
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sName;/* ���������� */
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
                public byte[] sAddress;/* �����˵�ַ */
            }

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;/* smtp������ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EMAIL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;/* pop3������ */

            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.Struct)]
            public struReceiver[] struStringInfo;/* ����������3���ռ��� */

            public byte byAttachment;/* �Ƿ������ */
            public byte bySmtpServerVerify;/* ���ͷ�����Ҫ�������֤ */
            public byte byMailInterval;/* mail interval */
            public byte byEnableSSL;//ssl�Ƿ�����9000_1.1
            public ushort wSmtpPort;//gmail��465����ͨ��Ϊ25  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 74, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        /*DVRʵ��Ѳ�����ݽṹ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_PARA
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byPresetNo;/* Ԥ�õ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.I1)]
            public byte[] byCruiseSpeed;/* Ѳ���ٶ� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CRUISE_MAX_PRESET_NUMS, ArraySubType = UnmanagedType.U2)]
            public ushort[] wDwellTime;/* ͣ��ʱ�� */
            public byte byEnableThisCruise;/* �Ƿ����� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }
        /****************************DS9000�����ṹ(end)******************************/     
        //ʱ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMEPOINT
        {
            public uint dwMonth;//�� 0-11��ʾ1-12����
            public uint dwWeekNo;//�ڼ��� 0����1�� 1����2�� 2����3�� 3����4�� 4�����һ��
            public uint dwWeekDate;//���ڼ� 0�������� 1������һ 2�����ڶ� 3�������� 4�������� 5�������� 6��������
            public uint dwHour;//Сʱ	��ʼʱ��0��23 ����ʱ��1��23
            public uint dwMin;//��	0��59
        }

        //����ʱ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZONEANDDST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����
            public uint dwEnableDST;//�Ƿ�������ʱ�� 0�������� 1������
            public byte byDSTBias;//����ʱƫ��ֵ��30min, 60min, 90min, 120min, �Է��Ӽƣ�����ԭʼ��ֵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_TIMEPOINT struBeginPoint;//��ʱ�ƿ�ʼʱ��
            public NET_DVR_TIMEPOINT struEndPoint;//��ʱ��ֹͣʱ��
        }

        //ͼƬ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGPARA
        {
            /*ע�⣺��ͼ��ѹ���ֱ���ΪVGAʱ��֧��0=CIF, 1=QCIF, 2=D1ץͼ��
	        ���ֱ���Ϊ3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA,7=XVGA, 8=HD900p
	        ��֧�ֵ�ǰ�ֱ��ʵ�ץͼ*/
            public ushort wPicSize;/* 0=CIF, 1=QCIF, 2=D1 3=UXGA(1600x1200), 4=SVGA(800x600), 5=HD720p(1280x720),6=VGA*/
            public ushort wPicQuality;/* ͼƬ����ϵ�� 0-��� 1-�Ϻ� 2-һ�� */
        }

        /* aux video out parameter */
        //���������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXOUTCFG
        {
            public uint dwSize;
            public uint dwAlarmOutChan;/* ѡ�񱨾������󱨾�ͨ���л�ʱ�䣺1��������ͨ��: 0:�����/1:��1/2:��2/3:��3/4:��4 */
            public uint dwAlarmChanSwitchTime;/* :1�� - 10:10�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAuxSwitchTime;/* ��������л�ʱ��: 0-���л�,1-5s,2-10s,3-20s,4-30s,5-60s,6-120s,7-300s */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXOUT * MAX_WINDOW, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuxOrder;/* �������Ԥ��˳��, 0xff��ʾ��Ӧ�Ĵ��ڲ�Ԥ�� */
        }

        //ntp
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NTPPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sNTPServer;/* Domain Name or IP addr of NTP server */
            public ushort wInterval;/* adjust time interval(hours) */
            public byte byEnableNTP;/* enable NPT client 0-no��1-yes*/
            public byte cTimeDifferenceH;/* ����ʱ�׼ʱ��� Сʱƫ��-12 ... +13 */
            public byte cTimeDifferenceM;/* ����ʱ�׼ʱ��� ����ƫ��0, 30, 45*/
            public byte res1;
            public ushort wNtpPort; /* ntp server port 9000���� �豸Ĭ��Ϊ123*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;
        }

        //ddns
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNS�˺��û���/���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName; /* ���� */
            public byte byEnableDDNS;/*�Ƿ�Ӧ�� 0-��1-��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_EX
        {
            public byte byHostIndex;/* 0-Hikvision DNS 1��Dyndns 2��PeanutHull(������)*/
            public byte byEnableDDNS;/*�Ƿ�Ӧ��DDNS 0-��1-��*/
            public ushort wDDNSPort;/* DDNS�˿ں� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNS�û���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* DDNS���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* �豸�䱸��������ַ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNS ��Ӧ�ķ�������ַ��������IP��ַ������ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //9000��չ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDDNS
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* DDNS�˺��û���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sDomainName;/* �豸�䱸��������ַ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] sServerName;/* DDNSЭ���Ӧ�ķ�������ַ��������IP��ַ������ */
            public ushort wDDNSPort;/* �˿ں� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DDNSPARA_V30
        {
            public byte byEnableDDNS;
            public byte byHostIndex;/* 0-Hikvision DNS(����) 1��Dyndns 2��PeanutHull(������)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DDNS_NUMS, ArraySubType = UnmanagedType.Struct)]
            public struDDNS[] struDDNS;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //email
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EMAILPARA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sUsername;/* �ʼ��˺�/���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sSmtpServer;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sPop3Server;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sMailAddr;/* email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr1;/* �ϴ�����/�쳣�ȵ�email */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] sEventMailAddr2;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //�����������
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETAPPCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDNSIp; /* DNS��������ַ */
            public NET_DVR_NTPPARA struNtpClientParam;/* NTP���� */
            public NET_DVR_DDNSPARA struDDNSClientParam;/* DDNS���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 464, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ���� */
        }

        //nfs�ṹ����
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_SINGLE_NFS
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sNfsHostIPAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNfsDirectory;

            public void Init()
            {
                this.sNfsDirectory = new byte[PATHNAME_LEN];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NFSCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NFS_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NFS[] struNfsDiskParam;

            public void Init()
            {
                this.struNfsDiskParam = new NET_DVR_SINGLE_NFS[MAX_NFS_DISK];

                for (int i = 0; i < MAX_NFS_DISK; i++)
                {
                    struNfsDiskParam[i].Init();
                }
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ISCSI_CFG
        {   
            public uint dwSize;                   // �ṹ��С
            public ushort wVrmPort;                  // VRM �����˿�
            public byte byEnable;                  // �Ƿ����� ISCSI�洢
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                 // �����ֽ�
            public NET_DVR_IPADDR struVrmAddr;          // VRM ip��ַ 16λ
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chNvtIndexCode;        //nvt index Code 
        }

        //Ѳ��������(HIK IP����ר��)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_POINT
        {
            public byte PresetNum;//Ԥ�õ�
            public byte Dwell;//ͣ��ʱ��
            public byte Speed;//�ٶ�
            public byte Reserve;//����

            public void Init()
            {
                PresetNum = 0;
                Dwell = 0;
                Speed = 0;
                Reserve = 0;
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CRUISE_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CRUISE_POINT[] struCruisePoint;//���֧��32��Ѳ����

            public void Init()
            {
                struCruisePoint = new NET_DVR_CRUISE_POINT[32];
                for (int i = 0; i < 32; i++)
                {
                    struCruisePoint[i].Init();
                }
            }
        }

        /************************************��·������(begin)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETCFG_OTHER
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDNSIP;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DECINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IP��ַ */
            public ushort wDVRPort;/* �˿ں� */
            public byte byChannel;/* ͨ���� */
            public byte byTransProtocol;/* ����Э������ 0-TCP, 1-UDP */
            public byte byTransMode;/* ��������ģʽ 0�������� 1��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* ���������½�ʺ� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ����������� */
        }

        //����/ֹͣ��̬����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DYNAMIC_DEC
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ��̬����ͨ����Ϣ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_STATUS
        {
            public uint dwSize;
            public uint dwIsLinked;/* ����ͨ��״̬ 0������ 1���������� 2�������� 3-���ڽ��� */
            public uint dwStreamCpRate;/* Stream copy rate, X kbits/second */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string cRes;/* ���� */
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ����ͨ����Ϣ */
            public uint dwDecState;/* 0-��̬���� 1��ѭ������ 2����ʱ��ط� 3�����ļ��ط� */
            public NET_DVR_TIME StartTime;/* ��ʱ��طſ�ʼʱ�� */
            public NET_DVR_TIME StopTime;/* ��ʱ��ط�ֹͣʱ�� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* ���ļ��ط��ļ��� */
        }

        //���ӵ�ͨ������ 2007-11-05
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHANINFO
        {
            public uint dwEnable;/* �Ƿ����� 0���� 1������*/
            public NET_DVR_MATRIX_DECINFO struDecChanInfo;/* ��ѭ����ͨ����Ϣ */
        }

        //2007-11-05 ����ÿ������ͨ��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO
        {
            public uint dwSize;
            public uint dwPoolTime;/*��Ѳʱ�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_DECCHANINFO[] struchanConInfo;
        }

        //2007-12-22
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct TTY_CONFIG
        {
            public byte baudrate;/* ������ */
            public byte databits;/* ����λ */
            public byte stopbits;/* ֹͣλ */
            public byte parity;/* ��żУ��λ */
            public byte flowcontrol;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO
        {
            public byte byTranChanEnable;/* ��ǰ͸��ͨ���Ƿ�� 0���ر� 1���� */
            /*
             *	��·������������1��485���ڣ�1��232���ڶ�������Ϊ͸��ͨ��,�豸�ŷ������£�
             *	0 RS485
             *	1 RS232 Console
             */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	Զ�̴��������������,һ��RS232��һ��RS485
	         *	1��ʾ232����
	         *	2��ʾ485����
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte res1;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res2;/* ���� */
            public TTY_CONFIG RemoteSerialDevCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ������·232͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ������·485͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*ͬʱ֧�ֽ���MAX_SERIAL_NUM��͸��ͨ��*/
        }

        //2007-12-24 Merry Christmas Eve...
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sDVRIP;/* DVR IP��ַ */
            public ushort wDVRPort;/* �˿ں� */
            public byte byChannel;/* ͨ���� */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/* ���� */
            public uint dwPlayMode;/* 0�����ļ� 1����ʱ��*/
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;/* �������� ���ļ���������*/
            public uint dwCmdParam;/* ����������� */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS
        {
            public uint dwSize;
            public uint dwCurMediaFileLen;/* ��ǰ���ŵ�ý���ļ����� */
            public uint dwCurMediaFilePosition;/* ��ǰ�����ļ��Ĳ���λ�� */
            public uint dwCurMediaFileDuration;/* ��ǰ�����ļ�����ʱ�� */
            public uint dwCurPlayTime;/* ��ǰ�Ѿ����ŵ�ʱ�� */
            public uint dwCurMediaFIleFrames;/* ��ǰ�����ļ�����֡�� */
            public uint dwCurDataType;/* ��ǰ������������ͣ�19-�ļ�ͷ��20-�����ݣ� 21-���Ž�����־ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 72, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //2009-4-11 added by likui ��·������new
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_PASSIVEMODE
        {
            public ushort wTransProtol;//����Э�飬0-TCP, 1-UDP, 2-MCAST
            public ushort wPassivePort;//UDP�˿�, TCPʱĬ��
            // char	sMcastIP[16];		//TCP,UDPʱ��Ч, MCASTʱΪ�ಥ��ַ
            public NET_DVR_IPADDR struMcastIP;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }       

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_INFO_V30
        {
            public byte byTranChanEnable;/* ��ǰ͸��ͨ���Ƿ�� 0���ر� 1���� */
            /*
	         *	��·������������1��485���ڣ�1��232���ڶ�������Ϊ͸��ͨ��,�豸�ŷ������£�
	         *	0 RS485
	         *	1 RS232 Console
	         */
            public byte byLocalSerialDevice;/* Local serial device */
            /*
	         *	Զ�̴��������������,һ��RS232��һ��RS485
	         *	1��ʾ232����
	         *	2��ʾ485����
	         */
            public byte byRemoteSerialDevice;/* Remote output serial device */
            public byte byRes1;/* ���� */
            public NET_DVR_IPADDR struRemoteDevIP;/* Remote Device IP */
            public ushort wRemoteDevPort;/* Remote Net Communication Port */
            public byte byIsEstablished;/* ͸��ͨ�������ɹ���־��0-û�гɹ���1-�����ɹ� */
            public byte byRes2;/* ���� */
            public TTY_CONFIG RemoteSerialDevCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUsername;/* 32BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;/* 16BYTES */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30
        {
            public uint dwSize;
            public byte by232IsDualChan;/* ������·232͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
            public byte by485IsDualChan;/* ������·485͸��ͨ����ȫ˫���� ȡֵ1��MAX_SERIAL_NUM */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] vyRes;/* ���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SERIAL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_TRAN_CHAN_INFO[] struTranInfo;/*ͬʱ֧�ֽ���MAX_SERIAL_NUM��͸��ͨ��*/
        }        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_INFO_V30
        {
            public uint dwEnable;/* �Ƿ����� 0���� 1������*/
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ��ѭ����ͨ����Ϣ */
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_V30
        {
            public uint dwSize;
            public uint dwPoolTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struchanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_MATRIX_DEC_CHAN_INFO_V30
        {
            public uint dwSize;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG streamMediaServerCfg;/*��ý�����������*/
            public NET_DVR_DEV_CHAN_INFO struDevChanInfo;/* ����ͨ����Ϣ */
            public uint dwDecState;/* 0-��̬���� 1��ѭ������ 2����ʱ��ط� 3�����ļ��ط� */
            public NET_DVR_TIME StartTime;/* ��ʱ��طſ�ʼʱ�� */
            public NET_DVR_TIME StopTime;/* ��ʱ��ط�ֹͣʱ�� */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;/* ���ļ��ط��ļ��� */
            public uint dwGetStreamMode;/*ȡ��ģʽ:1-������2-����*/
            public NET_DVR_MATRIX_PASSIVEMODE struPassiveMode;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_RESOLUTIONNUM = 64; //֧�ֵ����ֱ�����Ŀ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY
        {
            public uint dwSize;
            public byte byDecNums;
            public byte byStartChan;
            public byte byVGANums;
            public byte byBNCNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8*12, ArraySubType = UnmanagedType.I1)]
            public byte[] byVGAWindowMode;/*VGA֧�ֵĴ���ģʽ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byBNCWindowMode;/*BNC֧�ֵĴ���ģʽ*/
            public byte byDspNums;   
            public byte byHDMINums;//HDMI��ʾͨ����������25��ʼ��
            public byte byDVINums;//DVI��ʾͨ����������29��ʼ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESOLUTIONNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] bySupportResolution;//���������ö�ٶ���,һ���ֽڴ���һ���ֱ�����//��֧�֣�1��֧�֣�0����֧��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byHDMIWindowMode;//HDMI֧�ֵĴ���ģʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4*8, ArraySubType = UnmanagedType.I1)]
            public byte[] byDVIWindowMode;//DVI֧�ֵĴ���ģʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //�ϴ�logo�ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_LOGOCFG
        {
            public uint dwCorordinateX;//ͼƬ��ʾ����X����
            public uint dwCorordinateY;//ͼƬ��ʾ����Y����
            public ushort wPicWidth; //ͼƬ��
            public ushort wPicHeight; //ͼƬ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byFlash;//�Ƿ���˸1-��˸��0-����˸
            public byte byTranslucent;//�Ƿ��͸��1-��͸����0-����͸��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//����
            public uint dwLogoSize;//LOGO��С������BMP���ļ�ͷ
        }

        /*��������*/
        public const int NET_DVR_ENCODER_UNKOWN = 0;/*δ֪�����ʽ*/
        public const int NET_DVR_ENCODER_H264 = 1;/*HIK 264*/
        public const int NET_DVR_ENCODER_S264 = 2;/*Standard H264*/
        public const int NET_DVR_ENCODER_MPEG4 = 3;/*MPEG4*/
        public const int NET_DVR_ORIGINALSTREAM = 4;/*Original Stream*/
        public const int NET_DVR_PICTURE = 5;//*Picture*/
        public const int NET_DVR_ENCODER_MJPEG = 6;
        public const int NET_DVR_ECONDER_MPEG2 = 7;
        /* �����ʽ */
        public const int NET_DVR_STREAM_TYPE_UNKOWN = 0;/*δ֪�����ʽ*/
        public const int NET_DVR_STREAM_TYPE_HIKPRIVT = 1; /*�����Զ�������ʽ*/
        public const int NET_DVR_STREAM_TYPE_TS = 7;/* TS��� */
        public const int NET_DVR_STREAM_TYPE_PS = 8;/* PS��� */
        public const int NET_DVR_STREAM_TYPE_RTP = 9;/* RTP��� */

        /*����ͨ��״̬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CHAN_STATUS
        {
            public byte byDecodeStatus;/*��ǰ״̬:0:δ������1����������*/
            public byte byStreamType;/*��������*/
            public byte byPacketType;/*�����ʽ*/
            public byte byRecvBufUsage;/*���ջ���ʹ����*/
            public byte byDecBufUsage;/*���뻺��ʹ����*/
            public byte byFpsDecV;/*��Ƶ����֡��*/
            public byte byFpsDecA;/*��Ƶ����֡��*/
            public byte byCpuLoad;/*DSP CPUʹ����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDecodedV;/*�������Ƶ֡*/
            public uint dwDecodedA;/*�������Ƶ֡*/
            public ushort wImgW;/*��������ǰ��ͼ���С,��*/
            public ushort wImgH; //��
            public byte byVideoFormat;/*��Ƶ��ʽ:0-NON,NTSC--1,PAL--2*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public uint dwDecChan; /*��ȡȫ������ͨ��״̬ʱ��Ч������ʱ����0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
        }

        /*��ʾͨ��״̬*/
        public const int NET_DVR_MAX_DISPREGION = 16;         /*ÿ����ʾͨ����������ʾ�Ĵ���*/
        //VGA�ֱ��ʣ�Ŀǰ���õ��ǣ�VGA_THS8200_MODE_XGA_60HZ��VGA_THS8200_MODE_SXGA_60HZ��
        //
        public enum VGA_MODE
        {
            /*VGA*/
            VGA_NOT_AVALIABLE,
            VGA_THS8200_MODE_SVGA_60HZ,    //(800*600)
            VGA_THS8200_MODE_SVGA_75HZ,    //(800*600)
            VGA_THS8200_MODE_XGA_60HZ,     //(1024*768)
            VGA_THS8200_MODE_XGA_75HZ,     //(1024*768)
            VGA_THS8200_MODE_SXGA_60HZ,    //(1280*1024)
            VGA_THS8200_MODE_720P_60HZ,    //(1280*720)
            VGA_THS8200_MODE_1080I_60HZ,   //(1920*1080)
            VGA_THS8200_MODE_1080P_30HZ,   //(1920*1080)
            VGA_THS8200_MODE_UXGA_30HZ,    //(1600*1200)
            /*HDMI*/
            HDMI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            HDMI_SII9134_MODE_SXGA_60HZ,   //(1280*1024)
            HDMI_SII9134_MODE_SXGA2_60HZ,  //(1280*960)
            HDMI_SII9134_MODE_720P_60HZ,   //(1280*720)	
            HDMI_SII9134_MODE_720P_50HZ,   //(1280*720)		
            HDMI_SII9134_MODE_1080I_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080I_50HZ,  //(1920*1080)	
            HDMI_SII9134_MODE_1080P_25HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_30HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_50HZ,  //(1920*1080)
            HDMI_SII9134_MODE_1080P_60HZ,  //(1920*1080)
            HDMI_SII9134_MODE_UXGA_60HZ,   //(1600*1200)
            /*DVI*/
            DVI_SII9134_MODE_XGA_60HZ,	   //(1024*768)
            DVI_SII9134_MODE_SXGA_60HZ,	   //(1280*1024)
            DVI_SII9134_MODE_SXGA2_60HZ,   //(1280*960)
            DVI_SII9134_MODE_720P_60HZ,	   //(1280*720)	
            DVI_SII9134_MODE_720P_50HZ,    //(1280*720)		
            DVI_SII9134_MODE_1080I_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080I_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_25HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_30HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_50HZ,   //(1920*1080)
            DVI_SII9134_MODE_1080P_60HZ,   //(1920*1080)
            DVI_SII9134_MODE_UXGA_60HZ,     //(1600*1200)
            VGA_DECSVR_MODE_SXGA2_60HZ,
            HDMI_DECSVR_MODE_1080P_24HZ,
            DVI_DECSVR_MODE_1080P_24HZ,
            YPbPr_DECSVR_MODE_720P_60HZ,
            YPbPr_DECSVR_MODE_1080I_60HZ
        }

        //��֡�ʶ���
        public const int LOW_DEC_FPS_1_2 = 51;
        public const int LOW_DEC_FPS_1_4 = 52;
        public const int LOW_DEC_FPS_1_8 = 53;
        public const int LOW_DEC_FPS_1_16 = 54;

        /*��Ƶ��ʽ��׼*/
        public enum VIDEO_STANDARD
        {
            VS_NON = 0,
            VS_NTSC = 1,
            VS_PAL = 2,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM
        {
            /*�����Ӵ��ڶ�Ӧ����ͨ������Ӧ�Ľ�����ϵͳ�Ĳ�λ��(������Ƶ�ۺ�ƽ̨�н�����ϵͳ��Ч)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG
        {
            public uint dwSize;
            public byte byAudio;/*��Ƶ�Ƿ���,0-��1-��*/
            public byte byAudioWindowIdx;/*��Ƶ�����Ӵ���*/
            public byte byVgaResolution;/*VGA�ķֱ���*/
            public byte byVedioFormat;/*��Ƶ��ʽ��1:NTSC,2:PAL,0-NON*/
            public uint dwWindowMode;/*����ģʽ�������������ȡ��Ŀǰ֧��1,2,4,9,16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
            public byte byEnlargeStatus;          /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
            public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�
	        [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
                 public byte[] byRes;

                [FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM struNotVideoPlatform;
            }
            public byte byUnionType;/*���ֹ����壬0-��Ƶ�ۺ�ƽ̨�ڲ���������ʾͨ�����ã�1-������������ʾͨ������*/
            public byte byScale; /*��ʾģʽ��0---��ʵ��ʾ��1---������ʾ( ���BNC )*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS
        {
            public byte byDispStatus;/*��ʾ״̬��0��δ��ʾ��1��������ʾ*/
            public byte byBVGA; /*VGA/BNC*/
            public byte byVideoFormat;/*��Ƶ��ʽ:1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;/*��ǰ����ģʽ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NET_DVR_MAX_DISPREGION, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;/*ÿ���ӻ������ʾ֡��*/
            public byte byScreenMode;			//��Ļģʽ0-��ͨ 1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_DECODECHANNUM = 32;//��·������������ͨ����
        public const int MAX_DISPCHANNUM = 24;//��·�����������ʾͨ����

        /*�������豸״̬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DECODECHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;/*����ͨ��״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPCHANNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS[] struDispChanStatus;/*��ʾͨ��״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMIN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;/*��������״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ANALOG_ALARMOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAalarmOutStatus;/*�������״̬*/
            public byte byAudioInChanStatus;/*�����Խ�״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2009-12-1 ���ӱ������벥�ſ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PASSIVEDECODE_CONTROL
        {
            public uint dwSize;
            public uint dwPlayCmd;		/* �������� ���ļ���������*/
            public uint dwCmdParam;		/* ����������� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//Reverse
        }

        public const int PASSIVE_DEC_PAUSE = 1;	/*����������ͣ(���ļ�����Ч)*/
        public const int PASSIVE_DEC_RESUME = 2;	/*�ָ���������(���ļ�����Ч)*/
        public const int PASSIVE_DEC_FAST = 3;   /*���ٱ�������(���ļ�����Ч)*/
        public const int PASSIVE_DEC_SLOW = 4;   /*���ٱ�������(���ļ�����Ч)*/
        public const int PASSIVE_DEC_NORMAL = 5;   /*������������(���ļ�����Ч)*/
        public const int PASSIVE_DEC_ONEBYONE =	6;  /*�������뵥֡����(����)*/
        public const int PASSIVE_DEC_AUDIO_ON = 7;   /*��Ƶ����*/
        public const int PASSIVE_DEC_AUDIO_OFF = 8; 	 /*��Ƶ�ر�*/
        public const int PASSIVE_DEC_RESETBUFFER = 9;    /*��ջ�����*/

        //2009-12-16 ���ӿ��ƽ���������ͨ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DECCHAN_CONTROL
        {        
            public uint dwSize;
            public byte byDecChanScaleStatus;/*����ͨ����ʾ���ſ���,1��ʾ������ʾ��0��ʾ��ʵ��ʾ*/
            public byte byDecodeDelay;//������ʱ��0-Ĭ�ϣ�1-ʵʱ�Ժã�2-ʵʱ�ԽϺã�3-ʵʱ���У��������У�4-�����ԽϺã�5-�����Ժã�0xff-�Զ�����   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 66, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }
        /************************************��·������(end)***************************************/

        /************************************��Ƶ�ۺ�ƽ̨(begin)***************************************/
        public const int MAX_SUBSYSTEM_NUM = 80;   //һ������ϵͳ�������ϵͳ����
        public const int MAX_SUBSYSTEM_NUM_V40 = 120;   //һ������ϵͳ�������ϵͳ����
        public const int MAX_SERIALLEN = 36;  //������кų���
        public const int MAX_LOOPPLANNUM = 16;  //���ƻ��л���
        public const int DECODE_TIMESEGMENT = 4;     //�ƻ�����ÿ��ʱ�����

        public const int MAX_DOMAIN_NAME = 64;  /* ����������� */
        public const int MAX_DISKNUM_V30 = 33; //9000�豸���Ӳ����/* ���33��Ӳ��(����16������SATAӲ�̡�1��eSATAӲ�̺�16��NFS��) */
        public const int MAX_DAYS = 7;       //ÿ������
        public const int MAX_DISPNUM_V41 = 32;
        public const int MAX_WINDOWS_NUM = 12;
        public const int MAX_VOUTNUM = 32;
        public const int MAX_SUPPORT_RES = 32;
        public const int MAX_BIGSCREENNUM = 100;

        public const int VIDEOPLATFORM_ABILITY = 0x210; //��Ƶ�ۺ�ƽ̨������
        public const int MATRIXDECODER_ABILITY_V41 = 0x260; //������������

        public const int NET_DVR_MATRIX_BIGSCREENCFG_GET = 1140;//��ȡ����ƴ�Ӳ���        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEMINFO
        {
            public byte bySubSystemType;//��ϵͳ���ͣ�1-��������ϵͳ��2-��������ϵͳ��0-NULL���˲���ֻ�ܻ�ȡ��
            public byte byChan;//��ϵͳͨ�������˲���ֻ�ܻ�ȡ��
            public byte byLoginType;//ע�����ͣ�1-ֱ����2-DNS��3-������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struSubSystemIP;/*IP��ַ�����޸ģ�*/
            public ushort wSubSystemPort;//��ϵͳ�˿ںţ����޸ģ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_IPADDR struSubSystemIPMask;//��������
            public NET_DVR_IPADDR struGatewayIpAddr;	/* ���ص�ַ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;/* �û��� ���˲���ֻ�ܻ�ȡ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;/*���루�˲���ֻ�ܻ�ȡ��*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDomainName;//����(���޸�)
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_DOMAIN_NAME)]
            public string sDnsAddress;/*DNS������IP��ַ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//���кţ��˲���ֻ�ܻ�ȡ��
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLSUBSYSTEMINFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEMINFO[] struSubSystemInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOOPPLAN_SUBCFG
        {
            public uint dwSize;
            public uint dwPoolTime; /*��ѯ�������λ����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_INFO_V30[] struChanConInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]            
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARMMODECFG
        {
            public uint dwSize;
            public byte byAlarmMode;//�����������ͣ�1-��ѯ��2-���� 
            public ushort wLoopTime;//��ѯʱ��, ��λ���� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CODESPLITTERINFO
        {
            public uint dwSize;
            public NET_DVR_IPADDR struIP;/*�����IP��ַ*/
            public ushort wPort;//������˿ں�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]             
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)] 
            public byte[] sUserName;/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)] 
            public byte[] sPassword;/*���� */
            public byte byChan;//�����485��
            public byte by485Port;//485�ڵ�ַ      
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ASSOCIATECFG
        {
            public byte byAssociateType;//�������ͣ�1-����
            public ushort wAlarmDelay;//������ʱ��0��5�룻1��10�룻2��30�룻3��1���ӣ�4��2���ӣ�5��5���ӣ�6��10���ӣ�
            public byte byAlarmNum;//�����ţ������ֵ��Ӧ�ø�����ͬ�ı�������ͬ��ֵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DYNAMICDECODE
        {
            public uint dwSize;
            public NET_DVR_ASSOCIATECFG struAssociateCfg;//������̬��������ṹ
            public NET_DVR_PU_STREAM_CFG struPuStreamCfg;//��̬����ṹ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODESCHED
        {
            public NET_DVR_SCHEDTIME struSchedTime;
            public byte byDecodeType;/*0-�ޣ�1-��ѯ���룬2-��̬����*/
            public byte byLoopGroup;//��ѯ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)] 
            public byte[] byRes;
            public NET_DVR_PU_STREAM_CFG struDynamicDec;//��̬����
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLANDECODE
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * DECODE_TIMESEGMENT, ArraySubType = UnmanagedType.I1)] 
            public NET_DVR_DECODESCHED[] struDecodeSched;//��һ��Ϊ��ʼ����9000һ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)] 
            public byte[] byres;
        }
        /************************************��Ƶ�ۺ�ƽ̨(end)***************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;//������ϵͳ����
            public byte byDecodeSubSystemNums;//������ϵͳ����
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byWindowMode; /*��ʾͨ��֧�ֵĴ���ģʽ*/
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;
        }

        

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SUBSYSTEM_ABILITY
        {
            /*��ϵͳ���ͣ�1-��������ϵͳ��2-��������ϵͳ��3-���������ϵͳ��4-����������ϵͳ��5-�������ϵͳ��6-����������ϵͳ��7-������ϵͳ��8-V6������ϵͳ��9-V6��ϵͳ��0-NULL���˲���ֻ�ܻ�ȡ��*/
            public byte bySubSystemType;
            public byte byChanNum;//��ϵͳͨ����
            public byte byStartChan;//��ϵͳ��ʼͨ����
            public byte bySlotNum;//��λ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public struDecoderSystemAbility _struAbility;
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struDecoderSystemAbility
        {
            public byte byVGANums;//VGA��ʾͨ����������1��ʼ��
            public byte byBNCNums;//BNC��ʾͨ����������9��ʼ��
            public byte byHDMINums;//HDMI��ʾͨ����������25��ʼ��
            public byte byDVINums;//DVI��ʾͨ����������29��ʼ��

            public byte byLayerNums;//����ƴ���У�������ʱ��֧��ͼ����
            public byte bySpartan;//���Թ��ܣ�0-��֧�֣�1-֧��
            public byte byDecType; //������ϵͳ���ͣ�0-��ͨ��,1-��ǿ��(��ͨ�ͷ���ʱǰ4������ʹ��������Դ����ǿ���޴����ƣ���ǿ�����ɱ�������ϵͳ��16·D1������Դ
            //��ǿ�ͱ���������Ϊ��������Դ�ɱ����ã���ͨ�����ܱ�����)
            public byte byOutputSwitch;//�Ƿ�֧��HDMI/DVI�����л���0-��֧�֣�1-֧��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDecoderType; //���������  0-��ͨ����� 1-���ܽ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct struAbility
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            //  [FieldOffsetAttribute(0)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPLATFORM_ABILITY_V40
        {
            public uint dwSize;
            public byte byCodeSubSystemNums;
            public byte byDecodeSubSystemNums;//������ϵͳ����
            public byte bySupportNat;//�Ƿ�֧��NAT��0-��֧�֣�1-֧��
            public byte byInputSubSystemNums;//����������ϵͳ����
            public byte byOutputSubSystemNums;//���������ϵͳ����
            public byte byCodeSpitterSubSystemNums;//�����ϵͳ����
            public byte byAlarmHostSubSystemNums;//������ϵͳ����
            public byte bySupportBigScreenNum;//��֧�������ɴ����ĸ���
            public byte byVCASubSystemNums;//������ϵͳ����
            public byte byV6SubSystemNums;//V6��ϵͳ����
            public byte byV6DecoderSubSystemNums;//V6������ϵͳ����
            public byte bySupportBigScreenX;/*����ƴ�ӵ�ģʽ��m��n*/
            public byte bySupportBigScreenY;
            public byte bySupportSceneNums;//֧�ֳ���ģʽ�ĸ���
            public byte byVcaSupportChanMode;//����֧�ֵ�ͨ��ʹ��ģʽ��0-ʹ�ý���ͨ����1-ʹ����ʾͨ������ͨ����
            public byte bySupportScreenNums;//��֧�ֵĴ�������Ļ������
            public byte bySupportLayerNums;//��֧�ֵ�ͼ������0xff-��Ч
            public byte byNotSupportPreview;//�Ƿ�֧��Ԥ��,1-��֧�֣�0-֧��
            public byte byNotSupportStorage;//�Ƿ�֧�ִ洢,1-��֧�֣�0-֧��
            public byte byUploadLogoMode;//�ϴ�logoģʽ��0-�ϴ�������ͨ����1-�ϴ�����ʾͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUBSYSTEM_NUM_V40, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SUBSYSTEM_ABILITY[] struSubSystemAbility;
            public byte by485Nums;//485���ڸ���
            public byte by232Nums;//232���ڸ���
            public byte bySerieStartChan;//��ʼͨ��
            public byte byScreenMode;//����ģʽ��0-�����ɿͻ��˷��䣬1-�������豸�˷���
            public byte byDevVersion;//�豸�汾��0-B10/B11/B12��1-B20
            public byte bySupportBaseMapNums;//��֧�ֵĵ�ͼ������ͼ�Ŵ�1��ʼ
            public ushort wBaseLengthX;//ÿ������С�Ļ�׼ֵ��B20ʹ��
            public ushort wBaseLengthY;
            public byte bySupportPictureTrans;  //�Ƿ�֧��ͼƬ���ԣ�0-��֧�֣�1-֧��	
            public byte bySupportPreAllocDec;   //�Ƿ�֧�����ܽ�����ԴԤ���䣬0-��֧�֣�1-֧��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 628, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }       

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLESCREENCFG
        {
            public byte byScreenSeq;//��Ļ��ţ�0xff��ʾ���ô���,64-T��������һ����ʾ����
            public byte bySubSystemNum;//������ϵͳ��λ��,��������ֵû����
            public byte byDispNum;//������ϵͳ�϶�Ӧ��ʾͨ���ţ�64-T�������и�ֵ��ʾ����������ʾͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG
        {
            public uint dwSize;
            public byte byEnable;//����ƴ��ʹ�ܣ�0-��ʹ�ܣ�1-ʹ��
            public byte byModeX;/*����ƴ��ģʽ*/
            public byte byModeY;
            public byte byMainDecodeSystem;//�ۺ�ƽ̨�Ľ�����и�ֵ��ʾ������λ�ţ�64-T�������и�ֵ��ʾ����ͨ����
            public byte byMainDecoderDispChan;//����������ʾͨ���ţ�1.1netra�汾������netra��������������ʾͨ�������ܹ���Ϊ������64-T�и�ֵ��Ч
            public byte byVideoStandard;      //����ÿ��������ʽ��ͬ 1:NTSC,2:PAL
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwResolution;         //����ÿ�������ֱ�����ͬ
            //����ƴ�Ӵ���Ļ��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BIGSCREENNUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLESCREENCFG[] struFollowSingleScreen;
            //��ʼ�������Ϊ��׼�����������
            public ushort wBigScreenX; //�����ڵ���ǽ����ʼX����
            public ushort wBigScreenY; //�����ڵ���ǽ����ʼY����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            public void Init()
            {
                byRes1 = new byte[2];
                struFollowSingleScreen = new NET_DVR_SINGLESCREENCFG[MAX_BIGSCREENNUM];
                byRes2 = new byte[12];
            }
        }       

        /************************************��Ƶ�ۺ�ƽ̨(end)***************************************/
        
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_EMAILCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sPassWord;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sFromName;/* Sender *///�ַ����еĵ�һ���ַ������һ���ַ�������"@",�����ַ�����Ҫ��"@"�ַ�
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sFromAddr;/* Sender address */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName1;/* Receiver1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sToName2;/* Receiver2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr1;/* Receiver address1 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 48)]
            public string sToAddr2;/* Receiver address2 */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sEmailServer;/* Email server address */
            public byte byServerType;/* Email server type: 0-SMTP, 1-POP, 2-IMTP��*/
            public byte byUseAuthen;/* Email server authentication method: 1-enable, 0-disable */
            public byte byAttachment;/* enable attachment */
            public byte byMailinterval;/* mail interval 0-2s, 1-3s, 2-4s. 3-5s*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_NEW
        {
            public uint dwSize;
            public NET_DVR_COMPRESSION_INFO_EX struLowCompression;//��ʱ¼��
            public NET_DVR_COMPRESSION_INFO_EX struEventCompression;//�¼�����¼��
        }

        //���λ����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZPOS
        {
            public ushort wAction;//��ȡʱ���ֶ���Ч
            public ushort wPanPos;//ˮƽ����
            public ushort wTiltPos;//��ֱ����
            public ushort wZoomPos;//�䱶����
        }

        //�����Χ��Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZSCOPE
        {
            public ushort wPanPosMin;//ˮƽ����min
            public ushort wPanPosMax;//ˮƽ����max
            public ushort wTiltPosMin;//��ֱ����min
            public ushort wTiltPosMax;//��ֱ����max
            public ushort wZoomPosMin;//�䱶����min
            public ushort wZoomPosMax;//�䱶����max
        }

        //rtsp���� ipcameraר��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RTSPCFG
        {
            public uint dwSize;//����
            public ushort wPort;//rtsp�����������˿�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byReserve;//Ԥ��
        }

        /********************************�ӿڲ����ṹ(begin)*********************************/

        //NET_DVR_Login()�����ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//���к�
            public byte byAlarmInPortNum;//DVR�����������
            public byte byAlarmOutPortNum;//DVR�����������
            public byte byDiskNum;//DVRӲ�̸���
            public byte byDVRType;//DVR����, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;//DVR ͨ������
            public byte byStartChan;//��ʼͨ����,����DVS-1,DVR - 1
        }

        //NET_DVR_Login_V30()�����ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;  //���к�
            public byte byAlarmInPortNum;		        //�����������
            public byte byAlarmOutPortNum;		        //�����������
            public byte byDiskNum;				    //Ӳ�̸���
            public byte byDVRType;				    //�豸����, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				    //ģ��ͨ������
            public byte byStartChan;			        //��ʼͨ����,����DVS-1,DVR - 1
            public byte byAudioChanNum;                //����ͨ����
            public byte byIPChanNum;					//�������ͨ����������λ  
            public byte byZeroChanNum;			//��ͨ��������� //2010-01-16
            public byte byMainProto;			//����������Э������ 0-private, 1-rtsp,2-ͬʱ֧��private��rtsp
            public byte bySubProto;				//����������Э������0-private, 1-rtsp,2-ͬʱ֧��private��rtsp
            public byte bySupport;        //������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧�֣�
            //bySupport & 0x1, ��ʾ�Ƿ�֧����������
            //bySupport & 0x2, ��ʾ�Ƿ�֧�ֱ���
            //bySupport & 0x4, ��ʾ�Ƿ�֧��ѹ������������ȡ
            //bySupport & 0x8, ��ʾ�Ƿ�֧�ֶ�����
            //bySupport & 0x10, ��ʾ֧��Զ��SADP
            //bySupport & 0x20, ��ʾ֧��Raid������
            //bySupport & 0x40, ��ʾ֧��IPSAN Ŀ¼����
	        //bySupport & 0x80, ��ʾ֧��rtp over rtsp
            public byte bySupport1;        // ���������䣬λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
	        //bySupport1 & 0x1, ��ʾ�Ƿ�֧��snmp v30
	        //bySupport1 & 0x2, ֧�����ֻطź�����
	        //bySupport1 & 0x4, �Ƿ�֧�ֲ������ȼ�	
	        //bySupport1 & 0x8, �����豸�Ƿ�֧�ֲ���ʱ�����չ
	        //bySupport1 & 0x10, ��ʾ�Ƿ�֧�ֶ������������33����
	        //bySupport1 & 0x20, ��ʾ�Ƿ�֧��rtsp over http	
	        //bySupport1 & 0x80, ��ʾ�Ƿ�֧�ֳ����±�����Ϣ2012-9-28, �һ���ʾ�Ƿ�֧��NET_DVR_IPPARACFG_V40�ṹ��
            public byte bySupport2; /*������λ����Ϊ0��ʾ��֧�֣���0��ʾ֧��							
							bySupport2 & 0x1, ��ʾ�������Ƿ�֧��ͨ��URLȡ������
							bySupport2 & 0x2,  ��ʾ֧��FTPV40
							bySupport2 & 0x4,  ��ʾ֧��ANR
							bySupport2 & 0x8,  ��ʾ֧��CCD��ͨ����������
							bySupport2 & 0x10,  ��ʾ֧�ֲ��������ش���Ϣ����֧��ץ�Ļ����� ���ϱ����ṹ��
							bySupport2 & 0x20,  ��ʾ�Ƿ�֧�ֵ�����ȡ�豸״̬����
							bySupport2 & 0x40,  ��ʾ�Ƿ������������豸*/
            public ushort wDevType;              //�豸�ͺ�
            public byte bySupport3; //��������չ��λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
							//bySupport3 & 0x1, ��ʾ�Ƿ������
							// bySupport3 & 0x4 ��ʾ֧�ְ������ã� ������� ͨ��ͼ��������������������IP�������롢������������
                            // �û��������豸����״̬��JPEGץͼ����ʱ��ʱ��ץͼ��Ӳ��������� 
							//bySupport3 & 0x8Ϊ1 ��ʾ֧��ʹ��TCPԤ����UDPԤ�����ಥԤ���е�"��ʱԤ��"�ֶ���������ʱԤ������������ʹ�����ַ�ʽ������ʱԤ����������bySupport3 & 0x8Ϊ0ʱ����ʹ�� "˽����ʱԤ��"Э�顣
							//bySupport3 & 0x10 ��ʾ֧��"��ȡ����������Ҫ״̬��V40��"��
							//bySupport3 & 0x20 ��ʾ�Ƿ�֧��ͨ��DDNS��������ȡ��

            public byte byMultiStreamProto;//�Ƿ�֧�ֶ�����,��λ��ʾ,0-��֧��,1-֧��,bit1-����3,bit2-����4,bit7-��������bit-8������
            public byte byStartDChan;		//��ʼ����ͨ����,0��ʾ��Ч
            public byte byStartDTalkChan;	//��ʼ���ֶԽ�ͨ���ţ�������ģ��Խ�ͨ���ţ�0��ʾ��Ч
            public byte byHighDChanNum;		//����ͨ����������λ
            public byte bySupport4;
            public byte byLanguageType;// ֧����������,��λ��ʾ,ÿһλ0-��֧��,1-֧��  
						//  byLanguageType ����0 ��ʾ ���豸
						//  byLanguageType & 0x1��ʾ֧������
						//  byLanguageType & 0x2��ʾ֧��Ӣ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		//����
        }

        //sdk���绷��ö�ٱ���������Զ������
        public enum SDK_NETWORK_ENVIRONMENT
        {
            LOCAL_AREA_NETWORK = 0,
            WIDE_AREA_NETWORK,
        }

        //��ʾģʽ
        public enum DISPLAY_MODE
        {
            NORMALMODE = 0,
            OVERLAYMODE
        }

        //����ģʽ
        public enum SEND_MODE
        {
            PTOPTCPMODE = 0,
            PTOPUDPMODE,
            MULTIMODE,
            RTPMODE,
            RESERVEDMODE
        }

        //ץͼģʽ
        public enum CAPTURE_MODE
        {
            BMP_MODE = 0,		//BMPģʽ
            JPEG_MODE = 1		//JPEGģʽ 
        }

        //ʵʱ����ģʽ
        public enum REALSOUND_MODE
        {
            MONOPOLIZE_MODE = 1,//��ռģʽ
            SHARE_MODE = 2		//����ģʽ
        }

        public struct NET_DVR_CLIENTINFO
        {
            public Int32 lChannel;//ͨ����
            public Int32 lLinkMode;//���λ(31)Ϊ0��ʾ��������Ϊ1��ʾ��������0��30λ��ʾ�������ӷ�ʽ: 0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-����Ƶ�ֿ�(TCP)
            public IntPtr hPlayWnd;//���Ŵ��ڵľ��,ΪNULL��ʾ������ͼ��
            public string sMultiCastIP;//�ಥ���ַ
        }

        //SDK״̬��Ϣ(9000����)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKSTATE
        {
            public uint dwTotalLoginNum;//��ǰlogin�û���
            public uint dwTotalRealPlayNum;//��ǰrealplay·��
            public uint dwTotalPlayBackNum;//��ǰ�طŻ�����·��
            public uint dwTotalAlarmChanNum;//��ǰ��������ͨ��·��
            public uint dwTotalFormatNum;//��ǰӲ�̸�ʽ��·��
            public uint dwTotalFileSearchNum;//��ǰ��־���ļ�����·��
            public uint dwTotalLogSearchNum;//��ǰ��־���ļ�����·��
            public uint dwTotalSerialNum;//��ǰ͸��ͨ��·��
            public uint dwTotalUpgradeNum;//��ǰ����·��
            public uint dwTotalVoiceComNum;//��ǰ����ת��·��
            public uint dwTotalBroadCastNum;//��ǰ�����㲥·��
            public uint dwTotalListenNum;	    //��ǰ�������·��
            public uint dwEmailTestNum;       //��ǰ�ʼ�����·��
            public uint dwBackupNum;          // ��ǰ�ļ�����·��
            public uint dwTotalInquestUploadNum; //��ǰ��Ѷ�ϴ�·��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //SDK����֧����Ϣ(9000����)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SDKABL
        {
            public uint dwMaxLoginNum;//���login�û��� MAX_LOGIN_USERS
            public uint dwMaxRealPlayNum;//���realplay·�� WATCH_NUM
            public uint dwMaxPlayBackNum;//���طŻ�����·�� WATCH_NUM
            public uint dwMaxAlarmChanNum;//���������ͨ��·�� ALARM_NUM
            public uint dwMaxFormatNum;//���Ӳ�̸�ʽ��·�� SERVER_NUM
            public uint dwMaxFileSearchNum;//����ļ�����·�� SERVER_NUM
            public uint dwMaxLogSearchNum;//�����־����·�� SERVER_NUM
            public uint dwMaxSerialNum;//���͸��ͨ��·�� SERVER_NUM
            public uint dwMaxUpgradeNum;//�������·�� SERVER_NUM
            public uint dwMaxVoiceComNum;//�������ת��·�� SERVER_NUM
            public uint dwMaxBroadCastNum;//��������㲥·�� MAX_CASTNUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        //�����豸��Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ALARMER
        {
            public byte byUserIDValid;/* userid�Ƿ���Ч 0-��Ч��1-��Ч */
            public byte bySerialValid;/* ���к��Ƿ���Ч 0-��Ч��1-��Ч */
            public byte byVersionValid;/* �汾���Ƿ���Ч 0-��Ч��1-��Ч */
            public byte byDeviceNameValid;/* �豸�����Ƿ���Ч 0-��Ч��1-��Ч */
            public byte byMacAddrValid; /* MAC��ַ�Ƿ���Ч 0-��Ч��1-��Ч */
            public byte byLinkPortValid;/* login�˿��Ƿ���Ч 0-��Ч��1-��Ч */
            public byte byDeviceIPValid;/* �豸IP�Ƿ���Ч 0-��Ч��1-��Ч */
            public byte bySocketIPValid;/* socket ip�Ƿ���Ч 0-��Ч��1-��Ч */
            public int lUserID; /* NET_DVR_Login()����ֵ, ����ʱ��Ч */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;/* ���к� */
            public uint dwDeviceVersion;/* �汾��Ϣ ��16λ��ʾ���汾����16λ��ʾ�ΰ汾*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string sDeviceName;/* �豸���� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;/* MAC��ַ */
            public ushort wLinkPort; /* link port */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sDeviceIP;/* IP��ַ */
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sSocketIP;/* ���������ϴ�ʱ��socket IP��ַ */
            public byte byIpProtocol; /* IpЭ�� 0-IPV4, 1-IPV6 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //Ӳ������ʾ�������(�ӽṹ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_PARA
        {
            public int bToScreen;
            public int bToVideoOut;
            public int nLeft;
            public int nTop;
            public int nWidth;
            public int nHeight;
            public int nReserved;
        }

        //Ӳ����Ԥ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CARDINFO
        {
            public int lChannel;//ͨ����
            public int lLinkMode;//���λ(31)Ϊ0��ʾ��������Ϊ1��ʾ�ӣ�0��30λ��ʾ�������ӷ�ʽ:0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-�绰�ߣ�5��128k�����6��256k�����7��384k�����8��512k�����
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string sMultiCastIP;
            public NET_DVR_DISPLAY_PARA struDisplayPara;
        }

        //¼���ļ�����
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FIND_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//�ļ���
            public NET_DVR_TIME struStartTime;//�ļ��Ŀ�ʼʱ��
            public NET_DVR_TIME struStopTime;//�ļ��Ľ���ʱ��
            public uint dwFileSize;//�ļ��Ĵ�С
        }

        //¼���ļ�����(9000)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//�ļ���
            public NET_DVR_TIME struStartTime;//�ļ��Ŀ�ʼʱ��
            public NET_DVR_TIME struStopTime;//�ļ��Ľ���ʱ��
            public uint dwFileSize;//�ļ��Ĵ�С
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000�豸֧��,1��ʾ���ļ��Ѿ�������,0��ʾ�������ļ�
            public byte byFileType;  //�ļ�����:0����ʱ¼��,1-�ƶ���� ��2������������
            //3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼��,7���𶯱�����8-����������9-���ܱ�����10-PIR������11-���߱�����12-���ȱ���,14-���ܽ�ͨ�¼�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //¼���ļ�����(cvr)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//�ļ���
            public NET_DVR_TIME struStartTime;//�ļ��Ŀ�ʼʱ��
            public NET_DVR_TIME struStopTime;//�ļ��Ľ���ʱ��
            public uint dwFileSize;//�ļ��Ĵ�С
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
            public byte byLocked;//9000�豸֧��,1��ʾ���ļ��Ѿ�������,0��ʾ�������ļ�
            public byte byFileType;  //�ļ�����:0����ʱ¼��,1-�ƶ���� ��2������������
	        //3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼��,7���𶯱�����8-����������9-���ܱ�����10-PIR������11-���߱�����12-���ȱ���,14-���ܽ�ͨ�¼�
            public byte byQuickSearch; //0:��ͨ��ѯ�����1�����٣���������ѯ���
            public byte byRes;
            public uint dwFileIndex; //�ļ�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	
        }

        //¼���ļ�����(������)
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_FINDDATA_CARD
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;//�ļ���
            public NET_DVR_TIME struStartTime;//�ļ��Ŀ�ʼʱ��
            public NET_DVR_TIME struStopTime;//�ļ��Ľ���ʱ��
            public uint dwFileSize;//�ļ��Ĵ�С
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCardNum;
        }

        //¼���ļ����������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND
        {
            public int lChannel;//ͨ����
            public uint dwFileType;//¼���ļ�����0xff��ȫ����0����ʱ¼��,1-�ƶ���� ��2������������
            //3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼��
            public uint dwIsLocked;//�Ƿ����� 0-�����ļ�,1-�����ļ�, 0xff��ʾ�����ļ�
            public uint dwUseCardNo;//�Ƿ�ʹ�ÿ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;//����
            public NET_DVR_TIME struStartTime;//��ʼʱ��
            public NET_DVR_TIME struStopTime;//����ʱ��
        }

        //��̨����ѡ��Ŵ���С(HIK ����ר��)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POINT_FRAME
        {
            public int xTop;//������ʼ���x����
            public int yTop;//����������y����
            public int xBottom;//����������x����
            public int yBottom;//����������y����
            public int bCounter;//����
        }

        //�����Խ�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_AUDIO
        {
            public byte byAudioEncType;//��Ƶ�������� 0-G722; 1-G711
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;//���ﱣ����Ƶ��ѹ������ 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_AP_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sSsid;
            public uint dwMode;/* 0 mange ģʽ;1 ad-hocģʽ���μ�NICMODE */
            public uint dwSecurity;  /*0 �����ܣ�1 wep���ܣ�2 wpa-psk;3 wpa-Enterprise���μ�WIFISECURITY*/
            public uint dwChannel;/*1-11��ʾ11��ͨ��*/
            public uint dwSignalStrength;/*0-100�ź���������Ϊ��ǿ*/
            public uint dwSpeed;/*����,��λ��0.01mbps*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AP_INFO_LIST
        {
            public uint dwSize;
            public uint dwCount;/*����AP������������20*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = WIFI_MAX_AP_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AP_INFO[] struApInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFIETHERNET
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpAddress;/*IP��ַ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sIpMask;/*����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;/*�����ַ��ֻ������ʾ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes;
            public uint dwEnableDhcp;/*�Ƿ�����dhcp  0������ 1����*/
            public uint dwAutoDns;/*�������dhcp�Ƿ��Զ���ȡdns,0���Զ���ȡ 1�Զ���ȡ�����������������dhcpĿǰ�Զ���ȡdns*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFirstDns; /*��һ��dns����*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sSecondDns;/*�ڶ���dns����*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sGatewayIpAddr;/* ���ص�ַ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] bRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TTLS
        {
            public byte byEapolVersion; //EAPOL�汾��0-�汾1��1-�汾2
            public byte byAuthType; //�ڲ���֤��ʽ��0-PAP��1-MSCHAPV2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //�û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterprisģʽ����

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_PEAP
        {
            public byte byEapolVersion; //EAPOL�汾��0-�汾1��1-�汾2
            public byte byAuthType; //�ڲ���֤��ʽ��0-GTC��1-MD5��2-MSCHAPV2
            public byte byPeapVersion; //PEAP�汾��0-�汾0��1-�汾1
            public byte byPeapLabel; //PEAP��ǩ��0-�ϱ�ǩ��1-�±�ǩ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAnonyIdentity; //�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; //�û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword; //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } //WPA-enterprise/WPA2-enterprisģʽ����

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_EAP_TLS
        {
            public byte byEapolVersion; //EAPOL�汾��0-�汾1��1-�汾2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byIdentity; //���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivateKeyPswd; //˽Կ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct WIFI_AUTH_PARAM
        {
            [FieldOffsetAttribute(0)]
            public UNION_EAP_TTLS EAP_TTLS;//WPA-enterprise/WPA2-enterprisģʽ����
			
            [FieldOffsetAttribute(0)]
            public UNION_EAP_PEAP EAP_PEAP; //WPA-enterprise/WPA2-enterprisģʽ����

			[FieldOffsetAttribute(0)]
            public UNION_EAP_TLS EAP_TLS; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WEP
        {
            public uint dwAuthentication;/*0 -����ʽ 1-����ʽ*/
            public uint dwKeyLength;/* 0 -64λ��1- 128λ��2-152λ*/
            public uint dwKeyType;/*0 16����;1 ASCI */
            public uint dwActive;/*0 ������0---3��ʾ����һ����Կ*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WEP_MAX_KEY_COUNT * WIFI_WEP_MAX_KEY_LENGTH)]
            public string sKeyInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_PSK
        {
            public uint dwKeyLength;/*8-63��ASCII�ַ�*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = WIFI_WPA_PSK_MAX_KEY_LENGTH)]
            public string sKeyInfo;
            public byte byEncryptType;/*WPA/WPA2ģʽ�¼�������,0-AES, 1-TKIP*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct UNION_WPA_WPA2
        {
            public byte byEncryptType;  /*��������,0-AES, 1-TKIP*/
            public byte byAuthType; //��֤���ͣ�0-EAP_TTLS,1-EAP_PEAP,2-EAP_TLS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public WIFI_AUTH_PARAM auth_param;
        }

        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_WIFI_CFG_EX
        {
            public NET_DVR_WIFIETHERNET struEtherNet;/*wifi����*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = IW_ESSID_MAX_SIZE)]
            public string sEssid;/*SSID*/
            public uint dwMode;/* 0 mange ģʽ;1 ad-hocģʽ���μ�*/
            public uint dwSecurity;/*0 �����ܣ�1 wep���ܣ�2 wpa-psk; */
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct key
            {
                [FieldOffsetAttribute(0)]
                public UNION_WEP wep;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_PSK wpa_psk;

                [FieldOffsetAttribute(0)]
                public UNION_WPA_WPA2 wpa_wpa2;//WPA-enterprise/WPA2-enterprisģʽ����
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CFG
        {
            public uint dwSize;
            public NET_DVR_WIFI_CFG_EX struWifiCfg;
        }

        //wifi����״̬
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_CONNECT_STATUS
        {
            public uint dwSize;
            public byte byCurStatus;	//1-�����ӣ�2-δ���ӣ�3-��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		//����
            public uint dwErrorCode;	// byCurStatus = 2ʱ��Ч,1-�û������������,2-�޴�·����,3-δ֪����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 244, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WIFI_WORKMODE
        {
            public uint dwSize;
            public uint dwNetworkInterfaceMode;/*0 �Զ��л�ģʽ��1 ����ģʽ*/
        }

        //���ܿ�����Ϣ
        public const int MAX_VCA_CHAN = 16;//�������ͨ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLINFO
        {
            public byte byVCAEnable;//�Ƿ�������
            public byte byVCAType;//�����������ͣ�VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA;//�������Ƿ��������Ϣ
            public byte byMode;//ģʽ��VCA_CHAN_MODE_TYPE ,atm������ʱ����Ҫ����
            public byte byControlType;   //�������ͣ���λ��ʾ��0-��1-��
            // byControlType &1 �Ƿ�����ץ�Ĺ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����������Ϊ0 
        }

        //���ܿ�����Ϣ�ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CTRLCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_CTRLINFO[] struCtrlInfo;//������Ϣ,����0��Ӧ�豸����ʼͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //�����豸������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_ABILITY
        {
            public uint dwSize;//�ṹ����
            public byte byVCAChanNum;//����ͨ������
            public byte byPlateChanNum;//����ͨ������
            public byte byBBaseChanNum;//��Ϊ���������
            public byte byBAdvanceChanNum;//��Ϊ�߼������
            public byte byBFullChanNum;//��Ϊ���������
            public byte byATMChanNum;//����ATM����
            public byte byPDCChanNum;         //����ͳ��ͨ������
            public byte byITSChanNum;         //��ͨ�¼�ͨ������
            public byte byBPrisonChanNum;     //��Ϊ������(����)ͨ������
            public byte byFSnapChanNum;       //����ץ��ͨ������
            public byte byFSnapRecogChanNum;  //����ץ�ĺ�ʶ��ͨ������
            public byte byFRetrievalChanNum;  //�������������
            public byte bySupport;            //������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
            //bySupport & 0x1����ʾ�Ƿ�֧�����ܸ��� 2012-3-22
            //bySupport & 0x2����ʾ�Ƿ�֧��128·ȡ����չ2012-12-27
            public byte byFRecogChanNum;      //����ʶ��ͨ������
            public byte byBPPerimeterChanNum; //��Ϊ������(�ܽ�)ͨ������
            public byte byTPSChanNum;         //��ͨ�յ�ͨ������
            public byte byTFSChanNum;         //��·Υ��ȡ֤ͨ������
            public byte byFSnapBFullChanNum;  //����ץ�ĺ���Ϊ����ͨ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��Ϊ������������
        public enum VCA_ABILITY_TYPE:uint
        {
            TRAVERSE_PLANE_ABILITY = 0x01,       //��Խ������
            ENTER_AREA_ABILITY = 0x02,       //��������
            EXIT_AREA_ABILITY = 0x04,       //�뿪����
            INTRUSION_ABILITY = 0x08,       //����
            LOITER_ABILITY = 0x10,       //�ǻ�
            LEFT_TAKE_ABILITY = 0x20,       //��Ʒ������ȡ
            PARKING_ABILITY = 0x40,       //ͣ��
            RUN_ABILITY = 0x80,       //�����ƶ�
            HIGH_DENSITY_ABILITY = 0x100,      //��Ա�ۼ�
            LF_TRACK_ABILITY = 0x200,      //�������
            VIOLENT_MOTION_ABILITY = 0x400,      //�����˶����
            REACH_HIGHT_ABILITY = 0x800,      //�ʸ߼��
            GET_UP_ABILITY = 0x1000,     //������
            LEFT_ABILITY = 0x2000,     //��Ʒ����
            TAKE_ABILITY = 0x4000,     //��Ʒ��ȡ
            LEAVE_POSITION = 0x8000,     //���
            TRAIL_ABILITY = 0x10000,    //β�� 
            KEY_PERSON_GET_UP_ABILITY = 0x20000,    //�ص���Ա������
            FALL_DOWN_ABILITY = 0x80000,    //����
            AUDIO_ABNORMAL_ABILITY = 0x100000,   //��ǿͻ��
            ADV_REACH_HEIGHT_ABILITY = 0x200000,   //�����ʸ�
            TOILET_TARRY_ABILITY = 0x400000,   //��޳�ʱ
            YARD_TARRY_ABILITY = 0x800000,   //�ŷ糡����
            ADV_TRAVERSE_PLANE_ABILITY = 0x1000000,  //���߾�����
            HUMAN_ENTER_ABILITY = 0x10000000, //�˿���ATM ,ֻ��ATM_PANELģʽ��֧��
            OVER_TIME_ABILITY = 0x20000000, //������ʱ,ֻ��ATM_PANELģʽ��֧��
            STICK_UP_ABILITY = 0x40000000, //��ֽ��
            INSTALL_SCANNER_ABILITY = 0x80000000  //��װ������
        }

        //����ͨ������
        public enum VCA_CHAN_ABILITY_TYPE
        {
            VCA_BEHAVIOR_BASE = 1,          //��Ϊ����������
            VCA_BEHAVIOR_ADVANCE = 2,          //��Ϊ�����߼���
            VCA_BEHAVIOR_FULL = 3,          //��Ϊ����������
            VCA_PLATE = 4,          //��������
            VCA_ATM = 5,          //ATM����
            VCA_PDC = 6,          //������ͳ��
            VCA_ITS = 7,          //���� ��ͨ�¼�
            VCA_BEHAVIOR_PRISON = 8,          //��Ϊ����������(����) 
            VCA_FACE_SNAP = 9,           //����ץ������
            VCA_FACE_SNAPRECOG = 10,          //����ץ�ĺ�ʶ������
            VCA_FACE_RETRIEVAL = 11,          //�������������
            VCA_FACE_RECOG = 12,          //����ʶ������
            VCA_BEHAVIOR_PRISON_PERIMETER = 13, // ��Ϊ���������� (�ܽ�)
            VCA_TPS = 14,          //��ͨ�յ�
            VCA_TFS = 15,          //��·Υ��ȡ֤
            VCA_BEHAVIOR_FACESNAP = 16           //����ץ�ĺ���Ϊ��������
        }

        //����ATMģʽ����(ATM��������)
        public enum VCA_CHAN_MODE_TYPE
        {
            VCA_ATM_PANEL = 0,//ATM���
            VCA_ATM_SURROUND = 1,//ATM����
            VCA_ATM_FACE = 2	//ATM����
        }
        public enum TFS_CHAN_MODE_TYPE
        {
            TFS_CITYROAD = 0,  //TFS ���е�·
            TFS_FREEWAY = 1   //TFS ���ٵ�·
        }

        //��Ϊ��������ģʽ
        public enum BEHAVIOR_SCENE_MODE_TYPE
        {
            BEHAVIOR_SCENE_DEFAULT = 0, //ϵͳĬ��
            BEHAVIOR_SCENE_WALL = 1,    //Χǽ
            BEHAVIOR_SCENE_INDOOR = 2   //����
        }

        //ͨ�������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_CHAN_IN_PARAM
        {
            public byte byVCAType;//VCA_CHAN_ABILITY_TYPEö��ֵ
            public byte byMode;//ģʽ��VCA_CHAN_MODE_TYPE ,atm������ʱ����Ҫ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����������Ϊ0 
        }

        //��Ϊ�������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BEHAVIOR_ABILITY
        {
            public uint dwSize;//�ṹ����
            public uint dwAbilityType;//֧�ֵ��������ͣ���λ��ʾ����VCA_ABILITY_TYPE����
            public byte byMaxRuleNum;//��������
            public byte byMaxTargetNum;//���Ŀ����
            public byte bySupport;		// ֧�ֵĹ�������   ��λ��ʾ  
            // bySupport & 0x01 ֧�ֱ궨����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����������Ϊ0
        }

        // ��ͨ�������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_ABILITY
        {
            public uint dwSize;             // �ṹ���С
            public uint dwAbilityType;      // ֧�ֵ������б�  ����ITS_ABILITY_TYPE
            public byte byMaxRuleNum;	 	//��������
            public byte byMaxTargetNum; 	//���Ŀ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // ����
        }
        /***********************************end*******************************************/

        /************************************���ܲ����ṹ*********************************/
        //���ܹ��ýṹ
        //����ֵ��һ��,������ֵΪ��ǰ����İٷֱȴ�С, ����ΪС�������λ
        //������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POINT
        {
            public float fX;// X������, 0.001~1
            public float fY;//Y������, 0.001~1
        }

        //�����ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RECT
        {
            public float fX;//�߽�����Ͻǵ��X������, 0.001~1
            public float fY;//�߽�����Ͻǵ��Y������, 0.001~1
            public float fWidth;//�߽��Ŀ��, 0.001~1
            public float fHeight;//�߽��ĸ߶�, 0.001~1
        }

        //��Ϊ�����¼�����
        public enum VCA_EVENT_TYPE : uint
        {
            VCA_TRAVERSE_PLANE = 0x1,        //��Խ������
            VCA_ENTER_AREA = 0x2,        //Ŀ���������,֧���������
            VCA_EXIT_AREA = 0x4,        //Ŀ���뿪����,֧���������
            VCA_INTRUSION = 0x8,        //�ܽ�����,֧���������
            VCA_LOITER = 0x10,       //�ǻ�,֧���������
            VCA_LEFT_TAKE = 0x20,       //��Ʒ������ȡ,֧���������
            VCA_PARKING = 0x40,       //ͣ��,֧���������
            VCA_RUN = 0x80,       //�����ƶ�,֧���������
            VCA_HIGH_DENSITY = 0x100,      //��������Ա�ۼ�,֧���������
            VCA_VIOLENT_MOTION = 0x200,		 //�����˶����
            VCA_REACH_HIGHT = 0x400,		 //�ʸ߼��
            VCA_GET_UP = 0x800,	     //������
            VCA_LEFT = 0x1000,     //��Ʒ����
            VCA_TAKE = 0x2000,     //��Ʒ��ȡ
            VCA_LEAVE_POSITION = 0x4000,     //���
            VCA_TRAIL = 0x8000,     //β��
            VCA_KEY_PERSON_GET_UP = 0x10000,    //�ص���Ա������
            VCA_FALL_DOWN = 0x80000,    //���ؼ��
            VCA_AUDIO_ABNORMAL = 0x100000,   //��ǿͻ����
            VCA_ADV_REACH_HEIGHT = 0x200000,   //�����ʸ�
            VCA_TOILET_TARRY = 0x400000,   //��޳�ʱ
            VCA_YARD_TARRY = 0x800000,   //�ŷ糡����
            VCA_ADV_TRAVERSE_PLANE = 0x1000000,  //���߾�����
            VCA_HUMAN_ENTER = 0x10000000, //�˿���ATM           ֻ��ATM_PANELģʽ��֧��
            VCA_OVER_TIME = 0x20000000, //������ʱ            ֻ��ATM_PANELģʽ��֧��
            VCA_STICK_UP = 0x40000000, //��ֽ��,֧���������
            VCA_INSTALL_SCANNER = 0x80000000  //��װ������,֧���������
        }

        //��Ϊ�����¼�������չ
        public enum VCA_RULE_EVENT_TYPE_EX
        {
            ENUM_VCA_EVENT_TRAVERSE_PLANE = 1,   //��Խ������
            ENUM_VCA_EVENT_ENTER_AREA = 2,   //Ŀ���������,֧���������
            ENUM_VCA_EVENT_EXIT_AREA = 3,   //Ŀ���뿪����,֧���������
            ENUM_VCA_EVENT_INTRUSION = 4,   //�ܽ�����,֧���������
            ENUM_VCA_EVENT_LOITER = 5,   //�ǻ�,֧���������
            ENUM_VCA_EVENT_LEFT_TAKE = 6,   //��Ʒ������ȡ,֧���������
            ENUM_VCA_EVENT_PARKING = 7,   //ͣ��,֧���������
            ENUM_VCA_EVENT_RUN = 8,   //�����ƶ�,֧���������
            ENUM_VCA_EVENT_HIGH_DENSITY = 9,   //��������Ա�ۼ�,֧���������
            ENUM_VCA_EVENT_VIOLENT_MOTION = 10,  //�����˶����
            ENUM_VCA_EVENT_REACH_HIGHT = 11,  //�ʸ߼��
            ENUM_VCA_EVENT_GET_UP = 12,  //������
            ENUM_VCA_EVENT_LEFT = 13,  //��Ʒ����
            ENUM_VCA_EVENT_TAKE = 14,  //��Ʒ��ȡ
            ENUM_VCA_EVENT_LEAVE_POSITION = 15,  //���
            ENUM_VCA_EVENT_TRAIL = 16,  //β��
            ENUM_VCA_EVENT_KEY_PERSON_GET_UP = 17,  //�ص���Ա������
            ENUM_VCA_EVENT_FALL_DOWN = 20,  //���ؼ��
            ENUM_VCA_EVENT_AUDIO_ABNORMAL = 21,  //��ǿͻ����
            ENUM_VCA_EVENT_ADV_REACH_HEIGHT = 22,  //�����ʸ�
            ENUM_VCA_EVENT_TOILET_TARRY = 23,  //��޳�ʱ
            ENUM_VCA_EVENT_YARD_TARRY = 24,  //�ŷ糡����
            ENUM_VCA_EVENT_ADV_TRAVERSE_PLANE = 25,  //���߾�����
            ENUM_VCA_EVENT_HUMAN_ENTER = 29,  //�˿���ATM,ֻ��ATM_PANELģʽ��֧��   
            ENUM_VCA_EVENT_OVER_TIME = 30,  //������ʱ,ֻ��ATM_PANELģʽ��֧��
            ENUM_VCA_EVENT_STICK_UP = 31,  //��ֽ��,֧���������
            ENUM_VCA_EVENT_INSTALL_SCANNER = 32   //��װ������,֧���������
        }

        //�����洩Խ��������
        public enum VCA_CROSS_DIRECTION
        {
            VCA_BOTH_DIRECTION,// ˫�� 
            VCA_LEFT_GO_RIGHT,// �������� 
            VCA_RIGHT_GO_LEFT,// �������� 
        }

        //�߽ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE
        {
            public NET_VCA_POINT struStart;//��� 
            public NET_VCA_POINT struEnd; //�յ�

            //             public void init()
            //             {
            //                 struStart = new NET_VCA_POINT();
            //                 struEnd = new NET_VCA_POINT();
            //             }
        }

        //�ýṹ�ᵼ��xaml�������������������������������������ʱ��û���ҵ�  
        //��ʱ���νṹ��
        //����ͽṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_POLYGON
        {
            /// DWORD->unsigned int
            public uint dwPointNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = VCA_MAX_POLYGON_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPos;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAVERSE_PLANE
        {
            public NET_VCA_LINE struPlaneBottom;//������ױ�
            public VCA_CROSS_DIRECTION dwCrossDirection;//��Խ����: 0-˫��1-�����ң�2-���ҵ���
            public byte byRes1;//����
            public byte byPlaneHeight;//������߶�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;

            //             public void init()
            //             {
            //                 struPlaneBottom = new NET_VCA_LINE();
            //                 struPlaneBottom.init();
            //                 byRes2 = new byte[38];
            //             }
        }

        //����/�뿪�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AREA
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���ݱ����ӳ�ʱ������ʶ�����д�ͼƬ�����������IO����һ�£�1�뷢��һ����
        //���ֲ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_INTRUSION
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;//�����ӳ�ʱ��: 1-120�룬����5�룬�ж�����Ч������ʱ��
            public byte bySensitivity;        //�����Ȳ�������Χ[1-100]
            public byte byRate;               //ռ�ȣ�����������δ����Ŀ��ߴ�Ŀ��ռ��������ı��أ���һ��Ϊ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //�ǻ�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LOITER
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;//�����ǻ������ĳ���ʱ�䣺1-120�룬����10��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //����/�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE_LEFT
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;//��������/��������ĳ���ʱ�䣺1-120�룬����10��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ͣ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PARKING
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;//����ͣ����������ʱ�䣺1-120�룬����10��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���ܲ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RUN
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public float fRunDistance;//�˱���������, ��Χ: [0.1, 1.00]
            public byte byRes1;             // �����ֽ�
            public byte byMode;             // 0 ����ģʽ  1 ʵ��ģʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��Ա�ۼ�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HIGH_DENSITY
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public float fDensity;//�ܶȱ���, ��Χ: [0.1, 1.0]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public ushort wDuration;      // ������Ա�ۼ�����������ֵ 20-360s
        }

        //�����˶�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_VIOLENT_MOTION
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;           //���������˶�������ֵ��1-50��
            public byte bySensitivity;       //�����Ȳ�������Χ[1,5]
            public byte byMode;              //0-����Ƶģʽ��1-����Ƶ����ģʽ��2-����Ƶģʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //����
        }

        //�ʸ߲���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REACH_HIGHT
        {
            public NET_VCA_LINE struVcaLine;   //�ʸ߾�����
            public ushort wDuration; //�����ʸ߱�����ֵ��1-120��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // �����ֽ�
        }

        //�𴲲���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_GET_UP
        {
            public NET_VCA_POLYGON struRegion; //����Χ
            public ushort wDuration;	        //�����𴲱�����ֵ1-100 ��
            public byte byMode;             //������ģʽ,0-��ͨ��ģʽ,1-�ߵ���ģʽ,2-��ͨ����������ģʽ
            public byte bySensitivity;      //�����Ȳ�������Χ[1,10]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //�����ֽ�
        }

        //��Ʒ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEFT
        {
            public NET_VCA_POLYGON struRegion; // ����Χ
            public ushort wDuration;       // ������Ʒ����������ֵ 10-100��
            public byte bySensitivity;   // �����Ȳ�������Χ[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        // �����ֽ�
        }

        // ��Ʒ��ȡ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TAKE
        {
            public NET_VCA_POLYGON struRegion;     // ����Χ
            public ushort wDuration;      // ������Ʒ��ȡ������ֵ10-100��
            public byte bySensitivity;  // �����Ȳ�������Χ[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_OVER_TIME
        {
            public NET_VCA_POLYGON struRegion;    // ����Χ
            public ushort wDuration;  // ��������ʱ����ֵ 4s-60000s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ENTER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;			//�����ֽ�
        }

        //��ֽ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_STICK_UP
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;//��������ʱ�䣺10-60�룬����10��
            public byte bySensitivity;//�����Ȳ�������Χ[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SCANNER
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;//��������ʱ�䣺10-60��
            public byte bySensitivity;//�����Ȳ�������Χ[1,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //����¼�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LEAVE_POSITION
        {
            public NET_VCA_POLYGON struRegion; //����Χ
            public ushort wLeaveDelay;  //���˱���ʱ�䣬��λ��s��ȡֵ1-1800
            public ushort wStaticDelay; //˯������ʱ�䣬��λ��s��ȡֵ1-1800
            public byte byMode;       //ģʽ��0-����¼���1-˯���¼���2-���˯���¼�
            public byte byPersonType; //ֵ���������ͣ�0-����ֵ�ڣ�1-˫��ֵ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //����
        }

        //β�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TRAIL
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wRes;      /* ���� */
            public byte bySensitivity;       /* �����Ȳ�������Χ[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���ز���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FALL_DOWN
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDuration;      /* �����¼���ֵ 1-60s*/
            public byte bySensitivity;       /* �����Ȳ�������Χ[1,5] */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��ǿͻ�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_AUDIO_ABNORMAL
        {
            public ushort wDecibel;       //����ǿ��
            public byte bySensitivity;  //�����Ȳ�������Χ[1,5] 
            public byte byAudioMode;    //�������ģʽ��0-�����ȼ�⣬1-�ֱ���ֵ��⣬2-��������ֱ���ֵ��� 
            public byte byEnable;       //ʹ�ܣ��Ƿ���
            public byte byThreshold;    //������ֵ[0,100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 54, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //����   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_EXCEPTION
        {
            public uint dwSize;
            public byte byEnableAudioInException;  //ʹ�ܣ��Ƿ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmSched; //����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V40 struHandleException;  //�쳣����ʽ
            public uint dwMaxRelRecordChanNum;  //����������¼��ͨ�� ����ֻ�������֧������
            public uint dwRelRecordChanNum;     //����������¼��ͨ�� �� ʵ��֧�ֵ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] byRelRecordChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TOILET_TARRY
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDelay;        //��޳�ʱʱ��[1,3600]����λ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_YARD_TARRY
        {
            public NET_VCA_POLYGON struRegion;//����Χ
            public ushort wDelay;        //�ŷ糡����ʱ��[1,120]����λ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_REACH_HEIGHT
        {
            public NET_VCA_POLYGON struRegion; //�ʸ�����
            public uint dwCrossDirection;   //��Խ����(���VCA_CROSS_DIRECTION): 0-˫��1-������2-���ҵ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADV_TRAVERSE_PLANE
        {
            public NET_VCA_POLYGON struRegion; //����������
            public uint dwCrossDirection;   //��Խ����(���VCA_CROSS_DIRECTION): 0-˫��1-������2-���ҵ���
            public byte bySensitivity;      //�����Ȳ�������Χ[1,5] 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		    //�����ֽ�
        }

        //�����¼�����
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;//����
            [FieldOffsetAttribute(0)]
            public NET_VCA_TRAVERSE_PLANE struTraversePlane;//��Խ��������� 
            [FieldOffsetAttribute(0)]
            public NET_VCA_AREA struArea;//����/�뿪�������
            [FieldOffsetAttribute(0)]
            public NET_VCA_INTRUSION struIntrusion;//���ֲ���
            [FieldOffsetAttribute(0)]
            public NET_VCA_LOITER struLoiter;//�ǻ�����
            [FieldOffsetAttribute(0)]
            public NET_VCA_TAKE_LEFT struTakeTeft;//����/�������
            [FieldOffsetAttribute(0)]
            public NET_VCA_PARKING struParking;//ͣ������
            [FieldOffsetAttribute(0)]
            public NET_VCA_RUN struRun;//���ܲ���
            [FieldOffsetAttribute(0)]
            public NET_VCA_HIGH_DENSITY struHighDensity;//��Ա�ۼ�����  
            [FieldOffsetAttribute(0)]
            public NET_VCA_VIOLENT_MOTION struViolentMotion;	//�����˶�
            [FieldOffsetAttribute(0)]
            public NET_VCA_REACH_HIGHT struReachHight;      //�ʸ�
            [FieldOffsetAttribute(0)]
            public NET_VCA_GET_UP struGetUp;           //��
            [FieldOffsetAttribute(0)]
            public NET_VCA_LEFT struLeft;            //��Ʒ����
            [FieldOffsetAttribute(0)]
            public NET_VCA_TAKE struTake;            // ��Ʒ��ȡ
            [FieldOffsetAttribute(0)]
            public NET_VCA_HUMAN_ENTER struHumanEnter;      //��Ա����
            [FieldOffsetAttribute(0)]
            public NET_VCA_OVER_TIME struOvertime;        //������ʱ
            [FieldOffsetAttribute(0)]
            public NET_VCA_STICK_UP struStickUp;//��ֽ��
            [FieldOffsetAttribute(0)]
            public NET_VCA_SCANNER struScanner;//����������
            [FieldOffsetAttribute(0)]
            public NET_VCA_LEAVE_POSITION struLeavePos;        //��ڲ���
            [FieldOffsetAttribute(0)]
            public NET_VCA_TRAIL struTrail;           //β�����
            [FieldOffsetAttribute(0)]
            public NET_VCA_FALL_DOWN struFallDown;        //���ز���
            [FieldOffsetAttribute(0)]
            public NET_VCA_AUDIO_ABNORMAL struAudioAbnormal;   //��ǿͻ��
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADV_REACH_HEIGHT struReachHeight;     //�����ʸ߲���
            [FieldOffsetAttribute(0)]
            public NET_VCA_TOILET_TARRY struToiletTarry;     //��޳�ʱ����
            [FieldOffsetAttribute(0)]
            public NET_VCA_YARD_TARRY struYardTarry;       //�ŷ糡��������
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADV_TRAVERSE_PLANE struAdvTraversePlane;//���߾��������            
        }

        // �ߴ����������
        public enum SIZE_FILTER_MODE
        {
            IMAGE_PIX_MODE,//�������ش�С����
            REAL_WORLD_MODE,//����ʵ�ʴ�С����
            DEFAULT_MODE 	// Ĭ��ģʽ
        }

        //�ߴ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SIZE_FILTER
        {
            public byte byActive;//�Ƿ񼤻�ߴ������ 0-�� ��0-��
            public byte byMode;//������ģʽSIZE_FILTER_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//��������0
            public NET_VCA_RECT struMiniRect;//��СĿ���,ȫ0��ʾ������
            public NET_VCA_RECT struMaxRect;//���Ŀ���,ȫ0��ʾ������
        }

        //�������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE
        {
            public byte byActive;//�Ƿ񼤻����,0-��,��0-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����������Ϊ0�ֶ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//��������
            public VCA_EVENT_TYPE dwEventType;//��Ϊ�����¼�����
            public NET_VCA_EVENT_UNION uEventParam;//��Ϊ�����¼�����
            public NET_VCA_SIZE_FILTER struSizeFilter;//�ߴ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//����ʽ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
        }

        //��Ϊ�������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG
        {
            public uint dwSize;//�ṹ����
            public byte byPicProType;//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPictureParam;//ͼƬ���ṹ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE[] struRule;//��������
        }

        //�ߴ���˲���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FILTER_STRATEGY
        {
            public byte byStrategy;      //�ߴ���˲��� 0 - ������ 1-�߶ȺͿ�ȹ���,2-�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //����
        }

        //���򴥷�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_TRIGGER_PARAM
        {
            public byte byTriggerMode;   //����Ĵ�����ʽ��0- �����ã�1- �켣�� 2- Ŀ����� 
            public byte byTriggerPoint;  //�����㣬������ʽΪ�켣��ʱ��Ч 0- ��,1-��,2-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //����
            public float fTriggerArea;    //����Ŀ������ٷֱ� [0,100]��������ʽΪĿ�����ʱ��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //����
        }

        //�������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ONE_RULE_V41
        {
            public byte byActive; //�Ƿ񼤻����,0-��,��0-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //����������Ϊ0�ֶ�
            public ushort wEventTypeEx; //��Ϊ�¼�������չ�����ڴ����ֶ�dwEventType���ο�VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //��������
            public VCA_EVENT_TYPE dwEventType;	//��Ϊ�¼����ͣ�������Ϊ�˼��ݣ���������ʹ��wEventTypeEx��ȡ�¼�����
            public NET_VCA_EVENT_UNION uEventParam; //��Ϊ�����¼�����
            public NET_VCA_SIZE_FILTER struSizeFilter;  //�ߴ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//����ʽ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            public ushort wAlarmDelay; //���ܱ�����ʱ��0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //����
            public NET_VCA_FILTER_STRATEGY struFilterStrategy; //�ߴ���˲���
            public NET_VCA_RULE_TRIGGER_PARAM struTriggerParam;   //���򴥷�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��Ϊ�������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULECFG_V41
        {
            public uint dwSize;			//�ṹ����
            public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            public byte byUpLastAlarm; //2011-04-06 �Ƿ����ϴ����һ�εı���
            public byte byPicRecordEnable;  /*2012-3-1�Ƿ�����ͼƬ�洢, 0-������, 1-����*/
            public byte byRes1;
            public NET_DVR_JPEGPARA struPictureParam; 		//ͼƬ���ṹ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ONE_RULE_V41[] struRule;  //��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��Ŀ��ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_TARGET_INFO
        {
            public uint dwID;//Ŀ��ID ,��Ա�ܶȹ��߱���ʱΪ0
            public NET_VCA_RECT struRect; //Ŀ��߽�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        //�򻯵Ĺ�����Ϣ, ��������Ļ�����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_INFO
        {
            public byte byRuleID;//����ID,0-7
            public byte byRes;//����
            public ushort wEventTypeEx;   //��Ϊ�¼�������չ�����ڴ����ֶ�dwEventType���ο�VCA_RULE_EVENT_TYPE_EX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//��������
            public VCA_EVENT_TYPE dwEventType;//�����¼�����
            public NET_VCA_EVENT_UNION uEventParam;//�¼�����
        }

        //ǰ���豸��ַ��Ϣ�����ܷ����Ǳ�ʾ����ǰ���豸�ĵ�ַ��Ϣ�������豸��ʾ�����ĵ�ַ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DEV_INFO
        {
            public NET_DVR_IPADDR struDevIP;//ǰ���豸��ַ��
            public ushort wPort;//ǰ���豸�˿ںţ� 
            public byte byChannel;//ǰ���豸ͨ����
            public byte byRes;// �����ֽ�
        }

        //��Ϊ��������ϱ��ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_RULE_ALARM
        {
            public uint dwSize;//�ṹ����
            public uint dwRelativeTime;//���ʱ��
            public uint dwAbsTime;//����ʱ��
            public NET_VCA_RULE_INFO struRuleInfo;//�¼�������Ϣ
            public NET_VCA_TARGET_INFO struTargetInfo;//����Ŀ����Ϣ
            public NET_VCA_DEV_INFO struDevInfo;//ǰ���豸��Ϣ
            public uint dwPicDataLen;//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����*/
            public byte byPicType;		//  0-��ͨͼƬ 1-�Ա�ͼƬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//����������Ϊ0
            public IntPtr pImage;//ָ��ͼƬ��ָ��
        }

        //��Ϊ��������DSP��Ϣ���ӽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_DRAW_MODE
        {
            public uint dwSize;
            public byte byDspAddTarget;//�����Ƿ����Ŀ��
            public byte byDspAddRule;//�����Ƿ���ӹ���
            public byte byDspPicAddTarget;//ץͼ�Ƿ����Ŀ��
            public byte byDspPicAddRule;//ץͼ�Ƿ���ӹ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��������
        public enum OBJECT_TYPE_ENUM
        {
            ENUM_OBJECT_TYPE_COAT = 1  //����
        }

        //������ɫ�����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_COND
        {
            public uint dwChannel;   //ͨ����
            public uint dwObjType;   //�������ͣ��μ�OBJECT_TYPE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //����
        }

        //ͼƬ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIC
        {
            public byte byPicType;        //ͼƬ���ͣ�1-jpg
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //����
            public uint dwPicWidth;       //ͼƬ���
            public uint dwPicHeight;      //ͼƬ�߶�
            public uint dwPicDataLen;     //ͼƬ����ʵ�ʴ�С
            public uint dwPicDataBuffLen; //ͼƬ���ݻ�������С
            public IntPtr byPicDataBuff;    //ͼƬ���ݻ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       //����
        }

        //��ɫ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR_UNION
        {
            public NET_DVR_COLOR struColor;   //��ɫֵ
            public NET_DVR_PIC struPicture; //ͼƬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //����
        }

        //������ɫ�����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OBJECT_COLOR
        {
            public uint dwSize;       //�ṹ���С
            public byte byEnable;     //0-�����ã�1-����
            public byte byColorMode;  //ȡɫ��ʽ��1-��ɫֵ��2-ͼƬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //����
            public NET_DVR_OBJECT_COLOR_UNION uObjColor; //������ɫ�����壬ȡֵ������ȡɫ��ʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //����
        }

        //��������
        public enum AREA_TYPE_ENUM
        {
            ENUM_OVERLAP_REGION = 1,//��ͬ����
            ENUM_BED_LOCATION = 2   //����λ��
        }

        //��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA
        {
            public uint dwAreaType;   //�������ͣ��μ�AREA_TYPE_ENUM
            public byte byEnable;     //0-�����ã�1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;     //����
            public NET_VCA_POLYGON struPolygon; //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //����
        }

        //���������б�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUXAREA_LIST
        {
            public uint dwSize;	// �ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AUXAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_AUXAREA[] struArea; //��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// ����
        }

        //ͨ������ģʽ
        public enum CHAN_WORKMODE_ENUM
        {
            ENUM_CHAN_WORKMODE_INDEPENDENT = 1,  //����ģʽ
            ENUM_CHAN_WORKMODE_MASTER = 2,      //��ģʽ
            ENUM_CHAN_WORKMODE_SLAVE = 3        //��ģʽ
        }

        //ͨ������ģʽ�����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL_WORKMODE
        {
            public uint dwSize;        //�ṹ���С
            public byte byWorkMode;    //����ģʽ���μ�CHAN_WORKMODE_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //����
        }

        //�豸ͨ�������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANNEL
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byAddress;	//�豸IP������
            public ushort wDVRPort;			 	    //�˿ں�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                   //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	        //�����û���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;       //��������
            public uint dwChannel;                   //ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  //����
        }

        //��ͨ����Ϣ������
        [StructLayout(LayoutKind.Explicit)]
        public struct NET_DVR_SLAVE_CHANNEL_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 152, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //�������С
            [FieldOffsetAttribute(0)]
            public uint dwLocalChannel;    //����ͨ��
            [FieldOffsetAttribute(0)]
            public NET_DVR_CHANNEL struRemoteChannel; //Զ��ͨ��
        }

        //��ͨ�������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_PARAM
        {
            public byte byChanType;   //��ͨ�����ͣ�1-����ͨ����2-Զ��ͨ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //����
            public NET_DVR_SLAVE_CHANNEL_UNION uSlaveChannel; //��ͨ�������壬ȡֵ������byChanType
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //����
        }


        //��ͨ���������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SLAVE_CHANNEL_CFG
        {
            public uint dwSize;   //�ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SLAVE_CHANNEL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SLAVE_CHANNEL_PARAM[] struChanParam;//��ͨ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
        }

        //��Ƶ������ϼ���¼�
        public enum VQD_EVENT_ENUM
        {
            ENUM_VQD_EVENT_BLUR = 1,  //ͼ��ģ��
            ENUM_VQD_EVENT_LUMA = 2,  //�����쳣
            ENUM_VQD_EVENT_CHROMA = 3,  //ͼ��ƫɫ
            ENUM_VQD_EVENT_SNOW = 4,  //ѩ������
            ENUM_VQD_EVENT_STREAK = 5,  //���Ƹ���
            ENUM_VQD_EVENT_FREEZE = 6,  //���涳��
            ENUM_VQD_EVENT_SIGNAL_LOSS = 7,  //�źŶ�ʧ
            ENUM_VQD_EVENT_PTZ = 8,  //��̨ʧ��
            ENUM_VQD_EVENT_SCNENE_CHANGE = 9,  //����ͻ��
            ENUM_VQD_EVENT_VIDEO_ABNORMAL = 10, //��Ƶ�쳣
            ENUM_VQD_EVENT_VIDEO_BLOCK = 11, //��Ƶ�ڵ�
        }

        //��Ƶ��������¼������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_COND
        {
            public uint dwChannel;   //ͨ����
            public uint dwEventType; //����¼����ͣ��μ�VQD_EVENT_ENUM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //����
        }

        //��Ƶ��������¼�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_PARAM
        {
            public byte byThreshold;    //������ֵ����Χ[0,100]
            public byte byTriggerMode;  //1-����������2-���δ���
            public byte byUploadPic;    //0-���ϴ�ͼƬ��1-�ϴ�ͼƬ�������Ƿ��ϴ�ͼƬ���º󶼿��Դ��豸��ȡ���¼�����Ӧ���µ�һ�ű���ͼƬ���μ��ӿ�NET_DVR_StartDownload
            public byte byRes1;         //����
            public uint dwTimeInterval; //������������ʱ��������Χ[0,3600] ��λ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //����
        }

        //��Ƶ��������¼�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_EVENT_RULE
        {
            public uint dwSize;       //�ṹ���С 
            public byte byEnable;     //0-�����ã�1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //����
            public NET_DVR_VQD_EVENT_PARAM struEventParam; //��Ƶ��������¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//���ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;  //����ʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //����������¼��ͨ����1��ʾ������ͨ����0��ʾ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //����
        }

        //��׼��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASELINE_SCENE
        {
            public uint dwSize;     //�ṹ���С
            public byte byEnable;   //0-�����ã�1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
        }

        //��׼�������������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_BASELINE_SCENE_PARAM
        {
            public uint dwSize;     //�ṹ���С
            public uint dwChannel;  //ͨ����
            public byte byCommand;  //�������ͣ�1-���ֶα������ݲ�ʹ�ã�2-���»�׼����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
        }

        //��Ƶ������ϱ����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VQD_ALARM
        {
            public uint dwSize;                //�ṹ���С
            public uint dwRelativeTime;        //���ʱ��
            public uint dwAbsTime;	          //����ʱ��
            public NET_VCA_DEV_INFO struDevInfo; //ǰ���豸��Ϣ 
            public uint dwEventType;           //�¼����ͣ��ο�VQD_EVENT_ENUM
            public float fThreshold;            //������ֵ[0.000,1.000]
            public uint dwPicDataLen;          //ͼƬ���ȣ�Ϊ0��ʾû��ͼƬ
            public IntPtr pImage;               //ָ��ͼƬ��ָ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;            //����
        }

        //�궨���ӽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CB_POINT
        {
            public NET_VCA_POINT struPoint;     //�궨�㣬���������ǹ����
            public NET_DVR_PTZPOS struPtzPos;  //��������PTZ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //�궨�������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CALIBRATION_PARAM
        {
            public byte byPointNum;			//��Ч�궨�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint; //�궨����
        }

        //������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_CFG
        {
            public uint dwSize;				//�ṹ����	
            public byte byEnable;				//�궨ʹ��
            public byte byFollowChan;          // �����ƵĴ�ͨ��
            public byte byDomeCalibrate;			//�������ܸ�������궨��1���� 0������ 
            public byte byRes;					// �����ֽ�
            public NET_DVR_TRACK_CALIBRATION_PARAM struCalParam; //�궨����
        }

        //����ģʽ
        public enum TRACK_MODE
        {
            MANUAL_CTRL = 0,  //�ֶ�����
            ALARM_TRACK    //������������
        }

        //�ֶ����ƽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //����ģʽ�ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_MODE
        {
            public uint dwSize;		//�ṹ����
            public byte byTrackMode;   //����ģʽ
            public byte byRuleConfMode;   //�������ø���ģʽ0-�������ø��٣�1-Զ�����ø���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //��������0
            [StructLayout(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [FieldOffsetAttribute(0)]
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                public uint[] dwULen;
                [FieldOffsetAttribute(0)]
                public NET_DVR_MANUAL_CTRL_INFO struManualCtrl;//�ֶ����ٽṹ
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALARM_JPEG
        {
            public byte byPicProType;	    /*����ʱͼƬ����ʽ 0-������ 1-�ϴ�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //�����ֽ�
            public NET_DVR_JPEGPARA struPicParam; 				/*ͼƬ���ṹ*/
        }

        //��������Ϊ��������ṹ
        //�������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ONE_RULE
        {
            public byte byActive;/* �Ƿ񼤻����,0-��, ��0-�� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����������Ϊ0�ֶ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//��������
            public VCA_EVENT_TYPE dwEventType;//��Ϊ�����¼�����
            public NET_VCA_EVENT_UNION uEventParam;//��Ϊ�����¼�����
            public NET_VCA_SIZE_FILTER struSizeFilter;//�ߴ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;/*����������Ϊ0*/
        }

        // �����ǹ���ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_RULECFG
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_ONE_RULE[] struRule; //��������
        }

        // IVMS��Ϊ�������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_BEHAVIORCFG
        {
            public uint dwSize;
            public byte byPicProType;//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;//ͼƬ���ṹ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_RULECFG[] struRuleCfg;//ÿ��ʱ��ζ�Ӧ����
        }

        //���ܷ�����ȡ���ƻ��ӽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_DEVSCHED
        {
            public NET_DVR_SCHEDTIME struTime;//ʱ�����
            public NET_DVR_PU_STREAM_CFG struPUStream;//ǰ��ȡ������
        }

        //���ܷ����ǲ������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_STREAMCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_IVMS_DEVSCHED[] struDevSched;//��ʱ�������ǰ��ȡ���Լ�������Ϣ
        }

        //��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION
        {
            public byte byEnable;//�Ƿ񼤻�, 0-�񣬷�0-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//��������0
            public NET_VCA_POLYGON struPolygon;//���ζ����
        }

        //������������ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_MASK_REGION_LIST
        {
            public uint dwSize;//�ṹ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //��������0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_MASK_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION[] struMask;//������������
        }

        //ATM�����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ENTER_REGION
        {
            public uint dwSize;
            public byte byEnable;//�Ƿ񼤻0-�񣬷�0-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_VCA_POLYGON struPolygon;//��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //IVMS������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_MASK_REGION_LIST
        {
            public uint dwSize;//�ṹ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_MASK_REGION_LIST[] struList;
        }

        //IVMS��ATM�����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ENTER_REGION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_ENTER_REGION[] struEnter;//��������
        }

        // ivms ����ͼƬ�ϴ��ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_ALARM_JPEG
        {
            public byte byPicProType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_JPEGPARA struPicParam;
        }

        // IVMS ���������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_IVMS_SEARCHCFG
        {
            public uint dwSize;
            public NET_DVR_MATRIX_DEC_REMOTE_PLAY struRemotePlay;// Զ�̻ط�
            public NET_IVMS_ALARM_JPEG struAlarmJpeg;// �����ϴ�ͼƬ����
            public NET_IVMS_RULECFG struRuleCfg;//IVMS ��Ϊ��������
        }

        /************************************end******************************************/
        //NAS��֤����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IDENTIFICATION_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* �û��� 32*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* ���� 16*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//����
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNT_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;   //������ṹ��С
            [FieldOffsetAttribute(0)]
            public NET_DVR_IDENTIFICATION_PARAM struIdentificationParam;//(SMB/CIFSʱ��Ч)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAS_MOUNT_PARAM
        {
            public byte byMountType; //0������,1~NFS, 2~ SMB/CIFS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_MOUNT_PARAM_UNION uMountParam;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_MOUNTMETHOD_PARAM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen; //������ṹ��С   
            [FieldOffsetAttribute(0)]
            public NET_DVR_NAS_MOUNT_PARAM struNasMountParam;//NAS���ط�ʽ (byNetDiskTypeΪNFS(NAS)ʱ��Ч) 
        }

        //����Ӳ�̽ṹ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SINGLE_NET_DISK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����
            public NET_DVR_IPADDR struNetDiskAddr;//����Ӳ�̵�ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PATHNAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDirectory;// PATHNAME_LEN = 128
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//����
        }

        public const int MAX_NET_DISK = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NET_DISKCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NET_DISK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SINGLE_NET_DISK_INFO[] struNetDiskParam;
        }

        //�¼�����
        //������
        public enum MAIN_EVENT_TYPE
        {
            EVENT_MOT_DET = 0,//�ƶ����
            EVENT_ALARM_IN = 1,//��������
            EVENT_VCA_BEHAVIOR = 2,//��Ϊ����
            EVENT_INQUEST = 3,       //��Ѷ�¼�
            EVENT_VCA_DETECTION = 4, //�������
            EVENT_STREAM_INFO = 100  //��ID��Ϣ
        }

        public const int INQUEST_START_INFO = 0x1001;      /*Ѷ�ʿ�ʼ��Ϣ*/
        public const int INQUEST_STOP_INFO = 0x1002;       /*Ѷ��ֹͣ��Ϣ*/
        public const int INQUEST_TAG_INFO = 0x1003;       /*�ص�����Ϣ*/
        public const int INQUEST_SEGMENT_INFO = 0x1004;      /*��ѶƬ��״̬��Ϣ*/

        public enum VCA_DETECTION_MINOR_TYPE:uint
        {
            EVENT_VCA_TRAVERSE_PLANE = 1,        //Խ�����
            EVENT_FIELD_DETECTION,		     //�����������
            EVENT_AUDIO_INPUT_ALARM,      //��Ƶ�����쳣
            EVENT_SOUND_INTENSITY_ALARM,   //��ǿͻ�����
            EVENT_FACE_DETECTION,             //�������
            EVENT_VIRTUAL_FOCUS_ALARM, /*�齹���*/
            EVENT_SCENE_CHANGE_ALARM, /*����������*/
            EVENT_ALL = 0xffffffff				//��ʾȫ��
        }

        //��Ϊ���������Ͷ�Ӧ�Ĵ����ͣ� 0xffff��ʾȫ��
        public enum BEHAVIOR_MINOR_TYPE
        {
            EVENT_TRAVERSE_PLANE = 0,// ��Խ������,
            EVENT_ENTER_AREA,//Ŀ���������,֧���������
            EVENT_EXIT_AREA,//Ŀ���뿪����,֧���������
            EVENT_INTRUSION,// �ܽ�����,֧���������
            EVENT_LOITER,//�ǻ�,֧���������
            EVENT_LEFT_TAKE,//�������,֧���������
            EVENT_PARKING,//ͣ��,֧���������
            EVENT_RUN,//����,֧���������
            EVENT_HIGH_DENSITY,//��������Ա�ܶ�,֧���������
            EVENT_STICK_UP,//��ֽ��,֧���������
            EVENT_INSTALL_SCANNER,//��װ������,֧���������
            EVENT_OPERATE_OVER_TIME,        // ������ʱ
            EVENT_FACE_DETECT,              // �쳣����
            EVENT_LEFT,                     // ��Ʒ����
            EVENT_TAKE,                      // ��Ʒ��ȡ
            EVENT_LEAVE_POSITION,         //����¼�
            EVENT_TRAIL_INFO = 16,            //β��
            EVENT_FALL_DOWN_INFO = 19,                 //����
            EVENT_OBJECT_PASTE = 20,		// ����ճ������
            EVENT_FACE_CAPTURE_INFO = 21,                //��������
            EVENT_MULTI_FACES_INFO = 22,                  //��������
            EVENT_AUDIO_ABNORMAL_INFO = 23,             //��ǿͻ��
            EVENT_DETECT = 24     			   //�������
        }

        // ������100����Ӧ��С����
        public enum STREAM_INFO_MINOR_TYPE
        {
            EVENT_STREAM_ID = 0,				// ��ID
            EVENT_TIMING = 1,					// ��ʱ¼��
            EVENT_MOTION_DETECT = 2,			// �ƶ����
            EVENT_ALARM = 3,					// ����¼��
            EVENT_ALARM_OR_MOTION_DETECT = 4,	// �������ƶ����
            EVENT_ALARM_AND_MOTION_DETECT = 5,	// �������ƶ����
            EVENT_COMMAND_TRIGGER = 6,			// �����
            EVENT_MANNUAL = 7,					// �ֶ�¼��
            EVENT_BACKUP_VOLUME = 8				// �浵��¼��
        }

        //��ŵCVR
        public const int MAX_ID_COUNT = 256;
        public const int MAX_STREAM_ID_COUNT = 1024;
        public const int STREAM_ID_LEN = 32;
        public const int PLAN_ID_LEN = 32;

        // ����Ϣ - 72�ֽڳ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byID;      //ID����
            public uint dwChannel;                //�����豸ͨ��������0xffffffffʱ����ʾ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                //����
            public void init()
            {
                byID = new byte[STREAM_ID_LEN];
                byRes = new byte[32];
            }
        }

        //�¼��������� 200-04-07 9000_1.1
        public const int SEARCH_EVENT_INFO_LEN = 300;

        //��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInNo;//��������ţ�byAlarmInNo[0]����1���ʾ�����ɱ�������1�������¼�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_ALARMIN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byAlarmInNo = new byte[MAX_ALARMIN_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //�������� ��ֵ��ʾ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.U2)]
            public ushort[] wAlarmInNo;//��������ţ�byAlarmInNo[0]����1���ʾ�����ɱ�������1�������¼�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wAlarmInNo = new ushort[128];
                byRes = new byte[44];
            }
        }

        //�ƶ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotDetChanNo;//�ƶ����ͨ����byMotDetChanNo[0]����1���ʾ������ͨ��1�����ƶ���ⴥ�����¼�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byMotDetChanNo = new byte[MAX_CHANNUM_V30];
                byRes = new byte[SEARCH_EVENT_INFO_LEN - MAX_CHANNUM_V30];
            }
        }

        //�ƶ����--��ֵ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wMotDetChanNo;//��������ţ�byAlarmInNo[0]����1���ʾ�����ɱ�������1�������¼�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 172, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                wMotDetChanNo = new ushort[64];
                byRes = new byte[172];
            }
        }

        //��Ϊ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYBIT
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChanNo;//�����¼���ͨ��
            public byte byRuleID;//����ID��0xff��ʾȫ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 235, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����

            public void init()
            {
                byChanNo = new byte[MAX_CHANNUM_V30];
                byRes1 = new byte[235];
            }
        }

        //��Ϊ����--��ֵ��ʽ���� 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_BYVALUE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.U2)]
            public ushort[] wChanNo;	//�����¼���ͨ��			
            public byte byRuleID;      //��Ϊ�������ͣ�����0xff��ʾȫ������0��ʼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 171, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	 /*����*/
            public void init()
            {
                wChanNo = new ushort[64];
                byRes = new byte[171];
            }
        }

        //��Ѷ�¼���������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_PARAM
		{			
            public byte byRoomIndex;    //��Ѷ�ұ��,��1��ʼ
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 299, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //����
            public void init()
            {
                byRes = new byte[299];
            }
		}

        //��������������
		[StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYBIT
		{
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;//������������ͨ���ţ��������±��ʾ��byChan[0]����1���ʾ������ͨ��1�����ƶ���ⴥ�����¼� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //����
            public void init()
            {
                byChan = new byte[256];
                byRes = new byte[44];
            }
		}
		
        //�������������� ��ͨ���Ű�ֵ��ʾ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCADETECT_BYVALUE
		{
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30-1, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo;// ����ͨ����,��ֵ��ʾ��0xffffffff��Ч���Һ�������Ҳ��ʾ��Чֵ
            public byte byAll;//0-��ʾ����ȫ����1-��ʾȫ����
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 47, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                dwChanNo = new uint[MAX_CHANNUM_V30 - 1];
                byRes = new byte[47];
            }
		}

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_PARAM
        {
            public NET_DVR_STREAM_INFO struIDInfo; // ��id��Ϣ��72�ֽڳ�
            public uint dwCmdType;  // �ⲿ�������ͣ�NVR�����ƴ洢ʹ��
            public byte byBackupVolumeNum; //�浵��ţ�CVRʹ��
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 223, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public void init()
            {
                struIDInfo.init();
                byRes = new byte[223];
            }
		}

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYBIT struAlarmParam;
            [FieldOffsetAttribute(0)]
            public EVENT_ALARM_BYVALUE struAlarmParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYBIT struMotionParam;
            [FieldOffsetAttribute(0)]
            public EVENT_MOTION_BYVALUE struMotionParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYBIT struVcaParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCA_BYVALUE struVcaParamByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_INQUEST_PARAM struInquestParam;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYBIT struVCADetectByBit;
            [FieldOffsetAttribute(0)]
            public EVENT_VCADETECT_BYVALUE struVCADetectByValue;
            [FieldOffsetAttribute(0)]
            public EVENT_STREAMID_PARAM struStreamIDParam;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_PARAM
        {
            public ushort wMajorType;//0-�ƶ���⣬1-��������, 2-�����¼�
            public ushort wMinorType;//����������- ���������ͱ仯��0xffff��ʾȫ��
            public NET_DVR_TIME struStartTime;//�����Ŀ�ʼʱ�䣬ֹͣʱ��: ͬʱΪ(0, 0) ��ʾ�������ʱ�俪ʼ���������ǰ���4000���¼�
            public NET_DVR_TIME struEndTime;
            public byte byLockType;		// 0xff-ȫ����0-δ����1-����
            public byte byValue;			//0-��λ��ʾ��1-��ֵ��ʾ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
            public SEARCH_EVENT_UNION uSeniorPara;
        }

        //����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_ALARM_RET
        {
            public uint dwAlarmInNo;//���������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //�ƶ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_MOTION_RET
        {
            public uint dwMotDetNo;//�ƶ����ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SEARCH_EVENT_INFO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes = new byte[SEARCH_EVENT_INFO_LEN];
            }
        }
        //��Ϊ������� 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_VCA_RET
        {
            public uint dwChanNo;//�����¼���ͨ����
            public byte byRuleID;//����ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;//��������
            public NET_VCA_EVENT_UNION uEvent;//��Ϊ�¼�������wMinorType = VCA_EVENT_TYPE�����¼�����

            public void init()
            {
                byRes1 = new byte[3];
                byRuleName = new byte[NAME_LEN];
            }
        }

        //��Ѷ�¼���ѯ��� 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_INQUEST_RET
        {
            public byte byRoomIndex;  //��Ѷ�ұ��,��1��ʼ
            public byte byDriveIndex; //��¼�����,��1��ʼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //����            
            public uint dwSegmentNo;     //��Ƭ���ڱ�����Ѷ�е����,��1��ʼ 
            public ushort wSegmetSize;     //��Ƭ�ϵĴ�С, ��λM 
            public ushort wSegmentState;   //��Ƭ��״̬ 0 ��¼������1 ��¼�쳣��2 ����¼��Ѷ
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 288, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     //����

            public void init()
            {
                byRes1 = new byte[6];
                byRes2 = new byte[288];
            }
        }

        //��id¼���ѯ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct EVENT_STREAMID_RET
        {
            public uint dwRecordType;	//¼������ 0-��ʱ¼�� 1-�ƶ���� 2-����¼�� 3-����|�ƶ���� 4-����&�ƶ���� 5-����� 6-�ֶ�¼�� 7-�𶯱��� 8-�������� 9-���ܱ��� 10-�ش�¼��
            public uint dwRecordLength;	//¼���С
            public byte byLockFlag;    // ������־ 0��û���� 1������
            public byte byDrawFrameType;    // 0���ǳ�֡¼�� 1����֡¼��
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
			[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byFileName; 	//�ļ���
            public uint dwFileIndex;    		// �浵���ϵ��ļ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void init()
            {
                byRes1 = new byte[2];
                byFileName = new byte[NAME_LEN];
                byRes = new byte[256];
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SEARCH_EVENT_RET
        {
            [FieldOffset(0)]
            public EVENT_ALARM_RET struAlarmRet;
            [FieldOffset(0)]
            public EVENT_MOTION_RET struMotionRet;
            [FieldOffset(0)]
            public EVENT_VCA_RET struVcaRet;
            [FieldOffset(0)]
            public EVENT_INQUEST_RET struInquestRet;
            [FieldOffset(0)]
            public EVENT_STREAMID_RET struStreamIDRet;
            public void init()
            {
                struAlarmRet = new EVENT_ALARM_RET();
                struAlarmRet.init();
                //struMotionRet = new EVENT_MOTION_RET();
                //struMotionRet.init();
            }
        }
        //���ҷ��ؽ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SEARCH_EVENT_RET
        {
            public ushort wMajorType;//������MA
            public ushort wMinorType;//������
            public NET_DVR_TIME struStartTime;//�¼���ʼ��ʱ��
            public NET_DVR_TIME struEndTime;//�¼�ֹͣ��ʱ�䣬�����¼�ʱ�Ϳ�ʼʱ��һ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public SEARCH_EVENT_RET uSeniorRet;

            public void init()
            {
                byChan = new byte[MAX_CHANNUM_V30];
                byRes = new byte[36];
                uSeniorRet = new SEARCH_EVENT_RET();
                uSeniorRet.init();
            }
        }

        //SDK_V35  2009-10-26

        // �궨��������
        public enum tagCALIBRATE_TYPE
        {
            PDC_CALIBRATE  = 0x01,  // PDC �궨
            BEHAVIOR_OUT_CALIBRATE  = 0x02, //��Ϊ���ⳡ���궨  
            BEHAVIOR_IN_CALIBRATE = 0x03,    // ��Ϊ���ڳ����궨 
            ITS_CALBIRETE       = 0x04      //  ��ͨ�¼��궨
        }

        public const int MAX_RECT_NUM = 6;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECT_LIST
        {	
            public byte byRectNum;    // ���ο�ĸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //�����ֽ� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struVcaRect; // ���Ϊ6��Rect 
        }

        // PDC �궨����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_CALIBRATION
        {
            public NET_DVR_RECT_LIST struRectList;       // �궨���ο��б�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // �����ֽ� 
        }

        // �궨�ߵ��������������ʾ��ǰ�궨����ʵ�ʱ�ʾ���Ǹ߶��߻��ǳ����ߡ�
        public enum LINE_MODE
        {
            HEIGHT_LINE,        //�߶�������
            LENGTH_LINE        //����������
        }
        /*�����ñ궨��Ϣ��ʱ�������Ӧλ������ʹ�ܣ���������ز�������û������ʹ�ܣ���궨����Ի�ȡ��ص����������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_PARAM
        {
            public byte byEnableHeight;     // �Ƿ�ʹ������������߶���
            public byte byEnableAngle;      // �Ƿ�ʹ����������������Ƕ�
            public byte byEnableHorizon;    // �Ƿ�ʹ�������������ƽ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // �����ֽ� 
            public float  fCameraHeight;    // ������߶�
            public float  fCameraAngle;     // ����������Ƕ�
            public float  fHorizon;         // �����еĵ�ƽ��
        }
        
        /*��fValue��ʾĿ��߶ȵ�ʱ��struStartPoint��struEndPoint�ֱ��ʾĿ��ͷ����ͽŲ��㡣
         * ��fValue��ʾ�߶γ��ȵ�ʱ��struStartPoint��struEndPoint�ֱ��ʾ�߶���ʼ����յ㣬
         * mode��ʾ��ǰ�����߱�ʾ�߶��߻��ǳ����ߡ�*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINE_SEGMENT
        {
            public byte byLineMode;     // ���� LINE_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // �����ֽ� 
            public NET_VCA_POINT   struStartPoint;  
            public NET_VCA_POINT   struEndPoint;
            public float fValue;
        }

        public const int MAX_LINE_SEG_NUM = 8;

        /*�궨������Ŀǰ��Ҫ4-8�������ߣ��Ի�ȡ�������ز���*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_OUT_CALIBRATION
        {
            public uint dwLineSegNum;          // �����߸���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINE_SEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LINE_SEGMENT[]  struLineSegment;    // ������������
            public NET_DVR_CAMERA_PARAM  struCameraParam;    // ���������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*�ýṹ���ʾIAS���ܿ�궨���������а���һ��Ŀ����һ����Ӧ�ĸ߶ȱ궨�ߣ�
         * Ŀ���Ϊվ����������Ӿ��ο򣻸߶���������ʶ����ͷ���㵽�ŵ�ı궨�ߣ��ù�һ�������ʾ��*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IN_CAL_SAMPLE
        {
            public NET_VCA_RECT struVcaRect;   // Ŀ���
            public NET_DVR_LINE_SEGMENT struLineSegment;    // �߶ȱ궨��
        }

        public const int MAX_SAMPLE_NUM = 5;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BEHAVIOR_IN_CALIBRATION 
        {
            public uint dwCalSampleNum;      //  �궨��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SAMPLE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IN_CAL_SAMPLE[]  struCalSample; // �궨����������
            public NET_DVR_CAMERA_PARAM    struCameraParam;    // ���������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int CALIB_PT_NUM = 4;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ITS_CALIBRATION
        {
            public uint dwPointNum; //�궨����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CALIB_PT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POINT[] struPoint; //ͼ������
            public float fWidth;
            public float fHeight;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        // �����ֽ�
        }

        // �궨����������
        // ��������ر궨�������Է��ڸýṹ����
        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_CALIBRATION_PRARM_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //������ṹ��С
            [FieldOffsetAttribute(0)]
            public NET_DVR_PDC_CALIBRATION struPDCCalibration;  //PDC �궨����
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_OUT_CALIBRATION  struBehaviorOutCalibration;  //  ��Ϊ���ⳡ���궨  ��ҪӦ����IVS��
            [FieldOffsetAttribute(0)]
            public NET_DVR_BEHAVIOR_IN_CALIBRATION  struBehaviorInCalibration;     // ��Ϊ���ڳ����궨����ҪӦ��IAS�� 
            [FieldOffsetAttribute(0)]
            public NET_DVR_ITS_CALIBRATION struITSCalibration;
        }

        // �궨���ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CALIBRATION_CFG
        {
            public uint dwSize;               //�궨�ṹ��С
            public byte byEnable;           // �Ƿ����ñ궨
            public byte byCalibrationType;    // �궨���� ���ݲ�ͬ��������������ѡ��ͬ�ı궨 �ο�CALIBRATE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_CALIBRATION_PRARM_UNION uCalibrateParam;  // �궨����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //����ͳ�Ʒ���ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ENTER_DIRECTION
        {
            public NET_VCA_POINT struStartPoint; //����ͳ�Ʒ�����ʼ��
            public NET_VCA_POINT struEndPoint;    // ����ͳ�Ʒ�������� 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG
        {
            public uint dwSize;              //�ṹ��С
            public byte byEnable;             // �Ƿ񼤻����;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // �����ֽ� 
            public NET_VCA_POLYGON  struPolygon;            // �����
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // �������뷽��
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_RULE_CFG_V41
        {
            public uint dwSize;              //�ṹ��С
            public byte byEnable;             // �Ƿ񼤻����;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // �����ֽ� 
            public NET_VCA_POLYGON struPolygon;            // �����
            public NET_DVR_PDC_ENTER_DIRECTION  struEnterDirection;    // �������뷽��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME struAlarmTime;//����ʱ��
            public NET_DVR_TIME_EX struDayStartTime; //���쿪ʼʱ�䣬ʱ������Ч
            public NET_DVR_TIME_EX struNightStartTime; //ҹ��ʼʱ�䣬ʱ������Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       // �����ֽ�
        }

        //���ð���Ϣ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIAL_VERSION_CFG
        {
            public uint dwSize;
            public ushort wReserveTime; //������ʣ��ʱ�䣬0xffff��ʾ��Ч����λ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYN_CHANNEL_NAME_PARAM
        {
            public uint dwSize;
            public uint dwChannel; //ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RESET_COUNTER_CFG
        {
            public uint dwSize;
            public byte byEnable; //�Ƿ����ã�0-�����ã�1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TIME_EX[] struTime;//��������ʱ�䣬ʱ������Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_COND
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO  struStreamInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CTRLINFO_CFG
        {
            public uint dwSize;
            public byte byVCAEnable;     //�Ƿ�������
            public byte byVCAType;       //�����������ͣ�VCA_CHAN_ABILITY_TYPE 
            public byte byStreamWithVCA; //�������Ƿ��������Ϣ
            public byte byMode;			//ģʽ��ATM ����ʱ����VCA_CHAN_MODE_TYPE ,TFS ����ʱ���� TFS_CHAN_MODE_TYPE����Ϊ����������ʱ����BEHAVIOR_SCENE_MODE_TYPE
            public byte byControlType;   //�������ͣ���λ��ʾ��0-��1-��
	                        //byControlType &1 �Ƿ�����ץ�Ĺ���
                            //byControlType &2 �Ƿ���������ǰ���豸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 83, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 		//����������Ϊ0
        }

        /*����������ͳ�Ʋ���  ������Ϊ�ڲ��ؼ��ֲ���
         * HUMAN_GENERATE_RATE
         * Ŀ�������ٶȲ���������PDC������Ŀ����ٶȡ��ٶ�Խ�죬Ŀ��Խ�������ɡ�
         * ��������Ƶ���������ϲ�ԱȶȽϵ�ʱ���������õĹ��������Сʱ��Ӧ�ӿ�Ŀ�������ٶȣ� ����Ŀ���©�죻
         * ��������Ƶ�жԱȶȽϸ�ʱ�����߹�������ϴ�ʱ��Ӧ�ý���Ŀ�������ٶȣ��Լ�����졣
         * Ŀ�������ٶȲ�������5����1���ٶ�������5����죬Ĭ�ϲ���Ϊ3��
         *
         * DETECT_SENSITIVE
         * Ŀ���������ȿ��Ʋ���������PDC����һ���������򱻼��ΪĿ��������ȡ�
         * ������Խ�ߣ���������Խ���ױ����ΪĿ�꣬������Խ����Խ�Ѽ��ΪĿ�ꡣ
         * ��������Ƶ���������ϲ�ԱȶȽϵ�ʱ��Ӧ��߼�������ȣ� ����Ŀ���©�죻
         * ��������Ƶ�жԱȶȽϸ�ʱ��Ӧ�ý��ͼ�������ȣ��Լ�����졣
         * ��Ӧ��������5��������1��������ͣ�5����ߣ�Ĭ�ϼ���Ϊ3��
         * 
         * TRAJECTORY_LEN
         * �켣���ɳ��ȿ��Ʋ�������ʾ���ɹ켣ʱҪ��Ŀ������λ�����ء�
         * ��Ӧ��������5��������1�����ɳ�������켣����������5�����ɳ�����̣��켣������죬Ĭ�ϼ���Ϊ3��
         * 
         * TRAJECT_CNT_LEN
         * �켣�������ȿ��Ʋ�������ʾ�켣����ʱҪ��Ŀ������λ�����ء�
         * ��Ӧ��������5��������1������Ҫ�󳤶�����켣����������5������Ҫ�󳤶���̣��켣������죬Ĭ�ϼ���Ϊ3��
         * 
         * PREPROCESS
         * ͼ��Ԥ������Ʋ�����0 - ������1 - ����Ĭ��Ϊ0��
         * 
         * CAMERA_ANGLE
         * ������Ƕ���������� 0 - ��б�� 1 - ��ֱ��Ĭ��Ϊ0��
         */

        public enum PDC_PARAM_KEY
        {
            HUMAN_GENERATE_RATE = 50,  // Ŀ�������ٶ� ��50��ʼ
            DETECT_SENSITIVE    = 51,  // ���������
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_INFO
        {
            public uint dwTargetID;                 // Ŀ��id 
            public NET_VCA_RECT struTargetRect;    // Ŀ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_TARGET_IN_FRAME
        {
            public byte byTargetNum;                   //Ŀ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] yRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PDC_TARGET_INFO[]  struTargetInfo;   //Ŀ����Ϣ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                  // �����ֽ�
        }

        //��֡ͳ�ƽ��ʱʹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATFRAME
        {
            public uint dwRelativeTime;     // ���ʱ��
            public uint dwAbsTime;          // ����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_STATTIME
        {
            public NET_DVR_TIME tmStart; // ͳ����ʼʱ�� 
            public NET_DVR_TIME tmEnd;  //  ͳ�ƽ���ʱ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 92, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_ALRAM_INFO
        {
            public uint dwSize;           // PDC�����������ϴ��ṹ���С
            public byte byMode;            // 0 ��֡ͳ�ƽ�� 1��Сʱ���ͳ�ƽ��  
            public byte byChannel;           // �����ϴ�ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;         // �����ֽ�   
            public NET_VCA_DEV_INFO  	 struDevInfo;		        //ǰ���豸��Ϣ
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uStatModeParam
            {
                [FieldOffsetAttribute(0)]
                //��֡ͳ�ƽ��ʱʹ��
                public UNION_STATFRAME struStatFrame;

                [FieldOffsetAttribute(0)]
                public UNION_STATTIME struStatTime;
            }
            public uint dwLeaveNum;        // �뿪����
            public uint dwEnterNum;        // ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // �����ֽ�
        }

        //��������Ϣ��ѯ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PDC_QUERY
        {
            public NET_DVR_TIME tmStart;
            public NET_DVR_TIME tmEnd;
            public uint dwLeaveNum;
            public uint dwEnterNum; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PTZ_POSITION
        {
            // �Ƿ����ó����������ó�����Ϊ�����ʱ����ֶ���Ч������������������ó���λ����Ϣʱ��Ϊʹ��λ
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPtzPositionName; //����λ������
            public NET_DVR_PTZPOS struPtzPos; //ptz ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG
        {
            public uint dwSize;             // �ṹ��С 
            public NET_DVR_PTZ_POSITION    struPtzPosition;    // ����λ����Ϣ
            public NET_VCA_RULECFG         struVcaRuleCfg;     //��Ϊ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // �����ֽ�
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_RULE_CFG_V41
        {
            public uint dwSize;             // �ṹ��С 
            public NET_DVR_PTZ_POSITION  struPtzPosition;    // ����λ����Ϣ
            public NET_VCA_RULECFG_V41   struVcaRuleCfg;     //��Ϊ��������
            public byte byTrackEnable; //�Ƿ����ø���
            public byte byRes1;
            public ushort wTrackDuration; //���ٳ���ʱ�䣬��λs
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIMIT_ANGLE
        {
            public byte byEnable;	// �Ƿ����ó�����λ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_PTZPOS  struUp;     // ����λ
            public NET_DVR_PTZPOS  struDown;   // ����λ
            public NET_DVR_PTZPOS  struLeft;   // ����λ
            public NET_DVR_PTZPOS  struRight;  // ����λ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_INDEX
        {
            public byte byIndex;    // ��������
            public byte byRes1;
            public ushort wDwell;	// ͣ��ʱ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   // �����ֽ�
        }

        public const int MAX_POSITION_NUM = 10;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSITION_TRACK_CFG
        {
            public uint dwSize;
            public byte byNum; // ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_POSITION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_POSITION_INDEX[]   struPositionIndex;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        //Ѳ��·��������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_SCENE_INFO
        {
            public ushort wDwell;         // ͣ��ʱ�� 30-300
            public byte byPositionID;   // ������1-10��Ĭ��0��ʾ��Ѳ���㲻��ӳ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //����Ѳ������������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PATROL_TRACKCFG
        {
            public uint dwSize;  // �ṹ��С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PATROL_SCENE_INFO[] struPatrolSceneInfo;    // Ѳ��·��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                              // �����ֽ�
        }

        //������ع���˵����ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRACK_PARAMCFG
        {
            public uint dwSize;             // �ṹ��С
            public ushort wAlarmDelayTime;    // ������ʱʱ�䣬Ŀǰ���ֻ֧��ȫ������ ��Χ1-120��
            public ushort wTrackHoldTime;     // �������ٳ���ʱ��  ��Χ0-300��
            public byte byTrackMode;        //  ���� IPDOME_TRACK_MODE
            public byte byPreDirection;	// ���ٷ���Ԥ�� 0-������ 1-����
            public byte byTrackSmooth;	    // ��������  0-������ 1-����
            public byte byZoomAdjust;	// ����ϵ������ �μ��±�
            public byte byMaxTrackZoom;	//�����ٱ���ϵ��,0-��ʾĬ�ϱ���ϵ��,�ȼ�6-�궨ֵ*1.0(Ĭ��),1-5Ϊ��С�궨ֵ��ֵԽС����С�ı���Խ��,7-15Ϊ�Ŵ�ֵԽ�󣬷Ŵ�ı���Խ��
            public byte byStopTrackWhenFindFace;  //������⵽���Ƿ�ֹͣ���� 0-�� 1-��
            public byte byStopTrackThreshold;   //������ֹ������ֵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //  �����ֽ�                
        }

        //�����о����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DOME_MOVEMENT_PARAM
        {
            public ushort wMaxZoom;   // ��������ϵ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 42, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // �����ֽ�
        }

        /********************************���ܽ�ͨ�¼� begin****************************************/
        public const int MAX_REGION_NUM	= 8;  // �����б������Ŀ
        public const int MAX_TPS_RULE = 8;   // ������������Ŀ
        public const int MAX_AID_RULE = 8;   // ����¼�������Ŀ
        public const int MAX_LANE_NUM = 8;   // ��󳵵���Ŀ

        //��ͨ�¼�����
        public enum TRAFFIC_AID_TYPE
        {
            CONGESTION            = 0x01,    //ӵ��
            PARKING               = 0x02,    //ͣ��  
            INVERSE               = 0x04,    //����
            PEDESTRIAN            = 0x08,    //����                      
            DEBRIS                = 0x10,    //������ ��������Ƭ 
            SMOKE                 = 0x20,    //����  
	        OVERLINE              = 0x40,     //ѹ��
	        VEHICLE_CONTROL_LIST  = 0x80,  //����������
	        SPEED                 = 0x100  //����
        }
        
        public enum TRAFFIC_SCENE_MODE
        {
	        FREEWAY = 0,	//  ���ٻ��ⳡ��
	        TUNNEL,         //  �����������
	        BRIDGE          //  ������������
        }
        
        public enum ITS_ABILITY_TYPE
        {
            ITS_CONGESTION_ABILITY             = 0x01,      //ӵ��
            ITS_PARKING_ABILITY                = 0x02,      //ͣ��  
            ITS_INVERSE_ABILITY                = 0x04,      //����
            ITS_PEDESTRIAN_ABILITY             = 0x08,      //����                      
            ITS_DEBRIS_ABILITY                 = 0x10,      //������ ��������Ƭ
            ITS_SMOKE_ABILITY                  = 0x20,      //����-���
            ITS_OVERLINE_ABILITY               = 0x40,      //ѹ��
	        ITS_VEHICLE_CONTROL_LIST_ABILITY   = 0x80,		//����������
	        ITS_SPEED_ABILITY				   = 0x100,	    //����	
            ITS_LANE_VOLUME_ABILITY            = 0x010000,  //��������
            ITS_LANE_VELOCITY_ABILITY          = 0x020000,  //����ƽ���ٶ�
            ITS_TIME_HEADWAY_ABILITY           = 0x040000,  //��ͷʱ��
            ITS_SPACE_HEADWAY_ABILITY          = 0x080000,  //��ͷ���
            ITS_TIME_OCCUPANCY_RATIO_ABILITY   = 0x100000,  //����ռ���ʣ���ʱ����)
            ITS_SPACE_OCCUPANCY_RATIO_ABILITY  = 0x200000,  //����ռ���ʣ��ٷֱȼ��㣨�ռ���)
            ITS_LANE_QUEUE_ABILITY             = 0x400000,  //�Ŷӳ���
	        ITS_VEHICLE_TYPE_ABILITY           = 0x800000,  //��������
	        ITS_TRAFFIC_STATE_ABILITY          = 0x1000000  //��ͨ״̬
        }
        
        // ��ͨͳ�Ʋ���
        public enum ITS_TPS_TYPE
        {
            LANE_VOLUME           = 0x01,    //��������
            LANE_VELOCITY         = 0x02,    //�����ٶ�
            TIME_HEADWAY          = 0x04,    //��ͷʱ��
            SPACE_HEADWAY         = 0x08,    //��ͷ���
            TIME_OCCUPANCY_RATIO  = 0x10,    //����ռ���� (ʱ����)
            SPACE_OCCUPANCY_RATIO = 0x20,    //����ռ���ʣ��ٷֱȼ���(�ռ���)
            QUEUE                 = 0x40,    //�Ŷӳ���
	        VEHICLE_TYPE          = 0x80,    //��������
	        TRAFFIC_STATE         = 0x100    //��ͨ״̬
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REGION_LIST
        {
            public uint dwSize;	// �ṹ���С
            public byte byNum;      // �������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_POLYGON[] struPolygon; // ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	// �����ֽ�
        }

        //����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIRECTION
        {
            public NET_VCA_POINT struStartPoint;   // ������ʼ��
            public NET_VCA_POINT struEndPoint;     // ��������� 
        }

        //��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LANE
        {
            public byte byEnable;  //�����Ƿ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	   // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneName;       // ������������
            public NET_DVR_DIRECTION struFlowDirection;// �����ڳ�������
            public NET_VCA_POLYGON struPolygon;		// ��������
        }

        //��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_CFG
        {
            public uint dwSize;	// �ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LANE[] struLane;	// �������� �����±���Ϊ����ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	 // �����ֽ�
        }

        //��ͨ�¼�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_PARAM
        {
            public ushort wParkingDuration;       // Υͣ���������  10-120s
            public ushort wPedestrianDuration;    // ���˳���ʱ��    1-120s
            public ushort wDebrisDuration;        // ���������ʱ��  10-120s
            public ushort wCongestionLength;      // ӵ�³�����ֵ    5-200���ף�
            public ushort wCongestionDuration;    // ӵ�³�������    10-120s
            public ushort wInverseDuration;       // ���г���ʱ��    1-10s
            public ushort wInverseDistance;       // ���о�����ֵ ��λm ��Χ[2-100] Ĭ�� 10��
            public ushort wInverseAngleTolerance; // ����Ƕ�ƫ�� 90-180��,��������������ļн�
            public ushort wIllegalParkingTime;    // Υͣʱ��[4,60]����λ������ ,TFS(��ͨΥ��ȡ֤) ����ģʽ��
            public ushort wIllegalParkingPicNum;  // ΥͣͼƬ����[1,6], TFS(��ͨΥ��ȡ֤) ����ģʽ��
            public byte byMergePic;             // ͼƬƴ��,TFS ����ģʽ�� 0- ��ƴ�� 1- ƴ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;             // �����ֽ�
        }

        //������ͨ�¼�����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE
        {   
            public byte byEnable;                   // �Ƿ������¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;       // �������� 
            public uint dwEventType;                // ��ͨ�¼�������� TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; // �ߴ������
            public NET_VCA_POLYGON     struPolygon;    // ��������
            public NET_DVR_AID_PARAM   struAIDParam;   //  �¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //����ʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //��ͨ�¼�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG
        {
            public uint dwSize;                    // �ṹ���С 
            public byte byPicProType;              //����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                 // �����ֽ�
            public NET_DVR_JPEGPARA struPictureParam; //ͼƬ���ṹ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE[]  struOneAIDRule;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //������ͨ�¼�����ṹ��(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_AID_RULE_V41
        {   
            public byte byEnable;                 // �Ƿ������¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;     // �������� 
            public uint dwEventType;              // ��ͨ�¼�������� TRAFFIC_AID_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter;           // �ߴ������
            public NET_VCA_POLYGON struPolygon;              // ��������
            public NET_DVR_AID_PARAM struAIDParam;             // �¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;// ����ʱ���
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	          //����ʽ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_IVMS_IP_CHANNEL, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan; //����������¼��ͨ����1��ʾ������ͨ����0��ʾ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //����
        }

        //��ͨ�¼�����(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_RULECFG_V41
        {
            public uint dwSize;                     // �ṹ���С 
            public byte byPicProType;               // ����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                  // �����ֽ�
            public NET_DVR_JPEGPARA struPictureParam; 	// ͼƬ���ṹ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_AID_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_AID_RULE_V41[]  struAIDRule;  //��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                //����
        }

        //��ͨͳ�Ʋ����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE
        {
            public byte byEnable;                   //�Ƿ�ʹ�ܳ�����ͨ�������
            public byte byLaneID;		            //����ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwCalcType;                 //ͳ�Ʋ�������ITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER struSizeFilter; //�ߴ������ 
            public NET_VCA_POLYGON struVitrualLoop;    //������Ȧ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	//����ʽ,һ��Ϊ�����Ƿ��ϴ����ģ��������ܲ���Ҫ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                         //�����ֽ�
        }

        //��ͨ����ͳ�ƹ������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG
        {
            public uint dwSize;              // �ṹ��С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE[] struOneTpsRule; // �±��Ӧ��ͨ����ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         // �����ֽ�
        }

        //��ͨͳ�Ʋ����ṹ��(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_TPS_RULE_V41
        {
            public byte byEnable;                     //�Ƿ�ʹ�ܳ�����ͨ�������
            public byte byLaneID;		              //����ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //����
            public uint dwCalcType;                   // ͳ�Ʋ�������ITS_TPS_TYPE
            public NET_VCA_SIZE_FILTER  struSizeFilter;  //�ߴ������ 
            public NET_VCA_POLYGON  struVitrualLoop; //������Ȧ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]  struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	   //����ʽ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   // �����ֽ�
        }

        //��ͨ����ͳ�ƹ������ýṹ��(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_RULECFG_V41
        {
            public uint dwSize;         // �ṹ��С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_TPS_RULE_V41[] struOneTpsRule; // �±��Ӧ��ͨ����ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // ����
        }

        //��ͨ�¼���Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_INFO
        {
            public byte byRuleID;   // ������ţ�Ϊ�������ýṹ�±꣬0-16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; //  ��������
            public uint dwAIDType;  // �����¼�����
            public NET_DVR_DIRECTION   struDirect; // ����ָ������  
            public byte bySpeedLimit; //����ֵ����λkm/h[0,255]
            public byte byCurrentSpeed; //��ǰ�ٶ�ֵ����λkm/h[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 38, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  // �����ֽ� 
        }

        //��ͨ�¼����� 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM
        {
            public uint dwSize;         // �ṹ����
            public uint dwRelativeTime;	// ���ʱ��
            public uint dwAbsTime;		// ����ʱ��
            public NET_VCA_DEV_INFO struDevInfo;	// ǰ���豸��Ϣ
            public NET_DVR_AID_INFO struAIDInfo;    // ��ͨ�¼���Ϣ
            public uint dwPicDataLen;   // ����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����
            public IntPtr pImage;        // ָ��ͼƬ��ָ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // �����ֽ�  
        }

        //�������нṹ�� 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_QUEUE
        {
            public NET_VCA_POINT struHead;       //����ͷ
            public NET_VCA_POINT struTail;       //����β
            public uint dwLength;      //ʵ�ʶ��г��� ��λΪ�� [0-500]
        }

        public enum TRAFFIC_DATA_VARY_TYPE
        {
            NO_VARY,         //�ޱ仯 
            VEHICLE_ENTER,   //��������������Ȧ
            VEHICLE_LEAVE,   //�����뿪������Ȧ 
            UEUE_VARY        //���б仯             
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;  //������������ 
            public byte byRuleID;              //������ţ�Ϊ�������ýṹ�±꣬0-7 
            public byte byVaryType;            //������ͨ�����仯���� ���� TRAFFIC_DATA_VARY_TYPE
            public byte byLaneType;			   //�������л�����
            public byte byRes1;
            public uint dwLaneVolume;         //�������� ��ͳ���ж��ٳ���ͨ��
            public uint dwLaneVelocity;        //�����ٶȣ��������
            public uint dwTimeHeadway;         //��ͷʱ�࣬�������
            public uint dwSpaceHeadway;        //��ͷ��࣬����������
            public float fSpaceOccupyRation;    //����ռ���ʣ��ٷֱȼ��㣨�ռ���)
            public NET_DVR_LANE_QUEUE struLaneQueue;    //�������г���
            public NET_VCA_POINT struRuleLocation; //��Ȧ��������ĵ�λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO
        {
            public uint dwLanNum;   // ��ͨ�����ĳ�����Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM[]  struLaneParam;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM
        {
            public uint dwSize;          //�ṹ���С
            public uint dwRelativeTime;  //���ʱ��
            public uint dwAbsTime;       //����ʱ��
            public NET_VCA_DEV_INFO  struDevInfo;     //ǰ���豸��Ϣ
            public NET_DVR_TPS_INFO  struTPSInfo;     //��ͨ�¼���Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      //�����ֽ�
        }
        
        public enum TRAFFIC_DATA_VARY_TYPE_EX_ENUM
        {    
	        ENUM_TRAFFIC_VARY_NO             = 0x00,   //�ޱ仯
	        ENUM_TRAFFIC_VARY_VEHICLE_ENTER  = 0x01,   //��������������Ȧ
	        ENUM_TRAFFIC_VARY_VEHICLE_LEAVE  = 0x02,   //�����뿪������Ȧ
	        ENUM_TRAFFIC_VARY_QUEUE          = 0x04,   //���б仯
	        ENUM_TRAFFIC_VARY_STATISTIC      = 0x08,   //ͳ�����ݱ仯��ÿ���ӱ仯һ�ΰ���ƽ���ٶȣ������ռ�/ʱ��ռ���ʣ���ͨ״̬��        
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LANE_PARAM_V41
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName; // ������������
            public byte byRuleID;             // ������ţ�Ϊ�������ýṹ�±꣬0-7 
            public byte byLaneType;		     // �������л�����
            public byte byTrafficState;       // �����Ľ�ͨ״̬��0-��Ч��1-��ͨ��2-ӵ����3-����
            public byte byRes1;               // ����
            public uint dwVaryType;           // ������ͨ�����仯���Ͳ���  TRAFFIC_DATA_VARY_TYPE_EX_ENUM����λ����
            public uint dwTpsType;            // ���ݱ仯���ͱ�־����ʾ��ǰ�ϴ���ͳ�Ʋ����У���Щ������Ч������ITS_TPS_TYPE,��λ����
            public uint dwLaneVolume;	     // ����������ͳ���ж��ٳ���ͨ��
            public uint dwLaneVelocity;       // �����ٶȣ��������
            public uint dwTimeHeadway ;       // ��ͷʱ�࣬�������
            public uint dwSpaceHeadway;       // ��ͷ��࣬����������
            public float fSpaceOccupyRation;   // ����ռ���ʣ��ٷֱȼ��㣨�ռ���)
            public float fTimeOccupyRation;    // ʱ��ռ���ʣ��ٷֱȼ���
            public uint dwLightVehicle;       // С�ͳ�����
            public uint dwMidVehicle;         // ���ͳ�����
            public uint dwHeavyVehicle;       // ���ͳ�����
            public NET_DVR_LANE_QUEUE struLaneQueue;        // �������г���
            public NET_VCA_POINT struRuleLocation;     // ����λ��������Ȧ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;           // ����
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_INFO_V41
        {
            public uint dwLanNum;          // ��ͨ�����ĳ�����Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TPS_RULE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LANE_PARAM_V41[]  struLaneParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //����
        }

        //������������ 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG
        {
            public uint dwSize;              // �ṹ���С
            public byte byEnable;            // �Ƿ�����
            public byte byEventType;			//�����¼����ͣ� 0-�쳣����; 1-��������;2-�쳣����&��������;
            public byte byUpLastAlarm;       //2011-04-06 �Ƿ����ϴ����һ�εı���
            public byte byUpFacePic; //�Ƿ��ϴ�������ͼ��0-��1-��	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON     struVcaPolygon;    // ��������������
            public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            public byte bySensitivity;   // ����������
            public ushort wDuration;      // ������������ʱ����ֵ
            public NET_DVR_JPEGPARA    struPictureParam; 		//ͼƬ���ṹ
            public NET_VCA_SIZE_FILTER struSizeFilter;         //�ߴ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //����ʽ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            public byte byPicRecordEnable;  /*2012-3-1�Ƿ�����ͼƬ�洢, 0-������, 1-����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;         //�����ֽ�
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACE_PIPCFG
        {	
            public byte byEnable; //�Ƿ������л�
            public byte byBackChannel; //����ͨ���ţ����ͨ����
            public byte byPosition; //����λ�ã�0-����,1-����,2-����,3-����
            public byte byPIPDiv; //����ϵ��(��������:��廭��)��0-1:4,1-1:9,2-1:16
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_RULECFG_V41
        {
            public uint dwSize;              // �ṹ���С
            public byte byEnable;            // �Ƿ�����
            public byte byEventType;			//�����¼����ͣ� 0-�쳣����; 1-��������;2-�쳣����&��������;
            public byte byUpLastAlarm;       //2011-04-06 �Ƿ����ϴ����һ�εı���
            public byte byUpFacePic; //�Ƿ��ϴ�������ͼ��0-��1-��	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;
            public NET_VCA_POLYGON struVcaPolygon;    // ��������������
            public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            public byte bySensitivity;   // ����������
            public ushort wDuration;      // ������������ʱ����ֵ
            public NET_DVR_JPEGPARA    struPictureParam; 		//ͼƬ���ṹ
            public NET_VCA_SIZE_FILTER struSizeFilter;         //�ߴ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[]   struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;	  //����ʽ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;			//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            public byte byPicRecordEnable;  /*2012-10-22�Ƿ�����ͼƬ�洢, 0-������, 1-����*/
            public byte byRes1;
            public ushort wAlarmDelay; //2012-10-22���ܱ�����ʱ��0-5s,1-10,2-30s,3-60s,4-120s,5-300s,6-600s
            public NET_DVR_FACE_PIPCFG struFacePIP; //2012-11-7���л�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //�����ֽ�
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FACEDETECT_ALARM
        {
            public uint dwSize;     		// �ṹ��С
            public uint dwRelativeTime; // ���ʱ��
            public uint dwAbsTime;			// ����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;   // ��������
            public NET_VCA_TARGET_INFO  struTargetInfo;	//����Ŀ����Ϣ
            public NET_VCA_DEV_INFO  	 struDevInfo;		//ǰ���豸��Ϣ
            public uint dwPicDataLen;						//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����*/
            public byte byAlarmPicType;			// 0-�쳣��������ͼƬ 1- ����ͼƬ,2-�������� 
            public byte byPanelChan;        /*2012-3-1����ͨ�����������ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwFacePicDataLen;			//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // �����ֽ�
            public IntPtr pFaceImage; //ָ������ͼָ��
            public IntPtr pImage;   						//ָ��ͼƬ��ָ��
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] uLen;        	// �������СΪ12�ֽ�
            public uint dwHumanIn;  	//�����˽ӽ� 0 - ���� 1- ����  
            public float fCrowdDensity;  // ��Ա�ۼ�ֵ
        }

        //Ŀǰֻ�����������¼�����Ա�ۼ��¼�ʵʱ�����ϴ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO
        {
            public byte byRuleID;				// Rule ID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				// �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRuleName;	// ��������
            public uint dwEventType;    		// ����VCA_EVENT_TYPE
            public NET_DVR_EVENT_PARAM_UNION uEventParam;  // 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_INFO_LIST
        {
            public byte byNum;		// �¼�ʵʱ��Ϣ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_EVENT_INFO[] struEventInfo;	// �¼�ʵʱ��Ϣ
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RULE_INFO_ALARM
        {
            public uint dwSize;				// �ṹ���С
            public uint dwRelativeTime; 	// ���ʱ��
            public uint dwAbsTime;			// ����ʱ��
            public NET_VCA_DEV_INFO  	struDevInfo;		// ǰ���豸��Ϣ
            public NET_DVR_EVENT_INFO_LIST struEventInfoList;	//�¼���Ϣ�б�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// �����ֽ�
        }

        //��������ʱ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_TIME
        {
            public byte byActive;                     //0 -��Ч,1�C��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                    //����
            public uint dwSceneID;                    //����ID
            public NET_DVR_SCHEDTIME struEffectiveTime;   //������Чʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                   //����
        }

        //������Чʱ�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_TIME_CFG
        {   
            public uint dwSize;                                               //�ṹ��С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SCENE_TIMESEG_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_TIME[] struSceneTime; //����ʱ�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                            //����
        }

        //��������������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_SCENE_CFG
        {    
            public byte byEnable;                 //�Ƿ����øó���,0-������ 1- ����
            public byte byDirection;              //��ⷽ�� 1-���У�2-���У�3-˫��4-�ɶ�������5-�����򱱣�6-�����򶫣�7-�ɱ����ϣ�8-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                //����
            public uint dwSceneID;                //����ID(ֻ��), 0 - ��ʾ�ó�����Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;    //��������
            public NET_DVR_PTZPOS struPtzPos;       //ptz ����
            public uint dwTrackTime;              //�������ʱ��[5,300] �룬TFS(��ͨȡ֤)ģʽ����Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;               //����
        }

        //�������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_CFG
        {
            public uint dwSize;                                          //�ṹ��С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITS_SCENE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_SCENE_CFG[] struSceneCfg; //����������Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                                      //����
        }

        //�ೡ����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_COND
        {
            public uint dwSize;       //�ṹ��С
            public Int32 lChannel;     //ͨ����
            public uint dwSceneID;    //����ID, 0-��ʾ�ó�����Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //����
        }

        //ȡ֤��ʽ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FORENSICS_MODE
        {
            public uint dwSize;      //�ṹ��С
            public byte byMode;      // 0-�ֶ�ȡ֤ ,1-�Զ�ȡ֤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   //����
        }

        //����������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENE_INFO
        {  
            public uint dwSceneID;              //����ID, 0 - ��ʾ�ó�����Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] bySceneName;  //��������
            public byte byDirection;            //��ⷽ�� 1-���У�2-���У�3-˫��4-�ɶ�������5-�����򱱣�6-�����򶫣�7-�ɱ����ϣ�8-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;              //����
            public NET_DVR_PTZPOS  struPtzPos;             //Ptz ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2 ;            //����
        }

        //��ͨ�¼�����(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AID_ALARM_V41
        {
            public uint dwSize;              //�ṹ����
            public uint dwRelativeTime;	    //���ʱ��
            public uint dwAbsTime;			//����ʱ��
            public NET_VCA_DEV_INFO  struDevInfo;		    //ǰ���豸��Ϣ
            public NET_DVR_AID_INFO  struAIDInfo;         //��ͨ�¼���Ϣ
            public NET_DVR_SCENE_INFO struSceneInfo;       //������Ϣ
            public uint dwPicDataLen;        //ͼƬ����
            public IntPtr pImage; 			//ָ��ͼƬ��ָ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //����
        }

        //��ͨͳ����Ϣ����(��չ)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TPS_ALARM_V41
        {
            public uint dwSize;          // �ṹ���С
            public uint dwRelativeTime;  // ���ʱ��
            public uint dwAbsTime;       // ����ʱ��
            public NET_VCA_DEV_INFO struDevInfo;     // ǰ���豸��Ϣ
            public NET_DVR_TPS_INFO_V41  struTPSInfo;     // ��ͨ����ͳ����Ϣ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_VERSION
        {
            public ushort wMajorVersion;		// ���汾��
            public ushort wMinorVersion;		// �ΰ汾��
            public ushort wRevisionNumber;	// ������
            public ushort wBuildNumber;		// �����
            public ushort wVersionYear;		//	�汾����-��
            public byte byVersionMonth;		//	�汾����-��
            public byte byVersionDay;		//	�汾����-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			// �����ֽ�
        }
        /*******************************���ܽ�ͨ�¼� end*****************************************/

        /******************************����ʶ�� begin******************************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_PARAM
        {	
            public byte byPlateRecoMode;    //����ʶ���ģʽ,Ĭ��Ϊ1(��Ƶ����ģʽ)
            public byte byBelive;	/*�������Ŷ���ֵ, ֻ������Ƶʶ��ʽ, ���ݱ������ӳ̶�����, �󴥷��ʸ߾����, ©���ʸ߾����, 
                                     * ������80-90��Χ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //�����ֽ�
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATECFG
        {	
            public uint dwSize;
            public uint dwEnable;				           /* �Ƿ�������Ƶ����ʶ�� 0���� 1���� */
            public byte byPicProType;	//����ʱͼƬ����ʽ 0-������ ��0-�ϴ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // �����ֽ�
            public NET_DVR_JPEGPARA struPictureParam; 		//ͼƬ���ṹ
            public NET_DVR_PLATE_PARAM struPlateParam;   // ����ʶ���������
            public NET_DVR_HANDLEEXCEPTION struHandleType;	   /* ����ʽ */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;        //����������¼��ͨ��,Ϊ1��ʾ������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // �����ֽ�
        }

        //����ʶ�����ӽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_INFO
        {
            public byte byPlateType; //��������
            public byte byColor; //������ɫ
            public byte byBright; //��������
            public byte byLicenseLen;	//�����ַ�����
            public byte byEntireBelieve;//�������Ƶ����Ŷȣ�0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
            public NET_VCA_RECT	struPlateRect;	//����λ��
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;	//���ƺ��� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LICENSE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBelieve; //����ʶ���ַ������Ŷȣ����⵽����"��A12345", ���Ŷ�Ϊ,20,30,40,50,60,70�����ʾ"��"����ȷ�Ŀ�����ֻ��%��"A"�ֵ���ȷ�Ŀ�������%
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATERECO_RESULE
        {
            public uint dwSize;
            public uint dwRelativeTime;	//���ʱ��
            public uint dwAbsTime;	//����ʱ��
            public NET_VCA_DEV_INFO struDevInfo; // ǰ���豸��Ϣ
            public NET_DVR_PLATE_INFO struPlateInfo;
            public uint dwPicDataLen;	//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;	//����������Ϊ0
            public IntPtr pImage;   //ָ��ͼƬ��ָ��
        }
        /******************************����ʶ�� end******************************************/

        /******************************ץ�Ļ�*******************************************/
        //IO��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_INCFG
        {
            public uint dwSize;
            public byte byIoInStatus;//�����IO��״̬��0-�½��أ�1-�����أ�2-�����غ��½��أ�3-�ߵ�ƽ��4-�͵�ƽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//�����ֽ�
        }

        //IO�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IO_OUTCFG
        {
            public uint dwSize;
            public byte byDefaultStatus;//IOĬ��״̬��0-�͵�ƽ��1-�ߵ�ƽ 
            public byte byIoOutStatus;//IO��Чʱ״̬��0-�͵�ƽ��1-�ߵ�ƽ��2-����
            public ushort wAheadTime;//���IO��ǰʱ�䣬��λus
            public uint dwTimePluse;//������ʱ�䣬��λus
            public uint dwTimeDelay;//IO��Ч����ʱ�䣬��λus
            public byte byFreqMulti;		//��Ƶ����ֵ��Χ[1,15]
            public byte byDutyRate;		//ռ�ձȣ�[0,40%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLASH_OUTCFG
        {
            public uint dwSize;
            public byte byMode;//�������˸ģʽ��0-������1-����2-��������3-����
            public byte byRelatedIoIn;//����ƹ���������IO�ţ�������ʱ�˲�����Ч��
            public byte byRecognizedLane;  /*������IO�ţ���λ��ʾ��bit0��ʾIO1�Ƿ������0-��������1-����*/
            public byte byDetectBrightness;/*�Զ��������ʹ�������0-����⣻1-���*/
            public byte byBrightnessThreld;/*ʹ�������������ֵ����Χ[0,100],������ֵ��*/
            public byte byStartHour;		//��ʼʱ��-Сʱ,ȡֵ��Χ0-23
            public byte byStartMinute;		//��ʼʱ��-��,ȡֵ��Χ0-59
            public byte byEndHour;		 	//����ʱ��-Сʱ,ȡֵ��Χ0-23
            public byte byEndMinute;		//����ʱ��-��,ȡֵ��Χ0-59
            public byte byFlashLightEnable;	//���������ʱ��ʹ��:0-��;1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���̵ƹ��ܣ�2��IO����һ�飩
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LIGHTSNAPCFG
        {
            public uint dwSize;
            public byte byLightIoIn;//���̵Ƶ�IO ��
            public byte byTrigIoIn;//������IO��
            public byte byRelatedDriveWay;//����IO�����ĳ�����
            public byte byTrafficLight; //0-�ߵ�ƽ��ƣ��͵�ƽ�̵ƣ�1-�ߵ�ƽ�̵ƣ��͵�ƽ���
            public byte bySnapTimes1; //���ץ�Ĵ���1��0-��ץ�ģ���0-���Ĵ��������5�� 
            public byte bySnapTimes2; //�̵�ץ�Ĵ���2��0-��ץ�ģ���0-���Ĵ��������5�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//������ļ��ʱ�䣬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//�̵����ļ��ʱ�䣬ms
            public byte byRecord;//���������¼���־��0-��¼��1-¼��
            public byte bySessionTimeout;//���������¼��ʱʱ�䣨�룩
            public byte byPreRecordTime;//�����¼��Ƭ��Ԥ¼ʱ��(��)
            public byte byVideoDelay;//�����¼��Ƭ����ʱʱ�䣨�룩
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//�����ֽ�
        }

        //���ٹ���(2��IO����һ�飩
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MEASURESPEEDCFG
        {
            public uint dwSize;
            public byte byTrigIo1;   //���ٵ�1��Ȧ
            public byte byTrigIo2;   //���ٵ�2��Ȧ
            public byte byRelatedDriveWay;//����IO�����ĳ�����
            public byte byTestSpeedTimeOut;//����ģʽ��ʱʱ�䣬��λs
            public uint dwDistance;//��Ȧ����,cm
            public byte byCapSpeed;//����ģʽ�����ٶȣ���λkm/h
            public byte bySpeedLimit;//����ֵ����λkm/h
            public byte bySnapTimes1; //��Ȧ1ץ�Ĵ�����0-��ץ�ģ���0-���Ĵ��������5�� 
            public byte bySnapTimes2; //��Ȧ2ץ�Ĵ�����0-��ץ�ģ���0-���Ĵ��������5�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime1;//��Ȧ1���ļ��ʱ�䣬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime2;//��Ȧ2���ļ��ʱ�䣬ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//�����ֽ�
        }

        //��Ƶ��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOEFFECT
        {
            public byte byBrightnessLevel; /*0-100*/
            public byte byContrastLevel; /*0-100*/
            public byte bySharpnessLevel; /*0-100*/
            public byte bySaturationLevel; /*0-100*/
            public byte byHueLevel; /*0-100,��������*/
            public byte byEnableFunc; //ʹ�ܣ���λ��ʾ��bit0-SMART IR(������)��bit1-���ն�,bit2-ǿ������ʹ�ܣ�0-��1-��
            public byte byLightInhibitLevel; //ǿ�����Ƶȼ���[1-3]��ʾ�ȼ�
            public byte byGrayLevel; //�Ҷ�ֵ��0-[0-255]��1-[16-235]
        }

        //��������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAIN
        {
            public byte byGainLevel; /*���棺0-100*/
            public byte byGainUserSet; /*�û��Զ������棻0-100������ץ�Ļ�����CCDģʽ�µ�ץ������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMaxGainValue;/*�������ֵ����λdB*/
        }

        //��ƽ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WHITEBALANCE
        {
            public byte byWhiteBalanceMode; /*0-�ֶ���ƽ�⣨MWB��,1-�Զ���ƽ��1��AWB1��,2-�Զ���ƽ��2 (AWB2),3-�Զ����Ƹ���Ϊ������ƽ��(Locked WB)��
	                         4-����(Indoor)��5-����(Outdoor)6-�չ��(Fluorescent Lamp)��7-�Ƶ�(Sodium Lamp)��
	                         8-�Զ�����(Auto-Track)9-һ�ΰ�ƽ��(One Push)��10-�����Զ�(Auto-Outdoor)��
	                         11-�Ƶ��Զ� (Auto-Sodiumlight)��12-ˮ����(Mercury Lamp)��13-�Զ���ƽ��(Auto)��
	                         14-�׳�� (IncandescentLamp)��15-ů���(Warm Light Lamp)��16-��Ȼ��(Natural Light) */
            public byte byWhiteBalanceModeRGain; /*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� R����*/
            public byte byWhiteBalanceModeBGain; /*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� B����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //�ع����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EXPOSURE
        {
            public byte byExposureMode; /*0 �ֶ��ع� 1�Զ��ع�*/
            public byte byAutoApertureLevel; /* �Զ���Ȧ������, 0-10 */ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwVideoExposureSet; /* �Զ�����Ƶ�ع�ʱ�䣨��λus��*//*ע:�Զ��ع�ʱ��ֵΪ�ع�����ֵ ����20-1s(1000000us)*/        
            public uint dwExposureUserSet; /* �Զ����ع�ʱ��,��ץ�Ļ���Ӧ��ʱ��CCDģʽʱ��ץ�Ŀ����ٶ�*/   
            public uint dwRes;    
        }

        //��̬����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WDR
        {
            public byte byWDREnabled; /*��̬��0 dsibale  1 enable 2 auto*/
            public byte byWDRLevel1; /*0-F*/
            public byte byWDRLevel2; /*0-F*/
            public byte byWDRContrastLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��ҹת����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DAYNIGHT
        {
            public byte byDayNightFilterType; /*��ҹ�л���0-���죬1-ҹ��2-�Զ���3-��ʱ��4-�������봥��*/
            public byte bySwitchScheduleEnabled; /*0 dsibale  1 enable,(����)*/
            //��ʱģʽ����
            public byte byBeginTime; /*��ʼʱ�䣨Сʱ����0-23*/
            public byte byEndTime; /*����ʱ�䣨Сʱ����0-23*/
            //ģʽ2
            public byte byDayToNightFilterLevel; //0-7
            public byte byNightToDayFilterLevel; //0-7
            public byte byDayNightFilterTime;//(60��)
            //��ʱģʽ����
            public byte byBeginTimeMin; //��ʼʱ�䣨�֣���0-59
            public byte byBeginTimeSec; //��ʼʱ�䣨�룩��0-59
            public byte byEndTimeMin; //����ʱ�䣨�֣���0-59
            public byte byEndTimeSec; //����ʱ�䣨�룩��0-59
	        //�������봥��ģʽ����
            public byte byAlarmTrigState; //�������봥��״̬��0-���죬1-ҹ��
        }

        //GammaУ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GAMMACORRECT
        {
            public byte byGammaCorrectionEnabled; /*0 dsibale  1 enable*/
            public byte byGammaCorrectionLevel; /*0-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���ⲹ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKLIGHT
        {
            public byte byBacklightMode; /*���ⲹ��:0 off 1 UP��2 DOWN��3 LEFT��4 RIGHT��5MIDDLE��6�Զ���*/
            public byte byBacklightLevel; /*0x0-0xF*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwPositionX1; //��X����1��
            public uint dwPositionY1; //��Y����1��
            public uint dwPositionX2; //��X����2��
            public uint dwPositionY2; //��Y����2��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //���ֽ��빦��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NOISEREMOVE
        {
            public byte byDigitalNoiseRemoveEnable; /*0-�����ã�1-��ͨģʽ���ֽ��룬2-ר��ģʽ���ֽ���*/
            public byte byDigitalNoiseRemoveLevel; /*��ͨģʽ���ֽ��뼶��0x0-0xF*/
            public byte bySpectralLevel;       /*ר��ģʽ�¿���ǿ�ȣ�0-100*/
            public byte byTemporalLevel;   /*ר��ģʽ��ʱ��ǿ�ȣ�0-100*/
            public byte byDigitalNoiseRemove2DEnable;         /* ץ��֡2D���룬0-�����ã�1-���� */	
            public byte byDigitalNoiseRemove2DLevel;            /* ץ��֡2D���뼶��0-100 */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //CMOSģʽ��ǰ�˾�ͷ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CMOSMODECFG
        {
            public byte byCaptureMod;   //ץ��ģʽ��0-ץ��ģʽ1��1-ץ��ģʽ2
            public byte byBrightnessGate;//������ֵ
            public byte byCaptureGain1;   //ץ������1,0-100
            public byte byCaptureGain2;   //ץ������2,0-100
            public uint dwCaptureShutterSpeed1;//ץ�Ŀ����ٶ�1
            public uint dwCaptureShutterSpeed2;//ץ�Ŀ����ٶ�2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ǰ�˲�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*���ȡ��Աȶȡ����Ͷȡ���ȡ�ɫ������*/    
            public NET_DVR_GAIN struGain;/*�Զ�����*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*��ƽ��*/
            public NET_DVR_EXPOSURE struExposure; /*�ع����*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*GammaУ��*/
            public NET_DVR_WDR struWdr;/*��̬*/
            public NET_DVR_DAYNIGHT struDayNight;/*��ҹת��*/
            public NET_DVR_BACKLIGHT struBackLight;/*���ⲹ��*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*���ֽ���*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0 �Զ���Ȧ 1�ֶ���Ȧ*/    
            public byte byMirror ;  /* ����0 off��1- leftright��2- updown��3-center */
            public byte byDigitalZoom;  /*��������:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*������,0 dsibale  1 enable*/
            public byte byBlackPwl;/*�ڵ�ƽ���� ,  0-255*/ 
            public byte byEptzGate;// EPTZ���ر���:0-�����õ�����̨��1-���õ�����̨
            public byte byLocalOutputGate;//����������ر���0-��������ر�1-����BNC����� 2-HDMI����ر�  
				     //20-HDMI_720P50�����
					 //21-HDMI_720P60�����
					 //22-HDMI_1080I60�����
					 //23-HDMI_1080I50�����
					 //24-HDMI_1080P24�����
					 //25-HDMI_1080P25�����
					 //26-HDMI_1080P30�����
					 //27-HDMI_1080P50�����
			         //28-HDMI_1080P60�����
					 //40-SDI_720P50,
					 //41-SDI_720P60,
					 //42-SDI_1080I50,
					 //43-SDI_1080I60,
					 //44-SDI_1080P24,
					 //45-SDI_1080P25,
					 //46-SDI_1080P30,
					 //47-SDI_1080P50,
					 //48-SDI_1080P60
            public byte byCoderOutputMode;//������fpga���ģʽ0ֱͨ3���ذ��
            public byte byLineCoding; //�Ƿ����б��룺0-��1-��
            public byte byDimmerMode; //����ģʽ��0-���Զ���1-�Զ�
            public byte byPaletteMode; //��ɫ�壺0-���ȣ�1-���ȣ�2-��ɫ��2������8-��ɫ��8
            public byte byEnhancedMode; //��ǿ��ʽ��̽�������ܱߣ���0-����ǿ��1-1��2-2��3-3��4-4
            public byte byDynamicContrastEN;    //��̬�Աȶ���ǿ 0-1
            public byte byDynamicContrast;    //��̬�Աȶ� 0-100
            public byte byJPEGQuality;    //JPEGͼ������ 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSģʽ��ǰ�˲������ã���ͷģʽ����������ȡ
            public byte byFilterSwitch; //�˲����أ�0-�����ã�1-����
            public byte byFocusSpeed; //��ͷ�����ٶȣ�0-10
            public byte byAutoCompensationInterval; //��ʱ�Զ����Ų�����1-120����λ������
            public byte bySceneMode;  //����ģʽ��0-���⣬1-���ڣ�2-Ĭ�ϣ�3-����
        }

        //͸��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOGCFG
        {
            public byte byMode; //ģʽ��0-�����ã�1-�Զ�ģʽ��2-����ģʽ
            public byte byLevel; //�ȼ���0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        //���ӷ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ELECTRONICSTABILIZATION
        {
            public byte byEnable;//ʹ�� 0- �����ã�1- ����
            public byte byLevel; //�ȼ���0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        //����ģʽ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRIDOR_MODE_CCD
        {
            public byte byEnableCorridorMode; //�Ƿ���������ģʽ 0�������ã� 1������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //SMART IR(������)���ò���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMARTIR_PARAM
        {
            public byte byMode;//0���ֶ���1���Զ�
            public byte byIRDistance;//�������ȼ�(�ȼ�������������)level:1~100 Ĭ��:50���ֶ�ģʽ�����ӣ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��byIrisMode ΪP-Iris1ʱ��Ч�����ú����Ȧ��С�ȼ�������ģʽ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PIRIS_PARAM
        {
            public byte byMode;//0-�Զ���1-�ֶ�
            public byte byPIrisAperture;//�����Ȧ��С�ȼ�(�ȼ�,��Ȧ��С������)level:1~100 Ĭ��:50���ֶ�ģʽ�����ӣ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ǰ�˲�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERAPARAMCFG_EX
        {
            public uint dwSize;
            public NET_DVR_VIDEOEFFECT struVideoEffect;/*���ȡ��Աȶȡ����Ͷȡ���ȡ�ɫ������*/
            public NET_DVR_GAIN struGain;/*�Զ�����*/
            public NET_DVR_WHITEBALANCE struWhiteBalance;/*��ƽ��*/
            public NET_DVR_EXPOSURE struExposure; /*�ع����*/
            public NET_DVR_GAMMACORRECT struGammaCorrect;/*GammaУ��*/
            public NET_DVR_WDR struWdr;/*��̬*/
            public NET_DVR_DAYNIGHT struDayNight;/*��ҹת��*/
            public NET_DVR_BACKLIGHT struBackLight;/*���ⲹ��*/
            public NET_DVR_NOISEREMOVE struNoiseRemove;/*���ֽ���*/
            public byte byPowerLineFrequencyMode; /*0-50HZ; 1-60HZ*/
            public byte byIrisMode; /*0-�Զ���Ȧ 1-�ֶ���Ȧ, 2-P-Iris1*/    
            public byte byMirror ;  /* ����0 off��1- leftright��2- updown��3-center */
            public byte byDigitalZoom;  /*��������:0 dsibale  1 enable*/
            public byte byDeadPixelDetect;   /*������,0 dsibale  1 enable*/
            public byte byBlackPwl;/*�ڵ�ƽ���� ,  0-255*/ 
            public byte byEptzGate;// EPTZ���ر���:0-�����õ�����̨��1-���õ�����̨
            public byte byLocalOutputGate;//����������ر���0-��������ر�1-����BNC����� 2-HDMI����ر�  
	        //20-HDMI_720P50�����
	        //21-HDMI_720P60�����
	        //22-HDMI_1080I60�����
	        //23-HDMI_1080I50�����
	        //24-HDMI_1080P24�����
	        //25-HDMI_1080P25�����
	        //26-HDMI_1080P30�����
	        //27-HDMI_1080P50�����
	        //28-HDMI_1080P60�����
            public byte byCoderOutputMode;//������fpga���ģʽ0ֱͨ3���ذ��
            public byte byLineCoding; //�Ƿ����б��룺0-��1-��
            public byte byDimmerMode; //����ģʽ��0-���Զ���1-�Զ�
            public byte byPaletteMode; //��ɫ�壺0-���ȣ�1-���ȣ�2-��ɫ��2������8-��ɫ��8
            public byte byEnhancedMode; //��ǿ��ʽ��̽�������ܱߣ���0-����ǿ��1-1��2-2��3-3��4-4
            public byte byDynamicContrastEN;    //��̬�Աȶ���ǿ 0-1
            public byte byDynamicContrast;    //��̬�Աȶ� 0-100
            public byte byJPEGQuality;    //JPEGͼ������ 0-100
            public NET_DVR_CMOSMODECFG struCmosModeCfg;//CMOSģʽ��ǰ�˲������ã���ͷģʽ����������ȡ
            public byte byFilterSwitch; //�˲����أ�0-�����ã�1-����
            public byte byFocusSpeed; //��ͷ�����ٶȣ�0-10
            public byte byAutoCompensationInterval; //��ʱ�Զ����Ų�����1-120����λ������
            public byte bySceneMode;  //����ģʽ��0-���⣬1-���ڣ�2-Ĭ�ϣ�3-����
            public NET_DVR_DEFOGCFG struDefogCfg;//͸�����
            public NET_DVR_ELECTRONICSTABILIZATION struElectronicStabilization;//���ӷ���
            public NET_DVR_CORRIDOR_MODE_CCD struCorridorMode;//����ģʽ
            public byte byExposureSegmentEnable; //0~������,1~����  �ع�ʱ�������ʽ���״�����������ع����ϵ���ʱ��������ع�ʱ�䵽�м�ֵ��Ȼ��������浽�м�ֵ��������ع⵽���ֵ�����������浽���ֵ
            public byte byBrightCompensate;//������ǿ [0~100]

	        /*0-�رա�1-640*480@25fps��2-640*480@30ps��3-704*576@25fps��4-704*480@30fps��5-1280*720@25fps��6-1280*720@30fps��
             * 7-1280*720@50fps��8-1280*720@60fps��9-1280*960@15fps��10-1280*960@25fps��11-1280*960@30fps��
             * 12-1280*1024@25fps��13--1280*1024@30fps��14-1600*900@15fps��15-1600*1200@15fps��16-1920*1080@15fps��
             * 17-1920*1080@25fps��18-1920*1080@30fps��19-1920*1080@50fps��20-1920*1080@60fps��21-2048*1536@15fps��22-2048*1536@20fps��
             * 23-2048*1536@24fps��24-2048*1536@25fps��25-2048*1536@30fps��26-2560*2048@25fps��27-2560*2048@30fps��
             * 28-2560*1920@7.5fps��29-3072*2048@25fps��30-3072*2048@30fps��31-2048*1536@12.5��32-2560*1920@6.25��
             * 33-1600*1200@25��34-1600*1200@30��35-1600*1200@12.5��36-1600*900@12.5��37-1600@900@15��38-800*600@25��39-800*600@30*/
            public byte byCaptureModeN; //��Ƶ����ģʽ��N�ƣ�
            public byte byCaptureModeP; //��Ƶ����ģʽ��P�ƣ�
            public NET_DVR_SMARTIR_PARAM struSmartIRParam; //����Ź���������Ϣ
            public NET_DVR_PIRIS_PARAM struPIrisParam;//PIris������Ϣ��ӦbyIrisMode�ֶδ�2-PIris1��ʼ��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 296, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        //������ɫ
        public enum VCA_PLATE_COLOR
        {
            VCA_BLUE_PLATE = 0,//��ɫ����
            VCA_YELLOW_PLATE,//��ɫ����
            VCA_WHITE_PLATE,//��ɫ����
            VCA_BLACK_PLATE,//��ɫ����
            VCA_GREEN_PLATE //��ɫ����
        }

        //��������
        public enum VCA_PLATE_TYPE
        {
            VCA_STANDARD92_PLATE = 0,//��׼���ó������
            VCA_STANDARD02_PLATE,//02ʽ���ó��� 
            VCA_WJPOLICE_PLATE,//�侯�� 
            VCA_JINGCHE_PLATE,//����
            STANDARD92_BACK_PLATE,//���ó�˫��β��
            VCA_SHIGUAN_PLATE,          //ʹ�ݳ���
            VCA_NONGYONG_PLATE,         //ũ�ó�
            VCA_MOTO_PLATE              //Ħ�г�
        }

        public enum VLR_VEHICLE_CLASS
        {
            VLR_OTHER       = 0,   //����
	        VLR_VOLKSWAGEN = 1,    //����
	        VLR_BUICK        = 2,  //���
	        VLR_BMW         = 3,   //����
	        VLR_HONDA       = 4,   //����
	        VLR_PEUGEOT     = 5,   //����
	        VLR_TOYOTA      = 6,   //����
	        VLR_FORD         = 7,  //����
	        VLR_NISSAN       = 8,  //�ղ�
	        VLR_AUDI         = 9,  //�µ�
	        VLR_MAZDA       = 10,  //���Դ�
	        VLR_CHEVROLET  = 11,   //ѩ����
	        VLR_CITROEN     = 12,  //ѩ����
	        VLR_HYUNDAI    = 13,   //�ִ�
	        VLR_CHERY       = 14   //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VEHICLE_INFO
        {
            public uint dwIndex;
            public byte byVehicleType;
            public byte byColorDepth;
            public byte byColor;
            public byte byRes1;
            public ushort wSpeed;
            public ushort wLength;
            public byte byIllegalType;
            public byte byVehicleLogoRecog; //�ο�ö������ VLR_VEHICLE_CLASS
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byCustomInfo;  //�Զ�����Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;

            public void Init()
            {
                byRes2 = new byte[2];
                byCustomInfo = new byte[16];
                byRes = new byte[16];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RESULT
        {
            public uint dwSize;
            public byte byResultType;
            public byte byChanIndex;
            public ushort wAlarmRecordID;	//����¼��ID(���ڲ�ѯ¼�񣬽���byResultTypeΪ2ʱ��Ч)
            public uint dwRelativeTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAbsTime;
            public uint dwPicLen;
            public uint dwPicPlateLen;
            public uint dwVideoLen;
            public byte byTrafficLight;
            public byte byPicNum;
            public byte byDriveChan;
            public byte byVehicleType; //0- δ֪��1- �ͳ���2- ������3- �γ���4- �������5- С����
            public uint dwBinPicLen;
            public uint dwCarPicLen;
            public uint dwFarCarPicLen;
            public IntPtr pBuffer3;
            public IntPtr pBuffer4;
            public IntPtr pBuffer5;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;
            public NET_DVR_PLATE_INFO struPlateInfo;
            public NET_DVR_VEHICLE_INFO struVehicleInfo;
            public IntPtr pBuffer1;
            public IntPtr pBuffer2;

            public void Init()
            {
                byAbsTime = new byte[32];
                byRes3 = new byte[8];
            }
        }

        //ͼ�������Ϣ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IMAGEOVERLAYCFG
        {
            public uint dwSize;
            public byte byOverlayInfo;//����ʹ�ܿ��أ�0-�����ӣ�1-����
            public byte byOverlayMonitorInfo;//�Ƿ���Ӽ�����Ϣ��0-�����ӣ�1-����
            public byte byOverlayTime;//�Ƿ����ʱ�䣬0-�����ӣ�1-����
            public byte byOverlaySpeed;//�Ƿ�����ٶȣ�0-�����ӣ�1-����
            public byte byOverlaySpeeding;//�Ƿ���ӳ��ٱ�����0-�����ӣ�1-����
            public byte byOverlayLimitFlag;//�Ƿ�������ٱ�־��0-�����ӣ�1-����
            public byte byOverlayPlate;//�Ƿ���ӳ��ƺţ�0-�����ӣ�1-����
            public byte byOverlayColor;//�Ƿ���ӳ�����ɫ��0-�����ӣ�1-����
            public byte byOverlayLength;//�Ƿ���ӳ�����0-�����ӣ�1-����
            public byte byOverlayType;//�Ƿ���ӳ��ͣ�0-�����ӣ�1-����
            public byte byOverlayColorDepth;//�Ƿ���ӳ�����ɫ��ǳ��0-�����ӣ�1-����
            public byte byOverlayDriveChan;//�Ƿ���ӳ�����0-�����ӣ�1-����
            public byte byOverlayMilliSec; //���Ӻ�����Ϣ 0-�����ӣ�1-����
            public byte byOverlayIllegalInfo; //����Υ����Ϣ 0-�����ӣ�1-����
            public byte byOverlayRedOnTime;  //���Ӻ������ʱ�� 0-�����ӣ�1-����
            public byte byFarAddPlateJpeg;      //Զ��ͼ�Ƿ���ӳ��ƽ�ͼ,0-������,1-����
            public byte byNearAddPlateJpeg;      //����ͼ�Ƿ���ӳ��ƽ�ͼ,0-������,1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;    //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo1;    //������Ϣ1
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitorInfo2; //������Ϣ2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPCFG
        {
            public uint dwSize;
            public byte byRelatedDriveWay;
            public byte bySnapTimes;
            public ushort wSnapWaitTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTERVAL_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wIntervalTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public enum ITC_MAINMODE_ABILITY
        {
            ITC_MODE_UNKNOW = 0x0,   //��
	        ITC_POST_MODE   = 0x1,  //����ģʽ
	        ITC_EPOLICE_MODE      = 0x2,  //�羯ģʽ
	        ITC_POSTEPOLICE_MODE  = 0x4  //��ʽ�羯ģʽ
        }

        public enum ITC_RECOG_REGION_TYPE
        {
            ITC_REGION_RECT    = 0x0,   //����
	        ITC_REGION_POLYGON  = 0x1,  //�����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAP_ABILITY
        {
            public uint dwSize;
            public byte byIoInNum;//IO�������
            public byte byIoOutNum;//IO�������
            public byte bySingleSnapNum;//��IO��������
            public byte byLightModeArrayNum;//���̵�ģʽ����
            public byte byMeasureModeArrayNum;//����ģʽ����
            public byte byPlateEnable; //����ʶ������
            public byte byLensMode;//��ͷģʽ0-CCD,1-CMOS
            public byte byPreTriggerSupport; //�Ƿ�֧��ԭ����ģʽ��0-֧�֣�1-��֧��
            public uint dwAbilityType; //֧�ֵĴ���ģʽ��������λ��ʾ�������ITC_MAINMODE_ABILITY
            public byte byIoSpeedGroup; //֧�ֵ�IO��������
            public byte byIoLightGroup; //֧�ֵ�IO���̵�����
            public byte byRecogRegionType; //��ʶ����֧�ֵ����ͣ��������ITC_RECOG_REGION_TYPE
            public byte bySupport; //�豸��������λ��ʾ��0-��֧�֣�1-֧��
	        // bySupport&0x1����ʾ�Ƿ�֧����չ���ַ���������
	        // bySupport&0x2����ʾ�Ƿ�֧����չ��Уʱ���ýṹ
	        // bySupport&0x4, ��ʾ�Ƿ�֧�ֶ�����(��������)
	        // bySupport&0x8, ��ʾ�Ƿ�֧��������bonding����(�����ݴ�)
	        // bySupport&0x10, ��ʾ�Ƿ�֧�������Խ�
	        //2013-07-09 ����������
            public ushort wSupportMultiRadar;// �豸��������λ��ʾ��0-��֧�֣�1-֧��
	        // wSupportMultiRadar&0x1����ʾ ����RS485�״� ֧�ֳ��������״ﴦ��
	        // wSupportMultiRadar&0x2����ʾ ����������Ȧ ֧�ֳ��������״ﴦ��
	        // wSupportMultiRadar&0x4����ʾ ���п��� ֧�ֳ��������״ﴦ��
	        // wSupportMultiRadar&0x8����ʾ ��Ƶ��� ֧�ֳ��������״ﴦ��
            public byte byICRPresetNum;
	        // ��ʾ֧�ֵ�ICRԤ�õ㣨�˹�Ƭƫ�Ƶ㣩��
            public byte byICRTimeSlot;//��ʾ֧�ֵ�ICR��ʱ�������1��8��
            public byte bySupportRS485Num;//��ʾ֧�ֵ�RS485�ڵ�����
            public byte byExpandRs485SupportSensor;// �豸��������λ��ʾ��0-��֧�֣�1-֧��
	        // byExpandRs485SupportSensor &0x1����ʾ�羯������֧�ֳ�����
	        // byExpandRs485SupportSensor &0x2����ʾ��ʽ�羯������֧�ֳ�����
            public byte byExpandRs485SupportSignalLampDet;// �豸��������λ��ʾ��0-��֧�֣�1-֧��
	        // byExpandRs485SupportSignalLampDet &0x1����ʾ�羯������֧������źŵƼ����
            // byExpandRs485SupportSignalLampDet &0x2����ʾ��ʽ�羯������֧������źŵƼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 13, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRTIMECFG
        {
            public NET_DVR_SCHEDTIME  struTime;
            public byte byAssociateRresetNo;//Ԥ�õ��1��8 , 0������
            public byte bySubSwitchMode;//1~���죬2~���� (��Ԥ�õ����0 ��ʱ����Ч)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_TIMESWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_ICRTIMECFG[] struAutoCtrlTime;//�Զ��л�ʱ��� (�Զ��л��� ʱ������Ч ����֧��4�飬Ԥ��4��)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //ʵ����Ч������������̬��ʾ [0~100] �����±��ʾԤ�õ��1��8 ��0��7 ���Ӧ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_MANUALSWITCH_PARAM
        {	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //ʵ����Ч������������̬��ʾ [0~100]
            public byte  bySubSwitchMode;//1~���죬2~����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 147, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_AOTOSWITCH_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ICR_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byICRPreset; //ʵ����Ч������������̬��ʾ [0~100] �����±��ʾԤ�õ��1��8 ��0��7 ���Ӧ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 148, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICR_PARAM_UNION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 156, ArraySubType = UnmanagedType.I1)]
            public byte[] uLen;
            public NET_ITC_ICR_AOTOSWITCH_PARAM struICRAutoSwitch;
            public NET_ITC_ICR_MANUALSWITCH_PARAM struICRManualSwitch;
            public NET_ITC_ICR_TIMESWITCH_PARAM struICRTimeSwitch;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_ICRCFG
        {
            public uint dwSize;
            public byte bySwitchType;//1~�Զ��л���2~�ֶ��л� ,3~��ʱ�л� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_ITC_ICR_PARAM_UNION uICRParam;
        }

        //2013-07-09 �쳣����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_HANDLEEXCEPTION
        {
            public uint dwHandleType; //�쳣����,�쳣����ʽ��"��"���
	        /*0x00: ����Ӧ*/
	        /*0x01: �������Ͼ���*/
	        /*0x02: ��������*/
	        /*0x04: �ϴ�����*/
	        /*0x08: ��������������̵��������*/
	        /*0x10: ����JPRGץͼ���ϴ�Email*/
	        /*0x20: �������ⱨ��������*/
	        /*0x40: �������ӵ�ͼ(Ŀǰֻ��PCNVR֧��)*/
	        /*0x200: ץͼ���ϴ�FTP*/  
            public byte byEnable; //0�������ã�1������
            public byte byRes;
            public ushort wDuration;//����ʱ��(��λ/s)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ITC_EXCEPTIONOUT, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutTriggered;//�������ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITC_EXCEPTION
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_EXCEPTIONNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_ITC_HANDLEEXCEPTION[] struSnapExceptionType; 
            //�����ÿ��Ԫ�ض���ʾһ���쳣������0- Ӳ�̳���,1-���߶�,2-IP ��ַ��ͻ, 3-�������쳣, 4-�źŵƼ�����쳣
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRIGCOORDINATE
        {
            public ushort wTopLeftX; /*��Ȧ���ϽǺ����꣨2���ֽڣ�*/
            public ushort wTopLeftY; /*��Ȧ���Ͻ������꣨2���ֽڣ�*/
            public ushort wWdith; /*��Ȧ��ȣ�2���ֽڣ�*/
            public ushort wHeight; /*��Ȧ�߶ȣ�2���ֽڣ�*/
        }

        public enum PROVINCE_CITY_IDX
        {
	        ANHUI_PROVINCE             = 0,              //����
	        AOMEN_PROVINCE             = 1,              //����
	        BEIJING_PROVINCE           = 2,              //����
	        CHONGQING_PROVINCE         = 3,              //����
	        FUJIAN_PROVINCE            = 4,              //����
	        GANSU_PROVINCE             = 5,              //����
	        GUANGDONG_PROVINCE         = 6,              //�㶫
	        GUANGXI_PROVINCE           = 7,              //����
	        GUIZHOU_PROVINCE           = 8,              //����
	        HAINAN_PROVINCE            = 9,              //����
	        HEBEI_PROVINCE             = 10,             //�ӱ�
	        HENAN_PROVINCE             = 11,             //����
	        HEILONGJIANG_PROVINCE      = 12,             //������
	        HUBEI_PROVINCE             = 13,             //����
	        HUNAN_PROVINCE             = 14,             //����
	        JILIN_PROVINCE             = 15,             //����
	        JIANGSU_PROVINCE           = 16,             //����
	        JIANGXI_PROVINCE           = 17,             //����
	        LIAONING_PROVINCE          = 18,             //����
	        NEIMENGGU_PROVINCE         = 19,             //���ɹ�
	        NINGXIA_PROVINCE           = 20,             //����
	        QINGHAI_PROVINCE           = 21,             //�ຣ
	        SHANDONG_PROVINCE          = 22,             //ɽ��
	        SHANXI_JIN_PROVINCE        = 23,             //ɽ��
	        SHANXI_SHAN_PROVINCE       = 24,             //����
	        SHANGHAI_PROVINCE          = 25,             //�Ϻ�
	        SICHUAN_PROVINCE           = 26,             //�Ĵ�
	        TAIWAN_PROVINCE            = 27,             //̨��
	        TIANJIN_PROVINCE           = 28,             //���
	        XIZANG_PROVINCE            = 29,             //����
	        XIANGGANG_PROVINCE         = 30,             //���
	        XINJIANG_PROVINCE          = 31,             //�½�
	        YUNNAN_PROVINCE            = 32,             //����
	        ZHEJIANG_PROVINCE          = 33              //�㽭
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_GEOGLOCATION
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public int[] iRes; /*����*/
            public uint dwCity; /*���У����PROVINCE_CITY_IDX */
        }

        //����ģʽ
        public enum SCENE_MODE
        {
	        UNKOWN_SCENE_MODE   = 0,            //δ֪����ģʽ
	        HIGHWAY_SCENE_MODE  = 1,            //���ٳ���ģʽ
	        SUBURBAN_SCENE_MODE = 2,            //��������ģʽ(����)
	        URBAN_SCENE_MODE    = 3,            //��������ģʽ
	        TUNNEL_SCENE_MODE   = 4             //�������ģʽ(����)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VTPARAM
        {
            public uint dwSize;
            public byte byEnable;  /* �Ƿ�ʹ��������Ȧ��0-��ʹ�ã�1-ʹ��*/
            public byte byIsDisplay; /* �Ƿ���ʾ������Ȧ��0-����ʾ��1-��ʾ*/
            public byte byLoopPos; //��䴥����Ȧ��ƫ��0-���ϣ�1-����
            public byte bySnapGain; /*ץ������*/
            public uint dwSnapShutter; /*ץ�Ŀ����ٶ�*/
            public NET_DVR_TRIGCOORDINATE struTrigCoordinate; //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_TRIGCOORDINATE[] struRes;
            public byte byTotalLaneNum;/*��Ƶ�����ĳ�����1*/
            public byte byPolarLenType; /*ƫ�����ͣ�0������ƫ�񾵣�1����ʩ�͵�ƫ�񾵡�*/
            public byte	byDayAuxLightMode; /*���츨������ģʽ��0���޸���������1��LED��������2�����������*/
            public byte	byLoopToCalRoadBright; /*���Լ���·�����ȵĳ���(������Ȧ)*/
            public byte	byRoadGrayLowTh; /*·�����ȵ���ֵ��ʼ��ֵ1*/
            public byte	byRoadGrayHighTh; /*·�����ȸ���ֵ��ʼ��ֵ140*/
            public ushort wLoopPosBias; /*��䴥����Ȧλ��30*/
            public uint dwHfrShtterInitValue; /*����ͼ���ع�ʱ��ĳ�ʼֵ2000*/
            public uint dwSnapShtterInitValue; /*ץ��ͼ���ع�ʱ��ĳ�ʼֵ500*/
            public uint dwHfrShtterMaxValue; /*����ͼ���ع�ʱ������ֵ20000*/
            public uint dwSnapShtterMaxValue; /*ץ��ͼ���ع�ʱ������ֵ1500*/
            public uint dwHfrShtterNightValue; /*�������ͼ���ع�ʱ�������ֵ3000*/
            public uint dwSnapShtterNightMinValue; /*���ץ��ͼ���ع�ʱ�����Сֵ3000*/
            public uint dwSnapShtterNightMaxValue; /*���ץ��ͼ���ع�ʱ������ֵ5000*/
            public uint dwInitAfe; /*����ĳ�ʼֵ200*/
            public uint dwMaxAfe; /*��������ֵ400*/
            public ushort wResolutionX;/* �豸��ǰ�ֱ��ʿ�*/
            public ushort wResolutionY;/* �豸��ǰ�ֱ��ʸ�*/
            public uint dwGainNightValue; /*������棬Ĭ��ֵ70*/
            public uint dwSceneMode; /*����ģʽ�� ���SCENE_MODE */
            public uint dwRecordMode; /*¼���־��0-��¼��1-¼��*/
            public NET_DVR_GEOGLOCATION struGeogLocation; /*��ַλ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigFlag; /*������־��0-��ͷ������1-��β������2-��ͷ/��β������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrigSensitive;  /*���������ȣ�1-100*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNAPENABLECFG
        {
            public uint dwSize;
            public byte byPlateEnable;//�Ƿ�֧�ֳ���ʶ��0-��֧�֣�1-֧��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   //����
            public byte byFrameFlip;   //ͼ���Ƿ�ת 0-����ת��1-��ת
            public ushort wFlipAngle;    //ͼ��ת�Ƕ� 0,90,180,270
            public ushort wLightPhase;   //��λ��ȡֵ��Χ[0, 360]
            public byte byLightSyncPower;  //�Ƿ��źŵƵ�Դͬ����0-��ͬ����1-ͬ��
            public byte byFrequency;		//�ź�Ƶ��
            public byte byUploadSDEnable;  //�Ƿ��Զ��ϴ�SDͼƬ��0-��1-��
            public byte byPlateMode; //ʶ��ģʽ����:0-��Ƶ����,1-�ⲿ����
            public byte byUploadInfoFTP; //�Ƿ��ϴ�ץ�ĸ�����Ϣ��FTP��0-��1-��
            public byte byAutoFormatSD; //�Ƿ��Զ���ʽ��SD����0-��1-��
            public ushort wJpegPicSize; //JpegͼƬ��С[64-8196]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 56, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        /*ftp�ϴ�����*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FTPCFG
        {
            public uint dwSize;
            public uint dwEnableFTP;			/*�Ƿ�����ftp�ϴ�����*/
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string sFTPIP;				/*ftp ������*/
            public uint dwFTPPort;				/*ftp�˿�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*�û���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/*����*/
            public uint dwDirLevel;	/*0 = ��ʹ��Ŀ¼�ṹ��ֱ�ӱ����ڸ�Ŀ¼,1 = ʹ��1��Ŀ¼,2=ʹ��2��Ŀ¼*/
            public ushort wTopDirMode;	/* һ��Ŀ¼��0x1 = ʹ���豸��,0x2 = ʹ���豸��,0x3 = ʹ���豸ip��ַ��0x4=ʹ�ü���,0x5=ʹ��ʱ��(����),0x=6�Զ���,0x7=Υ������,0x8=����,0x9=�ص�*/
            public ushort wSubDirMode;	/* ����Ŀ¼��0x1 = ʹ��ͨ����,0x2 = ʹ��ͨ���ţ�,0x3=ʹ��ʱ��(������),0x4=ʹ�ó�����,0x=5�Զ���,0x6=Υ������,0x7=����,0x8=�ص�*/
            public byte byEnableAnony; //����������0-��1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*����������ͼƬ�����Ԫ�� */
        public const int PICNAME_ITEM_DEV_NAME = 1;		/*�豸��*/
        public const int PICNAME_ITEM_DEV_NO = 2;		/*�豸��*/
        public const int PICNAME_ITEM_DEV_IP = 3;		/*�豸IP*/
        public const int PICNAME_ITEM_CHAN_NAME = 4;	/*ͨ����*/
        public const int PICNAME_ITEM_CHAN_NO = 5;		/*ͨ����*/
        public const int PICNAME_ITEM_TIME = 6;		/*ʱ��*/
        public const int PICNAME_ITEM_CARDNO = 7;		/*����*/
        public const int PICNAME_ITEM_PLATE_NO = 8;   /*���ƺ���*/
        public const int PICNAME_ITEM_PLATE_COLOR = 9;   /*������ɫ*/
        public const int PICNAME_ITEM_CAR_CHAN = 10;  /*������*/
        public const int PICNAME_ITEM_CAR_SPEED = 11;  /*�����ٶ�*/
        public const int PICNAME_ITEM_CARCHAN = 12;  /*����*/
        public const int PICNAME_ITEM_PIC_NUMBER = 13;  //ͼƬ���
        public const int PICNAME_ITEM_CAR_NUMBER = 14;  //�������

        public const int PICNAME_ITEM_SPEED_LIMIT_VALUES = 15; //����ֵ
        public const int PICNAME_ITEM_ILLEGAL_CODE = 16; //����Υ������
        public const int PICNAME_ITEM_CROSS_NUMBER = 17; //·�ڱ��
        public const int PICNAME_ITEM_DIRECTION_NUMBER = 18; //������

        public const int PICNAME_MAXITEM = 15;
        //ͼƬ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	�����鶨���ļ������Ĺ��� */
            public byte byDelimiter;		/*�ָ�����һ��Ϊ'_'*/
        }


        //��������2013-09-27
        public const int PICNAME_ITEM_PARK_DEV_IP = 1;	/*�豸IP*/
        public const int PICNAME_ITEM_PARK_PLATE_NO = 2;/*���ƺ���*/
        public const int PICNAME_ITEM_PARK_TIME = 3;	/*ʱ��*/
        public const int PICNAME_ITEM_PARK_INDEX = 4;   /*��λ���*/
        public const int PICNAME_ITEM_PARK_STATUS = 5;  /*��λ״̬*/

        //ͼƬ������չ 2013-09-27
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PICTURE_NAME_EX
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PICNAME_MAXITEM, ArraySubType = UnmanagedType.I1)]
            public byte[] byItemOrder;	/*	�����鶨���ļ������Ĺ��� */
            public byte byDelimiter;	            	/*�ָ�����һ��Ϊ'_'*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                      /*����*/
        }

        /* ����ץͼ����*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CATCHPIC_PARA
        {
            public byte byStrFlag;	/*�������ݿ�ʼ��*/
            public byte byEndFlag;	/*������*/
            public ushort wCardIdx;	/*���������ʼλ*/
            public uint dwCardLen;	/*���ų���*/
            public uint dwTriggerPicChans;	/*��������ͨ���ţ���λ���ӵ�1λ��ʼ�ƣ���0x2��ʾ��һͨ��*/
        }

        //DVRץͼ�������ã����ߣ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEGCFG_V30
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_JPEGPARA[] struJpegPara;	/*ÿ��ͨ����ͼ�����*/
            public ushort wBurstMode;							/*ץͼ��ʽ,��λ����.0x1=�������봥����0x2=�ƶ���ⴥ�� 0x4=232������0x8=485������0x10=���紥��*/
            public ushort wUploadInterval;					/*ͼƬ�ϴ����(��)[0,65535]*/
            public NET_DVR_PICTURE_NAME 	struPicNameRule;	/* ͼƬ�������� */
            public byte bySaveToHD;		/*�Ƿ񱣴浽Ӳ��*/
            public byte byRes1;
            public ushort wCatchInterval;		/*ץͼ���(����)[0,65535]*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs232Cfg;
            public NET_DVR_SERIAL_CATCHPIC_PARA struRs485Cfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwTriggerPicTimes;	/* ÿ��ͨ��һ�δ������մ��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_V30, ArraySubType = UnmanagedType.U4)]
            public uint[] dwAlarmInPicChanTriggered; /*��������ץ��ͨ��,��λ���ã��ӵ�1λ��ʼ*/
        }

        //ץ�Ĵ�������ṹ(����)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MANUALSNAP
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SPRCFG    
        {
            public uint dwSize; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHJC_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDefaultCHN; /*�豸����ʡ�ݵĺ��ּ�д*/
            public byte byPlateOSD;    /*0:�����ͳ��Ʋ�ɫͼ,1:���ͳ��Ʋ�ɫͼ*/
            public byte bySendJPEG1;   /*0-�����ͽ���JPEGͼ,1-���ͽ���JPEGͼ*/
            public byte bySendJPEG2;   /*0-������Զ��JPEGͼ,1-����Զ��JPEGͼ*/
            public ushort wDesignedPlateWidth;   /*������ƿ��*/
            public byte byTotalLaneNum;  /*ʶ��ĳ�����*/
            public byte byRes1;      /*����*/
            public ushort wRecognizedLane;  /*ʶ��ĳ����ţ���λ��ʾ��bit0��ʾ����1�Ƿ�ʶ��0-��ʶ��1-ʶ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LANERECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect;  /*����ʶ������*/
            public uint dwRecogMode;  /*ʶ������ͣ�
	        bit0-����ʶ��0-������ʶ��1-����ʶ��(β��ʶ��) �� 
		    bit1-����ʶ���С����ʶ��0-С����ʶ��1-����ʶ�� ��
		    bit2-������ɫʶ��0-�����ó�����ɫʶ���ڱ���ʶ���С����ʶ��ʱ��ֹ���ã�1-������ɫʶ��
		    bit3-ũ�ó�ʶ��0-������ũ�ó�ʶ��1-ũ�ó�ʶ�� 
		    bit4-ģ��ʶ��0-������ģ��ʶ��1-ģ��ʶ��
		    bit5-֡��λ�򳡶�λ��0-֡��λ��1-����λ��
		    bit6-֡ʶ���ʶ��0-֡ʶ��1-��ʶ�� 
		    bit7-���ϻ���죺0-���죬1-���� */
            public byte bySendPRRaw;       	//�Ƿ���ԭͼ��0-�����ͣ�1-���� 
            public byte bySendBinImage;  	//�Ƿ��ͳ��ƶ�ֵͼ��0-�����ͣ�1-���� 
            public byte byDelayCapture;  //��ʱץ�Ŀ���,��λ��֡
            public byte byUseLED;    //ʹ��LED���ƣ�0-��1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 68, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLCCFG
        {
            public uint dwSize;
            public byte byPlcEnable;	//�Ƿ����ó������Ȳ�����Ĭ�����ã���0-�رգ�1-���� 
            public byte byPlateExpectedBright;	//���Ƶ�Ԥ�����ȣ�Ĭ��ֵ50��, ��Χ[0, 100]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//���� 
            public byte byTradeoffFlash;     //�Ƿ�������Ƶ�Ӱ��: 0 - ��;  1 - ��(Ĭ��); 
	        //ʹ������Ʋ���ʱ, ������Ǽ�������Ƶ�������ǿЧӦ, ����Ҫ��Ϊ1;����Ϊ0
            public byte byCorrectFactor;     //����ϵ��, ��Χ[0, 100], Ĭ��ֵ50 (��tradeoff_flash�л�ʱ,�ָ�Ĭ��ֵ��
            public ushort wLoopStatsEn;  //�Ƿ����Ȧ�����ȣ���λ��ʾ��0-��ͳ�ƣ�1-ͳ��
            public byte byPlcBrightOffset;// �������Ȳ���������(������Ȧģʽ��Ч)��ȡֵ��Χ1~100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICESTATECFG
        {
            public uint dwSize;
            public ushort wPreviewNum; //Ԥ�����Ӹ���
            public ushort wFortifyLinkNum; //�������Ӹ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struPreviewIP;  //Ԥ�����û�IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_IPADDR[] struFortifyIP; //�������ӵ��û�IP��ַ
            public uint dwVideoFrameRate;	//֡�ʣ�0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20; 14-15; 15-18; 16-22;
            public byte byResolution;  	//�ֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5��������,16-VGA��640*480��, 17-UXGA��1600*1200��, 18-SVGA ��800*600��,19-HD720p��1280*720��,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte bySnapResolution;  	//ץ�ķֱ���0-DCIF 1-CIF, 2-QCIF, 3-4CIF, 4-2CIF 5��������,16-VGA��640*480��, 17-UXGA��1600*1200��, 18-SVGA ��800*600��,19-HD720p��1280*720��,20-XVGA,  21-HD900p, 27-HD1080i, 28-2560*1920, 29-1600*304, 30-2048*1536, 31-2448*2048
            public byte byStreamType; //�������ͣ�0-��������1-������
            public byte byTriggerType; //����ģʽ��0-��Ƶ������1-��ͨ����
            public uint dwSDVolume;  //SD������
            public uint dwSDFreeSpace; //SD��ʣ��ռ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DRIVECHAN_NUM * MAX_COIL_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDetectorState;  //������״̬��0-δʹ�ã�1-������2-�쳣
            public byte byDetectorLinkState; //����������״̬��0-δ���ӣ�1-����
            public byte bySDStatus;    //SD��״̬ 0�����1�����ߣ�2���쳣��3-��sd��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_FORTIFY_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byFortifyLevel; //�����ȼ���0-�ޣ�1-һ�ȼ����ߣ���2-���ȼ����У���3-���ȼ����ͣ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 116, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POSTEPOLICECFG
        {
            public uint dwSize;
            public uint dwDistance;//��Ȧ����,��λcm��ȡֵ��Χ[0,20000]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SIGNALLIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwLightChan;	//�źŵ�ͨ����
            public byte byCapSpeed;//��־���٣���λkm/h��ȡֵ��Χ[0,255]
            public byte bySpeedLimit;//����ֵ����λkm/h��ȡֵ��Χ[0,255]
            public byte byTrafficDirection;//��������0-�ɶ�������1-�����򶫣�2-�����򱱣�3-�ɱ�����
            public byte byRes1; //����
            public ushort wLoopPreDist;        /*�����ӳپ��� ����λ������*/
            public ushort wTrigDelay;             /*����Ӳ��ʱʱ�� ����λ������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//�����ֽ�
        }
        /***************************** end *********************************************/
        public const int IPC_PROTOCOL_NUM = 50;  //ipc Э��������

        //Э������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE
        {
            public uint dwType;               /*ipcЭ��ֵ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*Э�������ֶ�*/
        }

        //Э���б�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PROTO_LIST
        {    
            public uint dwSize; 
            public uint dwProtoNum;           /*��Ч��ipcЭ����Ŀ*/  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = IPC_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struProto;   /*��Ч��ipcЭ��*/    
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_ALERTLINE_NUM = 8; //��󾯽�������	
        
        //Խ������ѯ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TRAVERSE_PLANE_SEARCHCOND
        {	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALERTLINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_TRAVERSE_PLANE[] struVcaTraversePlane;  //��Խ���������
            public uint dwPreTime;   /*���ܱ�����ǰʱ�� ��λ:��*/
            public uint dwDelayTime; /*���ܱ����ӳ�ʱ�� ��λ:��*/ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5656, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        } 

        public const int MAX_INTRUSIONREGION_NUM = 8; //�����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INTRUSION_SEARCHCOND  
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_INTRUSIONREGION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_INTRUSION[] struVcaIntrusion; //��������
            public uint dwPreTime;   /*���ܱ�����ǰʱ�� ��λ:��*/
            public uint dwDelayTime; /*���ܱ����ӳ�ʱ�� ��λ:��*/ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5400, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }


        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_AREA_SMARTSEARCH_COND_UNION
        {  
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6144, ArraySubType = UnmanagedType.I1)]
            public byte[] byLen;  //�ṹ�峤��
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64 * 96, ArraySubType = UnmanagedType.I1)]
            public byte[] byMotionScope; //������� 0-96λ��ʾ64�У�����96*64��С��飬1-���ƶ��������0-���ƶ�������� 
            [FieldOffsetAttribute(0)]
            public NET_DVR_TRAVERSE_PLANE_SEARCHCOND struTraversPlaneCond; //Խ�����
            [FieldOffsetAttribute(0)]
            public NET_DVR_INTRUSION_SEARCHCOND struIntrusionCond; //��������
        }

        //������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_PARAM
        {
            public byte byChan;					//ͨ����
            public byte bySearchCondType; //���ܲ���������NET_DVR_AREA_SMARTSEARCH_COND_UNION������     
	        /*0-�ƶ�������� ��1-Խ����⣬ 2-��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struStartTime;		//¼��ʼ��ʱ��
            public NET_DVR_TIME struEndTime;		//¼��ֹͣ��ʱ��
            public NET_DVR_AREA_SMARTSEARCH_COND_UNION uSmartSearchCond;  //���ܲ�������
            public byte bySensitivity;   			//�ƶ��������������,1	>80%  2 40%~80%  3 1%~40%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
    
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SMART_SEARCH_RET
        {
            public NET_DVR_TIME struStartTime;	//�ƶ���ⱨ����ʼ��ʱ��
            public NET_DVR_TIME struEndTime;   //�¼�ֹͣ��ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //IPSAN �ļ�Ŀ¼����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_PARAM
        {
            public NET_DVR_IPADDR  struIP;     // IPSAN IP��ַ
            public ushort wPort;      // IPSAN  �˿�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPSAN_SERACH_RET
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectory;  // ���ص��ļ�Ŀ¼
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //DVR�豸����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICECFG_V40
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDVRName; //DVR����
            public uint dwDVRID;				//DVR ID,����ң���� //V1.4(0-99), V1.5(0-255)
            public uint dwRecycleRecord;		//�Ƿ�ѭ��¼��,0:����; 1:��
            //���²��ɸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber; //���к�
            public uint dwSoftwareVersion;			//����汾��,��16λ�����汾,��16λ�Ǵΰ汾
            public uint dwSoftwareBuildDate;			//�����������,0xYYYYMMDD
            public uint dwDSPSoftwareVersion;		    //DSP����汾,��16λ�����汾,��16λ�Ǵΰ汾
            public uint dwDSPSoftwareBuildDate;		// DSP�����������,0xYYYYMMDD
            public uint dwPanelVersion;				// ǰ���汾,��16λ�����汾,��16λ�Ǵΰ汾
            public uint dwHardwareVersion;	// Ӳ���汾,��16λ�����汾,��16λ�Ǵΰ汾
            public byte byAlarmInPortNum;		//DVR�����������
            public byte byAlarmOutPortNum;		//DVR�����������
            public byte byRS232Num;			//DVR 232���ڸ���
            public byte byRS485Num;			//DVR 485���ڸ��� 
            public byte byNetworkPortNum;		//����ڸ���
            public byte byDiskCtrlNum;			//DVR Ӳ�̿���������
            public byte byDiskNum;				//DVR Ӳ�̸���
            public byte byDVRType;				//DVR����, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;				//DVR ͨ������
            public byte byStartChan;			//��ʼͨ����,����DVS-1,DVR - 1
            public byte byDecordChans;			//DVR ����·��
            public byte byVGANum;				//VGA�ڵĸ��� 
            public byte byUSBNum;				//USB�ڵĸ���
            public byte byAuxoutNum;			//���ڵĸ���
            public byte byAudioNum;			//�����ڵĸ���
            public byte byIPChanNum;			//�������ͨ���� ��8λ����8λ��byHighIPChanNum 
            public byte byZeroChanNum;			//��ͨ���������
            public byte bySupport;        //������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧�֣�
            //bySupport & 0x1, ��ʾ�Ƿ�֧����������
            //bySupport & 0x2, ��ʾ�Ƿ�֧�ֱ���
            //bySupport & 0x4, ��ʾ�Ƿ�֧��ѹ������������ȡ
            //bySupport & 0x8, ��ʾ�Ƿ�֧�ֶ�����
            //bySupport & 0x10, ��ʾ֧��Զ��SADP
            //bySupport & 0x20, ��ʾ֧��Raid������
            //bySupport & 0x40, ��ʾ֧��IPSAN����
	        //bySupport & 0x80, ��ʾ֧��rtp over rtsp
            public byte byEsataUseage;		//Esata��Ĭ����;��0-Ĭ�ϱ��ݣ�1-Ĭ��¼��
            public byte byIPCPlug;			//0-�رռ��弴�ã�1-�򿪼��弴��
            public byte byStorageMode;		//0-����ģʽ,1-�������, 2��֡ģʽ
            public byte bySupport1;		//������λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
	        //bySupport1 & 0x1, ��ʾ�Ƿ�֧��snmp v30
	        //bySupport1 & 0x2, ֧�����ֻطź�����
	        //bySupport1 & 0x4, �Ƿ�֧�ֲ������ȼ�	
	        //bySupport1 & 0x8, �����豸�Ƿ�֧�ֲ���ʱ�����չ
	        //bySupport1 & 0x10, ��ʾ�Ƿ�֧�ֶ������������33����
	        //bySupport1 & 0x20, ��ʾ�Ƿ�֧��rtsp over http	
            public ushort wDevType;//�豸�ͺ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DEV_TYPE_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDevTypeName;//�豸�ͺ����� 
            public byte bySupport2; //��������չ��λ����Ϊ0��ʾ��֧�֣�1��ʾ֧��
	        //bySupport2 & 0x1, ��ʾ�Ƿ�֧����չ��OSD�ַ�����(�ն˺�ץ�Ļ���չ����)
            public byte byAnalogAlarmInPortNum; //ģ�ⱨ���������
            public byte byStartAlarmInNo;    //ģ�ⱨ��������ʼ��
            public byte byStartAlarmOutNo;  //ģ�ⱨ�������ʼ��
            public byte byStartIPAlarmInNo;  //IP����������ʼ��  0-��Ч
            public byte byStartIPAlarmOutNo; //IP���������ʼ�� 0-��Ч
            public byte byHighIPChanNum;     //����ͨ����������8λ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//����
        }

        public const int MAX_ZEROCHAN_NUM = 16;
        //��ͨ��ѹ�����ò���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZEROCHANCFG
        {
            public uint dwSize;			    //�ṹ����
            public byte byEnable;			//0-ֹͣ��ͨ�����룬1-��ʾ������ͨ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//����
            public uint dwVideoBitrate; 	/*��Ƶ���� 0-���� 1-16K(����) 2-32K 3-48k 4-64K 5-80K 6-96K 7-128K 8-160k 9-192K 10-224K 11-256K 
                                             * 12-320K 13-384K 14-448K 15-512K 16-640K 17-768K 18-896K 19-1024K 20-1280K 21-1536K 22-1792K
                                             * 23-2048K
                                             * ���λ(31λ)�ó�1��ʾ���Զ�������, 0-30λ��ʾ����ֵ(MIN-32K MAX-8192K) */
            public uint dwVideoFrameRate;	//֡�� 0-ȫ��; 1-1/16; 2-1/8; 3-1/4; 4-1/2; 5-1; 6-2; 7-4; 8-6; 9-8; 10-10; 11-12; 12-16; 13-20, 
                                            //V2.0����14-15, 15-18, 16-22;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;        //����
        }

        //��ͨ�����Ų���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ZERO_ZOOMCFG
        {
            public uint dwSize;			    //�ṹ����
            public NET_VCA_POINT struPoint;	//�����е������
            public byte byState;		 //���ڵ�״̬��0-��С��1-�Ŵ�  
            public byte byPreviewNumber;       //Ԥ����Ŀ,0-1����,1-4����,2-9����,3-16���� �ò���ֻ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOW_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byPreviewSeq;//����ͨ����Ϣ �ò���ֻ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;				//���� 
        }

        public const int DESC_LEN_64 = 64;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG
        {
            public uint dwSize;			//�ṹ����
            public byte byEnable;			//0-����SNMP��1-��ʾ����SNMP
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			//����
            public ushort wVersion;		//snmp �汾  v1 = 1, v2 =2, v3 =3���豸Ŀǰ��֧�� v3
            public ushort wServerPort; //snmp��Ϣ���ն˿ڣ�Ĭ�� 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity; //����ͬ�壬���31,Ĭ��"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;//д��ͬ��,���31 �ֽ�,Ĭ�� "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;	//��������ip��ַ������֧��IPV4 IPV6����������    
            public ushort wTrapHostPort;   //trap�����˿�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 70, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPv3_USER
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName;			// �û���				
            public byte bySecLevel;	//��ȫ���� 1-��У�� 2-����ȨУ�� 3-��ȨУ��
            public byte byAuthtype;	//��֤���� 0-MD5��֤ 1-SHA��֤ 2: none
            public byte byPrivtype;	//0: DES; 1: AES; 2: none;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byAuthpass;	//��֤����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPrivpass;	//��������
        }
        
        //snmpv30
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SNMPCFG_V30
        {
            public uint dwSize;			//�ṹ����
            public byte byEnableV1;		//0-����SNMP V1��1-��ʾ����SNMP V1
            public byte byEnableV2;		//0-����SNMP V2��1-��ʾ����SNMP V2
            public byte byEnableV3;		//0-����SNMP V3��1-��ʾ����SNMP V3
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wServerPort;					//snmp��Ϣ���ն˿ڣ�Ĭ�� 161
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byReadCommunity;		//����ͬ�壬���31,Ĭ��"public"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWriteCommunity;		//д��ͬ��,���31 �ֽ�,Ĭ�� "private"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_64, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapHostIP;		//��������ip��ַ������֧��IPV4 IPV6����������    
            public ushort wTrapHostPort;					// trap�����˿�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;       
            public NET_DVR_SNMPv3_USER struRWUser;    // ��д�û�
            public NET_DVR_SNMPv3_USER struROUser;    // ֻ���û�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byTrapName;
        }
        
        public const int PROCESSING = 0;    //���ڴ���
        public const int PROCESS_SUCCESS = 100;   //�������
        public const int PROCESS_EXCEPTION = 400;   //�����쳣
        public const int PROCESS_FAILED = 500;   //����ʧ��
        public const int PROCESS_QUICK_SETUP_PD_COUNT = 501; //һ����������3��Ӳ��

        public const int SOFTWARE_VERSION_LEN = 48;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO
        {
            public NET_DVR_IPADDR struIP;     // �豸IP��ַ
            public ushort wPort;      // �豸�˿ں�
            public ushort wFactoryType;   // �豸��������
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = SOFTWARE_VERSION_LEN)]
            public string chSoftwareVersion;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string chSerialNo; // ���к�
            public ushort wEncCnt;   // ����ͨ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMACAddr;		// MAC ��ַ
            public NET_DVR_IPADDR struSubDVRIPMask;   // DVR IP��ַ����
            public NET_DVR_IPADDR struGatewayIpAddr;  // ����
            public NET_DVR_IPADDR struDnsServer1IpAddr;	/* ����������1��IP��ַ */
            public NET_DVR_IPADDR struDnsServer2IpAddr;	/* ����������2��IP��ַ */
            public byte byDns;
            public byte byDhcp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 158, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     // �����ֽ�
        }

        public const int MAX_SADP_NUM = 256;  //�������豸�����Ŀ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADPINFO_LIST
        {
            public uint dwSize;   //  �ṹ��С
            public ushort wSadpNum;   // �������豸��Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SADP_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SADPINFO[] struSadpInfo; // ����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SADP_VERIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string chPassword;
            public NET_DVR_IPADDR struOldIP;
            public ushort wOldPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        /***************************** end *********************************************/

        /*******************************���ݽṹ begin********************************/
        //��ȡ�����豸��Ϣ�ӿڶ���
        public const int DESC_LEN_32 = 32;   //�����ֳ���
        public const int MAX_NODE_NUM = 256;  //�ڵ����

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DESC_NODE
        { 
            public int iValue; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; //�����ֶ� 
            public uint dwFreeSpace; //��ȡ�����б�ר��,��λΪM
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			  //����  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISKABILITY_LIST
        { 
            public uint dwSize;            //�ṹ����
            public uint dwNodeNum;		 //����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[] struDescNode;  //��������  
        }

        //���ݽ����б�
        public const int BACKUP_SUCCESS            =    100;  //�������
        public const int BACKUP_CHANGE_DEVICE      =    101;  //�����豸�����������豸��������

        public const int BACKUP_SEARCH_DEVICE      =    300;  //�������������豸
        public const int BACKUP_SEARCH_FILE        =    301;  //��������¼���ļ�
        public const int BACKUP_SEARCH_LOG_FILE    =    302;  //����������־�ļ�

        public const int BACKUP_EXCEPTION		   =    400;  //�����쳣
        public const int BACKUP_FAIL			   =	500;  //����ʧ��

        public const int BACKUP_TIME_SEG_NO_FILE   =    501;  //ʱ�������¼���ļ�
        public const int BACKUP_NO_RESOURCE        =    502;  //���벻����Դ
        public const int BACKUP_DEVICE_LOW_SPACE   =    503;  //�����豸��������
        public const int BACKUP_DISK_FINALIZED     =    504;  //��¼���̷���
        public const int BACKUP_DISK_EXCEPTION     =    505;  //��¼�����쳣
        public const int BACKUP_DEVICE_NOT_EXIST   =    506;  //�����豸������
        public const int BACKUP_OTHER_BACKUP_WORK  =    507;  //���������ݲ����ڽ���
        public const int BACKUP_USER_NO_RIGHT      =    508;  //�û�û�в���Ȩ��
        public const int BACKUP_OPERATE_FAIL       =    509;  //����ʧ��
        public const int BACKUP_NO_LOG_FILE        =    510;  //Ӳ��������־

        //���ݹ��̽ӿڶ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_NAME_PARAM
        {
            public uint dwFileNum;   //�ļ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_FILE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FINDDATA_V30[] struFileList; //�ļ��б�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;   //���ݴ�������
            public byte byWithPlayer;      //�Ƿ񱸷ݲ�����
            public byte byContinue;    /*�Ƿ�������� 0������ 1����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;         //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_TIME_PARAM
        {
            public int lChannel;        //��ʱ�䱸�ݵ�ͨ��
            public NET_DVR_TIME struStartTime;   //���ݵ���ʼʱ��
            public NET_DVR_TIME struStopTime;    //���ݵ���ֹʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;     //���ݴ�������
            public byte byWithPlayer;               //�Ƿ񱸷ݲ�����
            public byte byContinue;                 //�Ƿ�������� 0������ 1����
            public byte byDrawFrame;			     //0 ����֡  1 ��֡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 33, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					 // �����ֽ� 
        }
        /********************************* end *******************************************/
        public enum COMPRESSION_ABILITY_TYPE
        {
            COMPRESSION_STREAM_ABILITY = 0, //����ѹ������
	        MAIN_RESOLUTION_ABILITY = 1,	//������ѹ���ֱ���
	        SUB_RESOLUTION_ABILITY  = 2,	//������ѹ���ֱ���
	        EVENT_RESOLUTION_ABILITY =  3,  //�¼�ѹ�������ֱ���
	        FRAME_ABILITY = 4,				//֡������
	        BITRATE_TYPE_ABILITY = 5,		//λ����������
	        BITRATE_ABILITY = 6,			//λ������
	        THIRD_RESOLUTION_ABILITY = 7,   //������ѹ���ֱ���
	        STREAM_TYPE_ABILITY = 8,        //��������
	        PIC_QUALITY_ABILITY = 9,         //ͼ������
	        INTERVAL_BPFRAME_ABILITY = 10,  //BP֡���
	        VIDEO_ENC_ABILITY = 11,           //��Ƶ��������
	        AUDIO_ENC_ABILITY = 12,           //��Ƶ��������
	        VIDEO_ENC_COMPLEXITY_ABILITY = 13, //��Ƶ���븴�Ӷ�����
	        FORMAT_ABILITY = 14, //��װ��ʽ����
        }

        //�����б�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ABILITY_LIST
        { 
            public uint dwAbilityType;	//�������� COMPRESSION_ABILITY_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //�����ֽ�
            public uint dwNodeNum;		//����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NODE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DESC_NODE[]  struDescNode;  //��������  
        }

        public const int MAX_ABILITYTYPE_NUM = 12;   //���������

        // ѹ�����������б�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSIONCFG_ABILITY
        { 
            public uint dwSize;            //�ṹ����
            public uint dwAbilityNum;		//�������͸���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ABILITYTYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ABILITY_LIST[] struAbilityNode; //��������  
        }

        //ģʽA 
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEA
        {
            public byte byStartMonth;	// ��ʼ�� ��1��ʼ
            public byte byStartDay;		// ��ʼ�� ��1��ʼ
            public byte byEndMonth;		// ������ 
            public byte byEndDay;		// ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEB
        {
            public byte byStartMonth;	// ��1��ʼ
            public byte byStartWeekNum;	// �ڼ������� ��1��ʼ 
            public byte byStartWeekday;	// ���ڼ�
            public byte byEndMonth;		// ��1��ʼ
            public byte byEndWeekNum;	// �ڼ������� ��1��ʼ 
            public byte byEndWeekday;	// ���ڼ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ� 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDATE_MODEC
        {
            public ushort wStartYear;		// ��
            public byte byStartMon;		// ��
            public byte byStartDay;		// ��
            public ushort wEndYear;		// ��
            public byte byEndMon;		// ��
            public byte byEndDay;		// ��
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_HOLIDATE_UNION
        {	
            //�������С 12�ֽ�
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U4)]
            public uint[] dwSize;
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEA	struModeA;	// ģʽA
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEB	struModeB;	// ģʽB
            [FieldOffsetAttribute(0)]
            public NET_DVR_HOLIDATE_MODEC	struModeC;	// ģʽC
        }

        public enum HOLI_DATE_MODE
        {
            HOLIDATE_MODEA = 0,
            HOLIDATE_MODEB,
            HOLIDATE_MODEC
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM
        {
            public byte byEnable;			// �Ƿ�����
            public byte byDateMode;			// ����ģʽ 0-ģʽA 1-ģʽB 2-ģʽC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// �����ֽ�
            public NET_DVR_HOLIDATE_UNION uHolidate;	// ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName;	// ��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// �����ֽ�
        }

        public const int MAX_HOLIDAY_NUM = 32;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_PARAM_CFG
        {
            public uint dwSize;			// �ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HOLIDAY_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_HOLIDAY_PARAM[] struHolidayParam;	// ���ղ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// ��������
        }

        //���ձ�������ʽ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_HANDLE
        {
            public uint dwSize;				// �ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;	// ����ʱ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 240, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;		// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HOLIDAY_RECORD
        {
            public uint dwSize;
            public NET_DVR_RECORDDAY struRecDay;     // ¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_RECORDSCHED[] struRecordSched; // ¼��ʱ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //  �����ֽ�
        }

        public const int MAX_LINK_V30 = 128;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ONE_LINK
        {
            public NET_DVR_IPADDR  struIP;     // �ͻ���IP
            public int lChannel;   // ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LINK_STATUS
        {
            public uint dwSize;      // �ṹ���С
            public ushort wLinkNum;    // ���ӵ���Ŀ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LINK_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_LINK[] struOneLink;   // ���ӵĿͻ�����Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  // �����ֽ�
        }

        public const int MAX_BOND_NUM = 2;

                //��BONDING�������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_ONE_BONDING
        {
            public byte byMode;
            public byte byUseDhcp;
            public byte byMasterCard;
            public byte byStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NETWORK_CARD, ArraySubType = UnmanagedType.I1)]
            public byte[] byBond;
            public NET_DVR_ETHERNET_V30 struEtherNet;
            public NET_DVR_IPADDR struGatewayIpAddr;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //BONDING�������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_DVR_NETWORK_BONDING
        {  
            public uint dwSize;  
            public byte byEnable;
            public byte byNum;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_BOND_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_ONE_BONDING[] struOneBond;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }


        //�������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA 
        {
            public byte byQuotaType;	 // �����������,1 - ������ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       // �����ֽ�
            public uint dwHCapacity;     // ����Ĵ���������32λ ��λMB
            public uint dwLCapacity;     // ����Ĵ���������32λ ��λMB
            public uint dwHUsedSpace;    // ��ʹ�õĴ��̴�С��32λ ��λMB
            public uint dwLUsedSpace;    // ��ʹ�õĴ��̴�С��32λ ��λMB
            public byte byQuotaRatio;    //	����Ĵ��̱���,��λ:%
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_QUOTA_CFG
        {
            public uint dwSize;         // �ṹ���С
            public NET_DVR_DISK_QUOTA struPicQuota;    //  ͼƬ���
            public NET_DVR_DISK_QUOTA struRecordQuota;    //  ¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //�����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIMING_CAPTURE
        {
            public NET_DVR_JPEGPARA struJpegPara;   // ��ʱץͼͼƬ����
            public uint dwPicInterval; //��ʱץͼʱ����,��λs   1-1s 2-2s 3-3s 4-4s 5-5s 
                                       //6-10m 7-30m 8-1h 9-12h 10-24h
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byChan;    // ��λ��ʾ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          // �����ֽ�
        }

        public const int MAX_PIC_EVENT_NUM = 32;
        public const int MAX_ALARMIN_CAPTURE = 16;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REL_CAPTURE_CHAN_V40
        {
            public uint dwMaxRelCaptureChanNum;  //���ɴ����Ĺ���ͨ����-ֻ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwChanNo; //�����Ĺ���ץͼͨ���ţ���ֵ��ʾ�����ý���������,0xffffffff��ʾ������Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE_V40
        {
            public NET_DVR_JPEGPARA struJpegPara;   // �¼�ץͼͼƬ����
            public uint dwPicInterval;   // �¼�ץͼʱ����  ��λΪ�� 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struRelCaptureChan;   // �����±� 0 �ƶ���ⴥ��ץͼ 1 ��Ƶ�ڵ�����ץͼ 2 ��Ƶ��ʧ����ץͼ,����3��ʾPIR����ץͼ������4��ʾ���߱���ץͼ������5��ʾ���ȱ���ץͼ,����6��ʾ����ץͼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN_V40[] struAlarmInCapture;    // �������봥��ץͼ���±�0 ����������1 ��������
            public uint dwMaxGroupNum;  //�豸֧�ֵ���󱨾�����������ÿ��16����������
            public byte byCapTimes; //ץͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_EVENT_CAPTURE
        {
            public NET_DVR_JPEGPARA  struJpegPara;   // �¼�ץͼͼƬ����
            public uint dwPicInterval;  /*�¼�ץͼʱ����  ��λΪ��  1-1s 2-2s 3-3s 4-4s 5-5s 
                                             * 6-10m 7-30m 8-1h 9-12h 10-24h*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PIC_EVENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struRelCaptureChan; /* �����±� 0 �ƶ���ⴥ��ץͼ 1 ��Ƶ�ڵ�����ץͼ,
                                                                   * 2 ��Ƶ��ʧ����ץͼ,����3��ʾPIR����ץͼ������4��ʾ���߱���ץͼ��
                                                                   * ����5��ʾ���ȱ���ץͼ,����6��ʾ����ץͼ�� ����7��ʾ�������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_ALARMIN_CAPTURE, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_REL_CAPTURE_CHAN[] struAlarmInCapture;  //�������봥��ץͼ���±�0 ����������1 ��������
            public byte byCapTimes; //ץͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 59, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG_V40
        {
            public uint dwSize;               //�ṹ�峤��
            public NET_DVR_TIMING_CAPTURE struTimingCapture;    
            public NET_DVR_EVENT_CAPTURE_V40 struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_JPEG_CAPTURE_CFG
        {
            public uint dwSize;         // �ṹ���С
            public NET_DVR_TIMING_CAPTURE struTimingCapture;    
            public NET_DVR_EVENT_CAPTURE struEventCapture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes3;     // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_DAY
        {
            public byte byAllDayCapture;	// �Ƿ�ȫ��ץͼ
            public byte byCaptureType;		// ץͼ���ͣ�0-��ʱץͼ��1-�ƶ����ץͼ��2-����ץͼ��3-�ƶ����򱨾�ץͼ��4-�ƶ����ͱ���ץͼ��6-���ܱ���ץͼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAPTURE_SCHED
        {
            public NET_DVR_SCHEDTIME struCaptureTime;        // ץͼʱ���
            public byte byCaptureType;       // ץͼ���ͣ�0-��ʱץͼ��1-�ƶ����ץͼ��2-����ץͼ��3-�ƶ����򱨾�ץͼ��4-�ƶ����ͱ���ץͼ��6-���ܱ���ץͼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           // �����ֽ�
        }

        //ͨ��ץͼ�ƻ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCHED_CAPTURECFG
        {
            public uint dwSize;     //�ṹ��
            public byte byEnable;	//�Ƿ�ץͼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;	//�����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_DAY[] struCaptureDay;//ȫ��ץͼ�ƻ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struCaptureSched;//ʱ���ץͼ�����ƻ�
            public NET_DVR_CAPTURE_DAY	struCaptureHoliday;	//����ץͼ�ƻ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TIMESEGMENT_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CAPTURE_SCHED[] struHolidaySched;	//ʱ��μ���ץͼ�����ƻ�
            public uint dwRecorderDuration;	//ץͼ�����ʱ�� 0xffffffff��ʾ��ֵ��Ч 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;			//�����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_TEST_PARAM
        {
            public uint dwSize;              //�ṹ��С
            public int lCardIndex;         //��������
            public uint dwInterval;         //�豸�ϴ�����ʱ����, ��λ:100ms
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //�����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FLOW_INFO
        {
            public uint dwSize;             //�ṹ��С
            public uint dwSendFlowSize;     //����������С,��λkbps
            public uint dwRecvFlowSize;     //����������С,��λkbps
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;          //���� 
        }

        //¼���ǩ
        public const int LABEL_NAME_LEN = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_LABEL
        {
            public uint dwSize;					// �ṹ���С
            public NET_DVR_TIME struTimeLabel;			// ��ǩ��ʱ�� 
            public byte byQuickAdd;				// �Ƿ������� �������ʱ��ǩ������Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				// �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ��ǩ������ ����Ϊ40�ֽ�  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// �����ֽ�
        }

        public const int LABEL_IDENTIFY_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LABEL_IDENTIFY
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_IDENTIFY_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelIdentify;    // 64�ֽڱ�ʶ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;               // �����ֽ�
        }

        public const int MAX_DEL_LABEL_IDENTIFY = 20;// ɾ��������ǩ��ʶ����

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEL_LABEL_PARAM
        {
            public uint dwSize;       // �ṹ���С
            public byte byMode;   // ��λ��ʾ,0x01��ʾ����ʶɾ��
            public byte byRes1;
            public ushort wLabelNum;      // ��ǩ��Ŀ   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DEL_LABEL_IDENTIFY, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LABEL_IDENTIFY[] struIndentify; // ��ǩ��ʶ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   //�����ֽ�    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MOD_LABEL_PARAM
        {
            public NET_DVR_LABEL_IDENTIFY struIndentify; //Ҫ�޸ĵı�ǩ��ʶ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//�޸ĺ�ı�ǩ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				
        }

        //��ǩ�����ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_LABEL
        {
            public uint dwSize;          // �ṹ���С
            public int lChannel;		// ���ҵ�ͨ��
            public NET_DVR_TIME	struStartTime;	// ��ʼʱ��
            public NET_DVR_TIME	struStopTime;	// ����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	//  ¼���ǩ���� �����ǩ����Ϊ�գ���������ֹʱ�����б�ǩ
            public byte byDrawFrame;		//0:����֡��1����֡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
        }

        //��ǩ��Ϣ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FINDLABEL_DATA
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = LABEL_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sLabelName;	// ��ǩ����
            public NET_DVR_TIME struTimeLabel;		// ��ǩʱ��
            public NET_DVR_LABEL_IDENTIFY struLabelIdentify; // ��ǩ��ʶ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;			// �����ֽ�
        }

        public const int CARDNUM_LEN_V30 = 40;
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE_PARAM
        {
            public uint dwSize;        //�ṹ���С 
            public int lChannel;       //ͨ����
            public byte byFileType;   /* ���ҵ�ͼƬ����:0��ʱץͼ1 �ƶ����ץͼ 2 ����ץͼ3  ���� | �ƶ����ץͼ 4 ���� & �ƶ����ץͼ
                                       * 6 �ֶ�ץͼ ,9-����ͼƬ,10- PIR������11- ���߱�����12- ���ȱ���,0xa Ԥ��ʱ��ͼ��0xd �������, 
                                       * 0xe Խ����⣬0xf ����������⣬0x10 ����������, 0x11-�豸���ػط�ʱ��ͼ, 0x12-������⣬
                                       * 0xff- ȫ������ 2013-07-16*/  
            public byte byNeedCard;     //�Ƿ���Ҫ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;      // �����ֽ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNum;     // ����
            public NET_DVR_TIME  struStartTime;//����ͼƬ�Ŀ�ʼʱ��
            public NET_DVR_TIME  struStopTime;// ����ͼƬ�Ľ���ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;     // �����ֽ�
        }

        public const int PICTURE_NAME_LEN = 64;

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_PICTURE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PICTURE_NAME_LEN)]
            public string sFileName;//ͼƬ��
            public NET_DVR_TIME struTime;//ͼƬ��ʱ��
            public uint dwFileSize;//ͼƬ�Ĵ�С
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = CARDNUM_LEN_V30)]
            public string sCardNum;	//����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		//  �����ֽ�
        }

        public const int MAX_RECORD_PICTURE_NUM = 50;   //��󱸷�ͼƬ����  

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BACKUP_PICTURE_PARAM
        {
            public uint dwSize;         // �ṹ���С   
            public uint dwPicNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RECORD_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_FIND_PICTURE[] struPicture;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN_32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDiskDes;
            public byte byWithPlayer;
            public byte byContinue;    /*�Ƿ�������� 0������ 1����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_COMPRESSION_LIMIT
        {	
            public uint dwSize;           //�ṹ���С
            public uint dwChannel;        //ͨ����
            public byte byCompressType;   //����ȡ��ѹ����������1,������2,������3,�¼�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //����
            public NET_DVR_COMPRESSIONCFG_V30  struCurrentCfg; //��ǰѹ����������
        }

        public const int STEP_READY      = 0;    //׼������
        public const int STEP_RECV_DATA  = 1;    //��������������
        public const int STEP_UPGRADE    = 2;    //����ϵͳ
        public const int STEP_BACKUP     = 3;    //����ϵͳ
        public const int STEP_SEARCH     = 255;  //���������ļ�

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_EFFECT
        {
            public uint dwBrightValue;      //����[0,255]
            public uint dwContrastValue;    //�Աȶ�[0,255]
            public uint dwSaturationValue;  //���Ͷ�[0,255]
            public uint dwHueValue;         //ɫ��[0,255]
            public uint dwSharpness;		  //���[0,255]
            public uint dwDenoising;		  //ȥ��[0,255]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEO_INPUT_EFFECT
        {	
            public uint dwSize;				//�ṹ���С
            public ushort wEffectMode;        //ģʽ 0-��׼ 1-���� 2-���� 3-����  255-�Զ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 146, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;        //����
            public NET_DVR_VIDEO_EFFECT struVideoEffect;	//��ƵЧ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			//����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VIDEOPARA_V40
        {
            public uint dwChannel;			// ͨ����
            public uint dwVideoParamType;  	// ��Ƶ�������� 0-���� 1-�Աȶ� 2-���Ͷ� 3-ɫ�� 4-��� 5-ȥ��
            public uint dwVideoParamValue;  //��Ӧ����Ƶ����ֵ����Χ����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFAULT_VIDEO_COND
        {
            public uint dwSize;			// �ṹ���С
            public uint dwChannel;		// ͨ����
            public uint dwVideoMode;	// ģʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      // ����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ENCODE_JOINT_PARAM
        {
            public uint dwSize;			// �ṹ���С
            public byte byJointed;		//  0 û�й��� 1 �Ѿ�����
            public byte byDevType;		// ���������豸����  1 ���������豸
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;		// �����ֽ�
            public NET_DVR_IPADDR	struIP;			// �����ı�ȡ���豸IP��ַ
            public ushort wPort;			// �����ı�ȡ���豸�˿ں�
            public ushort wChannel;		// �����ı�ȡ���豸ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;			// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_CHAN_WORKSTATUS
        {
            public byte byJointed;				// 0-û�й���  1-�Ѿ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR	struIP;					// ������ȡ���豸IP��ַ
            public ushort wPort;					// ������ȡ���豸�˿ں�
            public ushort wChannel;				// ������ȡ���豸ͨ����
            public byte byVcaChanStatus;		// 0 - δ���� 1 - ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;				// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VCA_DEV_WORKSTATUS
        {
            public uint dwSize;			// �ṹ���С
            public byte byDeviceStatus;	// �豸��״̬0 - �������� 1- ����������
            public byte byCpuLoad;		// CPUʹ����0-100 �ֱ����ʹ�ðٷ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_VCA_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_VCA_CHAN_WORKSTATUS[] struVcaChanStatus;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;		// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_VIDEOPLATFORM_V40
        {
            /*�����Ӵ��ڶ�Ӧ����ͨ������Ӧ�Ľ�����ϵͳ�Ĳ�λ��(������Ƶ�ۺ�ƽ̨�н�����ϵͳ��Ч)*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            //��ʾ����������Ƶ�ֱ��ʣ�1-D1,2-720P,3-1080P���豸����Ҫ���ݴ�//�ֱ��ʽ��н���ͨ���ķ��䣬��1�������ó�1080P�����豸���4������ͨ
            //����������˽���ͨ��
            public byte byDecResolution;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 143, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct UNION_NOTVIDEOPLATFORM_V40
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VGA_DISP_CHAN_CFG_V40
        {        
            public uint dwSize; 
            public byte byAudio;			/*��Ƶ�Ƿ���*/
            public byte byAudioWindowIdx;      /*��Ƶ�����Ӵ���*/
            public byte byVgaResolution;      /*�ֱ��ʣ�����������ȡ*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL��0-NULL*/
            public uint dwWindowMode;		/*����ģʽ����������ȡ*/       
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
            public byte byEnlargeStatus;          /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
            public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�
            public byte byScale; /*��ʾģʽ��0---��ʵ��ʾ��1---������ʾ( ���BNC )*/
	        /*���ֹ����壬0-��Ƶ�ۺ�ƽ̨�ڲ���������ʾͨ�����ã�1-������������ʾͨ������*/
            public byte byUnionType;
	
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct struDiff
            {
                [FieldOffsetAttribute(0)]
		        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
                public byte[] byRes;

                [FieldOffsetAttribute(0)]
                public UNION_VIDEOPLATFORM_V40 struVideoPlatform;

                [FieldOffsetAttribute(0)]
                public UNION_NOTVIDEOPLATFORM_V40 struNotVideoPlatform;
	        }
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_V6SUBSYSTEMPARAM
        {
            public byte bySerialTrans;//�Ƿ�͸����0-��1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_V6PSUBSYSTEMARAM_GET = 1501;//��ȡV6��ϵͳ����
        public const int NET_DVR_V6PSUBSYSTEMARAM_SET = 1502;//����V6��ϵͳ����

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CORRECT_DEADPIXEL_PARAM
        {
            public uint dwSize;
            public uint dwCommand; //���0-���뻵��ģʽ��1-��ӻ��㣬2-���滵�㣬3-�˳�����
            public uint dwDeadPixelX; //����X����
            public uint dwDeadPixelY; //����Y����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        public const int MAX_REDAREA_NUM = 6;   //�����̵��������

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_REDAREACFG
        {
            public uint dwSize;
            public uint dwCorrectEnable; //�Ƿ���У�����ܣ�0-�رգ�1-����
            public uint dwCorrectLevel; //У������1(У�������)-10(У�������),Ĭ��Ϊ5
            public uint dwAreaNum; //У���������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_REDAREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_RECT[] struLaneRect; //У������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HISTORICDATACFG
        {
            public uint dwSize;
            public uint dwTotalNum;  //��ʷ���ݸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int INQUEST_MESSAGE_LEN  = 44;    //��Ѷ�ص�����Ϣ����
        public const int INQUEST_MAX_ROOM_NUM = 2;    //�����Ѷ�Ҹ���
        public const int MAX_RESUME_SEGMENT   = 2;     //֧��ͬʱ�ָ���Ƭ����Ŀ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM
        {
            public byte byRoomIndex;     //��Ѷ�ұ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;       //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_MESSAGE
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = INQUEST_MESSAGE_LEN)]
            public string sMessage; //�ص�����Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;                     //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_DEVICE
        {
            public ushort wDeviceType;	//���ݲɼ��豸�ͺ�:0-�� 1-���� 2-�ز� 3-���� 4-���� 5-���ء�6-���ϡ�7-ά��˹��
            public ushort wDeviceAddr;	//���ݲɼ��豸��ַ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	    //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SENSOR_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_SENSOR_DEVICE[] struSensorDevice;
            public uint  dwSupportPro;      //֧��Э������,��λ��ʾ, �°汾����������������չ���ֶ�
							   //0x1:���� 0x2:�ز� 0x4:����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_ROOM_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = NAME_LEN)]
            public string szCDName;	//�������ƣ�����˫�̹���������һ����
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uCalcMode
	        {
                [FieldOffsetAttribute(0)]
                public byte byBitRate;	// byCalcTypeΪ0ʱ��Ч��(0-32��1-48��2-64��3-80��4-96��5-128��
								//6-160��7-192��8-224��9-256��10-320��11-384��12-448��
								//13-512��14-640��15-768��16-896ǰ16��ֵ����)17-1024��18-1280��19-1536��
								//20-1792��21-2048��22-3072��23-4096��24-8192
                [FieldOffsetAttribute(0)]
                public byte byInquestTime;  // byCalcTypeΪ1ʱ��Ч��0-1Сʱ, 1-2Сʱ,2-3Сʱ,3-4Сʱ, 4-6Сʱ,5-8Сʱ
		                        //8-16Сʱ, 9-20Сʱ,10-22Сʱ,11-24Сʱ
	        }
            public byte byCalcType;			//��¼��������0-������ 1-��ʱ��
            public byte byAutoDelRecord;	// �Ƿ��Զ�ɾ��¼��0-��ɾ����������ʱ����¼�� 1-ɾ��
            public byte byAlarmThreshold;		// ����������ֵ
            public byte byInquestChannelResolution;     //��Ѷͨ���ֱ��ʣ�0:720P  1:1080P
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_SYSTEM_INFO
        {
            public uint dwRecordMode;         //��¼ģʽ:1 ����˫��ģʽ 2 �����ֿ�ģʽ 3 ˫��˫��ģʽ���޸���Ҫ�����豸��
            public uint  dwWorkMode;           //����ģʽ:0 ��׼ģʽ 1 ͨ��ģʽ(������Ŀǰֻ�б�׼ģʽ)
            public uint dwResolutionMode;     //�豸�ֱ��ʣ�0:���� 1:D1 2:720P 3:1080P��������Ѷ�����ô��ֶΣ�
            public NET_DVR_INQUEST_SENSOR_INFO struSensorInfo;  //��ʪ�ȴ���������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = INQUEST_MAX_ROOM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_ROOM_INFO[] struInquestRoomInfo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_SEGMENT
        {
            public NET_DVR_TIME  struStartTime; //�¼���ʼʱ��
            public NET_DVR_TIME  struStopTime;  //�¼���ֹʱ��
            public byte byRoomIndex;         //��Ѷ�ұ��,��1��ʼ
            public byte byDriveIndex;        //��¼�����,��1��ʼ
            public ushort wSegmetSize;         //��Ƭ�ϵĴ�С, ��λM 
            public uint dwSegmentNo;         //��Ƭ���ڱ�����Ѷ�е����,��1��ʼ 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;           //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_RESUME_EVENT
        {
            public uint  dwResumeNum;       //��ָ����¼�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RESUME_SEGMENT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INQUEST_RESUME_SEGMENT[] struResumeSegment;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;        //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INQUEST_DEVICE_VERSION
        {
            public byte byMainVersion;         /*�������汾.
								   0 : δ֪
								   1 : 8000��ѶDVR
								       �ΰ汾: 1 : 8000HD-S
								   2 : 8100��ѶDVR 
									   �ΰ汾: 1 : ��Ѷ81SNL
											   2 : ��Ѷ81SH
											   3 : ��Ѷ81SFH
								   3 : 8608������Ѷ��NVR 
									   �ΰ汾: 1 : DS-8608SN-SP
											   2 : DS-8608SN-ST
									  */
            public byte bySubVersion;          //���ߴΰ汾
            public byte byUpgradeVersion;      //�����汾,δ����Ϊ0
            public byte byCustomizeVersion;     //���ư汾,�Ƕ���Ϊ0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;             //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISK_RAID_INFO 
        {
            public uint dwSize;   //�ṹ���С
            public byte byEnable;  //����Raid�Ƿ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //�����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SYNCHRONOUS_IPC
        {
            public uint dwSize;    //�ṹ���С
            public byte byEnable;  //�Ƿ����ã�Ϊǰ��IPCͬ���豸����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_PASSWD
        {
            public uint dwSize;    //�ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sOldPasswd;  //IPC�ľ����룬����DVR��DVR��֤
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = PASSWD_LEN)]
            public string sNewPasswd;  //IPC��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ͨ����ȡDVR������״̬����λbps
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DEVICE_NET_USING_INFO 
        {
            public uint dwSize;    //�ṹ���С
            public uint dwPreview;   //Ԥ��
            public uint dwPlayback;  //�ط�
            public uint dwIPCModule; //IPC����
            public uint dwNetDiskRW; //���̶�д
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
        }

        //ͨ��DVR����ǰ��IPC��IP��ַ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IPC_NETCFG
        {
            public uint dwSize;      //�ṹ���С
            public NET_DVR_IPADDR struIP;       //IPC��IP��ַ
            public ushort wPort;       //IPC�Ķ˿�
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 126)]
            public string res;  
        }

        //��ʱ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_TIME_LOCK
        {
            public uint dwSize;      //�ṹ���С
            public NET_DVR_TIME strBeginTime;
            public NET_DVR_TIME strEndTime;
            public uint dwChannel;        //ͨ����, 0xff��ʾ����ͨ��
            public uint dwRecordType;     //¼������:  0xffffffff��ȫ����0����ʱ¼��1-�ƶ���⣬2������������3-�����������ƶ���⣬4-�����������ƶ���⣬5-�������6-�ֶ�¼��7-����¼��(ͬ�ļ�����)
            public uint dwLockDuration;   //��������ʱ��,��λ��,0xffffffff��ʾ��������
            public NET_DVR_TIME_EX strUnlockTimePoint;	//����ʱ��Ч����dwLockDuration��Ϊ��������ʱ������������ʱ�䵽��ʱ�����Զ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOCK_RETURN
        {
            public uint dwSize;      //�ṹ���С
            public NET_DVR_TIME strBeginTime; 
            public NET_DVR_TIME strEndTime;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //67DVS
        //֤����������
        public enum NET_SDK_UPLOAD_TYPE 
        {
            UPGRADE_CERT_FILE = 0, 
	        UPLOAD_CERT_FILE = 1,
	        TRIAL_CERT_FILE = 2,
            CONFIGURATION_FILE = 3
        }

        public enum NET_SDK_DOWNLOAD_TYPE
        {
	        NET_SDK_DOWNLOAD_CERT = 0,		//����֤��
	        NET_SDK_DOWNLOAD_IPC_CFG_FILE = 1,//����IPC�����ļ�
            NET_SDK_DOWNLOAD_BASELINE_SCENE_PIC = 2, //���ػ�׼����ͼƬ
	        NET_SDK_DOWNLOAD_VQD_ALARM_PIC = 3,       //����VQD����ͼƬ
            NET_SDK_DOWNLOAD_CONFIGURATION_FILE=4   //���������ļ�
        }

        //����״̬
       public enum NET_SDK_DOWNLOAD_STATUS
       {
	        NET_SDK_DOWNLOAD_STATUS_SUCCESS = 1,	//���سɹ�
	        NET_SDK_DOWNLOAD_STATUS_PROCESSING,		//��������
	        NET_SDK_DOWNLOAD_STATUS_FAILED,			//����ʧ��
	        NET_SDK_DOWNLOAD_STATUS_UNKOWN_ERROR	//δ֪���� 
       }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BONJOUR_CFG
        {
            public uint dwSize;				// �ṹ���С
            public byte byEnableBonjour;		// Bonjourʹ�� 0 ������ 1���ر�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;				
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendlyName; 	// ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SOCKS_CFG
        {
            public uint dwSize;				// �ṹ���С
            public byte byEnableSocks;  		// ʹ�� 0���ر� 1������
            public byte byVersion;  			// SOCKS�汾 4��SOCKS4   5��SOCKS5
            public ushort wProxyPort;				// ����˿ڣ�Ĭ��1080
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byProxyaddr;  	// ����IP��ַ������������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUserName; 	// �û��� SOCKS����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPassword;			// ����SOCKS5����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LOCAL_ADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocalAddr;  //��ʹ��socks��������Σ���ʽΪ"ip/netmask;ip/netmask;��"
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_QOS_CFG
        {
            public uint dwSize;
            public byte byManageDscp;   // �������ݵ�DSCPֵ [0-63]
            public byte byAlarmDscp;    // �������ݵ�DSCPֵ [0-63]
            public byte byVideoDscp;    // ��Ƶ���ݵ�DSCPֵ [0-63]��byFlagΪ0ʱ����ʾ����Ƶ
            public byte byAudioDscp;    // ��Ƶ���ݵ�DSCPֵ [0-63]��byFlagΪ1ʱ��Ч
            public byte byFlag;			// 0������Ƶ��һ��1������Ƶ�ֿ�
            public byte byEnable;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_HTTPS_CFG
        {
            public uint dwSize;
            public ushort wHttpsPort;		// HTTPS�˿�
            public byte byEnable;		// ʹ�� 0���ر� 1������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //֤�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_NAME
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_COUNTRY_NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCountry;  			//���Ҵ��� CN��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byState;				//�޻�ʡ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byLocality;			//����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byOrganization;		//��֯
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byUnit;				//��λ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byCommonName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DOMAIN_NAME, ArraySubType = UnmanagedType.I1)]
            public byte[] byEmail;  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_PARAM
        {
            public uint dwSize;
            public ushort wCertFunc; //֤�����࣬0-802.1x,1-HTTPS
            public ushort wCertType; //֤�����ͣ�0-CA��1-Certificate,2-˽Կ�ļ�
            public byte byFileType; //֤���ļ����ͣ�0-PEM,1-PFX
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        public const int UPLOAD_CERTIFICATE = 1; //�ϴ�֤��

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CERT_INFO
        {
            public uint dwSize;
            public NET_DVR_CERT_PARAM struCertParam;	//֤�����
            public uint dwValidDays;   //��Ч����������Ϊ��ǩ��ʱ��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPasswd;   //˽Կ����
            public NET_DVR_CERT_NAME struCertName;    // ֤������
            public NET_DVR_CERT_NAME struIssuerName;    // ֤�鷢�������ƣ���ǩ��֤����Ϣ��ȡʱ��Ч��
            public NET_DVR_TIME_EX struBeginTime;   //֤�鴴��ʱ�䣨��ǩ��֤����Ϣ��ȡʱ��Ч��
            public NET_DVR_TIME_EX struEndTime;   //֤���ֹʱ�䣨��ǩ��֤����Ϣ��ȡʱ��Ч��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] serialNumber;   //֤���ʶ�루��ǩ��֤����Ϣ��ȡʱ��Ч��
            public byte byVersion; 
            public byte byKeyAlgorithm;			//�������� 0-RSA  1-DSA
            public byte byKeyLen;				//���ܳ��� 0-512  1-1024�� 2-2048
            public byte bySignatureAlgorithm; //ǩ���㷨���ͣ���ǩ��֤����Ϣ��ȡʱ��Ч��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //channel record status
        //***ͨ��¼��״̬*****//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHANS_RECORD_STATUS
        {
            public byte byValid;       //�Ƿ���Ч
            public byte byRecord;      /*(ֻ��)¼������, ��λ��ʾ:0: ����¼��1����¼�� 2-���� 
						3-������ 4-��������Ƶ 5-δ���� 6-�浵��
							7-�ش��� 8-�û���������� 9-δ��֤
							10-�浵�к�¼���� 11-¼��ش��к�¼����*/
            public ushort wChannelNO;   //ͨ����
            public uint dwRelatedHD;  //��������
            public byte byOffLineRecord;  //����¼���� 0-�ر� 1-����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;      //�����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_IP_ALARM_GROUP_NUM
        {
            public uint dwSize; 
            public uint dwIPAlarmInGroup;      //IPͨ��������������
            public uint dwIPAlarmInNum;       //IPͨ�������������
            public uint dwIPAlarmOutGroup;     //IPͨ�������������
            public uint dwIPAlarmOutNum;      //IPͨ�������������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
        }
        
        //****NVR end***//
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CHAN_GROUP_RECORD_STATUS
        {
            public uint dwSize; //�ṹ���С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CHANS_RECORD_STATUS[] struChanStatus; //һ��64��
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG
        {
            public ushort wXCoordinate; /*�������Ͻ���ʼ��X����*/
            public ushort wYCoordinate; /*�������Ͻ�Y����*/
            public ushort wWidth;       /*���ο��*/
            public ushort wHeight;      /*���θ߶�*/
        }

        /*������Ϣ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINCFG
        {
            public uint dwSize;
            public byte byVaild;
            public byte byInputIdx;          /*����Դ����*/
            public byte byLayerIdx;          /*ͼ�㣬0Ϊ��ײ�*/
            public byte byTransparency; //͸���ȣ�0��100 
            public NET_DVR_RECTCFG  struWin;//Ŀ�Ĵ���(�����ʾǽ)
            public ushort wScreenHeight;//������
            public ushort wScreenWidth;//������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ALLWINCFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENZOOM
        {
            public uint dwSize;
            public uint dwScreenNum;//������
            public NET_DVR_POINT_FRAME struPointFrame;
            public byte byLayer;//ͼ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //2011-04-18
        /*�������Ϣ,���9999������1��ʼ */
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_CAMERAINFO
        {  
            public uint dwGlobalCamId;      /* cam��ȫ�ֱ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName; /*cam������*/
            public uint dwMatrixId;          /*cam��Ӧ����ı��*/
            public uint dwLocCamId;         /*cam��Ӧ������ڲ����*/ 
            public byte byValid;    /*�Ƿ���Ч��0-��1-��*/
            public byte byPtzCtrl; /* �Ƿ�ɿأ�0-��1-��*/
            public byte byUseType; //*ʹ�����ͣ�0-����Ϊ����ʹ�ã�1-BNC��2-SP3,3-V6���ˣ�4-��������*/ 
            public byte byUsedByTrunk;//��ǰʹ��״̬��0-û�б�ʹ�ã�1-������ʹ�� 
            public byte byTrunkReq; /*������ֱ���,��D1Ϊ��λ��1 - 1��D1��2- 2��D1����Ϊ����ʹ��ʱ��ָ���Ǹ��ߵĴ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_TIME struInstallTime;//��װʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*��;����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;  
        }

        /*��������Ϣ�����2048��*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MONITORINFO 
        {
            public uint dwGloalMonId; /*mon ��ͳһ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sMonName;
            public uint dwMatrixId;  /*mon���ھ���ı��*/
            public uint dwLocalMonId; /*mon���ڲ����*/
            public byte byValid;    /*�Ƿ���Ч��0-��1-��*/
            public byte byTrunkType; /*ʹ�����ͣ�0-����Ϊ����ʹ�ã�1-BNC��2-SP3,3-V6���ˣ�4-��������*/ 
            public byte byUsedByTrunk;//��ǰʹ��״̬��0-û�б�ʹ�ã�1-������ʹ�� 
            public byte byTrunkReq; /*�ֱ���, ��D1Ϊ��λ��1- 1��D1��2- 2��D1����Ϊ����ʹ��ʱ��ָ���Ǹ��ߵĴ���*/
            public NET_DVR_TIME struInstallTime;//��װʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*��;����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_DIGITALMATRIX
        {
            public NET_DVR_IPADDR struAddress; /*�豸Ϊ�����豸ʱ��IP��Ϣ*/
            public ushort wPort;
            public byte byNicNum; /*0 - eth0, 1 - eth1, ����˫�������ͨ�ż���󶨵�����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 69, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_ANALOGMATRIX
        {
            public byte bySerPortNum;   /*���ӵĴ��ں�*/
            public byte byMatrixSerPortType;/* ����������صĴ�����ģ�����ļ��̿�(����Э��)���ӻ��������ͨ�ſڣ�����Э�飩���� ��0 --- ����Э��ͨѶ�� 1 --- ����ͨѶ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SINGLE_RS232 struRS232;	//232���ڲ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;      
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_MATRIX_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_MATRIX_DIGITALMATRIX struDigitalMatrix;
            [FieldOffsetAttribute(0)]
            public NET_MATRIX_ANALOGMATRIX struAnalogMatrix;
        }
        
        /*����������Ϣ�����20��*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_MATRIXINFO 
        {
            public uint dwSize;
            public uint dwMatrixId;  /*������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;
            public byte byCtrlType; /*ָͨѶ��ʽ�Ǵ���ͨ��, ��������ͨ��*/
            public byte byProtocolType;/*����ͨ�ſ���Э��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;   /*Ԥ��*/
            public NET_MATRIX_UNION struMatrixUnion;
            public uint dwMaxPortsIn; /*����������*/
            public uint dwMaxPortsOut;/*���������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;   /*��¼�û���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;  /*��¼����*/        
            public NET_DVR_TIME struInstallTime;//��װʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPurpose;/*��;����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;   /*Ԥ��*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwMatrixNum;//�豸���صľ�������
            public IntPtr pBuffer;//������Ϣ������
            public uint dwBufLen;//������ָ�볤�ȣ��������
        }
 
        /*����������Ϣ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_UARTPARAM
        {	
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPortName;
            public ushort wUserId; /*�û���ţ��������豸Ϊ����ʱ����һ���û�������Ȩ�޹���*/
            public byte byPortType;    /*�������ͣ�����0-RS232/1-RS485/2-RS422*/
            public byte byFuncType; /*�������ӵ��豸������0-���У�1-���̣�2-����͸��ͨ��(485���ڲ������ó�͸��ͨ��),3-ģ�����*/     
            public byte byProtocolType;  /*����֧�ֵ�Э������, �����Ӽ����豸ʱ��Ҫ����Ϣ,��ȡ����֧��Э��ı�ż�������*/
            public byte byBaudRate;
            public byte byDataBits;
            public byte byStopBits;   /*ֹͣλ*/
            public byte byParity;      /*У��*/
            public byte byFlowCtrl;   /*���أ�������أ�������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     /*Ԥ��*/
        }

        //���256���û���1��256
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERPARAM 
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;
            public byte byRole;/*�û���ɫ:0-����Ա,1-����Ա��ֻ��һ��ϵͳ����Ա��255������Ա*/
            public byte byLevel;  /*ͳһ�������ڲ����������,1- 255*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //���255����Դ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_RESOURSEGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byGroupName;
            public byte byGroupType;/*0-�����CAM�飬1-������MON��*/
            public byte byRes1;
            public ushort wMemNum;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
            public uint[] dwGlobalId; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //���255���û���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_USERGROUPPARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wUserMember;  /*�������û���Ա*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 255, ArraySubType = UnmanagedType.U2)]
            public ushort[] wResorceGroupMember; /*��������Դ���Ա*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byPermission;//Ȩ�ޣ�����0-ptzȨ�ޡ��л�Ȩ�ޡ���ѯȨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_MATRIX_TRUNKPARAM
        {
            public uint dwSize;
            public uint dwTrunkId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sTrunkName;
            public uint dwSrcMonId;
            public uint dwDstCamId;
            public byte byTrunkType;  /*ʹ������  1-BNC��2-SP3���˸��壬3-SP3����D1�� 4-V6���ˣ�5-��������*/
            public byte byAbility;     /*��ʾ���˵Ĵ������Դ��伸·*/
            public byte bySubChan;   /*��Թ��˸��߶��ԣ���ʾ��ͨ����*/
            public byte byLevel;		/* ���߼��� 1-255*/
            public ushort wReserveUserID;	//Ԥ�����û�ID�� 1~256 ��0��ʾ�ͷ�Ԥ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_TRUNKLIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwTrunkNum;//�豸���صĸ�������
            public IntPtr pBuffer;//������Ϣ������
            public uint dwBufLen;//������ָ�볤�ȣ��������
        }

        public const int MATRIX_PROTOCOL_NUM   = 20;    //֧�ֵ�������Э����
        public const int KEYBOARD_PROTOCOL_NUM = 20;    //֧�ֵ�������Э����

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PROTO_TYPE_EX
        { 
            public ushort wType;               /*ipcЭ��ֵ*/  
            public ushort wCommunitionType;		/*0��ģ�� 1������ 2������ģ�⡢����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DESC_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byDescribe; /*Э�������ֶ�*/    
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIXMANAGE_ABIILITY
        {
            public uint dwSize;
            public uint dwMaxCameraNum;//���Camera����
            public uint dwMaxMonitorNum;//������������
            public ushort wMaxMatrixNum;//����������
            public ushort wMaxSerialNum;//��������
            public ushort wMaxUser;//����û���
            public ushort wMaxResourceArrayNum;//�����Դ����
            public ushort wMaxUserArrayNum;//����û�����
            public ushort wMaxTrunkNum;//��������
            public byte nStartUserNum;//��ʼ�û���
            public byte nStartUserGroupNum;//��ʼ�û����
            public byte nStartResourceGroupNum;//��ʼ��Դ���
            public byte nStartSerialNum;//��ʼ���ں�
            public uint  dwMatrixProtoNum;     /*��Ч�ľ���Э����Ŀ����0��ʼ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struMatrixProto;/*���Э���б���*/ 
            public uint dwKeyBoardProtoNum;     /*��Ч�ļ���Э����Ŀ����0��ʼ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MATRIX_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE_EX[] struKeyBoardProto;/*���Э���б���*/   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //����ץ�Ĺ���(����)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_FACESNAPCFG
        {
            public byte byActive;				//�Ƿ񼤻����0-��1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //����
            public NET_VCA_SIZE_FILTER struSizeFilter;   //�ߴ������
            public NET_VCA_POLYGON struVcaPolygon;		//����ʶ������
        }

        //����ץ�Ĺ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAPCFG
        {
            public uint dwSize;
            public byte bySnapTime;					//����Ŀ��������ץ�Ĵ���0-10
            public byte bySnapInterval;                 //ץ�ļ������λ��֡
            public byte bySnapThreshold;               //ץ����ֵ��0-100
            public byte byGenerateRate; 		//Ŀ�������ٶ�,��Χ[1, 5]	
            public byte bySensitive;			//Ŀ���������ȣ���Χ[1, 5]
            public byte byReferenceBright; //2012-3-27�ο�����[0,100]
            public byte byMatchType;         //2012-5-3�ȶԱ���ģʽ��0-Ŀ����ʧ�󱨾���1-ʵʱ����
            public byte byMatchThreshold;  //2012-5-3ʵʱ�ȶ���ֵ��0~100
            public NET_DVR_JPEGPARA struPictureParam; //ͼƬ���ṹ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_FACESNAPCFG[] struRule; //����ץ�Ĺ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //����ץ�Ľ�������ϴ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_RESULT
        {
            public uint dwSize;
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwFacePicID;
            public uint dwFaceScore;
            public NET_VCA_TARGET_INFO struTargetInfo;
            public NET_VCA_RECT struRect;
            public NET_VCA_DEV_INFO struDevInfo;
            public uint dwFacePicLen;
            public uint dwBackgroundPicLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
            public IntPtr pBuffer1;//ָ��������ͼ��ͼƬ����
            public IntPtr pBuffer2;//����ͼ��ͼƬ���ݣ�������ͨ�����ұ���ͼ�ӿڿ��Ի�ȡ����ͼ��
        }

        //�齹�����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEFOCUS_ALARM
        {
            public uint dwSize;     /*�ṹ����*/
            public NET_VCA_DEV_INFO struDevInfo;/*�豸��Ϣ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIOEXCEPTION_ALARM
        {
            public uint    dwSize;     /*�ṹ����*/
            public byte byAlarmType;//�������ͣ�1-��Ƶ�����쳣��2-��Ƶ����ͻ��
            public byte byRes1;
            public ushort wAudioDecibel;//����ǿ�ȣ���Ƶ����ͻ��ʱ�õ���
            public NET_VCA_DEV_INFO struDevInfo;/*�豸��Ϣ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_BUTTON_DOWN_EXCEPTION_ALARM
        {
            public uint dwSize;     /*�ṹ����*/
            public NET_VCA_DEV_INFO struDevInfo;/*�豸��Ϣ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		// �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_IMAGE_CFG
        {
            public uint dwWidth;                  //�Ҷ�ͼ�����ݿ��
            public uint dwHeight;                 //�Ҷ�ͼ��߶�
            public uint dwImageLen;  //�Ҷ�ͼ�����ݳ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
            public IntPtr pImage;    //�Ҷ�ͼ������
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_CFG
        {
            public uint  dwSize;           //�ṹ��С
            public byte byEnable;         //�Ƿ񼤻����;
            public byte bySensitivity;      //��������ȣ�[0,5]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 22, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;       //�����ֽ� 
            public NET_VCA_SIZE_FILTER struSizeFilter;  //�ߴ������
            public NET_VCA_POLYGON  struPolygon;    //�����
            public NET_VCA_FD_IMAGE_CFG struFDImage;  //ͼƬ��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_PROCIMG
        {
            public uint dwImageLen;  //ͼƬ���ݳ���
            public uint dwFaceScore;		//��������,0-100
            public NET_VCA_RECT struVcaRect; //������ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
            public IntPtr pImage;  //ͼƬ����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FD_PROCIMG_RESULT
        {
            public uint dwSize;   //�ṹ��С
            public uint dwImageId; //��ͼID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
            public uint dwSubImageNum;  //������ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_TARGET_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SUB_PROCIMG[] struProcImg;  //������ͼ��Ϣ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PICMODEL_RESULT
        {
            public uint dwImageLen;  //ͼƬ���ݳ���
            public uint dwModelLen;  //ģ�����ݳ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
            public IntPtr pImage;  //����ͼƬ����ָ��
            public IntPtr pModel;  //ģ������ָ��
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_REGISTER_PIC
        {
            public uint dwImageID; //��ͼID
            public uint dwFaceScore;		//��������,0-100
            public NET_VCA_RECT struVcaRect;  //������ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
        }

        //��������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AREAINFOCFG
        {
            public ushort wNationalityID;//����
            public ushort wProvinceID;//ʡ
            public ushort wCityID;//��
            public ushort wCountyID;//��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        //��Ա��Ϣ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMAN_ATTRIBUTE
        {
            public byte bySex;//�Ա�0-�У�1-Ů
            public byte byCertificateType;//֤�����ͣ�0-���֤��1-����֤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byBirthDate;//�������£��磺201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //����
            public NET_DVR_AREAINFOCFG struNativePlace;//�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber; //֤����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_HUMANATTRIBUTE_COND
        {
            public byte bySex; //�Ա�0-�����ã�1-�У�2-Ů
            public byte byCertificateType; //֤�����ͣ�0-�����ã�1-���֤��2-����֤
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStartBirthDate; //��ʼ�������£��磺201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_BIRTHDATE_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byEndBirthDate; //��ֹ�������£���201106
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byName; //����
            public NET_DVR_AREAINFOCFG struNativePlace; //�������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byCertificateNumber;  //֤����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO
        {
            public uint dwSize;//�ṹ��С
            public uint dwRegisterID;//����ע��ID�ţ�ֻ����
            public uint dwGroupNo;//�����
            public byte byType;//�ڰ�������־��0-ȫ����1-��������2-������
            public byte byLevel;//�������ȼ���0-ȫ����1-�ͣ�2-�У�3-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute;//��Ա��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byRemark;//��ע��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;//����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PARA
        {
            public uint dwSize;   //�ṹ��С
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //��������������
            public uint dwRegisterPicNum;  //������ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struRegisterPic;  //������ͼƬ��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_COND
        {
            public Int32 lChannel; //ͨ����
            public uint dwGroupNo; //�����
            public byte byType; //�ڰ�������־��0-ȫ����1-��������2-������
            public byte byLevel; //�������ȼ���0-ȫ����1-�ͣ�2-�У�3-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;  //����
            public NET_VCA_HUMAN_ATTRIBUTE struAttribute; //��Ա��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_PIC
        {
            public uint dwSize;   //�ṹ��С
            public uint dwFacePicNum;  //����ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_HUMAN_PICTURE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PICMODEL_RESULT[] struBlackListPic;  //������Ƭ��Ϣ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND
        {
            public Int32 lChannel;//ͨ����
            public NET_DVR_TIME struStartTime;//��ʼʱ��
            public NET_DVR_TIME struStopTime;//����ʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        public const int MAX_FACE_PIC_LEN = 6144;   //�������ͼƬ���ݳ���
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SUB_SNAPPIC_DATA
        {
            public uint dwFacePicID; //����ͼID
            public uint dwFacePicLen;  //����ͼ���ݳ���
            public NET_DVR_TIME struSnapTime;  //ץ��ʱ��
            public uint dwSimilarity; //���ƶ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_FACE_PIC_LEN)]
            public string sPicBuf;  //ͼƬ����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_ADVANCE_FIND
        {
            public uint dwFacePicID; //����ͼƬID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_NORMAL_FIND
        {
            public uint dwImageID; //��ͼID
            public uint dwFaceScore;  //��������
            public NET_VCA_RECT struVcaRect; //������ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_VCA_FIND_SNAPPIC_UNION
        {
            //�������СΪ44�ֽ�
            [FieldOffsetAttribute(0)]
            public NET_VCA_NORMAL_FIND  struNormalFind; //��ͨ����
            [FieldOffsetAttribute(0)]
            public NET_VCA_ADVANCE_FIND struAdvanceFind; //�߼�����
        }

        public enum VCA_FIND_SNAPPIC_TYPE
        {
            VCA_NORMAL_FIND  = 0x00000000,   //��ͨ����
	        VCA_ADVANCE_FIND  = 0x00000001  //�߼�����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FIND_PICTURECOND_ADVANCE
        {
            public Int32 lChannel;//ͨ����
            public NET_DVR_TIME struStartTime;//��ʼʱ��
            public NET_DVR_TIME struStopTime;//����ʱ��
            public byte byThreshold;  //��ֵ��0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 23, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
            public VCA_FIND_SNAPPIC_TYPE dwFindType;//�������ͣ����VCA_FIND_SNAPPIC_TYPE
            public NET_VCA_FIND_SNAPPIC_UNION uFindParam; //��������
        }

        //����ץ����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM
        {
            public uint dwRelativeTime;
            public uint dwAbsTime;
            public uint dwSnapFacePicID;
            public uint dwSnapFacePicLen;
            public NET_VCA_DEV_INFO struDevInfo;//����ץ���ϴ���Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
            public IntPtr pBuffer1;//ָ��ͼƬ��ָ��
        }
        //������������Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;
            public uint dwBlackListPicLen;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
            public IntPtr pBuffer1;//ָ��ͼƬ��ָ��
        }

        //�������ȶԽ�������ϴ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM
        {
            public uint dwSize;
            public float fSimilarity;//���ƶȣ�ȡֵ��Χ��[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM struSnapInfo;//����ץ���ϴ���Ϣ
            public NET_VCA_BLACKLIST_INFO_ALARM struBlackListInfo;//������������Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }   
   
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_INFO_ALARM_LOG
        {
            public NET_VCA_BLACKLIST_INFO struBlackListInfo; //������������Ϣ
            public uint dwBlackListPicID;       //������������ͼID�����ڲ���ͼƬ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_INFO_ALARM_LOG
        {
            public uint dwRelativeTime;     // ���ʱ��
            public uint dwAbsTime;			// ����ʱ��
            public uint dwSnapFacePicID;       //ץ������ͼID
            public NET_VCA_DEV_INFO struDevInfo;		//ǰ���豸��Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACESNAP_MATCH_ALARM_LOG
        {
            public uint dwSize;     		// �ṹ��С
            public float fSimilarity; //���ƶȣ�[0.001,1]
            public NET_VCA_FACESNAP_INFO_ALARM_LOG  struSnapInfoLog; //ץ����Ϣ
            public NET_VCA_BLACKLIST_INFO_ALARM_LOG struBlackListInfoLog; //��������Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICCOND
        {
            public uint dwSize;     		// �ṹ��С
            public uint dwSnapFaceID; //ץ��������ͼID
            public uint dwBlackListID; //ƥ��ĺ�����ID
            public uint dwBlackListFaceID; //�ȶԵĺ�����������ͼID
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              // �����ֽ�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_FACEMATCH_PICTURE
        {
            public uint dwSize;     		// �ṹ��С
            public uint dwSnapFaceLen; //ץ��������ͼ����
            public uint dwBlackListFaceLen; //�ȶԵĺ�����������ͼ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;              //�����ֽ�
            public IntPtr pSnapFace;  //ץ��������ͼ��ͼƬ����
            public IntPtr pBlackListFace;  //�ȶԵĺ�����������ͼ����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_BLACKLIST_FASTREGISTER_PARA
        {
            public uint dwSize;   //�ṹ��С
            public NET_VCA_BLACKLIST_INFO struBlackListInfo;  //��������������
            public uint dwImageLen;  //ͼ�����ݳ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 124, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
            public IntPtr pImage;    //ͼ������
        }

        //������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SINGLE_PATH
        {
            public byte byActive;  // �Ƿ����,0-��,1-�� 
            public byte byType;   //0-�洢ץ�ģ�1-�洢�������ȶԱ�����2-�洢ץ�ĺͺ������ȶԱ�����0xff-��Ч
            public byte bySaveAlarmPic; //�Ƿ����ڱ�������ı���ͼƬ��0-��1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1; //����
            public uint dwDiskDriver;   //�̷��ţ���0��ʼ
            public uint dwLeftSpace;   //Ԥ����������λΪG��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2; //����
        }

        //�洢·������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_SAVE_PATH_CFG
        { 
            public uint dwSize;   //�ṹ��С
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISKNUM_V30, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_SINGLE_PATH[] struPathInfo; //��������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_ACCESS_CFG
        {
            public uint   dwSize;
            public NET_DVR_IPADDR struIP;		//�����豸��IP��ַ
            public ushort wDevicePort;			 	//�˿ں�
            public byte byEnable;		         //�Ƿ����ã�0-��1-��
            public byte byRes1;				//����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	//�����豸�ĵ�¼�ʺ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	//�����豸�ĵ�¼����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        /********************************��������ʶ�� end****************************/
        //�ֱ���
        public const int NOT_AVALIABLE = 0;
        public const int SVGA_60HZ = 52505660;
        public const int SVGA_75HZ = 52505675;
        public const int XGA_60HZ = 67207228;
        public const int XGA_75HZ = 67207243;
        public const int SXGA_60HZ = 84017212;
        public const int SXGA2_60HZ = 84009020;
        public const int _720P_60HZ = 83978300;
        public const int _720P_50HZ = 83978290;
        public const int _1080I_60HZ = 394402876;
        public const int _1080I_50HZ = 394402866;
        public const int _1080P_60HZ = 125967420;
        public const int _1080P_50HZ = 125967410;
        public const int _1080P_30HZ = 125967390;
        public const int _1080P_25HZ = 125967385;
        public const int _1080P_24HZ = 125967384;
        public const int UXGA_60HZ = 105011260;
        public const int UXGA_30HZ = 105011230;
        public const int WSXGA_60HZ = 110234940;
        public const int WUXGA_60HZ = 125982780;
        public const int WUXGA_30HZ = 125982750;
        public const int WXGA_60HZ = 89227324;
        public const int SXGA_PLUS_60HZ = 91884860;

        //��ʾͨ������ָ�ģʽ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPWINDOWMODE
        {
            public byte byDispChanType;//��ʾͨ�����ͣ�0-VGA, 1-BNC, 2-HDMI, 3-DVI
            public byte byDispChanSeq;//��ʾͨ�����,��1��ʼ�����������VGA�����ʾ�ڼ���VGA
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_NUM, ArraySubType = UnmanagedType.I1)]
            public byte[] byDispMode;
        }

        //��ʾͨ����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPINFO
        {
            public byte byChanNums;//ͨ������
            public byte byStartChan;//��ʼͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SUPPORT_RES, ArraySubType = UnmanagedType.U1)]
            public uint[] dwSupportResolution;//֧�ֵķֱ���
        }

        //����ƴ����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINFO
        {
            public byte bySupportBigScreenNums;//������ƴ������
            public byte byStartBigScreenNum;//����ƴ����ʼ��
            public byte byMaxScreenX;//����ƴ��ģʽ
            public byte byMaxScreenY;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_ABILITY_V41
        {
            public uint dwSize;
            public byte byDspNums;//DSP����  
            public byte byDecChanNums;//����ͨ����
            public byte byStartChan;//��ʼ����ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;

            public NET_DVR_DISPINFO struVgaInfo;//VGA��ʾͨ����Ϣ
            public NET_DVR_DISPINFO struBncInfo;//BNC��ʾͨ����Ϣ
            public NET_DVR_DISPINFO struHdmiInfo;//HDMI��ʾͨ����Ϣ
            public NET_DVR_DISPINFO struDviInfo;//DVI��ʾͨ����Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISPWINDOWMODE[] struDispMode;
            public NET_DVR_SCREENINFO struBigScreenInfo;
            public byte bySupportAutoReboot; //�Ƿ�֧���Զ�������0-��֧�֣�1-֧��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 119, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        public const int MAX_WINDOWS = 16;//��󴰿���
        public const int MAX_WINDOWS_V41 = 36;
        
        public const int STARTDISPCHAN_VGA = 1;
        public const int STARTDISPCHAN_BNC = 9;
        public const int STARTDISPCHAN_HDMI	= 25;
        public const int STARTDISPCHAN_DVI = 29;

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_VIDEO_PLATFORM
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [FieldOffsetAttribute(0)]
            public VideoPlatform struVideoPlatform;
            [FieldOffsetAttribute(0)]
            public NotVideoPlatform struNotVideoPlatform;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public NET_DVR_RECTCFG struPosition; //��ʾͨ���ڵ���ǽ��λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NotVideoPlatform
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 160, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*��ʾͨ�����ýṹ��*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_VOUTCFG
        {
            public uint dwSize;
            public byte byAudio;			/*��Ƶ�Ƿ���*/
            public byte byAudioWindowIdx;      /*��Ƶ�����Ӵ���*/
            public byte byDispChanType;      /*��ʾͨ�����ͣ�0-BNC��1-VGA��2-HDMI��3-DVI��4-YPbPr(���뿨������DECODER_SERVERר��)*/
            public byte byVedioFormat;         /*1:NTSC,2:PAL��0-NULL*/
            public uint dwResolution;//�ֱ���
            public uint dwWindowMode;		/*����ģʽ����������ȡ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��,�豸֧�ֽ�����Դ�Զ�����ʱ�˲����������*/
            public byte byEnlargeStatus;          /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
            public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�
            public byte byScale; /*��ʾģʽ��0---��ʵ��ʾ��1---������ʾ( ���BNC )*/
            public byte byUnionType;/*���ֹ�����,0-��Ƶ�ۺ�ƽ̨�ڲ���������ʾͨ�����ã�1-������������ʾͨ������*/
            public NET_DVR_VIDEO_PLATFORM struDiff;
            public uint dwDispChanNum; //��ʾ����ţ��˲�����ȫ����ȡʱ��Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        } 

        /*�������豸״̬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISP_CHAN_STATUS_V41
        {
            public byte byDispStatus;      /*��ʾ״̬��0��δ��ʾ��1��������ʾ*/
            public byte byBVGA;              /*0-BNC��1-VGA�� 2-HDMI��3-DVI��0xff-��Ч*/
            public byte byVideoFormat;     /*��Ƶ��ʽ��1:NTSC,2:PAL,0-NON*/
            public byte byWindowMode;       /*����ģʽ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;   /*�����ӻ�������Ľ���ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byFpsDisp;        /*ÿ���ӻ������ʾ֡��*/
            public byte byScreenMode;		/*��Ļģʽ0-��ͨ 1-����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDispChan; /*��ȡȫ����ʾͨ��״̬ʱ��Ч������ʱ����0*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        }

        /*�������豸״̬*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODER_WORK_STATUS_V41
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_MATRIX_CHAN_STATUS[] struDecChanStatus;     /*����ͨ��״̬*/
	        /*��ʾͨ��״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DISPNUM_V41, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_DISP_CHAN_STATUS_V41[] struDispChanStatus;     
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmInStatus;         /*��������״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byAlarmOutStatus;       /*�������״̬*/
            public byte byAudioInChanStatus;          /*�����Խ�״̬*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************�ļ��ط�-Զ�̻ط�����*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_DEC_REMOTE_PLAY_V41
        {
            public uint dwSize;
            public NET_DVR_IPADDR	struIP;		/* DVR IP��ַ */	
            public ushort wDVRPort;			/* �˿ں� */	
            public byte byChannel;			/* ͨ���� */
            public byte byReserve;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;		/* �û��� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;		/* ���� */
            public uint dwPlayMode;   	/* 0�����ļ� 1����ʱ��*/        	
            public NET_DVR_TIME StartTime;
            public NET_DVR_TIME StopTime;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string sFileName;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;		/*����*/
        }

        public const int MAX_BIGSCREENNUM_SCENE = 100;

        //��ʾͨ�����ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECTCFG_SCENE
        {
            public ushort wXCoordinate; /*�������Ͻ���ʼ��X����*/
            public ushort wYCoordinate; /*�������Ͻ�Y����*/
            public ushort wWidth;       /*���ο��*/
            public ushort wHeight;      /*���θ߶�*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCENEDISPCFG
        {
            public byte byEnable;//�Ƿ����ã�0-�����ã�1-����
            public byte bySoltNum;//��λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byDispChanNum;
            public byte byAudio;				/*��Ƶ�Ƿ���,0-��1-��*/
            public byte byAudioWindowIdx;      /*��Ƶ�����Ӵ���*/
            public byte byVedioFormat;          /*1:NTSC,2:PAL��0-NULL*/
            public byte byWindowMode;			/*����ģʽ������������ȡ*/
            public byte byEnlargeStatus;         /*�Ƿ��ڷŴ�״̬��0�����Ŵ�1���Ŵ�*/
            public byte byEnlargeSubWindowIndex;//�Ŵ���Ӵ��ں�    
            public byte byScale; /*��ʾģʽ��0-��ʵ��ʾ��1-������ʾ( ���BNC )*/
            public uint dwResolution;//�ֱ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecChan;/*�����Ӵ��ڹ����Ľ���ͨ��*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byJoinDecoderId;/*��λ��*/
            //��ʾ����������Ƶ�ֱ��ʣ�1-D1,2-720P,3-1080P���豸����Ҫ���ݴ�//�ֱ��ʽ��н���ͨ���ķ��䣬��1�������ó�1080P�����豸���4������ͨ����������˽���ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WINDOWS_V41, ArraySubType = UnmanagedType.I1)]
            public byte[] byDecResolution;
            public byte byRow;//�������ڵ��е����
            public byte byColumn;//�������ڵ��е����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public NET_DVR_RECTCFG struDisp; //����ǽ��ʾλ��
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEV_CHAN_INFO_SCENE
        {
            public NET_DVR_IPADDR struIP;				/* DVR IP��ַ */
            public ushort wDVRPort;			 	/* �˿ں� */
            public byte byChannel;		/* ͨ���ţ�����9000���豸��IPC���룬ͨ���Ŵ�33��ʼ */
            public byte byTransProtocol;		/* ����Э������0-TCP��1-UDP ��2-MCAST��3-RTP*/
            public byte byTransMode;			/* ��������ģʽ 0�������� 1��������*/
            public byte byFactoryType;				/*ǰ���豸��������*/
            public byte byDeviceType;			//�豸���ͣ�1-IPC��2- ENCODER
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/* ���������½�ʺ� */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword;	/* ����������� */
        }

        /*��ý���������������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE
        {
            public byte byValid;			/*�Ƿ�������ý�������ȡ��,0��ʾ��Ч*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_IPADDR struDevIP;	/*��ý���������ַ*/
            public ushort wDevPort;			/*��ý��������˿�*/
            public byte byTransmitType;		/*����Э������0-TCP��1-UDP */
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PU_STREAM_CFG_SCENE
        {
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE	streamMediaServerCfg;
            public NET_DVR_DEV_CHAN_INFO_SCENE				struDevChanInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYC_SUR_CHAN_ELE_SCENE
        {
            public byte byEnable;	/* �Ƿ����� 0���� 1������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_STREAM_MEDIA_SERVER_CFG_SCENE	struStreamMediaSvrCfg;	
            public NET_DVR_DEV_CHAN_INFO_SCENE			struDecChanInfo;	/*��Ѳ����ͨ����Ϣ*/
        }

        //��Ѳ����ṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_LOOP_DECINFO_SCENE
        {
            public ushort wPoolTime;		/*��ѯ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CYCLE_CHAN, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYC_SUR_CHAN_ELE_SCENE[] struChanArray;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //��������ͨ�����ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DECODECHANCFG_SCENE
        {
            public byte byDecodeEnable;//������ͣ��־��0-ֹͣ��1-���ö�̬���룬2-������Ѳ����
            public byte bySlotNum;//��λ��
            public byte byDecChan;
            public byte byJointAllDecodeChan;		//�Ƿ�������ܽ���ͨ�� 0-��������1-����
            public byte byJointSlotNum;			//�����Ĳ�λ�ţ����ܽ����Ĳ�λ�ţ�
            public byte byJointChanNum;		//������ͨ���ţ����ܽ����ͨ���ţ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public STRUDECCFG struDecCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct STRUDECCFG
        {
            //[FieldOffsetAttribute(0)]
            //[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5480, ArraySubType = UnmanagedType.I1)]
            //public byte[] byRes;
            [FieldOffsetAttribute(0)]
            public NET_DVR_PU_STREAM_CFG_SCENE struSceneDynamicDecCfg;
            [FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_LOOP_DECINFO_SCENE struSceneCycDecCfg;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENCFG_SCENE
        {
            public byte byAllValid; /*����ʹ�ܱ�־ */
            public byte byAssociateBaseMap;//�����ĵ�ͼ��ţ�0��������
            public byte byEnableSpartan;//��������ʹ�ܣ�1-����0-��
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYERNUMS, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_WINCFG[] struWinCfg;
            public NET_DVR_BIGSCREENCFG struBigScreen;

            public void Init()
            {
                struBigScreen = new NET_DVR_BIGSCREENCFG();
                struWinCfg = new NET_DVR_WINCFG[MAX_LAYERNUMS];
            }
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_SCENECFG
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSceneName;
            public byte byBigScreenNums;//�����ĸ��������ֵͨ����������ȡ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public ushort wDecChanNums;//�����н���ͨ���ĸ���
            public ushort wDispChanNums;//��������ʾͨ���ĸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
            public IntPtr pBigScreenBuffer;//�������û�����, byBigScreenNums��sizeof(NET_DVR_BIGSCREENCFG_SCENE)
            public IntPtr pDecChanBuffer;//����ͨ�����û�����, wDecChanNums��sizeof(NET_DVR_DECODECHANCFG_SCENE)
            public IntPtr pDispChanBuffer;//��ʾͨ�����û�����, wDispChanNums��sizeof(NET_DVR_SCENEDISPCFG)
            public void Init()
            {
                sSceneName = new byte[NAME_LEN];
                byRes1 = new byte[3];
                byRes1 = new byte[12];
            }
        }
        public const int NET_DVR_GET_ALLWINCFG = 1503; //���ڲ�����ȡ

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BIGSCREENASSOCIATECFG
        {
            public uint dwSize;
            public byte byEnableBaseMap;//ʹ�ܵ�ͼ��ʾ
            public byte byAssociateBaseMap;//�����ĵ�ͼ��ţ�0��������
            public byte byEnableSpartan;//��������ʹ�ܣ�1-����0-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 21, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        /*******************************��������*******************************/
        public const int MAX_WIN_COUNT = 224; //֧�ֵ���󿪴���

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_WINCFG{
            public uint dwSize;
            public byte byVaild;
            public byte byInputType;		//��CAM_MDOE
            public ushort wInputIdx;			/*����Դ����*/
            public uint dwLayerIdx;			/*ͼ�㣬0Ϊ��ײ�*/
            public NET_DVR_RECTCFG struWin;	//Ŀ�Ĵ���(�����ʾǽ)
            public byte byWndIndex;			//���ں�
            public byte byCBD;				//0-�ޣ�1-��������2-��������
            public byte bySubWnd;			//0���ǣ�1��
            public byte byRes1;
            public uint dwDeviceIndex;//�豸���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_WINLIST
        {
            public uint dwSize;
            public ushort wScreenSeq;	//�豸���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwWinNum;	//�豸���صĴ�������
            public IntPtr pBuffer;	//������Ϣ�����������Ϊ224*sizeof(NET_DVR_WINCFG)
            public uint dwBufLen;	//������ָ�볤��
        }

        public const int MAX_LAYOUT_COUNT = 16;		//��󲼾���

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUTCFG
        {
            public uint dwSize;
            public byte byValid;								//�����Ƿ���Ч
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byLayoutName;			//��������			
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_WIN_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCREEN_WINCFG[] struWinCfg;	//�����ڴ��ڲ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LAYOUT_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_LAYOUT_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_LAYOUTCFG[] struLayoutInfo;   //���в���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int MAX_CAM_COUNT = 224;

        public enum NET_DVR_CAM_MODE
        {
	        NET_DVR_UNKNOW  = 0,//��Ч
	        NET_DVR_CAM_BNC,
	        NET_DVR_CAM_VGA,
	        NET_DVR_CAM_DVI,
	        NET_DVR_CAM_HDMI,
	        NET_DVR_CAM_IP,
	        NET_DVR_CAM_RGB,
            NET_DVR_CAM_DECODER,
	        NET_DVR_CAM_MATRIX,
	        NET_DVR_CAM_YPBPR,
	        NET_DVR_CAM_USB,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAMCFG
        {
            public uint dwSize ;
            public byte byValid ;
            public byte byCamMode;						//�ź�����Դ���ͣ���NET_DVR_CAM_MODE
            public ushort wInputNo;						//�ź�Դ���0-224
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sCamName;			//�ź�����Դ����
            public NET_DVR_VIDEOEFFECT struVideoEffect;	//��Ƶ����
            public NET_DVR_PU_STREAM_CFG struPuStream;	//ip����ʱʹ��
            public ushort wBoardNum ;						//�ź�Դ���ڵİ忨��
            public ushort wInputIdxOnBoard;				//�ź�Դ�ڰ忨�ϵ�λ��
            public ushort wResolutionX;					//�ֱ���
            public ushort wResolutionY;
            public byte byVideoFormat;					//��Ƶ��ʽ��0-�ޣ�1-NTSC��2-PAL
            public byte byNetSignalResolution;	//; 1-CIF 2-4CIF 3-720P 4-1080P 5-500wp �������ź�Դ�ķֱ��ʣ�����������ź�Դʱ�����豸���豸��������ֱ��������������Դ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sGroupName;	//�����ź�Դ���� ����
            public byte byJointMatrix;			//  �������� ��0-������  1-����
            public byte byRes;  
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTREAM_LIST
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CAM_COUNT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_INPUTSTREAMCFG[] struInputStreamInfo; //�����ź�Դ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************�����������*******************************/
        /*���ͨ������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTPARAM
        {
            public uint  dwSize;
            public byte byMonMode;		/*�������ģʽ,1-BNC,2-VGA,3-DVI,4-HDMI*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint  dwResolution;	/*�ֱ��ʣ�������������ȡ��֧�ֵĽ�������*/
            public NET_DVR_VIDEOEFFECT  struVideoEffect;	/*���ͨ����Ƶ��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OUTPUTCFG
        {
            public uint dwSize;
            public byte byScreenLayX;						//��������-������
            public byte byScreenLayY;						//��������-������
            public ushort wOutputChanNum;					//���ͨ��������0��ʾ�豸֧�ֵ�������ͨ������������������������ȡ������ֵ��ʾʵ�����ͨ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_OUTPUTPARAM struOutputParam;	/*���ͨ����Ƶ��������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sWallName;					//����ǽ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************������*******************************/
        public const int SCREEN_PROTOCOL_NUM = 20;   //֧�ֵ�������������Э����
        
        //����������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENSERVER_ABILITY
        {
            public uint dwSize;   			/*�ṹ����*/
            public byte byIsSupportScreenNum; /*��֧�ִ�������������Ŀ*/
            public byte bySerialNums;			//���ڸ���
            public byte byMaxInputNums;
            public byte byMaxLayoutNums;
            public byte byMaxWinNums;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 19, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byMaxScreenLayX;//��������-�������������
            public byte byMaxScreenLayY;//��������-��������������
            public ushort wMatrixProtoNum; /*��Ч�Ĵ���Э����Ŀ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SCREEN_PROTOCOL_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PROTO_TYPE[] struScreenProto;/*���Э���б�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //����������������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENCONTROL_ABILITY
        {
            public uint dwSize;   		/*�ṹ����*/
            public byte byLayoutNum; 		/* ���ָ���*/
            public byte byWinNum; 			/*��Ļ���ڸ���*/
            public byte byOsdNum;  		/*OSD����*/
            public byte byLogoNum; 		/*Logo����*/
            public byte byInputStreamNum;  //����Դ���� ---�豸֧���������ͨ��������������������Դ����������Դ��
            public byte byOutputChanNum;	//���ͨ������---�豸֧��������ͨ������
            public byte byCamGroupNum;		/*�������*/
            public byte byPlanNum;    		/*Ԥ������*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public byte byIsSupportPlayBack;  /*�Ƿ�֧�ֻط�*/	
            public byte byMatrixInputNum;  //֧���������������
            public byte byMatrixOutputNum; //֧���������������
            public NET_DVR_DISPINFO struVgaInfo;//VGA�����Ϣ
            public NET_DVR_DISPINFO struBncInfo;//BNC�����Ϣ
            public NET_DVR_DISPINFO struHdmiInfo;//HDMI�����Ϣ
            public NET_DVR_DISPINFO struDviInfo;//DVI�����Ϣ
            public byte byMaxUserNums;//֧���û���
            public byte byPicSpan;		//��ͼ��ȣ�һ�ŵ�ͼ���ɸ��ǵ���Ļ��
            public ushort wDVCSDevNum;	//�ֲ�ʽ��������������豸��
            public ushort wNetSignalNum;	//�����������Դ����
            public ushort wBaseCoordinateX;//��׼����
            public ushort wBaseCoordinateY; 
            public byte byExternalMatrixNum;	//�����Ӿ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 49, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************�����ź�״̬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGINPUTSTATUS
        {
            public uint dwLostFrame;		/*��Ƶ���붪֡��*/
            public byte byHaveSignal;		/*�Ƿ�����Ƶ�ź�����*/
            public byte byVideoFormat;		/*��Ƶ��ʽ��1��NTSC,2��PAL,0����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 46, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        } 

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_INPUTSTATUS_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_MATRIX_CHAN_STATUS struIpInputStatus;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGINPUTSTATUS struAnalogInputStatus;
        }
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUTSTATUS
        {
            public ushort wInputNo;		/*�ź�Դ���*/
            public byte byInputType;	//��NET_DVR_CAM_MODE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_INPUTSTATUS_UNION struStatusUnion;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENINPUTSTATUS
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public uint dwNums;		//�豸���ص�����Դ״̬������
            public IntPtr pBuffer;	//������
            public uint dwBufLen;	//������ָ�볤�ȣ��������
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREENALARMCFG
        {
            public uint dwSize;
            public byte byAlarmType;	//�������ͣ�1-�Ӱ�γ���2-�Ӱ���룬3-��ϵͳ״̬�쳣��4-��ϵͳ�ָ��ָ� 5-����Դ�쳣   6-�¶ȱ��� 7-FPGA�汾��ƥ�� 8-Ԥ����ʼ 9-Ԥ������ 10-�������� 11-�����IP��ַ��ͻ��12-�����쳣
            public byte byBoardType;	// 1-����� 2-����� ��3-���壬4-���壬��������Ϊ1��2��3��6��ʱ��ʹ�� 
            public byte bySubException;	//�����쳣ʱ�������쳣 1- �ֱ��������ı� 2-����˿����͸ı�3-�ֱ��ʴ���4-�ֱ��ʸı䵼�½�����Դ���㣬�رո�����Դ��Ӧ���ڡ�5-�ֱ��ʸı䣬�����ѿ��������ű�������1/8��8����Χ��6-�ֱ��ʻָ�����,7-�ֱ��ʸı䵼�����������������,�豸�رմ��� 
            public byte byRes1;
            public ushort wStartInputNum; // �쳣����Դ���쳣��㣩 
            public ushort wEndInputNum;	// �쳣����Դ���쳣�յ㣩 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	   
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_MATRIX_CFG
        {
            public byte byValid;				//�ж��Ƿ���ģ������Ƿ���Ч��
            public byte byCommandProtocol;	//ģ������ָ�4�֣�
            public byte byScreenType;			//����	
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byScreenToMatrix;	//ģ�������������Ļ�Ķ�Ӧ��ϵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DIGITALSCREEN
        {
            public NET_DVR_IPADDR  struAddress;/*�豸Ϊ�����豸ʱ��IP��Ϣ*/
            public ushort wPort;		//ͨ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ANALOGSCREEN
        {
            public byte byDevSerPortNum;   /*�����豸�Ĵ��ں�*/
            public byte byScreenSerPort;  /*���Ӵ����Ĵ��ں�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 130, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;   
            public NET_DVR_MATRIX_CFG struMatrixCfg;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_UNION
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_DIGITALSCREEN struDigitalScreen;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ANALOGSCREEN struAnalogScreen;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_SCREENINFO
        {
            public uint dwSize;
            public byte byValid;				//�Ƿ���Ч
            public byte nLinkMode;				//���ӷ�ʽ��0-���ڣ�1-����
            public byte byDeviceType;			//�豸�ͺţ���������ȡ
            public byte byScreenLayX;			//��������-������
            public byte byScreenLayY;			//��������-������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sUserName;	/*��¼�û���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PASSWD_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPassword; /*��¼����*/   
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDevName;	/*�豸����*/
            public NET_DVR_SCREEN_UNION struScreenUnion;
            public byte byInputNum;			// ����Դ����
            public byte byOutputNum;			// ���Դ����
            public byte byCBDNum;				//CBD����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 29, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************��ͼ�ϴ�*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_BASEMAP_CFG
        {	
            public byte byScreenIndex;         //��Ļ�����
            public byte byMapNum;				/*���ָ���˶��ٿ�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] res;
            public ushort wSourWidth;			/* ԭͼƬ�Ŀ�� */
            public ushort wSourHeight;			/* ԭͼƬ�ĸ߶� */
        }            

        /*******************************OSD*******************************/
        public const int MAX_OSDCHAR_NUM = 256;
        
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_OSDCFG
        {
            public uint dwSize;
            public byte byValid;    /*�Ƿ���Ч 0��Ч 1��Ч*/
            public byte byDispMode;  //��ʾģʽ��1-͸����2-��͸����3-��������ģʽ
            public byte byFontColorY; /*������ɫY,0-255*/
            public byte byFontColorU; /*������ɫU,0-255*/
            public byte byFontColorV; /*������ɫV,0-255*/
            public byte byBackColorY; /*������ɫY,0-255*/
            public byte byBackColorU; /*������ɫU,0-255*/
            public byte byBackColorV; /*������ɫV,0-255*/
            public ushort wXCoordinate;   /*OSD����Ļ���Ͻ�λ��x*/
            public ushort wYCoordinate;   /*OSD����Ļ���Ͻ�λ��y*/
            public ushort wWidth;       /*OSD���*/
            public ushort wHeight;      /*OSD�߶�*/
            public uint dwCharCnt;     /*�ַ��ĸ���*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OSDCHAR_NUM, ArraySubType = UnmanagedType.U2)]
            public ushort[] wOSDChar;       /*OSD�ַ�����*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        /*******************************��ȡ������Ϣ*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SERIAL_CONTROL
        { 
            public uint dwSize ;
            public byte bySerialNum;        // ���ڸ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] bySerial;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************��Ļ����*******************************/
        //��Ļ����Դ����
        public enum INPUT_INTERFACE_TYPE
        {
	        INTERFACE_VGA = 0,
	        INTERFACE_SVIDEO, // 2046NL��֧�֣�2046NH֧��
	        INTERFACE_YPBPR,
	        INTERFACE_DVI ,
	        INTERFACE_BNC , 
	        INTERFACE_DVI_LOOP,//(��ͨ) 2046NH��֧�֣�2046NL֧��
	        INTERFACE_BNC_LOOP, //(��ͨ) 2046NH��֧�֣�2046NL.֧��
	        INTERFACE_HDMI,
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_INTERFACE_CTRL
        {
            public byte byInputSourceType;	//��INPUT_INTERFACE_TYPE
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        
        //��ʾ��Ԫ��ɫ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_COLOR_CTRL
        {
            public byte byColorType;		//1-���� 2-�Աȶ� 3-���Ͷ� 4-������
            public char	byScale;			//-1 ��0��+1����ֵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //��ʾ��Ԫλ�ÿ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DISPLAY_POSITION_CTRL
        {
            public byte byPositionType;	//1-ˮƽλ�� 2-��ֱλ�ã�
            public char byScale;			//-1 ��0��+1����ֵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SCREEN_CONTROL_PARAM
        {
            [FieldOffsetAttribute(0)]
            public NET_DVR_INPUT_INTERFACE_CTRL struInputCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_COLOR_CTRL struDisplayCtrl;
            [FieldOffsetAttribute(0)]
            public NET_DVR_DISPLAY_POSITION_CTRL struPositionCtrl;
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL
        { 	
            public uint dwSize;			 
            public uint dwCommand ;      /* ���Ʒ��� 1-�� 2-�� 3-��Ļ����Դѡ�� 4-��ʾ��Ԫ��ɫ���� 5-��ʾ��Ԫλ�ÿ���*/
            public byte byProtocol;      //����Э������,1:LCD-S1,2:LCD-S2
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_SCREEN_CONTROL_PARAM	struControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;	
        }

        /*******************************��Ļ����V41*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SCREEN_CONTROL_V41
        { 	
            public uint dwSize;
            public byte bySerialNo;		//���ں�
            public byte byBeginAddress;	//���Ͻ���Ļ�ţ���1��ʼ
            public byte byEndAddress;	//���½���Ļ�ţ���1��ʼ
            public byte byProtocol;      	   // ����Э������  1-LCD-S1 , 2-LCD-S2 , 3-LCD-L1 �� 4-LCD-DLP�� 5-LCD-S3 , 6-LCD-H1 
            public uint dwCommand ;      /* ���Ʒ��� 1-�� 2-�� 3-��Ļ����Դѡ�� 4-��ʾ��Ԫ��ɫ���� 5-��ʾ��Ԫλ�ÿ���*/
            public NET_DVR_SCREEN_CONTROL_PARAM	struControlParam;
            public byte byWallNo;		// ����ǽ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 51, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;	
        }

        /*******************************Ԥ������*******************************/
        public const int MAX_PLAN_ACTION_NUM = 32; 	//Ԥ����������
        public const int DAYS_A_WEEK = 7;	//һ��7��
        public const int MAX_PLAN_COUNT = 16;	//Ԥ������

        public enum NET_DVR_PLAN_OPERATE_TYPE
        {
	        NET_DVR_SWITCH_LAYOUT = 1, 		// �����л� Ĭ��
	        NET_DVR_SCREEN_POWER_OFF,  		// �رմ���Ļ��ʾ
	        NET_DVR_SCREEN_POWER_ON,   		// �򿪴���Ļ��ʾ
        }

        /*Ԥ������Ϣ*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_INFO
        {
            public byte byValid;      	// �����Ƿ���Ч
            public byte byType;       	// ������NET_DVR_PLAN_OPERATE_TYPE
            public ushort wLayoutNo;  	// ���ֺ�
            public byte byScreenStyle;    //��Ļ�ͺţ����ػ����ã�1�ǵ�����2�Ǹ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwDelayTime;  	// һ���������ʱ��, ��λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CYCLE_TIME
        {
            public byte byValid; 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_TIME_EX struTime;
        }

        /*Ԥ������*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_CFG
        {
            public uint dwSize;
            public byte byValid;      	// ��Ԥ���Ƿ���Ч
            public byte byWorkMode;  	// Ԥ������ģʽ 1��ʾ�ֶ���2�Զ���3Ԥ��ѭ��
            public byte byWallNo;		//����ǽ�ţ���1��ʼ
            public byte byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlanName; //Ԥ������
            public NET_DVR_TIME_EX struTime; // ����ģʽΪ�Զ�ʱʹ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = DAYS_A_WEEK, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CYCLE_TIME[] struTimeCycle; /*ѭ��ʱ�䣬����Ϊһ�����ڣ��ꡢ�¡�������������ʹ�á��磺struTimeCycle[0]�е�byValid��ֵ��1����ʾ������ִ�и�Ԥ��������ȡֵ����Ϊ[0,6]������0���������죬1��������һ���Դ�����*/
            public uint dwWorkCount;  	// Ԥ������ִ�д�����0Ϊһֱѭ�����ţ�����ֵ��ʾ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLAN_ACTION_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_PLAN_INFO[] strPlanEntry;  // Ԥ��ִ�е�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************��ȡ�豸״̬*******************************/
        /*Ԥ���б�*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAN_LIST
        {
            public uint dwSize;
            public uint dwPlanNums;			//�豸�����ź�Դ����
            public IntPtr pBuffer;			//ָ��dwInputSignalNums��NET_DVR_PLAN_CFG�ṹ��С�Ļ�����
            public byte byWallNo;			//ǽ�ţ���1��ʼ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//�����仺�������ȣ�������������ڵ���dwInputSignalNums��NET_DVR_PLAN_CFG�ṹ��С��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************Ԥ������*******************************/
        //�ýṹ�����Ϊͨ�ÿ��ƽṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CONTROL_PARAM
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = NAME_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sDeviceID; //�����豸���豸ID
            public ushort wChan;				 //����ͨ��
            public byte byIndex;			 //������������������ȷ�������ʾʲô����
            public byte byRes1;
            public uint dwControlParam;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        /*******************************��ȡ�豸״̬*******************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICE_RUN_STATUS
        {
            public uint dwSize;
            public uint dwMemoryTotal;		//�ڴ�����	��λKbyte
            public uint dwMemoryUsage;		//�ڴ�ʹ���� ��λKbyte
            public byte byCPUUsage;			//CPUʹ���� 0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 127, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //91ϵ��HD-SDI����DVR �����Ϣ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ACCESS_CAMERA_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sCameraInfo;		// ǰ�������Ϣ
            public byte  byInterfaceType;		// ǰ�˽���ӿ����ͣ�1:VGA, 2:HDMI, 3:YPbPr 4:SDI 5:FC
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AUDIO_INPUT_PARAM
        {
            public byte byAudioInputType;  //��Ƶ�������ͣ�0-mic in��1-line in
            public byte byVolume; //volume,[0-100]
            public byte byEnableNoiseFilter; //�Ƿ�����������-�أ�-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I1)]
            public byte[] byres;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CAMERA_DEHAZE_CFG
        {
            public uint dwSize;
            public byte byDehazeMode; //0-�����ã�1-�Զ�ģʽ��2-��
            public byte byLevel; //�ȼ���0-100
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; 
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_INPUT_SIGNAL_LIST
        {
            public uint dwSize;
            public uint dwInputSignalNums;	//�豸�����ź�Դ����
            public IntPtr pBuffer;			//ָ��dwInputSignalNums��NET_DVR_INPUTSTREAMCFG�ṹ��С�Ļ�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public uint dwBufLen;			//�����仺�������ȣ�������������ڵ���dwInputSignalNums��NET_DVR_INPUTSTREAMCFG�ṹ��С��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;
        }

        //��ȫ����״̬
        public const int PULL_DISK_SUCCESS = 1;     // ��ȫ���̳ɹ�
        public const int PULL_DISK_FAIL = 2;        // ��ȫ����ʧ��
        public const int PULL_DISK_PROCESSING = 3;  // ����ֹͣ����
        public const int PULL_DISK_NO_ARRAY = 4;	// ���в����� 
        public const int PULL_DISK_NOT_SUPPORT = 5; // ��֧�ְ�ȫ����

        //ɨ������״̬
        public const int SCAN_RAID_SUC = 1; 	// ɨ�����гɹ�
        public const int SCAN_RAID_FAIL = 2; 	// ɨ������ʧ��
        public const int SCAN_RAID_PROCESSING = 3;	// ����ɨ������
        public const int SCAN_RAID_NOT_SUPPORT = 4; // ��֧������ɨ��

        //����ǰ���������״̬
        public const int SET_CAMERA_TYPE_SUCCESS = 1;  // �ɹ�
        public const int SET_CAMERA_TYPE_FAIL = 2;  // ʧ��
        public const int SET_CAMERA_TYPE_PROCESSING	= 3;   // ���ڴ���

        //9000 2.2
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN_INQUIRY
        {
            public uint dwSize;    //�ṹ���С
            public byte byType;    //0 ��������Ƶ¼��, 1ͼƬͨ��¼��, 2ANRͨ��¼��, 3��֡ͨ��¼��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_RECORD_TIME_SPAN
        {
            public uint dwSize;        //�ṹ���С
            public NET_DVR_TIME strBeginTime;  //��ʼʱ��
            public NET_DVR_TIME strEndTime;    //����ʱ��
            public byte byType;        //0 ��������Ƶ¼��, 1ͼƬͨ��¼��, 2ANRͨ��¼��, 3��֡ͨ��¼��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 35, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;     //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DRAWFRAME_DISK_QUOTA_CFG
        {
            public uint dwSize;					//�ṹ���С
            public byte byPicQuota;				//ͼƬ�ٷֱ�	 [0%,  30%]
            public byte byRecordQuota;				//��ͨ¼��ٷֱ� [20%, 40%]
            public byte byDrawFrameRecordQuota;	//��֡¼��ٷֱ� [30%, 80%]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;					//�����ֽ�
        }

        //�˿�ӳ�����ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_PORT
        {
            public ushort wEnable;
            public ushort wExtPort;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //�˿�ӳ�����ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_NAT_CFG
        {
            public uint dwSize;
            public ushort wEnableUpnp;
            public ushort wEnableNat;
            public NET_DVR_IPADDR struIpAddr;//��ʱ��ֹͣʱ��
            public NET_DVR_NAT_PORT struHttpPort;//��ʱ��ֹͣʱ��
            public NET_DVR_NAT_PORT struCmdPort;//��ʱ��ֹͣʱ��
            public NET_DVR_NAT_PORT struRtspPort;//��ʱ��ֹͣʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byFriendName;
            public byte byNatType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            public NET_DVR_NAT_PORT struHttpsPort;//��ʱ��ֹͣʱ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 76, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //Upnp�˿�ӳ��״̬�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_PORT_STATE
        {
            public uint dwEnabled;//�ö˿��Ƿ�ʹ��ӳ��
            public ushort wInternalPort;//ӳ��ǰ�Ķ˿�
            public ushort wExternalPort;//ӳ���Ķ˿�
            public uint dwStatus;//�˿�ӳ��״̬��0- δ��Ч��1- δ��Ч��ӳ��Դ�˿���Ŀ�Ķ˿���һ�£�2- δ��Ч��ӳ��˿ں��ѱ�ʹ�ã�3- ��Ч
            public NET_DVR_IPADDR struNatExternalIp;//ӳ�����ⲿ��ַ
            public NET_DVR_IPADDR struNatInternalIp;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        //Upnp�˿�ӳ��״̬�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_UPNP_NAT_STATE
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_UPNP_PORT_STATE[] strUpnpPort;//�˿�ӳ��״̬:������0- web server�˿ڣ�����1- ����˿ڣ�����2- rtsp��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLAYCOND
        {
            public uint dwChannel;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame;  //0:����֡��1����֡
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //����
        }

        //¼��طŽṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_VOD_PARA
        {
            public uint dwSize; //�ṹ���С
            public NET_DVR_STREAM_INFO struIDInfo; //��ID��Ϣ
            public NET_DVR_TIME struBeginTime;//�طſ�ʼʱ��
            public NET_DVR_TIME struEndTime;//�طŽ���ʱ��
            public IntPtr hWnd;//�طŴ���
            public byte byDrawFrame;//�Ƿ��֡��0- ����֡��1- ��֡
            public byte byVolumeType;//0-��ͨ¼���1-�浵��������CVR�豸����ͨ������ͨ��¼�񣬴浵�����ڱ���¼��
            public byte byVolumeNum;//�浵��� 
            public byte byRes1;//����
            public uint dwFileIndex;//�浵���ϵ�¼���ļ������������浵��¼��ʱ���ص�ֵ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_ATMFINDINFO
        {
            public byte byTransactionType;       //�������� 0-ȫ����1-��ѯ�� 2-ȡ� 3-�� 4-�޸����룬5-ת�ˣ� 6-�޿���ѯ 7-�޿��� 8-�̳� 9-�̿� 10-�Զ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;    //����
            public uint dwTransationAmount ;     //���׽�� ;
        }

        [StructLayoutAttribute(LayoutKind.Explicit)]
        public struct NET_DVR_SPECIAL_FINDINFO_UNION
        {
            [FieldOffsetAttribute(0)]
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byLenth ;
            [FieldOffsetAttribute(0)]
            public NET_DVR_ATMFINDINFO struATMFindInfo;	       //ATM��ѯ
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND_V40
        {
            public Int32 lChannel;
            public uint dwFileType;
            public uint dwIsLocked;
            public uint dwUseCardNo;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = CARDNUM_LEN_OUT, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public byte byDrawFrame; //0:����֡��1����֡
            public byte byFindType; //0:��ѯ��ͨ��1����ѯ�浵��
            public byte byQuickSearch; //0:��ͨ��ѯ��1�����٣���������ѯ
            public byte bySpecialFindInfoType ;    //ר�в�ѯ�������� 0-��Ч�� 1-��ATM��ѯ����  
            public uint dwVolumeNum;  //�浵���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = GUID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byWorkingDeviceGUID;    //������GUID��ͨ����ȡN+1�õ�
            public NET_DVR_SPECIAL_FINDINFO_UNION uSpecialFindInfo ;   //ר�в�ѯ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;    //����
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_AES_KEY_INFO
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] sAESKey;  /*����������Կ*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;  /*�����ֽ�*/
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_POE_CFG
        {
            public NET_DVR_IPADDR struIP;     //IP��ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes; //����
        }

        public const int MAX_PRO_PATH = 256; //���Э��·������

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CUSTOM_PROTOCAL
        {
            public uint dwSize;              //�ṹ���С
            public uint dwEnabled;           //�Ƿ����ø�Э��0 ������ 1 ����
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = DESC_LEN)]
            public string sProtocalName;   //�Զ���Э������, 16λ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;          //����,����Э��������չ
            public uint dwEnableSubStream;   //�������Ƿ�����0 ������ 1 ����	
            public byte byMainProType;        //������Э������ 1 RTSP
            public byte byMainTransType;		//�������������� 0��Auto 1��udp 2��rtp over rtsp
            public ushort wMainPort;           //�������˿�	
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sMainPath;  //������·��	
            public byte bySubProType;         //������Э������ 1 RTSP
            public byte bySubTransType;		//�������������� 0��Auto 1��udp 2��rtp over rtsp
            public ushort wSubPort;   //�������˿�
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_PRO_PATH)]
            public string sSubPath;   //������·�� 	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 200, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes2;          //����
        }
     
        //Ԥ��V40�ӿ�
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PREVIEWINFO
        {
            public Int32 lChannel;//ͨ����
            public uint dwStreamType;	// �������ͣ�0-��������1-��������2-����3��3-����4 ���Դ�����
            public uint dwLinkMode;// 0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-RTP/RTSP,5-RSTP/HTTP 
            public IntPtr hPlayWnd;//���Ŵ��ڵľ��,ΪNULL��ʾ������ͼ��
            public bool bBlocked;  //0-������ȡ��, 1-����ȡ��, �������SDK�ڲ�connectʧ�ܽ�����5s�ĳ�ʱ���ܹ�����,���ʺ�����ѯȡ������.
            public bool bPassbackRecord; //0-������¼��ش�,1����¼��ش�
            public byte byPreviewMode;//Ԥ��ģʽ��0-����Ԥ����1-�ӳ�Ԥ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = STREAM_ID_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byStreamID;//��ID��lChannelΪ0xffffffffʱ���ô˲���
            public byte byProtoType; //Ӧ�ò�ȡ��Э�飬0-˽��Э�飬1-RTSPЭ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 222, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        ///ץ�Ļ�
        ///
        public const int MAX_OVERLAP_ITEM_NUM = 50;       //����ַ���������
        public const int NET_ITS_GET_OVERLAP_CFG = 5072;//��ȡ�ַ����Ӳ������ã������ITS�նˣ�
        public const int NET_ITS_SET_OVERLAP_CFG = 5073;//�����ַ����Ӳ������ã������ITS�նˣ�

        //�ַ������������������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAPCFG_COND
        {
            public uint dwSize;
            public uint dwChannel;//ͨ���� 
            public uint dwConfigMode;//����ģʽ��0- �նˣ�1- ǰ��(ֱ��ǰ�˻��ն˽�ǰ��)
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        //�����ַ�������Ϣ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_SINGLE_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����
            public byte byItemType;//����
            public byte byChangeLineNum;//�������Ļ�������ȡֵ��Χ��[0,10]��Ĭ�ϣ�0 
            public byte bySpaceNum;//�������Ŀո�����ȡֵ��Χ��[0-255]��Ĭ�ϣ�0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        //�ַ����������ýṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_ITEM_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_OVERLAP_ITEM_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_ITS_OVERLAP_SINGLE_ITEM_PARAM[] struSingleItem;//�ַ���������Ϣ
            public uint dwLinePercent;
            public uint dwItemsStlye;
            public ushort wStartPosTop;
            public ushort wStartPosLeft;
            public ushort wCharStyle;
            public ushort wCharSize;
            public ushort wCharInterval;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//����
            public uint dwForeClorRGB;//ǰ��ɫ��RGBֵ��bit0~bit7: B��bit8~bit15: G��bit16~bit23: R��Ĭ�ϣ�x00FFFFFF-��
            public uint dwBackClorRGB;//����ɫ��RGBֵ��ֻ��ͼƬ�������Ч��bit0~bit7: B��bit8~bit15: G��bit16~bit23: R��Ĭ�ϣ�x00000000-�� 
            public byte byColorAdapt;//��ɫ�Ƿ�����Ӧ��0-��1-��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����
        }

        //�ַ�����������Ϣ�ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_INFO_PARAM
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I1)]
            public byte[] bySite;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRoadNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byInstrumentNum;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirection;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byDirectionDesc;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byLaneDes;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//���ﱣ����Ƶ��ѹ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 44, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite1;//
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byMonitoringSite2;//���ﱣ����Ƶ��ѹ������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//���ﱣ����Ƶ��ѹ������ 
        }

        //�ַ������������������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_ITS_OVERLAP_CFG
        {
            public uint dwSize;
            public byte byEnable;//�Ƿ����ã�0- �����ã�1- ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;//���ﱣ����Ƶ��ѹ������
            public NET_ITS_OVERLAP_ITEM_PARAM struOverLapItem;//�ַ�������
            public NET_ITS_OVERLAP_INFO_PARAM struOverLapInfo;//�ַ���������Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//���ﱣ����Ƶ��ѹ������ 
        }

        //�������������ṹ��
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_SETUPALARM_PARAM
        {
            public uint dwSize;
            public byte byLevel;//�������ȼ���0- һ�ȼ����ߣ���1- ���ȼ����У���2- ���ȼ����ͣ�������
            public byte byAlarmInfoType;//�ϴ�������Ϣ���ͣ����ܽ�ͨ�����֧�֣���0- �ϱ�����Ϣ��NET_DVR_PLATE_RESULT����1- �±�����Ϣ(NET_ITS_PLATE_RESULT) 
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//���ﱣ����Ƶ��ѹ������ 
        }           
        /********************************�ӿڲ����ṹ(end)*********************************/


        /********************************SDK�ӿں�������*********************************/

        /*********************************************************
        Function:	NET_DVR_Init
        Desc:		��ʼ��SDK����������SDK������ǰ�ᡣ
        Input:	
        Output:	
        Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ�ܡ�
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();

        /*********************************************************
        Function:	NET_DVR_Cleanup
        Desc:		�ͷ�SDK��Դ���ڽ���֮ǰ������
        Input:	
        Output:	
        Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ��
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessage(uint nMessage, IntPtr hWnd);

        /*********************************************************
        Function:	EXCEPYIONCALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void EXCEPYIONCALLBACK(uint dwType, int lUserID, int lHandle, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetExceptionCallBack_V30(uint nMessage, IntPtr hWnd, EXCEPYIONCALLBACK fExceptionCallBack, IntPtr pUser);


        /*********************************************************
        Function:	MESSCALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACK(int lCommand, string sDVRIP, string pBuf, uint dwBufLen);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack(MESSCALLBACK fMessCallBack);

        /*********************************************************
        Function:	MESSCALLBACKEX
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKEX(int iCommand, int iUserID, string pBuf, uint dwBufLen);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_EX(MESSCALLBACKEX fMessCallBack_EX);

        /*********************************************************
        Function:	MESSCALLBACKNEW
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSCALLBACKNEW(int lCommand, string sDVRIP, string pBuf, uint dwBufLen, ushort dwLinkDVRPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessCallBack_NEW(MESSCALLBACKNEW fMessCallBack_NEW);

        /*********************************************************
        Function:	MESSAGECALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate int MESSAGECALLBACK(int lCommand, System.IntPtr sDVRIP, System.IntPtr pBuf, uint dwBufLen, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack(MESSAGECALLBACK fMessageCallBack, uint dwUser);


        /*********************************************************
        Function:	MSGCallBack
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void MSGCallBack(int lCommand, ref NET_DVR_ALARMER pAlarmer, IntPtr pAlarmInfo, uint dwBufLen, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRMessageCallBack_V30(MSGCallBack fMessageCallBack, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConnectTime(uint dwWaitTime, uint dwTryTimes);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetReconnect(uint dwInterval, int bEnableRecon);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKVersion();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetSDKBuildVersion();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_IsSupport();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartListen(string sLocalIP, ushort wLocalPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartListen_V30(String sLocalIP, ushort wLocalPort, MSGCallBack DataCallback, IntPtr pUserData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopListen_V30(Int32 lListenHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login(string sDVRIP, ushort wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO lpDeviceInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout(int iUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern string NET_DVR_GetErrorMsg(ref int pErrorNo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetShowMode(uint dwShowType, uint colorKey);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr(string sServerIP, ushort wServerPort, string sDVRName, ushort wDVRNameLen, string sDVRSerialNumber, ushort wDVRSerialLen, IntPtr pGetIP);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRIPByResolveSvr_EX(string sServerIP, ushort wServerPort, byte[] sDVRName, ushort wDVRNameLen, byte[] sDVRSerialNumber, ushort wDVRSerialLen, byte[] sGetIP, ref uint dwPort);
        //Ԥ����ؽӿ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_RealPlay(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_SDK_RealPlay(int iUserLogID, ref NET_DVR_CLIENTINFO lpDVRClientInfo);
        /*********************************************************
		Function:	REALDATACALLBACK
		Desc:		Ԥ���ص�
		Input:	lRealHandle ��ǰ��Ԥ����� 
				dwDataType ��������
				pBuffer ������ݵĻ�����ָ�� 
				dwBufSize ��������С 
				pUser �û����� 
		Output:	
		Return:	void
		**********************************************************/
        public delegate void REALDATACALLBACK(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser);
        [DllImport(@"..\bin\HCNetSDK.dll")]

        /*********************************************************
        Function:	NET_DVR_RealPlay_V30
        Desc:		ʵʱԤ����
        Input:	lUserID [in] NET_DVR_Login()��NET_DVR_Login_V30()�ķ���ֵ 
                lpClientInfo [in] Ԥ������ 
                cbRealDataCallBack [in] �������ݻص����� 
                pUser [in] �û����� 
                bBlocked [in] �������������Ƿ�������0����1���� 
        Output:	
        Return:	1��ʾʧ�ܣ�����ֵ��ΪNET_DVR_StopRealPlay�Ⱥ����ľ������
        **********************************************************/
        public static extern int NET_DVR_RealPlay_V30(int iUserID, ref NET_DVR_CLIENTINFO lpClientInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser, UInt32 bBlocked);

        /*********************************************************
        Function:	NET_DVR_RealPlay_V40
        Desc:		ʵʱԤ����չ�ӿڡ�
        Input:	lUserID [in] NET_DVR_Login()��NET_DVR_Login_V30()�ķ���ֵ 
                lpPreviewInfo [in] Ԥ������ 
                fRealDataCallBack_V30 [in] �������ݻص����� 
                pUser [in] �û����� 
        Output:	
        Return:	1��ʾʧ�ܣ�����ֵ��ΪNET_DVR_StopRealPlay�Ⱥ����ľ������
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_V40(int iUserID, ref NET_DVR_PREVIEWINFO lpPreviewInfo, REALDATACALLBACK fRealDataCallBack_V30, IntPtr pUser);

       // [DllImport(@"..\bin\HCNetSDK.dll")]
       // public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);
        /*********************************************************
		Function:	NET_DVR_StopRealPlay
		Desc:		ֹͣԤ����
		Input:	lRealHandle [in] Ԥ�������NET_DVR_RealPlay����NET_DVR_RealPlay_V30�ķ���ֵ 
		Output:	
		Return:	
		**********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopRealPlay(int iRealHandle);

        /*********************************************************
        Function:	DRAWFUN
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void DRAWFUN(int lRealHandle, IntPtr hDc, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayerBufNumber(Int32 lRealHandle, uint dwBufNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ThrowBFrame(Int32 lRealHandle, uint dwNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAudioMode(uint dwMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSoundShare(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSoundShare(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Volume(Int32 lRealHandle, ushort wVolume);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData(Int32 lRealHandle, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopSaveRealData(Int32 lRealHandle);

        /*********************************************************
        Function:	REALDATACALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SETREALDATACALLBACK(int lRealHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRealDataCallBack(int lRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint dwUser);

        /*********************************************************
        Function:	STDDATACALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void STDDATACALLBACK(int lRealHandle, uint dwDataType, ref byte pBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetStandardDataCallBack(int lRealHandle, STDDATACALLBACK fStdDataCallBack, uint dwUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture(Int32 lRealHandle, string sPicFileName);

        //��̬����I֡
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrame(Int32 lUserID, Int32 lChannel);//������

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MakeKeyFrameSub(Int32 lUserID, Int32 lChannel);//������

        //��̨������ؽӿ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl(Int32 lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCtrl_Other(Int32 lUserID, int lChannel);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl(Int32 lRealHandle, uint dwPTZCommand, uint dwStop);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_Other(Int32 lUserID, Int32 lChannel, uint dwPTZCommand, uint dwStop);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ(Int32 lRealHandle, string pPTZCodeBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_Other(int lUserID, int lChannel, string pPTZCodeBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_Other(int lUserID, int lChannel, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_TransPTZ_EX(int lRealHandle, string pPTZCodeBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControl_EX(int lRealHandle, uint dwPTZCommand, uint dwStop);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZPreset_EX(int lRealHandle, uint dwPTZPresetCmd, uint dwPresetIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_Other(int lUserID, int lChannel, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZCruise_EX(int lRealHandle, uint dwPTZCruiseCmd, byte byCruiseRoute, byte byCruisePoint, ushort wInput);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack(int lRealHandle, uint dwPTZTrackCmd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZTrack_EX(int lRealHandle, uint dwPTZTrackCmd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_Other(int lUserID, int lChannel, int dwPTZCommand, int dwStop, int dwSpeed);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZControlWithSpeed_EX(int lRealHandle, uint dwPTZCommand, uint dwStop, uint dwSpeed);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZCruise(int lUserID, int lChannel, int lCruiseRoute, ref NET_DVR_CRUISE_RET lpCruiseRet);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_Other(int lUserID, int lChannel, uint dwPTZTrackCmd, uint dwTrackIndex);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZMltTrack_EX(int lRealHandle, uint dwPTZTrackCmd, uint dwTrackIndex);

        //�ļ�������ط�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose(int lFindHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V30(int lFindHandle, ref NET_DVR_FINDDATA_V30 lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_V40(int lFindHandle, ref NET_DVR_FINDDATA_V40 lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V40(int lUserID, ref NET_DVR_FILECOND_V40 pFindCond);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose_V30(int lFindHandle);

        //2007-04-16���Ӳ�ѯ��������ŵ��ļ�����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile_Card(int lFindHandle, ref NET_DVR_FINDDATA_CARD lpFindData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_Card(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_LockFileByName(int lUserID, string sLockFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_UnlockFileByName(int lUserID, string sUnlockFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, System.IntPtr hWnd);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime_V40(int lUserID, ref NET_DVR_VOD_PARA pVodPara);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref uint LPOutValue);
        
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl_V40(int lPlayHandle, uint dwControlCode, IntPtr lpInBuffer, uint dwInValue, IntPtr lpOutBuffer, ref uint LPOutValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);

        /*********************************************************
        Function:	PLAYDATACALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void PLAYDATACALLBACK(int lPlayHandle, uint dwDataType, IntPtr pBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetPlayDataCallBack(int lPlayHandle, PLAYDATACALLBACK fPlayDataCallBack, uint dwUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackSaveData(int lPlayHandle, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBackSave(int lPlayHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPlayBackOsdTime(int lPlayHandle, ref NET_DVR_TIME lpOsdTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackCaptureFile(int lPlayHandle, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByName(int lUserID, string sDVRFileName, string sSavedFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime(int lUserID, int lChannel, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, string sSavedFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetFileByTime_V40(int lUserID, string sSavedFileName, ref NET_DVR_PLAYCOND pDownloadCond);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopGetFile(int lFileHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetDownloadPos(int lFileHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPos(int lPlayHandle);

        //����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_Upgrade(int lUserID, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeState(int lUpgradeHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetUpgradeProgress(int lUpgradeHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseUpgradeHandle(int lUpgradeHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetNetworkEnvironment(uint dwEnvironmentLevel);

        //Զ�̸�ʽ��Ӳ��
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FormatDisk(int lUserID, int lDiskNumber);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetFormatProgress(int lFormatHandle, ref int pCurrentFormatDisk, ref int pCurrentDiskPos, ref int pFormatStatic);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseFormatHandle(int lFormatHandle);

        //����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan(int lAlarmHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_SetupAlarmChan_V30(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseAlarmChan_V30(int lAlarmHandle);

        //�����Խ�
        /*********************************************************
        Function:	VOICEDATACALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACK(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

        /*********************************************************
        Function:	VOICEDATACALLBACKV30
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEDATACALLBACKV30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_V30(int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVoiceComClientVolume(int lVoiceComHandle, ushort wVolume);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopVoiceCom(int lVoiceComHandle);

        //����ת��
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR(int lUserID, VOICEDATACALLBACK fVoiceDataCallBack, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_StartVoiceCom_MR_V30(int lUserID, uint dwVoiceChan, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_VoiceComSendData(int lVoiceComHandle, string pSendBuf, uint dwBufSize);

        //�����㲥
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart();

        /*********************************************************
        Function:	VOICEAUDIOSTART
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void VOICEAUDIOSTART(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStart_V30(VOICEAUDIOSTART fVoiceAudioStart, IntPtr pUser);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientAudioStop();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_AddDVR(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_AddDVR_V30(int lUserID, uint dwVoiceChan);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DelDVR_V30(int lVoiceHandle);


        //͸��ͨ������
        /*********************************************************
        Function:	SERIALDATACALLBACK
        Desc:		(�ص�����)
        Input:	
        Output:	
        Return:	
        **********************************************************/
        public delegate void SERIALDATACALLBACK(int lSerialHandle, string pRecvDataBuffer, uint dwBufSize, uint dwUser);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStart(int lUserID, int lSerialPort, SERIALDATACALLBACK fSerialDataCallBack, uint dwUser);

        //485��Ϊ͸��ͨ��ʱ����Ҫָ��ͨ���ţ���Ϊ��ͬͨ����485�����ÿ��Բ�ͬ(���粨����)
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialSend(int lSerialHandle, int lChannel, string pSendBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SerialStop(int lSerialHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SendTo232Port(int lUserID, string pSendBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SendToSerialPort(int lUserID, uint dwSerialPort, uint dwSerialIndex, string pSendBuf, uint dwBufSize);

        //���� nBitrate = 16000
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_InitG722Decoder(int nBitrate);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Decoder(IntPtr pDecHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG722Frame(IntPtr pDecHandle, ref byte pInBuffer, ref byte pOutBuffer);

        //����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern IntPtr NET_DVR_InitG722Encoder();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG722Frame(IntPtr pEncodeHandle, ref byte pInBuffer, ref byte pOutBuffer);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern void NET_DVR_ReleaseG722Encoder(IntPtr pEncodeHandle);

        //Զ�̿��Ʊ�����ʾ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClickKey(int lUserID, int lKeyIndex);

        //Զ�̿����豸���ֶ�¼��
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDVRRecord(int lUserID, int lChannel, int lRecordType);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDVRRecord(int lUserID, int lChannel);

        //���뿨
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDevice_Card(ref int pDeviceTotalChan);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDevice_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDraw_Card(IntPtr hParent, uint colorKey);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDraw_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_RealPlay_Card(int lUserID, ref NET_DVR_CARDINFO lpCardInfo, int lChannelNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ResetPara_Card(int lRealHandle, ref NET_DVR_DISPLAY_PARA lpDisplayPara);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshSurface_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClearSurface_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreSurface_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_OpenSound_Card(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CloseSound_Card(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVolume_Card(int lRealHandle, ushort wVolume);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_AudioPreview_Card(int lRealHandle, int bEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetCardLastError_Card();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern System.IntPtr NET_DVR_GetChanHandle_Card(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CapturePicture_Card(int lRealHandle, string sPicFileName);

        //��ȡ���뿨���кŴ˽ӿ���Ч������GetBoardDetail�ӿڻ��(2005-12-08֧��)
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSerialNum_Card(int lChannelNum, ref uint pDeviceSerialNo);

        //��־
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog(int lLogHandle, ref NET_DVR_LOG lpLogData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose(int lLogHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_V30(int lUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime, bool bOnlySmart);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_V30(int lLogHandle, ref NET_DVR_LOG_V30 lpLogData);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindLogClose_V30(int lLogHandle);

        //��ֹ2004��8��5��,��113���ӿ�
        //ATM DVR
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByCard(int lUserID, int lChannel, uint dwFileType, int nFindType, ref byte sCardNumber, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);


        //2005-09-15
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, string sPicFileName);

        //JPEGץͼ���ڴ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_CaptureJPEGPicture_NEW(int lUserID, int lChannel, ref NET_DVR_JPEGPARA lpJpegPara, byte[] sJpegPicBuffer, uint dwPicSize, ref uint lpSizeReturned);

        //2006-02-16
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetRealPlayerIndex(int lRealHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetPlayBackPlayerIndex(int lPlayHandle);

        //2006-08-28 704-640 ��������
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG(int lUserID, uint dwScale);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG(int lUserID, ref uint lpOutScale);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetScaleCFG_V30(int lUserID, ref NET_DVR_SCALECFG pScalecfg);

        //2006-08-28 ATM���˿�����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetATMPortCFG(int lUserID, ushort wATMPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetATMPortCFG(int lUserID, ref ushort LPOutATMPort);

        //2006-11-10 ֧���Կ��������
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_InitDDrawDevice();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ReleaseDDrawDevice();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_GetDDrawDeviceTotalNums();

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDDrawDevice(int lPlayPort, uint nDeviceNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn(int lRealHandle, ref NET_DVR_POINT_FRAME pStruPointFrame);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_PTZSelZoomIn_EX(int lUserID, int lChannel, ref NET_DVR_POINT_FRAME pStruPointFrame);

        //�����豸DS-6001D/DS-6001F
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecode(int lUserID, int lChannel, ref NET_DVR_DECODERINFO lpDecoderinfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecode(int lUserID, int lChannel);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecoderState(int lUserID, int lChannel, ref NET_DVR_DECODERSTATE lpDecoderState);

        //2005-08-01
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecInfo(int lUserID, int lChannel, ref NET_DVR_DECCFG lpDecoderinfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecTransPort(int lUserID, ref NET_DVR_PORTCFG lpTransPort);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecPlayBackCtrl(int lUserID, int lChannel, uint dwControlCode, uint dwInValue, ref uint LPOutValue, ref NET_DVR_PLAYREMOTEFILE lpRemoteFileInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StartDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopDecSpecialCon(int lUserID, int lChannel, ref NET_DVR_DECCHANINFO lpDecChanInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlDec(int lUserID, int lChannel, uint dwControlCode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecCtrlScreen(int lUserID, int lChannel, uint dwControl);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDecCurLinkStatus(int lUserID, int lChannel, ref NET_DVR_DECSTATUS lpDecStatus);

        //��·������
        //2007-11-30 V211֧�����½ӿ� //11
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DYNAMIC_DEC lpDynamicInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopDynamic(int lUserID, uint dwDecChanNum);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecEnable(int lUserID, ref uint lpdwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDecChanEnable(int lUserID, uint dwDecChanNum, uint dwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanEnable(int lUserID, uint dwDecChanNum, ref uint lpdwEnable);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_STATUS lpInter);

        //2007-12-22 ����֧�ֽӿ� //18
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlay(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetRemotePlayControl(int lUserID, uint dwDecChanNum, uint dwControlCode, uint dwInValue, ref uint LPOutValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetRemotePlayStatus(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_REMOTE_PLAY_STATUS lpOuter);

        //2009-4-13 ����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStartDynamic_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_PU_STREAM_CFG lpDynamicInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetLoopDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_LOOP_DECINFO_V30 lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDecChanInfo_V30(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_DEC_CHAN_INFO_V30 lpInter);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetTranInfo_V30(int lUserID, ref NET_DVR_MATRIX_TRAN_CHAN_CONFIG_V30 lpTranInfo);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetDisplayCfg(int lUserID, uint dwDispChanNum, ref NET_DVR_VGA_DISP_CHAN_CFG lpDisplayCfg);


        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_MatrixStartPassiveDecode(int lUserID, uint dwDecChanNum, ref NET_DVR_MATRIX_PASSIVEMODE lpPassiveMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSendData(int lPassiveHandle, System.IntPtr pSendBuf, uint dwBufSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixStopPassiveDecode(int lPassiveHandle);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_UploadLogo(int lUserID, uint dwDispChanNum, ref NET_DVR_DISP_LOGOCFG lpDispLogoCfg, System.IntPtr sLogoBuffer);

        public const int NET_DVR_SHOWLOGO = 1;/*��ʾLOGO*/
        public const int NET_DVR_HIDELOGO = 2;/*����LOGO*/

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_LogoSwitch(int lUserID, uint dwDecChan, uint dwLogoSwitch);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetDeviceStatus(int lUserID, ref NET_DVR_DECODER_WORK_STATUS lpDecoderCfg);

        /*��ʾͨ�������붨��*/
        //�Ϻ����� ����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RigisterPlayBackDrawFun(int lRealHandle, DRAWFUN fDrawFun, uint dwUser);


        public const int DISP_CMD_ENLARGE_WINDOW = 1;	/*��ʾͨ���Ŵ�ĳ������*/
        public const int DISP_CMD_RENEW_WINDOW = 2;	/*��ʾͨ�����ڻ�ԭ*/

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixDiaplayControl(int lUserID, uint dwDispChanNum, uint dwDispChanCmd, uint dwCmdParam);

        //end
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RefreshPlay(int lPlayHandle);

        //�ָ�Ĭ��ֵ
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RestoreConfig(int lUserID);

        //�������
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveConfig(int lUserID);

        //����
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_RebootDVR(int lUserID);

        //�ر�DVR
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ShutDownDVR(int lUserID);

        //�������� begin
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRConfig(int lUserID, uint dwCommand, int lChannel, IntPtr lpOutBuffer, uint dwOutBufferSize, ref uint lpBytesReturned);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetDVRConfig(int lUserID, uint dwCommand, int lChannel, System.IntPtr lpInBuffer, uint dwInBufferSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState_V30(int lUserID, IntPtr pWorkState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDVRWorkState(int lUserID, ref NET_DVR_WORKSTATE lpWorkState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVideoEffect(int lUserID, int lChannel, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVideoEffect(int lUserID, int lChannel, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetframeformat(int lUserID, ref NET_DVR_FRAMEFORMAT lpFrameFormat);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAtmProtocol(int lUserID, ref NET_DVR_ATM_PROTOCOL lpAtmProtocol);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut_V30(int lUserID, IntPtr lpAlarmOutState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetAlarmOut(int lUserID, ref NET_DVR_ALARMOUTSTATUS lpAlarmOutState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetAlarmOut(int lUserID, int lAlarmOutPort, int lAlarmOutStatic);

        //��ȡUPNP�˿�ӳ��״̬
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetUpnpNatState(int lUserID, ref NET_DVR_UPNP_NAT_STATE lpState);

        //��Ƶ��������
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientSetVideoEffect(int lRealHandle, uint dwBrightValue, uint dwContrastValue, uint dwSaturationValue, uint dwHueValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_ClientGetVideoEffect(int lRealHandle, ref uint pBrightValue, ref uint pContrastValue, ref uint pSaturationValue, ref uint pHueValue);

        //�����ļ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile(int lUserID, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile(int lUserID, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_V30(int lUserID, string sOutBuffer, uint dwOutSize, ref uint pReturnSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetConfigFile_EX(int lUserID, string sOutBuffer, uint dwOutSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetConfigFile_EX(int lUserID, string sInBuffer, uint dwInSize);

        //������־�ļ�д��ӿ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLogToFile(int bLogEnable, string strLogDir, bool bAutoDel);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKState(ref NET_DVR_SDKSTATE pSDKState);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetSDKAbility(ref NET_DVR_SDKABL pSDKAbl);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetPTZProtocol(int lUserID, ref NET_DVR_PTZCFG pPtzcfg);

        //ǰ�������
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_LockPanel(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_UnLockPanel(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpInBuffer, uint dwInBufferSize);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRtspConfig(int lUserID, uint dwCommand, ref NET_DVR_RTSPCFG lpOutBuffer, uint dwOutBufferSize);

        //��Ƶ�ۺ�ƽ̨
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixGetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_MatrixSetSceneCfg(int lUserID, uint dwSceneNum, ref NET_DVR_MATRIX_SCENECFG lpSceneCfg);

        //SDK_V222
        //�����豸����
        public const int DS6001_HF_B = 60;//��Ϊ������DS6001-HF/B
        public const int DS6001_HF_P = 61;//����ʶ��DS6001-HF/P
        public const int DS6002_HF_B = 62;//˫�����٣�DS6002-HF/B
        public const int DS6101_HF_B = 63;//��Ϊ������DS6101-HF/B
        public const int IDS52XX = 64;//���ܷ�����IVMS
        public const int DS9000_IVS = 65;//9000ϵ������DVR
        public const int DS8004_AHL_A = 66;//����ATM, DS8004AHL-S/A
        public const int DS6101_HF_P = 67;//����ʶ��DS6101-HF/P

        //������ȡ����
        public const int VCA_DEV_ABILITY = 256;//�豸���ܷ�����������
        public const int VCA_CHAN_ABILITY = 272;//��Ϊ��������
        public const int MATRIXDECODER_ABILITY = 512;//��·��������ʾ����������
        //��ȡ/���ô�ӿڲ�����������
        //����ʶ��NET_VCA_PLATE_CFG��
        public const int NET_DVR_SET_PLATECFG = 150;//���ó���ʶ�����
        public const int NET_DVR_GET_PLATECFG = 151;//��ȡ����ʶ�����
        //��Ϊ��Ӧ��NET_VCA_RULECFG��
        public const int NET_DVR_SET_RULECFG = 152;//������Ϊ��������
        public const int NET_DVR_GET_RULECFG = 153;//��ȡ��Ϊ��������

        //˫������궨������NET_DVR_LF_CFG��
        public const int NET_DVR_SET_LF_CFG = 160;//����˫����������ò���
        public const int NET_DVR_GET_LF_CFG = 161;//��ȡ˫����������ò���

        //���ܷ�����ȡ�����ýṹ
        public const int NET_DVR_SET_IVMS_STREAMCFG = 162;//�������ܷ�����ȡ������
        public const int NET_DVR_GET_IVMS_STREAMCFG = 163;//��ȡ���ܷ�����ȡ������

        //���ܿ��Ʋ����ṹ
        public const int NET_DVR_SET_VCA_CTRLCFG = 164;//�������ܿ��Ʋ���
        public const int NET_DVR_GET_VCA_CTRLCFG = 165;//��ȡ���ܿ��Ʋ���

        //��������NET_VCA_MASK_REGION_LIST
        public const int NET_DVR_SET_VCA_MASK_REGION = 166;//���������������
        public const int NET_DVR_GET_VCA_MASK_REGION = 167;//��ȡ�����������

        //ATM�������� NET_VCA_ENTER_REGION
        public const int NET_DVR_SET_VCA_ENTER_REGION = 168;//���ý����������
        public const int NET_DVR_GET_VCA_ENTER_REGION = 169;//��ȡ�����������

        //�궨������NET_VCA_LINE_SEGMENT_LIST
        public const int NET_DVR_SET_VCA_LINE_SEGMENT = 170;//���ñ궨��
        public const int NET_DVR_GET_VCA_LINE_SEGMENT = 171;//��ȡ�궨��

        // ivms��������NET_IVMS_MASK_REGION_LIST
        public const int NET_DVR_SET_IVMS_MASK_REGION = 172;//����IVMS�����������
        public const int NET_DVR_GET_IVMS_MASK_REGION = 173;//��ȡIVMS�����������
        // ivms����������NET_IVMS_ENTER_REGION
        public const int NET_DVR_SET_IVMS_ENTER_REGION = 174;//����IVMS�����������
        public const int NET_DVR_GET_IVMS_ENTER_REGION = 175;//��ȡIVMS�����������

        public const int NET_DVR_SET_IVMS_BEHAVIORCFG = 176;//�������ܷ�������Ϊ�������
        public const int NET_DVR_GET_IVMS_BEHAVIORCFG = 177;//��ȡ���ܷ�������Ϊ�������

        // IVMS �طż���
        public const int NET_DVR_IVMS_SET_SEARCHCFG = 178;//����IVMS�طż�������
        public const int NET_DVR_IVMS_GET_SEARCHCFG = 179;//��ȡIVMS�طż�������        

        //�ṹ�����궨�� 
        public const int VCA_MAX_POLYGON_POINT_NUM = 10;//����������֧��10����Ķ����
        public const int MAX_RULE_NUM = 8;//����������
        public const int MAX_TARGET_NUM = 30;//���Ŀ�����
        public const int MAX_CALIB_PT = 6;//���궨�����
        public const int MIN_CALIB_PT = 4;//��С�궨�����
        public const int MAX_TIMESEGMENT_2 = 2;//���ʱ�����
        public const int MAX_LICENSE_LEN = 16;//���ƺ���󳤶�
        public const int MAX_PLATE_NUM = 3;//���Ƹ���
        public const int MAX_MASK_REGION_NUM = 4;//����ĸ���������
        public const int MAX_SEGMENT_NUM = 6;//������궨�����������Ŀ
        public const int MIN_SEGMENT_NUM = 3;//������궨��С��������Ŀ        
        /*********************************************************
		Function:	NET_DVR_GetDeviceAbility
		Desc:		
		Input:	
		Output:	
		Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ�ܡ�
		**********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetDeviceAbility(int lUserID, uint dwAbilityType, IntPtr pInBuf, uint dwInLength, IntPtr pOutBuf, uint dwOutLength);

        //�����ؼ���
        public enum IVS_PARAM_KEY
        {
            OBJECT_DETECT_SENSITIVE = 1,//Ŀ����������
            BACKGROUND_UPDATE_RATE = 2,//���������ٶ�
            SCENE_CHANGE_RATIO = 3,//�����仯�����Сֵ
            SUPPRESS_LAMP = 4,//�Ƿ����Ƴ�ͷ��
            MIN_OBJECT_SIZE = 5,//�ܼ�������СĿ���С
            OBJECT_GENERATE_RATE = 6,//Ŀ�������ٶ�
            MISSING_OBJECT_HOLD = 7,//Ŀ����ʧ���������ʱ��
            MAX_MISSING_DISTANCE = 8,//Ŀ����ʧ��������پ���
            OBJECT_MERGE_SPEED = 9,//���Ŀ�꽻��ʱ��Ŀ����ں��ٶ�
            REPEATED_MOTION_SUPPRESS = 10,//�ظ��˶�����
            ILLUMINATION_CHANGE = 11,//��Ӱ�仯���ƿ���
            TRACK_OUTPUT_MODE = 12,//�켣���ģʽ��0-���Ŀ������ģ�1-���Ŀ��ĵײ�����
            ENTER_CHANGE_HOLD = 13,//�������仯��ֵ
            RESUME_DEFAULT_PARAM = 255,//�ָ�Ĭ�Ϲؼ��ֲ���
        }

        //����/��ȡ�����ؼ���
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, int nValue);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetBehaviorParamKey(int lUserID, int lChannel, uint dwParameterKey, ref int pValue);

        //��ȡ/������Ϊ����Ŀ����ӽӿ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetVCADrawMode(int lUserID, int lChannel, ref NET_VCA_DRAW_MODE lpDrawMode);

        //�궨�������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CALIBRATION_PARAM
        {
            public byte byPointNum;//��Ч�궨�����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CALIB_PT, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_CB_POINT[] struCBPoint;//�궨����
        }

        //LF˫��������ýṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_CFG
        {
            public uint dwSize;//�ṹ����	
            public byte byEnable;//�궨ʹ��
            public byte byFollowChan;// �����ƵĴ�ͨ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
            public NET_DVR_LF_CALIBRATION_PARAM struCalParam;//�궨����
        }

        //L/F�ֶ����ƽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_MANUAL_CTRL_INFO
        {
            public NET_VCA_POINT struCtrlPoint;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //L/FĿ����ٽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_TARGET_INFO
        {
            public uint dwTargetID;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LF_TRACK_MODE
        {
            public uint dwSize;//�ṹ����
            public byte byTrackMode;//����ģʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//��������0
            [StructLayoutAttribute(LayoutKind.Explicit)]
            public struct uModeParam
            {
                [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
                [FieldOffsetAttribute(0)]
                public uint[] dwULen;
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_MANUAL_CTRL_INFO struManualCtrl;//�ֶ����ٽṹ
                [FieldOffsetAttribute(0)]
                public NET_DVR_LF_TRACK_TARGET_INFO struTargetTrack;//Ŀ����ٽṹ
            }
        }

        //˫���������ģʽ���ýӿ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetLFTrackMode(int lUserID, int lChannel, ref NET_DVR_LF_TRACK_MODE lpTrackMode);

        //ʶ�𳡾�
        public enum VCA_RECOGNIZE_SCENE
        {
            VCA_LOW_SPEED_SCENE = 0,//����ͨ���������շ�վ��С���ſڡ�ͣ������
            VCA_HIGH_SPEED_SCENE = 1,//����ͨ�����������ڡ����ٹ�·���ƶ�����)
            VCA_MOBILE_CAMERA_SCENE = 2,//�ƶ������Ӧ�ã� 
        }

        //ʶ������־
        public enum VCA_RECOGNIZE_RESULT
        {
            VCA_RECOGNIZE_FAILURE = 0,//ʶ��ʧ��
            VCA_IMAGE_RECOGNIZE_SUCCESS,//ͼ��ʶ��ɹ�
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_BEST_LICENSE,//��Ƶʶ����Ž��
            VCA_VIDEO_RECOGNIZE_SUCCESS_OF_NEW_LICENSE,//��Ƶʶ���µĳ���
            VCA_VIDEO_RECOGNIZE_FINISH_OF_CUR_LICENSE,//��Ƶʶ���ƽ���
        }

        

        //��Ƶʶ�𴥷�����
        public enum VCA_TRIGGER_TYPE
        {
            INTER_TRIGGER = 0,// ģ���ڲ�����ʶ��
            EXTER_TRIGGER = 1,// �ⲿ�����źŴ�������Ȧ���״�ֶ������źţ�
        }

        public const int MAX_CHINESE_CHAR_NUM = 64;    // ������������
        //���ƿɶ�̬�޸Ĳ���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_PARAM
        {
            public NET_VCA_RECT struSearchRect;//��������(��һ��)
            public NET_VCA_RECT struInvalidateRect;//��Ч���������������ڲ� (��һ��)
            public ushort wMinPlateWidth;//������С���
            public ushort wTriggerDuration;//��������֡��
            public byte byTriggerType;//����ģʽ, VCA_TRIGGER_TYPE
            public byte bySensitivity;//������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//��������0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I1)]
            public byte[] byCharPriority;// �������ȼ�
        }

        /*wMinPlateWidth:�ò���Ĭ������Ϊ80���أ��ò��������ö��ڳ��ƺ������ӳ���ʶ��˵���ĵ� 
	    ʶ����Ӱ�죬������ù�����ô��������г���С���ƾͻ�©ʶ����������г��ƿ���ձ�ϴ󣬿��԰Ѹò��������Դ󣬱��ڼ��ٶ���ٳ��ƵĴ����ڱ�������½�������Ϊ80�� �ڸ�������½�������Ϊ120
        wTriggerDuration �� �ⲿ�����źų���֡�������京���ǴӴ����źſ�ʼʶ���֡��������ֵ�ڵ��ٳ�����������Ϊ50��100�����ٳ�����������Ϊ15��25���ƶ�ʶ��ʱ���Ҳ���ⲿ����������Ϊ15��25��������Ը����ֳ������������
        */
        //����ʶ������ӽṹ
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATEINFO
        {
            public VCA_RECOGNIZE_SCENE eRecogniseScene;//ʶ�𳡾�(���ٺ͸���)
            public NET_VCA_PLATE_PARAM struModifyParam;//���ƿɶ�̬�޸Ĳ���
        }

        //����ʶ�����ò���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATECFG
        {
            public uint dwSize;
            public byte byPicProType;//����ʱͼƬ����ʽ 0-������ 1-�ϴ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//����������Ϊ0
            public NET_DVR_JPEGPARA struPictureParam;//ͼƬ���ṹ
            public NET_VCA_PLATEINFO struPlateInfo;//������Ϣ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT_2, ArraySubType = UnmanagedType.Struct)]
            public NET_DVR_SCHEDTIME[] struAlarmTime;//����ʱ��
            public NET_DVR_HANDLEEXCEPTION_V30 struHandleType;//����ʽ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_CHANNUM_V30, ArraySubType = UnmanagedType.I1)]
            public byte[] byRelRecordChan;//����������¼��ͨ��,Ϊ1��ʾ������ͨ��
        }

        //����ʶ�����ӽṹ
        [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct NET_VCA_PLATE_INFO
        {
            public VCA_RECOGNIZE_RESULT eResultFlag;//ʶ������־ 
            public VCA_PLATE_TYPE ePlateType;//��������
            public VCA_PLATE_COLOR ePlateColor;//������ɫ
            public NET_VCA_RECT struPlateRect;//����λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;//����������Ϊ0 
            public uint dwLicenseLen;//���Ƴ���
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sLicense;//���ƺ��� 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = MAX_LICENSE_LEN)]
            public string sBelieve;//����ʶ���ַ������Ŷȣ����⵽����"��A12345", ���Ŷ�Ϊ10,20,30,40,50,60,70�����ʾ"��"����ȷ�Ŀ�����ֻ��10%��"A"�ֵ���ȷ�Ŀ�������20%
        }

        //���Ƽ����
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_PLATE_RESULT
        {
            public uint dwSize;//�ṹ����
            public uint dwRelativeTime;//���ʱ��
            public uint dwAbsTime;//����ʱ��
            public byte byPlateNum;//���Ƹ���
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_PLATE_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_PLATE_INFO[] struPlateInfo;//������Ϣ�ṹ
            public uint dwPicDataLen;//����ͼƬ�ĳ��� Ϊ0��ʾû��ͼƬ������0��ʾ�ýṹ�������ͼƬ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes2;//����������Ϊ0 ͼƬ�ĸ߿�
            public System.IntPtr pImage;//ָ��ͼƬ��ָ��
        }

        //�������ܿ�
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_VCA_RestartLib(int lUserID, int lChannel);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEGMENT
        {
            public NET_VCA_POINT struStartPoint;//��ʾ�߶���ʱ����ʾͷ����
            public NET_VCA_POINT struEndPoint;//��ʾ�߶���ʱ����ʾ�Ų���
            public float fValue;//�߶�ֵ����λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //�궨������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_VCA_LINE_SEG_LIST
        {
            public uint dwSize;//�ṹ����
            public byte bySegNum;//�궨������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = System.Runtime.InteropServices.UnmanagedType.I1)]
            public byte[] byRes;//��������0
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_SEGMENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public NET_VCA_LINE_SEGMENT[] struSeg;
        }

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealHeight(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpHeight);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetRealLength(int lUserID, int lChannel, ref NET_VCA_LINE lpLine, ref Single lpLength);        

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SaveRealData_V30(int lRealHandle, uint dwTransType, string sFileName);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_EncodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_DecodeG711Frame(uint iType, ref byte pInBuffer, ref byte pOutBuffer);

        //2009-7-22 end  

        //�ʼ�������� 9000_1.1
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_EmailTest(int lUserID);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFileByEvent(int lUserID, ref NET_DVR_SEARCH_EVENT_PARAM lpSearchEventParam);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextEvent(int lSearchHandle, ref NET_DVR_SEARCH_EVENT_RET lpSearchEventRet);


        //2009-8-18 ץ�Ļ�
        public const int PLATE_INFO_LEN = 1024;
        public const int PLATE_NUM_LEN = 16;
        public const int FILE_NAME_LEN = 256;

        //liscense plate result
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_PLATE_RET
        {
            public uint dwSize;//�ṹ����
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_NUM_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byPlateNum;//���ƺ�
            public byte byVehicleType;// ������
            public byte byTrafficLight;//0-�̵ƣ�1-���
            public byte byPlateColor;//������ɫ
            public byte byDriveChan;//����������
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byTimeInfo;/*ʱ����Ϣ*///plate_172.6.113.64_20090724155526948_197170484 
            //Ŀǰ��17λ����ȷ��ms:20090724155526948
            public byte byCarSpeed;/*��λkm/h*/
            public byte byCarSpeedH;/*cm/s��8λ*/
            public byte byCarSpeedL;/*cm/s��8λ*/
            public byte byRes;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = PLATE_INFO_LEN - 36, ArraySubType = UnmanagedType.I1)]
            public byte[] byInfo;
            public uint dwPicLen;
        }
        /*ע��������� dwPicLen ���ȵ� ͼƬ ��Ϣ*/

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_INVOKE_PLATE_RECOGNIZE(int lUserID, int lChannel, string pPicFileName, ref NET_DVR_PLATE_RET pPlateRet, string pPicBuf, uint dwPicBufLen);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_CCD_CFG
        {
            public uint dwSize;//�ṹ����
            public byte byBlc;/*���ⲹ��0-off; 1-on*/
            public byte byBlcMode;/*blc����0-�Զ���1-�ϣ�2-�£�3-��4-�ң�5-�У�ע��������blcΪ on ʱ����Ч*/
            public byte byAwb;/*�Զ���ƽ��0-�Զ�1; 1-�Զ�2; 2-�Զ�����*/
            public byte byAgc;/*�Զ�����0-��; 1-��; 2-��; 3-��*/
            public byte byDayNight;/*��ҹת����0 ��ɫ��1�ڰף�2�Զ�*/
            public byte byMirror;/*����0-��;1-����;2-����;3-����*/
            public byte byShutter;/*����0-�Զ�; 1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k;*/
            public byte byIrCutTime;/*IRCUT�л�ʱ�䣬5, 10, 15, 20, 25*/
            public byte byLensType;/*��ͷ����0-���ӹ�Ȧ; 1-�Զ���Ȧ*/
            public byte byEnVideoTrig;/*��Ƶ����ʹ�ܣ�1-֧�֣�0-��֧�֡���Ƶ����ģʽ����Ƶ�����ٶȰ���byShutter�ٶȣ�ץ��ͼƬ�Ŀ����ٶȰ���byCapShutter�ٶȣ�ץ����ɺ���Զ����ڻ���Ƶģʽ*/
            public byte byCapShutter;/*ץ��ʱ�Ŀ����ٶȣ�1-1/25; 2-1/50; 3-1/100; 4-1/250;5-1/500; 6-1/1k ;7-1/2k; 8-1/4k; 9-1/10k; 10-1/100k; 11-1/150; 12-1/200*/
            public byte byEnRecognise;/*1-֧��ʶ��0-��֧��ʶ��*/
        }

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_SetCCDCfg(int lUserID, int lChannel, ref NET_DVR_CCD_CFG lpCCDCfg);

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagCAMERAPARAMCFG
        {
            public uint dwSize;
            public uint dwPowerLineFrequencyMode;/*0-50HZ; 1-60HZ*/
            public uint dwWhiteBalanceMode;/*0�ֶ���ƽ��; 1�Զ���ƽ��1����ΧС��; 2 �Զ���ƽ��2����Χ��2200K-15000K��;3�Զ�����3*/
            public uint dwWhiteBalanceModeRGain;/*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� R����*/
            public uint dwWhiteBalanceModeBGain;/*�ֶ���ƽ��ʱ��Ч���ֶ���ƽ�� B����*/
            public uint dwExposureMode;/*0 �ֶ��ع� 1�Զ��ع�*/
            public uint dwExposureSet;/* 0-USERSET, 1-�Զ�x2��2-�Զ�4��3-�Զ�81/25, 4-1/50, 5-1/100, 6-1/250, 7-1/500, 8-1/750, 9-1/1000, 10-1/2000, 11-1/4000,12-1/10,000; 13-1/100,000*/
            public uint dwExposureUserSet;/* �Զ��Զ����ع�ʱ��*/
            public uint dwExposureTarget;/*�ֶ��ع�ʱ�� ��Χ��Manumal��Ч��΢�룩*/
            public uint dwIrisMode;/*0 �Զ���Ȧ 1�ֶ���Ȧ*/
            public uint dwGainLevel;/*���棺0-100*/
            public uint dwBrightnessLevel;/*0-100*/
            public uint dwContrastLevel;/*0-100*/
            public uint dwSharpnessLevel;/*0-100*/
            public uint dwSaturationLevel;/*0-100*/
            public uint dwHueLevel;/*0-100����������*/
            public uint dwGammaCorrectionEnabled;/*0 dsibale  1 enable*/
            public uint dwGammaCorrectionLevel;/*0-100*/
            public uint dwWDREnabled;/*��̬��0 dsibale  1 enable*/
            public uint dwWDRLevel1;/*0-F*/
            public uint dwWDRLevel2;/*0-F*/
            public uint dwWDRContrastLevel;/*0-100*/
            public uint dwDayNightFilterType;/*��ҹ�л���0 day,1 night,2 auto */
            public uint dwSwitchScheduleEnabled;/*0 dsibale  1 enable,(����)*/
            //ģʽ1(����)
            public uint dwBeginTime;	/*0-100*/
            public uint dwEndTime;/*0-100*/
            //ģʽ2
            public uint dwDayToNightFilterLevel;//0-7
            public uint dwNightToDayFilterLevel;//0-7
            public uint dwDayNightFilterTime;//(60��)
            public uint dwBacklightMode;/*���ⲹ��:0 USERSET 1 UP��2 DOWN��3 LEFT��4 RIGHT��5MIDDLE*/
            public uint dwPositionX1;//��X����1��
            public uint dwPositionY1;//��Y����1��
            public uint dwPositionX2;//��X����2��
            public uint dwPositionY2;//��Y����2��
            public uint dwBacklightLevel;/*0x0-0xF*/
            public uint dwDigitalNoiseRemoveEnable; /*����ȥ�룺0 dsibale  1 enable*/
            public uint dwDigitalNoiseRemoveLevel;/*0x0-0xF*/
            public uint dwMirror; /* ����0 Left;1 Right,;2 Up;3Down */
            public uint dwDigitalZoom;/*��������:0 dsibale  1 enable*/
            public uint dwDeadPixelDetect;/*������,0 dsibale  1 enable*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRes;
        }

        public const int NET_DVR_GET_CCDPARAMCFG = 1067;       //IPC��ȡCCD��������
        public const int NET_DVR_SET_CCDPARAMCFG = 1068;      //IPC����CCD��������

        //ͼ����ǿ��
        //ͼ����ǿȥ����������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEREGION
        {
            public uint dwSize;//�ܵĽṹ����
            public ushort wImageRegionTopLeftX;/* ͼ����ǿȥ�������x���� */
            public ushort wImageRegionTopLeftY;/* ͼ����ǿȥ�������y���� */
            public ushort wImageRegionWidth;/* ͼ����ǿȥ������Ŀ� */
            public ushort wImageRegionHeight;/*ͼ����ǿȥ������ĸ�*/
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        //ͼ����ǿ��ȥ�뼶���ȶ���ʹ������
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGESUBPARAM
        {
            public NET_DVR_SCHEDTIME struImageStatusTime;//ͼ��״̬ʱ���
            public byte byImageEnhancementLevel;//ͼ����ǿ�ļ���0-7��0��ʾ�ر�
            public byte byImageDenoiseLevel;//ͼ��ȥ��ļ���0-7��0��ʾ�ر�
            public byte byImageStableEnable;//ͼ���ȶ���ʹ�ܣ�0��ʾ�رգ�1��ʾ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        public const int NET_DVR_GET_IMAGEREGION = 1062;       //ͼ����ǿ��ͼ����ǿȥ�������ȡ
        public const int NET_DVR_SET_IMAGEREGION = 1063;       //ͼ����ǿ��ͼ����ǿȥ�������ȡ
        public const int NET_DVR_GET_IMAGEPARAM = 1064;       // ͼ����ǿ��ͼ�����(ȥ�롢��ǿ�����ȶ���ʹ��)��ȡ
        public const int NET_DVR_SET_IMAGEPARAM = 1065;       // ͼ����ǿ��ͼ�����(ȥ�롢��ǿ�����ȶ���ʹ��)����

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagIMAGEPARAM
        {
            public uint dwSize;
            //ͼ����ǿʱ��β������ã����տ�ʼ	
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_DAYS * MAX_TIMESEGMENT, ArraySubType = UnmanagedType.Struct)]
            public tagIMAGESUBPARAM[] struImageParamSched;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }

        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_GetParamSetMode(int lUserID, ref uint dwParamSetMode);

        /*********************************************************
        Function:	NET_DVR_Login_V30
        Desc:		
        Input:	sDVRIP [in] �豸IP��ַ 
                wServerPort [in] �豸�˿ں� 
                sUserName [in] ��¼���û��� 
                sPassword [in] �û����� 
        Output:	lpDeviceInfo [out] �豸��Ϣ 
        Return:	-1��ʾʧ�ܣ�����ֵ��ʾ���ص��û�IDֵ
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login_V30(string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo);

        /*********************************************************
        Function:	NET_DVR_Logout_V30
        Desc:		�û�ע���豸��
        Input:	lUserID [in] �û�ID��
        Output:	
        Return:	TRUE��ʾ�ɹ���FALSE��ʾʧ��
        **********************************************************/
        [DllImport(@"..\bin\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout_V30(Int32 lUserID);











        #region  ȡ��ģ����ؽṹ��ӿ�

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PLAY_INFO
        {
            public int iUserID;      //ע���û�ID
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strDeviceIP;
            public int iDevicePort;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string strDevAdmin;
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string strDevPsd;
            public int iChannel;      //����ͨ����(��0��ʼ)
            public int iLinkMode;   //���λ(31)Ϊ0��ʾ��������Ϊ1��ʾ��������0��30λ��ʾ�������ӷ�ʽ: 0��TCP��ʽ,1��UDP��ʽ,2���ಥ��ʽ,3 - RTP��ʽ��4-����Ƶ�ֿ�(TCP)
            public bool bUseMedia;     //�Ƿ�������ý��
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string strMediaIP; //��ý��IP��ַ
            public int iMediaPort;   //��ý��˿ں�
        }


        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_Init();

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_UnInit();


        [DllImport("GetStream.dll")]
        public static extern int CLIENT_SDK_GetStream(PLAY_INFO lpPlayInfo); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SetRealDataCallBack(int iRealHandle, SETREALDATACALLBACK fRealDataCallBack, uint lUser); //

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_StopStream(int iRealHandle);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_GetVideoEffect(int iRealHandle, ref int iBrightValue, ref int iContrastValue, ref int iSaturationValue, ref int iHueValue);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_SetVideoEffect(int iRealHandle, int iBrightValue, int iContrastValue, int iSaturationValue, int iHueValue);

        [DllImport("GetStream.dll")]
        public static extern bool CLIENT_SDK_MakeKeyFrame(int iRealHandle);

        #endregion


        #region VOD�㲥�ſ�

        public const int WM_NETERROR = 0x0400 + 102;          //�����쳣��Ϣ
        public const int WM_STREAMEND = 0x0400 + 103;		  //�ļ����Ž���

        public const int FILE_HEAD = 0;      //�ļ�ͷ
        public const int VIDEO_I_FRAME = 1;  //��ƵI֡
        public const int VIDEO_B_FRAME = 2;  //��ƵB֡
        public const int VIDEO_P_FRAME = 3;  //��ƵP֡
        public const int VIDEO_BP_FRAME = 4; //��ƵBP֡
        public const int VIDEO_BBP_FRAME = 5; //��ƵB֡B֡P֡
        public const int AUDIO_PACKET = 10;   //��Ƶ��

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct BLOCKTIME
        {
            public ushort wYear;
            public byte bMonth;
            public byte bDay;
            public byte bHour;
            public byte bMinute;
            public byte bSecond;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODSEARCHPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VOD�ͻ��˾��
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVR�������ַ
            public uint dvrPort;                                            //	[in]DVR�Ķ˿ڵ�ַ
            public uint channelNum;                                         //  [in]DVR��ͨ����
            public BLOCKTIME startTime;                                     //	[in]��ѯ�Ŀ�ʼʱ��
            public BLOCKTIME stopTime;                                      //	[in]��ѯ�Ľ���ʱ��
            public bool bUseIPServer;                                       //  [in]�Ƿ�ʹ��IPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]�豸�����к�
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SECTIONLIST
        {
            public BLOCKTIME startTime;
            public BLOCKTIME stopTime;
            public byte byRecType;
            public IntPtr pNext;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct VODOPENPARAM
        {
            public IntPtr sessionHandle;                                    //[in]VOD�ͻ��˾��
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string dvrIP;                                            //	[in]DVR�������ַ
            public uint dvrPort;                                            //	[in]DVR�Ķ˿ڵ�ַ
            public uint channelNum;                                         //  [in]DVR��ͨ����
            public BLOCKTIME startTime;                                     //	[in]��ѯ�Ŀ�ʼʱ��
            public BLOCKTIME stopTime;                                      //	[in]��ѯ�Ľ���ʱ��
            public uint uiUser;
            public bool bUseIPServer;                                       //  [in]�Ƿ�ʹ��IPServer 
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string SerialNumber;                                     //  [in]�豸�����к�

            public VodStreamFrameData streamFrameData;
        }


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CONNPARAM
        {
            public uint uiUser;
            public ErrorCallback errorCB;
        }


        // �쳣�ص�����
        public delegate void ErrorCallback(System.IntPtr hSession, uint dwUser, int lErrorType);
        //֡���ݻص�����
        public delegate void VodStreamFrameData(System.IntPtr hStream, uint dwUser, int lFrameType, System.IntPtr pBuffer, uint dwSize);

        //ģ���ʼ��
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerConnect(string strServerIp, uint uiServerPort, ref IntPtr hSession, ref CONNPARAM struConn, IntPtr hWnd);

        //ģ������
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODServerDisconnect(IntPtr hSession);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStreamSearch(IntPtr pSearchParam, ref IntPtr pSecList);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODDeleteSectionList(IntPtr pSecList);

        // ����ID��ʱ��δ�����ȡ�����
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenStream(IntPtr pOpenParam, ref IntPtr phStream);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseStream(IntPtr hStream);

        //����ID��ʱ��δ���������
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODOpenDownloadStream(ref VODOPENPARAM struVodParam, ref IntPtr phStream);

        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODCloseDownloadStream(IntPtr hStream);

        // ��ʼ����������������֡
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStartStreamData(IntPtr phStream);
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODPauseStreamData(IntPtr hStream, bool bPause);
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODStopStreamData(IntPtr hStream);

        // ����ʱ�䶨λ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSeekStreamData(IntPtr hStream, IntPtr pStartTime);


        // ����ʱ�䶨λ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODSetStreamSpeed(IntPtr hStream, int iSpeed);

        // ����ʱ�䶨λ
        [DllImport("PdCssVodClient.dll")]
        public static extern bool VODGetStreamCurrentTime(IntPtr hStream, ref BLOCKTIME pCurrentTime);

        #endregion


        #region ֡������


        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct PACKET_INFO
        {
            public int nPacketType;     // packet type
            // 0:  file head
            // 1:  video I frame
            // 2:  video B frame
            // 3:  video P frame
            // 10: audio frame
            // 11: private frame only for PS


            //      [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.LPStr)]
            public IntPtr pPacketBuffer;
            public uint dwPacketSize;
            public int nYear;
            public int nMonth;
            public int nDay;
            public int nHour;
            public int nMinute;
            public int nSecond;
            public uint dwTimeStamp;
        }



        /******************************************************************************
        * function��get a empty port number
        * parameters��
        * return�� 0 - 499 : empty port number
        *          -1      : server is full  			
        * comment��
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetSafeHandle();


        /******************************************************************************
        * function��open standard stream data for analyzing
        * parameters��lHandle - working port number
        *             pHeader - pointer to file header or info header
        * return��TRUE or FALSE
        * comment��
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataOpenStreamEx(int iHandle, byte[] pFileHead);


        /******************************************************************************
        * function��close analyzing
        * parameters��lHandle - working port number
        * return��
        * comment��
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataClose(int iHandle);


        /******************************************************************************
        * function��input stream data
        * parameters��lHandle		- working port number
        *			  pBuffer		- data pointer
        *			  dwBuffersize	- data size
        * return��TRUE or FALSE
        * comment��
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataInputData(int iHandle, IntPtr pBuffer, uint uiSize); //byte []


        /******************************************************************************
        * function��get analyzed packet
        * parameters��lHandle		- working port number
        *			  pPacketInfo	- returned structure
        * return��-1 : error
        *          0 : succeed
        *		   1 : failed
        *		   2 : file end (only in file mode)				
        * comment��
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern int AnalyzeDataGetPacket(int iHandle, ref PACKET_INFO pPacketInfo);  //Ҫ��pPacketInfoת����PACKET_INFO�ṹ


        /******************************************************************************
        * function��get remain data from input buffer
        * parameters��lHandle		- working port number
        *			  pBuf	        - pointer to the mem which stored remain data
        *             dwSize        - size of remain data  
        * return�� TRUE or FALSE				
        * comment��
        ******************************************************************************/
        [DllImport("AnalyzeData.dll")]
        public static extern bool AnalyzeDataGetTail(int iHandle, ref IntPtr pBuffer, ref uint uiSize);


        [DllImport("AnalyzeData.dll")]
        public static extern uint AnalyzeDataGetLastError(int iHandle);

        #endregion


        #region ¼���

        public const int DATASTREAM_HEAD = 0;		//����ͷ
        public const int DATASTREAM_BITBLOCK = 1;		//�ֽ�����
        public const int DATASTREAM_KEYFRAME = 2;		//�ؼ�֡����
        public const int DATASTREAM_NORMALFRAME = 3;		//�ǹؼ�֡����


        public const int MESSAGEVALUE_DISKFULL = 0x01;
        public const int MESSAGEVALUE_SWITCHDISK = 0x02;
        public const int MESSAGEVALUE_CREATEFILE = 0x03;
        public const int MESSAGEVALUE_DELETEFILE = 0x04;
        public const int MESSAGEVALUE_SWITCHFILE = 0x05;




        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STOREINFO
        {
            public int iMaxChannels;
            public int iDiskGroup;
            public int iStreamType;
            public bool bAnalyze;
            public bool bCycWrite;
            public uint uiFileSize;

            public CALLBACKFUN_MESSAGE funCallback;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CREATEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileCreateTime;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct CLOSEFILE_INFO
        {
            public int iHandle;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strCameraid;

            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string strFileName;

            public BLOCKTIME tFileSwitchTime;
        }



        public delegate int CALLBACKFUN_MESSAGE(int iMessageType, System.IntPtr pBuf, int iBufLen);


        [DllImport("RecordDLL.dll")]
        public static extern int Initialize(STOREINFO struStoreInfo);

        [DllImport("RecordDLL.dll")]
        public static extern int Release();

        [DllImport("RecordDLL.dll")]
        public static extern int OpenChannelRecord(string strCameraid, IntPtr pHead, uint dwHeadLength);

        [DllImport("RecordDLL.dll")]
        public static extern bool CloseChannelRecord(int iRecordHandle);

        [DllImport("RecordDLL.dll")]
        public static extern int GetData(int iHandle, int iDataType, IntPtr pBuf, uint uiSize);

        #endregion

        //�豸��������
        public const int REGIONTYPE = 0;//��������
        public const int MATRIXTYPE = 11;//����ڵ�
        public const int DEVICETYPE = 2;//�����豸
        public const int CHANNELTYPE = 3;//����ͨ��
        public const int USERTYPE = 5;//�����û�

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_LOG_MATRIX
        {
            public NET_DVR_TIME strLogTime;
            public uint dwMajorType;
            public uint dwMinorType;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sPanelUser;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MAX_NAMELEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sNetUser;
            public NET_DVR_IPADDR struRemoteHostAddr;
            public uint dwParaType;
            public uint dwChannel;
            public uint dwDiskNumber;
            public uint dwAlarmInPort;
            public uint dwAlarmOutPort;
            public uint dwInfoLen;
            public byte byDevSequence;//��λ��
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MAC��ַ
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//���к�
            [MarshalAsAttribute(UnmanagedType.ByValTStr, SizeConst = LOG_INFO_LEN - SERIALNO_LEN - MACADDR_LEN - 1)]
            public string sInfo;
        }

        //��Ƶ�ۺ�ƽ̨���
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct tagVEDIOPLATLOG
        {
            public byte bySearchCondition;//����������0-����λ��������1-�����к����� 2-��MAC��ַ��������
            public byte byDevSequence;//��λ�ţ�0-79����Ӧ��ϵͳ�Ĳ�λ�ţ�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = SERIALNO_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;//���к�
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = MACADDR_LEN, ArraySubType = UnmanagedType.I1)]
            public byte[] byMacAddr;//MAC��ַ
        }

        [DllImportAttribute(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextLog_MATRIX(int iLogHandle, ref NET_DVR_LOG_MATRIX lpLogData);


        [DllImportAttribute(@"..\bin\HCNetSDK.dll")]
        public static extern int NET_DVR_FindDVRLog_Matrix(int iUserID, int lSelectMode, uint dwMajorType, uint dwMinorType, ref tagVEDIOPLATLOG lpVedioPlatLog, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
    }
}
