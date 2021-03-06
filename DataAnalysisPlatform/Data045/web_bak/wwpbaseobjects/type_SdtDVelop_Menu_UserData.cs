/*
				   File: type_SdtDVelop_Menu_UserData
			Description: DVelop_Menu_UserData
				 Author: Nemo for C# version 16.0.0.127771
		   Generated on: 2020/2/27 9:48:53
		   Program type: Callable routine
			  Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web.Services.Protocols;

using GeneXus.Programs;
namespace GeneXus.Programs.wwpbaseobjects{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="DVelop_Menu_UserData")]
	[XmlType(TypeName="DVelop_Menu_UserData" , Namespace="DataAnalysisPlatform" )]
	[Serializable]
	public class SdtDVelop_Menu_UserData : GxUserType
	{
		public SdtDVelop_Menu_UserData( )
		{
			/* Constructor for serialization */
			gxTv_SdtDVelop_Menu_UserData_Photouri = "";

			gxTv_SdtDVelop_Menu_UserData_Firstline = "";

			gxTv_SdtDVelop_Menu_UserData_Secondline = "";

		}

		public SdtDVelop_Menu_UserData(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("PhotoUri", gxTpr_Photouri, false);
			AddObjectProperty("FirstLine", gxTpr_Firstline, false);
			AddObjectProperty("SecondLine", gxTpr_Secondline, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="PhotoUri")]
		[XmlElement(ElementName="PhotoUri")]
		public String gxTpr_Photouri
		{
			get { 
				return gxTv_SdtDVelop_Menu_UserData_Photouri; 
			}
			set { 
				gxTv_SdtDVelop_Menu_UserData_Photouri = value;
				SetDirty("Photouri");
			}
		}


		[SoapElement(ElementName="FirstLine")]
		[XmlElement(ElementName="FirstLine")]
		public String gxTpr_Firstline
		{
			get { 
				return gxTv_SdtDVelop_Menu_UserData_Firstline; 
			}
			set { 
				gxTv_SdtDVelop_Menu_UserData_Firstline = value;
				SetDirty("Firstline");
			}
		}


		[SoapElement(ElementName="SecondLine")]
		[XmlElement(ElementName="SecondLine")]
		public String gxTpr_Secondline
		{
			get { 
				return gxTv_SdtDVelop_Menu_UserData_Secondline; 
			}
			set { 
				gxTv_SdtDVelop_Menu_UserData_Secondline = value;
				SetDirty("Secondline");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtDVelop_Menu_UserData_Photouri = "";
			gxTv_SdtDVelop_Menu_UserData_Firstline = "";
			gxTv_SdtDVelop_Menu_UserData_Secondline = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtDVelop_Menu_UserData_Photouri;
		protected String gxTv_SdtDVelop_Menu_UserData_Firstline;
		protected String gxTv_SdtDVelop_Menu_UserData_Secondline;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"DVelop_Menu_UserData", Namespace="DataAnalysisPlatform")]
	public class SdtDVelop_Menu_UserData_RESTInterface : GxGenericCollectionItem<SdtDVelop_Menu_UserData>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtDVelop_Menu_UserData_RESTInterface( ) : base()
		{
		}

		public SdtDVelop_Menu_UserData_RESTInterface( SdtDVelop_Menu_UserData psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="PhotoUri", Order=0)]
		public String gxTpr_Photouri
		{
			get { 
				return sdt.gxTpr_Photouri;
			}
			set { 
				sdt.gxTpr_Photouri = value;
			}
		}

		[DataMember(Name="FirstLine", Order=1)]
		public String gxTpr_Firstline
		{
			get { 
				return sdt.gxTpr_Firstline;
			}
			set { 
				sdt.gxTpr_Firstline = value;
			}
		}

		[DataMember(Name="SecondLine", Order=2)]
		public String gxTpr_Secondline
		{
			get { 
				return sdt.gxTpr_Secondline;
			}
			set { 
				sdt.gxTpr_Secondline = value;
			}
		}


		#endregion

		public SdtDVelop_Menu_UserData sdt
		{
			get { 
				return (SdtDVelop_Menu_UserData)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtDVelop_Menu_UserData() ;
			}
		}
	}
	#endregion
}