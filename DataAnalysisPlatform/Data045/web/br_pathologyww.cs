/*
               File: BR_PathologyWW
        Description:  ����ѧ
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:14:9.83
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_pathologyww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_pathologyww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathologyww( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Pathology_N = new GXCombobox();
         cmbBR_Pathology_M = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false;
            gxfirstwebparm = GetNextPar( );
            gxfirstwebparm_bkp = gxfirstwebparm;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
            {
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( );
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_31 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_31_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_31_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV17TFBR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_PathologyID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Information_PatientNo = GetNextPar( );
               AV26TFBR_Information_PatientNo_Sel = GetNextPar( );
               AV29TFBR_PathologyID_TestID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV30TFBR_PathologyID_TestID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV33TFBR_PathologyID_PADate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV34TFBR_PathologyID_PADate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV39TFBR_PathologyID_PAHosp = GetNextPar( );
               AV40TFBR_PathologyID_PAHosp_Sel = GetNextPar( );
               AV43TFBR_PathologyID_PAAge = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV44TFBR_PathologyID_PAAge_To = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV47TFBR_PathologyID_PrePaDia = GetNextPar( );
               AV48TFBR_PathologyID_PrePaDia_Sel = GetNextPar( );
               AV51TFBR_PathologyID_PAResult = GetNextPar( );
               AV52TFBR_PathologyID_PAResult_Sel = GetNextPar( );
               AV91TFBR_Pathology_Dia_Name = GetNextPar( );
               AV92TFBR_Pathology_Dia_Name_Sel = GetNextPar( );
               AV67TFBR_Pathology_T = NumberUtil.Val( GetNextPar( ), ".");
               AV68TFBR_Pathology_T_To = NumberUtil.Val( GetNextPar( ), ".");
               AV75TFBR_Pathology_LymphNum = NumberUtil.Val( GetNextPar( ), ".");
               AV76TFBR_Pathology_LymphNum_To = NumberUtil.Val( GetNextPar( ), ".");
               AV79TFBR_Pathology_LymphRate = GetNextPar( );
               AV80TFBR_Pathology_LymphRate_Sel = GetNextPar( );
               AV87TFBR_Pathology_MetaLoc = GetNextPar( );
               AV88TFBR_Pathology_MetaLoc_Sel = GetNextPar( );
               AV19ddo_BR_PathologyIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace = GetNextPar( );
               AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = GetNextPar( );
               AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = GetNextPar( );
               AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace = GetNextPar( );
               AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = GetNextPar( );
               AV69ddo_BR_Pathology_TTitleControlIdToReplace = GetNextPar( );
               AV73ddo_BR_Pathology_NTitleControlIdToReplace = GetNextPar( );
               AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace = GetNextPar( );
               AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace = GetNextPar( );
               AV85ddo_BR_Pathology_MTitleControlIdToReplace = GetNextPar( );
               AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV72TFBR_Pathology_N_Sels);
               ajax_req_read_hidden_sdt(GetNextPar( ), AV84TFBR_Pathology_M_Sels);
               AV131Pgmname = GetNextPar( );
               AV61IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV63IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               AV64IsAuthorized_BR_Information_PatientNo = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_PathologyID, AV18TFBR_PathologyID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_PathologyID_TestID, AV30TFBR_PathologyID_TestID_To, AV33TFBR_PathologyID_PADate, AV34TFBR_PathologyID_PADate_To, AV39TFBR_PathologyID_PAHosp, AV40TFBR_PathologyID_PAHosp_Sel, AV43TFBR_PathologyID_PAAge, AV44TFBR_PathologyID_PAAge_To, AV47TFBR_PathologyID_PrePaDia, AV48TFBR_PathologyID_PrePaDia_Sel, AV51TFBR_PathologyID_PAResult, AV52TFBR_PathologyID_PAResult_Sel, AV91TFBR_Pathology_Dia_Name, AV92TFBR_Pathology_Dia_Name_Sel, AV67TFBR_Pathology_T, AV68TFBR_Pathology_T_To, AV75TFBR_Pathology_LymphNum, AV76TFBR_Pathology_LymphNum_To, AV79TFBR_Pathology_LymphRate, AV80TFBR_Pathology_LymphRate_Sel, AV87TFBR_Pathology_MetaLoc, AV88TFBR_Pathology_MetaLoc_Sel, AV19ddo_BR_PathologyIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV69ddo_BR_Pathology_TTitleControlIdToReplace, AV73ddo_BR_Pathology_NTitleControlIdToReplace, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV85ddo_BR_Pathology_MTitleControlIdToReplace, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, AV72TFBR_Pathology_N_Sels, AV84TFBR_Pathology_M_Sels, AV131Pgmname, AV61IsAuthorized_Update, AV63IsAuthorized_Delete, AV64IsAuthorized_BR_Information_PatientNo) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA5C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START5C2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022815141075", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathologyww.aspx") +"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_PathologyID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_INFORMATION_PATIENTNO", AV25TFBR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_INFORMATION_PATIENTNO_SEL", AV26TFBR_Information_PatientNo_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_TESTID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_TESTID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PADATE", context.localUtil.Format(AV33TFBR_PathologyID_PADate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PADATE_TO", context.localUtil.Format(AV34TFBR_PathologyID_PADate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PAHOSP", AV39TFBR_PathologyID_PAHosp);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PAHOSP_SEL", AV40TFBR_PathologyID_PAHosp_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PAAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PAAGE_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PREPADIA", AV47TFBR_PathologyID_PrePaDia);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PREPADIA_SEL", AV48TFBR_PathologyID_PrePaDia_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PARESULT", AV51TFBR_PathologyID_PAResult);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGYID_PARESULT_SEL", AV52TFBR_PathologyID_PAResult_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIA_NAME", AV91TFBR_Pathology_Dia_Name);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_DIA_NAME_SEL", AV92TFBR_Pathology_Dia_Name_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_T", StringUtil.LTrim( StringUtil.NToC( AV67TFBR_Pathology_T, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_T_TO", StringUtil.LTrim( StringUtil.NToC( AV68TFBR_Pathology_T_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_LYMPHNUM", StringUtil.LTrim( StringUtil.NToC( AV75TFBR_Pathology_LymphNum, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_LYMPHNUM_TO", StringUtil.LTrim( StringUtil.NToC( AV76TFBR_Pathology_LymphNum_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_LYMPHRATE", AV79TFBR_Pathology_LymphRate);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_LYMPHRATE_SEL", AV80TFBR_Pathology_LymphRate_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_METALOC", AV87TFBR_Pathology_MetaLoc);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PATHOLOGY_METALOC_SEL", AV88TFBR_Pathology_MetaLoc_Sel);
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV58GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV57GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV54DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV54DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYIDTITLEFILTERDATA", AV16BR_PathologyIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYIDTITLEFILTERDATA", AV16BR_PathologyIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV24BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV24BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA", AV28BR_PathologyID_TestIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA", AV28BR_PathologyID_TestIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PADATETITLEFILTERDATA", AV32BR_PathologyID_PADateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PADATETITLEFILTERDATA", AV32BR_PathologyID_PADateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA", AV38BR_PathologyID_PAHospTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA", AV38BR_PathologyID_PAHospTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PAAGETITLEFILTERDATA", AV42BR_PathologyID_PAAgeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PAAGETITLEFILTERDATA", AV42BR_PathologyID_PAAgeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA", AV50BR_PathologyID_PAResultTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA", AV50BR_PathologyID_PAResultTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA", AV90BR_Pathology_Dia_NameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA", AV90BR_Pathology_Dia_NameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_TTITLEFILTERDATA", AV66BR_Pathology_TTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_TTITLEFILTERDATA", AV66BR_Pathology_TTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_NTITLEFILTERDATA", AV70BR_Pathology_NTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_NTITLEFILTERDATA", AV70BR_Pathology_NTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA", AV74BR_Pathology_LymphNumTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA", AV74BR_Pathology_LymphNumTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA", AV78BR_Pathology_LymphRateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA", AV78BR_Pathology_LymphRateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_MTITLEFILTERDATA", AV82BR_Pathology_MTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_MTITLEFILTERDATA", AV82BR_Pathology_MTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PATHOLOGY_METALOCTITLEFILTERDATA", AV86BR_Pathology_MetaLocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PATHOLOGY_METALOCTITLEFILTERDATA", AV86BR_Pathology_MetaLocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFBR_PATHOLOGY_N_SELS", AV72TFBR_Pathology_N_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFBR_PATHOLOGY_N_SELS", AV72TFBR_Pathology_N_Sels);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFBR_PATHOLOGY_M_SELS", AV84TFBR_Pathology_M_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFBR_PATHOLOGY_M_SELS", AV84TFBR_Pathology_M_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV131Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV61IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV63IsAuthorized_Delete);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", AV64IsAuthorized_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV64IsAuthorized_BR_Information_PatientNo, context));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Caption", StringUtil.RTrim( Ddo_br_pathologyid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cls", StringUtil.RTrim( Ddo_br_pathologyid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathologyid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathologyid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_br_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_br_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_br_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_br_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_br_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_set", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_set", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_br_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_br_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filtertype", StringUtil.RTrim( Ddo_br_information_patientno_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filterisrange", StringUtil.BoolToStr( Ddo_br_information_patientno_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_br_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalisttype", StringUtil.RTrim( Ddo_br_information_patientno_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalistproc", StringUtil.RTrim( Ddo_br_information_patientno_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_information_patientno_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_br_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_br_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Loadingdata", StringUtil.RTrim( Ddo_br_information_patientno_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cleanfilter", StringUtil.RTrim( Ddo_br_information_patientno_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Noresultsfound", StringUtil.RTrim( Ddo_br_information_patientno_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_br_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Caption", StringUtil.RTrim( Ddo_br_pathologyid_testid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_testid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Cls", StringUtil.RTrim( Ddo_br_pathologyid_testid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_testid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_testid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_testid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_testid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_testid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_testid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_testid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathologyid_testid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Rangefilterto", StringUtil.RTrim( Ddo_br_pathologyid_testid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_testid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Caption", StringUtil.RTrim( Ddo_br_pathologyid_padate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_padate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Cls", StringUtil.RTrim( Ddo_br_pathologyid_padate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_padate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_padate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_padate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_padate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_padate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_padate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_padate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathologyid_padate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Rangefilterto", StringUtil.RTrim( Ddo_br_pathologyid_padate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_padate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Caption", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Cls", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_pahosp_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Datalisttype", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Datalistproc", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathologyid_pahosp_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Loadingdata", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Noresultsfound", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Caption", StringUtil.RTrim( Ddo_br_pathologyid_paage_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_paage_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Cls", StringUtil.RTrim( Ddo_br_pathologyid_paage_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_paage_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_paage_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_paage_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_paage_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_paage_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_paage_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_paage_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathologyid_paage_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Rangefilterto", StringUtil.RTrim( Ddo_br_pathologyid_paage_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_paage_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Caption", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Cls", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_prepadia_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Datalisttype", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Datalistproc", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathologyid_prepadia_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Loadingdata", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Noresultsfound", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Caption", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Tooltip", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Cls", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Sortedstatus", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includefilter", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Filtertype", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathologyid_paresult_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Datalisttype", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Datalistproc", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathologyid_paresult_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Sortasc", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Sortdsc", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Loadingdata", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Cleanfilter", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Noresultsfound", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Caption", StringUtil.RTrim( Ddo_br_pathology_dia_name_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Tooltip", StringUtil.RTrim( Ddo_br_pathology_dia_name_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Cls", StringUtil.RTrim( Ddo_br_pathology_dia_name_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_dia_name_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_dia_name_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_dia_name_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_dia_name_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_dia_name_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Filtertype", StringUtil.RTrim( Ddo_br_pathology_dia_name_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_dia_name_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_dia_name_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_dia_name_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_dia_name_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Sortasc", StringUtil.RTrim( Ddo_br_pathology_dia_name_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_dia_name_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_dia_name_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_dia_name_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_dia_name_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_dia_name_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Caption", StringUtil.RTrim( Ddo_br_pathology_t_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Tooltip", StringUtil.RTrim( Ddo_br_pathology_t_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Cls", StringUtil.RTrim( Ddo_br_pathology_t_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_t_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_t_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_t_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_t_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_t_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_t_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_t_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_t_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filtertype", StringUtil.RTrim( Ddo_br_pathology_t_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_t_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_t_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Sortasc", StringUtil.RTrim( Ddo_br_pathology_t_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_t_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_t_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_t_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_t_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_t_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Caption", StringUtil.RTrim( Ddo_br_pathology_n_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Tooltip", StringUtil.RTrim( Ddo_br_pathology_n_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Cls", StringUtil.RTrim( Ddo_br_pathology_n_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_n_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_n_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_n_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_n_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_n_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_n_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_n_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_n_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_n_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Allowmultipleselection", StringUtil.BoolToStr( Ddo_br_pathology_n_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Datalistfixedvalues", StringUtil.RTrim( Ddo_br_pathology_n_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Sortasc", StringUtil.RTrim( Ddo_br_pathology_n_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_n_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_n_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_n_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Caption", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Tooltip", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Cls", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtextto_set", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filtertype", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_lymphnum_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Sortasc", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Rangefilterfrom", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Rangefilterto", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Caption", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Tooltip", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Cls", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Filtertype", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_lymphrate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_lymphrate_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Sortasc", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Caption", StringUtil.RTrim( Ddo_br_pathology_m_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Tooltip", StringUtil.RTrim( Ddo_br_pathology_m_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Cls", StringUtil.RTrim( Ddo_br_pathology_m_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_m_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_m_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_m_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_m_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_m_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_m_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_m_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_m_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_m_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Allowmultipleselection", StringUtil.BoolToStr( Ddo_br_pathology_m_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Datalistfixedvalues", StringUtil.RTrim( Ddo_br_pathology_m_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Sortasc", StringUtil.RTrim( Ddo_br_pathology_m_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_m_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_m_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_m_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Caption", StringUtil.RTrim( Ddo_br_pathology_metaloc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Tooltip", StringUtil.RTrim( Ddo_br_pathology_metaloc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Cls", StringUtil.RTrim( Ddo_br_pathology_metaloc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Filteredtext_set", StringUtil.RTrim( Ddo_br_pathology_metaloc_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Selectedvalue_set", StringUtil.RTrim( Ddo_br_pathology_metaloc_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_pathology_metaloc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_pathology_metaloc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Sortedstatus", StringUtil.RTrim( Ddo_br_pathology_metaloc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includefilter", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Filtertype", StringUtil.RTrim( Ddo_br_pathology_metaloc_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Filterisrange", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_pathology_metaloc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Datalisttype", StringUtil.RTrim( Ddo_br_pathology_metaloc_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Datalistproc", StringUtil.RTrim( Ddo_br_pathology_metaloc_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_pathology_metaloc_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Sortasc", StringUtil.RTrim( Ddo_br_pathology_metaloc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Sortdsc", StringUtil.RTrim( Ddo_br_pathology_metaloc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Loadingdata", StringUtil.RTrim( Ddo_br_pathology_metaloc_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Cleanfilter", StringUtil.RTrim( Ddo_br_pathology_metaloc_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Noresultsfound", StringUtil.RTrim( Ddo_br_pathology_metaloc_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_pathology_metaloc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_testid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_padate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_dia_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_dia_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_dia_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_t_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_t_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_t_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_n_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_n_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_m_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_m_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_metaloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_metaloc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_metaloc_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_testid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_TESTID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_testid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_padate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PADATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_padate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAHOSP_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathologyid_pahosp_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PAAGE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathologyid_paage_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PREPADIA_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathologyid_prepadia_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Activeeventkey", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGYID_PARESULT_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathologyid_paresult_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_dia_name_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_dia_name_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_DIA_NAME_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_dia_name_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_t_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_t_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_T_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_t_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_n_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_N_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_n_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtextto_get", StringUtil.RTrim( Ddo_br_pathology_lymphnum_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_LYMPHRATE_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_lymphrate_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_m_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_M_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_m_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Activeeventkey", StringUtil.RTrim( Ddo_br_pathology_metaloc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Filteredtext_get", StringUtil.RTrim( Ddo_br_pathology_metaloc_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PATHOLOGY_METALOC_Selectedvalue_get", StringUtil.RTrim( Ddo_br_pathology_metaloc_Selectedvalue_get));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE5C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT5C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_pathologyww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_PathologyWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " ����ѧ" ;
      }

      protected void WB5C0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableheader.SetProperty("Width", Dvpanel_tableheader_Width);
            ucDvpanel_tableheader.SetProperty("AutoWidth", Dvpanel_tableheader_Autowidth);
            ucDvpanel_tableheader.SetProperty("AutoHeight", Dvpanel_tableheader_Autoheight);
            ucDvpanel_tableheader.SetProperty("Cls", Dvpanel_tableheader_Cls);
            ucDvpanel_tableheader.SetProperty("Title", Dvpanel_tableheader_Title);
            ucDvpanel_tableheader.SetProperty("Collapsible", Dvpanel_tableheader_Collapsible);
            ucDvpanel_tableheader.SetProperty("Collapsed", Dvpanel_tableheader_Collapsed);
            ucDvpanel_tableheader.SetProperty("ShowCollapseIcon", Dvpanel_tableheader_Showcollapseicon);
            ucDvpanel_tableheader.SetProperty("IconPosition", Dvpanel_tableheader_Iconposition);
            ucDvpanel_tableheader.SetProperty("AutoScroll", Dvpanel_tableheader_Autoscroll);
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, "DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "����", bttBtninsert_Jsonclick, 5, "����", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_PathologyWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"31\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Information_PatientNo_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Information_PatientNo_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Information_PatientNo_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_TestID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_TestID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_TestID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PADate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PADate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PADate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PAHosp_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PAHosp_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PAHosp_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PAAge_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PAAge_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PAAge_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PrePaDia_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PrePaDia_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PrePaDia_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_PathologyID_PAResult_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_PathologyID_PAResult_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_PathologyID_PAResult_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_Dia_Name_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_Dia_Name_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_Dia_Name_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_T_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_T_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_T_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Pathology_N_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Pathology_N.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Pathology_N.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_LymphNum_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_LymphNum_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_LymphNum_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_LymphRate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_LymphRate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_LymphRate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Pathology_M_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Pathology_M.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Pathology_M.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Pathology_MetaLoc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Pathology_MetaLoc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Pathology_MetaLoc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV59Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV60Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV62Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A36BR_Information_PatientNo);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Information_PatientNo_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Information_PatientNo_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Information_PatientNo_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A237BR_PathologyID_TestID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_TestID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_TestID_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_PathologyID_TestID_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PADate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PADate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A239BR_PathologyID_PAHosp);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PAHosp_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PAHosp_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A240BR_PathologyID_PAAge), 3, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PAAge_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PAAge_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A241BR_PathologyID_PrePaDia);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PrePaDia_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PrePaDia_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A242BR_PathologyID_PAResult);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_PathologyID_PAResult_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_PathologyID_PAResult_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A326BR_Pathology_Dia_Name);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_Dia_Name_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_Dia_Name_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A314BR_Pathology_T, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_T_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_T_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A315BR_Pathology_N);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Pathology_N.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Pathology_N_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A316BR_Pathology_LymphNum, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_LymphNum_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_LymphNum_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A317BR_Pathology_LymphRate);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_LymphRate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_LymphRate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A318BR_Pathology_M);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Pathology_M.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Pathology_M_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A319BR_Pathology_MetaLoc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Pathology_MetaLoc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Pathology_MetaLoc_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 31 )
         {
            wbEnd = 0;
            nRC_GXsfl_31 = (short)(nGXsfl_31_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_gridpaginationbar_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucGridpaginationbar.SetProperty("Class", Gridpaginationbar_Class);
            ucGridpaginationbar.SetProperty("ShowFirst", Gridpaginationbar_Showfirst);
            ucGridpaginationbar.SetProperty("ShowPrevious", Gridpaginationbar_Showprevious);
            ucGridpaginationbar.SetProperty("ShowNext", Gridpaginationbar_Shownext);
            ucGridpaginationbar.SetProperty("ShowLast", Gridpaginationbar_Showlast);
            ucGridpaginationbar.SetProperty("PagesToShow", Gridpaginationbar_Pagestoshow);
            ucGridpaginationbar.SetProperty("PagingButtonsPosition", Gridpaginationbar_Pagingbuttonsposition);
            ucGridpaginationbar.SetProperty("PagingCaptionPosition", Gridpaginationbar_Pagingcaptionposition);
            ucGridpaginationbar.SetProperty("EmptyGridClass", Gridpaginationbar_Emptygridclass);
            ucGridpaginationbar.SetProperty("RowsPerPageSelector", Gridpaginationbar_Rowsperpageselector);
            ucGridpaginationbar.SetProperty("RowsPerPageOptions", Gridpaginationbar_Rowsperpageoptions);
            ucGridpaginationbar.SetProperty("Previous", Gridpaginationbar_Previous);
            ucGridpaginationbar.SetProperty("Next", Gridpaginationbar_Next);
            ucGridpaginationbar.SetProperty("Caption", Gridpaginationbar_Caption);
            ucGridpaginationbar.SetProperty("EmptyGridCaption", Gridpaginationbar_Emptygridcaption);
            ucGridpaginationbar.SetProperty("RowsPerPageCaption", Gridpaginationbar_Rowsperpagecaption);
            ucGridpaginationbar.SetProperty("CurrentPage", AV56GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV58GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV57GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_br_pathologyid.SetProperty("Caption", Ddo_br_pathologyid_Caption);
            ucDdo_br_pathologyid.SetProperty("Tooltip", Ddo_br_pathologyid_Tooltip);
            ucDdo_br_pathologyid.SetProperty("Cls", Ddo_br_pathologyid_Cls);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_Dropdownoptionstype);
            ucDdo_br_pathologyid.SetProperty("IncludeSortASC", Ddo_br_pathologyid_Includesortasc);
            ucDdo_br_pathologyid.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_Includesortdsc);
            ucDdo_br_pathologyid.SetProperty("IncludeFilter", Ddo_br_pathologyid_Includefilter);
            ucDdo_br_pathologyid.SetProperty("FilterType", Ddo_br_pathologyid_Filtertype);
            ucDdo_br_pathologyid.SetProperty("FilterIsRange", Ddo_br_pathologyid_Filterisrange);
            ucDdo_br_pathologyid.SetProperty("IncludeDataList", Ddo_br_pathologyid_Includedatalist);
            ucDdo_br_pathologyid.SetProperty("SortASC", Ddo_br_pathologyid_Sortasc);
            ucDdo_br_pathologyid.SetProperty("SortDSC", Ddo_br_pathologyid_Sortdsc);
            ucDdo_br_pathologyid.SetProperty("CleanFilter", Ddo_br_pathologyid_Cleanfilter);
            ucDdo_br_pathologyid.SetProperty("RangeFilterFrom", Ddo_br_pathologyid_Rangefilterfrom);
            ucDdo_br_pathologyid.SetProperty("RangeFilterTo", Ddo_br_pathologyid_Rangefilterto);
            ucDdo_br_pathologyid.SetProperty("SearchButtonText", Ddo_br_pathologyid_Searchbuttontext);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid.SetProperty("DropDownOptionsData", AV16BR_PathologyIDTitleFilterData);
            ucDdo_br_pathologyid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_Internalname, "DDO_BR_PATHOLOGYIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_PathologyIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("FilterType", Ddo_br_encounterid_Filtertype);
            ucDdo_br_encounterid.SetProperty("FilterIsRange", Ddo_br_encounterid_Filterisrange);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("CleanFilter", Ddo_br_encounterid_Cleanfilter);
            ucDdo_br_encounterid.SetProperty("RangeFilterFrom", Ddo_br_encounterid_Rangefilterfrom);
            ucDdo_br_encounterid.SetProperty("RangeFilterTo", Ddo_br_encounterid_Rangefilterto);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV20BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_information_patientno.SetProperty("Caption", Ddo_br_information_patientno_Caption);
            ucDdo_br_information_patientno.SetProperty("Tooltip", Ddo_br_information_patientno_Tooltip);
            ucDdo_br_information_patientno.SetProperty("Cls", Ddo_br_information_patientno_Cls);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsType", Ddo_br_information_patientno_Dropdownoptionstype);
            ucDdo_br_information_patientno.SetProperty("IncludeSortASC", Ddo_br_information_patientno_Includesortasc);
            ucDdo_br_information_patientno.SetProperty("IncludeSortDSC", Ddo_br_information_patientno_Includesortdsc);
            ucDdo_br_information_patientno.SetProperty("IncludeFilter", Ddo_br_information_patientno_Includefilter);
            ucDdo_br_information_patientno.SetProperty("FilterType", Ddo_br_information_patientno_Filtertype);
            ucDdo_br_information_patientno.SetProperty("FilterIsRange", Ddo_br_information_patientno_Filterisrange);
            ucDdo_br_information_patientno.SetProperty("IncludeDataList", Ddo_br_information_patientno_Includedatalist);
            ucDdo_br_information_patientno.SetProperty("DataListType", Ddo_br_information_patientno_Datalisttype);
            ucDdo_br_information_patientno.SetProperty("DataListProc", Ddo_br_information_patientno_Datalistproc);
            ucDdo_br_information_patientno.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_information_patientno_Datalistupdateminimumcharacters);
            ucDdo_br_information_patientno.SetProperty("SortASC", Ddo_br_information_patientno_Sortasc);
            ucDdo_br_information_patientno.SetProperty("SortDSC", Ddo_br_information_patientno_Sortdsc);
            ucDdo_br_information_patientno.SetProperty("LoadingData", Ddo_br_information_patientno_Loadingdata);
            ucDdo_br_information_patientno.SetProperty("CleanFilter", Ddo_br_information_patientno_Cleanfilter);
            ucDdo_br_information_patientno.SetProperty("NoResultsFound", Ddo_br_information_patientno_Noresultsfound);
            ucDdo_br_information_patientno.SetProperty("SearchButtonText", Ddo_br_information_patientno_Searchbuttontext);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV24BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_testid.SetProperty("Caption", Ddo_br_pathologyid_testid_Caption);
            ucDdo_br_pathologyid_testid.SetProperty("Tooltip", Ddo_br_pathologyid_testid_Tooltip);
            ucDdo_br_pathologyid_testid.SetProperty("Cls", Ddo_br_pathologyid_testid_Cls);
            ucDdo_br_pathologyid_testid.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_testid_Dropdownoptionstype);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeSortASC", Ddo_br_pathologyid_testid_Includesortasc);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_testid_Includesortdsc);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeFilter", Ddo_br_pathologyid_testid_Includefilter);
            ucDdo_br_pathologyid_testid.SetProperty("FilterType", Ddo_br_pathologyid_testid_Filtertype);
            ucDdo_br_pathologyid_testid.SetProperty("FilterIsRange", Ddo_br_pathologyid_testid_Filterisrange);
            ucDdo_br_pathologyid_testid.SetProperty("IncludeDataList", Ddo_br_pathologyid_testid_Includedatalist);
            ucDdo_br_pathologyid_testid.SetProperty("SortASC", Ddo_br_pathologyid_testid_Sortasc);
            ucDdo_br_pathologyid_testid.SetProperty("SortDSC", Ddo_br_pathologyid_testid_Sortdsc);
            ucDdo_br_pathologyid_testid.SetProperty("CleanFilter", Ddo_br_pathologyid_testid_Cleanfilter);
            ucDdo_br_pathologyid_testid.SetProperty("RangeFilterFrom", Ddo_br_pathologyid_testid_Rangefilterfrom);
            ucDdo_br_pathologyid_testid.SetProperty("RangeFilterTo", Ddo_br_pathologyid_testid_Rangefilterto);
            ucDdo_br_pathologyid_testid.SetProperty("SearchButtonText", Ddo_br_pathologyid_testid_Searchbuttontext);
            ucDdo_br_pathologyid_testid.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_testid.SetProperty("DropDownOptionsData", AV28BR_PathologyID_TestIDTitleFilterData);
            ucDdo_br_pathologyid_testid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_testid_Internalname, "DDO_BR_PATHOLOGYID_TESTIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_padate.SetProperty("Caption", Ddo_br_pathologyid_padate_Caption);
            ucDdo_br_pathologyid_padate.SetProperty("Tooltip", Ddo_br_pathologyid_padate_Tooltip);
            ucDdo_br_pathologyid_padate.SetProperty("Cls", Ddo_br_pathologyid_padate_Cls);
            ucDdo_br_pathologyid_padate.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_padate_Dropdownoptionstype);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeSortASC", Ddo_br_pathologyid_padate_Includesortasc);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_padate_Includesortdsc);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeFilter", Ddo_br_pathologyid_padate_Includefilter);
            ucDdo_br_pathologyid_padate.SetProperty("FilterType", Ddo_br_pathologyid_padate_Filtertype);
            ucDdo_br_pathologyid_padate.SetProperty("FilterIsRange", Ddo_br_pathologyid_padate_Filterisrange);
            ucDdo_br_pathologyid_padate.SetProperty("IncludeDataList", Ddo_br_pathologyid_padate_Includedatalist);
            ucDdo_br_pathologyid_padate.SetProperty("SortASC", Ddo_br_pathologyid_padate_Sortasc);
            ucDdo_br_pathologyid_padate.SetProperty("SortDSC", Ddo_br_pathologyid_padate_Sortdsc);
            ucDdo_br_pathologyid_padate.SetProperty("CleanFilter", Ddo_br_pathologyid_padate_Cleanfilter);
            ucDdo_br_pathologyid_padate.SetProperty("RangeFilterFrom", Ddo_br_pathologyid_padate_Rangefilterfrom);
            ucDdo_br_pathologyid_padate.SetProperty("RangeFilterTo", Ddo_br_pathologyid_padate_Rangefilterto);
            ucDdo_br_pathologyid_padate.SetProperty("SearchButtonText", Ddo_br_pathologyid_padate_Searchbuttontext);
            ucDdo_br_pathologyid_padate.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_padate.SetProperty("DropDownOptionsData", AV32BR_PathologyID_PADateTitleFilterData);
            ucDdo_br_pathologyid_padate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_padate_Internalname, "DDO_BR_PATHOLOGYID_PADATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", 0, edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_pahosp.SetProperty("Caption", Ddo_br_pathologyid_pahosp_Caption);
            ucDdo_br_pathologyid_pahosp.SetProperty("Tooltip", Ddo_br_pathologyid_pahosp_Tooltip);
            ucDdo_br_pathologyid_pahosp.SetProperty("Cls", Ddo_br_pathologyid_pahosp_Cls);
            ucDdo_br_pathologyid_pahosp.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_pahosp_Dropdownoptionstype);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeSortASC", Ddo_br_pathologyid_pahosp_Includesortasc);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_pahosp_Includesortdsc);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeFilter", Ddo_br_pathologyid_pahosp_Includefilter);
            ucDdo_br_pathologyid_pahosp.SetProperty("FilterType", Ddo_br_pathologyid_pahosp_Filtertype);
            ucDdo_br_pathologyid_pahosp.SetProperty("FilterIsRange", Ddo_br_pathologyid_pahosp_Filterisrange);
            ucDdo_br_pathologyid_pahosp.SetProperty("IncludeDataList", Ddo_br_pathologyid_pahosp_Includedatalist);
            ucDdo_br_pathologyid_pahosp.SetProperty("DataListType", Ddo_br_pathologyid_pahosp_Datalisttype);
            ucDdo_br_pathologyid_pahosp.SetProperty("DataListProc", Ddo_br_pathologyid_pahosp_Datalistproc);
            ucDdo_br_pathologyid_pahosp.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathologyid_pahosp_Datalistupdateminimumcharacters);
            ucDdo_br_pathologyid_pahosp.SetProperty("SortASC", Ddo_br_pathologyid_pahosp_Sortasc);
            ucDdo_br_pathologyid_pahosp.SetProperty("SortDSC", Ddo_br_pathologyid_pahosp_Sortdsc);
            ucDdo_br_pathologyid_pahosp.SetProperty("LoadingData", Ddo_br_pathologyid_pahosp_Loadingdata);
            ucDdo_br_pathologyid_pahosp.SetProperty("CleanFilter", Ddo_br_pathologyid_pahosp_Cleanfilter);
            ucDdo_br_pathologyid_pahosp.SetProperty("NoResultsFound", Ddo_br_pathologyid_pahosp_Noresultsfound);
            ucDdo_br_pathologyid_pahosp.SetProperty("SearchButtonText", Ddo_br_pathologyid_pahosp_Searchbuttontext);
            ucDdo_br_pathologyid_pahosp.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_pahosp.SetProperty("DropDownOptionsData", AV38BR_PathologyID_PAHospTitleFilterData);
            ucDdo_br_pathologyid_pahosp.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_pahosp_Internalname, "DDO_BR_PATHOLOGYID_PAHOSPContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", 0, edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_paage.SetProperty("Caption", Ddo_br_pathologyid_paage_Caption);
            ucDdo_br_pathologyid_paage.SetProperty("Tooltip", Ddo_br_pathologyid_paage_Tooltip);
            ucDdo_br_pathologyid_paage.SetProperty("Cls", Ddo_br_pathologyid_paage_Cls);
            ucDdo_br_pathologyid_paage.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_paage_Dropdownoptionstype);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeSortASC", Ddo_br_pathologyid_paage_Includesortasc);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_paage_Includesortdsc);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeFilter", Ddo_br_pathologyid_paage_Includefilter);
            ucDdo_br_pathologyid_paage.SetProperty("FilterType", Ddo_br_pathologyid_paage_Filtertype);
            ucDdo_br_pathologyid_paage.SetProperty("FilterIsRange", Ddo_br_pathologyid_paage_Filterisrange);
            ucDdo_br_pathologyid_paage.SetProperty("IncludeDataList", Ddo_br_pathologyid_paage_Includedatalist);
            ucDdo_br_pathologyid_paage.SetProperty("SortASC", Ddo_br_pathologyid_paage_Sortasc);
            ucDdo_br_pathologyid_paage.SetProperty("SortDSC", Ddo_br_pathologyid_paage_Sortdsc);
            ucDdo_br_pathologyid_paage.SetProperty("CleanFilter", Ddo_br_pathologyid_paage_Cleanfilter);
            ucDdo_br_pathologyid_paage.SetProperty("RangeFilterFrom", Ddo_br_pathologyid_paage_Rangefilterfrom);
            ucDdo_br_pathologyid_paage.SetProperty("RangeFilterTo", Ddo_br_pathologyid_paage_Rangefilterto);
            ucDdo_br_pathologyid_paage.SetProperty("SearchButtonText", Ddo_br_pathologyid_paage_Searchbuttontext);
            ucDdo_br_pathologyid_paage.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_paage.SetProperty("DropDownOptionsData", AV42BR_PathologyID_PAAgeTitleFilterData);
            ucDdo_br_pathologyid_paage.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_paage_Internalname, "DDO_BR_PATHOLOGYID_PAAGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", 0, edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_prepadia.SetProperty("Caption", Ddo_br_pathologyid_prepadia_Caption);
            ucDdo_br_pathologyid_prepadia.SetProperty("Tooltip", Ddo_br_pathologyid_prepadia_Tooltip);
            ucDdo_br_pathologyid_prepadia.SetProperty("Cls", Ddo_br_pathologyid_prepadia_Cls);
            ucDdo_br_pathologyid_prepadia.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_prepadia_Dropdownoptionstype);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeSortASC", Ddo_br_pathologyid_prepadia_Includesortasc);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_prepadia_Includesortdsc);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeFilter", Ddo_br_pathologyid_prepadia_Includefilter);
            ucDdo_br_pathologyid_prepadia.SetProperty("FilterType", Ddo_br_pathologyid_prepadia_Filtertype);
            ucDdo_br_pathologyid_prepadia.SetProperty("FilterIsRange", Ddo_br_pathologyid_prepadia_Filterisrange);
            ucDdo_br_pathologyid_prepadia.SetProperty("IncludeDataList", Ddo_br_pathologyid_prepadia_Includedatalist);
            ucDdo_br_pathologyid_prepadia.SetProperty("DataListType", Ddo_br_pathologyid_prepadia_Datalisttype);
            ucDdo_br_pathologyid_prepadia.SetProperty("DataListProc", Ddo_br_pathologyid_prepadia_Datalistproc);
            ucDdo_br_pathologyid_prepadia.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathologyid_prepadia_Datalistupdateminimumcharacters);
            ucDdo_br_pathologyid_prepadia.SetProperty("SortASC", Ddo_br_pathologyid_prepadia_Sortasc);
            ucDdo_br_pathologyid_prepadia.SetProperty("SortDSC", Ddo_br_pathologyid_prepadia_Sortdsc);
            ucDdo_br_pathologyid_prepadia.SetProperty("LoadingData", Ddo_br_pathologyid_prepadia_Loadingdata);
            ucDdo_br_pathologyid_prepadia.SetProperty("CleanFilter", Ddo_br_pathologyid_prepadia_Cleanfilter);
            ucDdo_br_pathologyid_prepadia.SetProperty("NoResultsFound", Ddo_br_pathologyid_prepadia_Noresultsfound);
            ucDdo_br_pathologyid_prepadia.SetProperty("SearchButtonText", Ddo_br_pathologyid_prepadia_Searchbuttontext);
            ucDdo_br_pathologyid_prepadia.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_prepadia.SetProperty("DropDownOptionsData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
            ucDdo_br_pathologyid_prepadia.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_prepadia_Internalname, "DDO_BR_PATHOLOGYID_PREPADIAContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", 0, edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathologyid_paresult.SetProperty("Caption", Ddo_br_pathologyid_paresult_Caption);
            ucDdo_br_pathologyid_paresult.SetProperty("Tooltip", Ddo_br_pathologyid_paresult_Tooltip);
            ucDdo_br_pathologyid_paresult.SetProperty("Cls", Ddo_br_pathologyid_paresult_Cls);
            ucDdo_br_pathologyid_paresult.SetProperty("DropDownOptionsType", Ddo_br_pathologyid_paresult_Dropdownoptionstype);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeSortASC", Ddo_br_pathologyid_paresult_Includesortasc);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeSortDSC", Ddo_br_pathologyid_paresult_Includesortdsc);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeFilter", Ddo_br_pathologyid_paresult_Includefilter);
            ucDdo_br_pathologyid_paresult.SetProperty("FilterType", Ddo_br_pathologyid_paresult_Filtertype);
            ucDdo_br_pathologyid_paresult.SetProperty("FilterIsRange", Ddo_br_pathologyid_paresult_Filterisrange);
            ucDdo_br_pathologyid_paresult.SetProperty("IncludeDataList", Ddo_br_pathologyid_paresult_Includedatalist);
            ucDdo_br_pathologyid_paresult.SetProperty("DataListType", Ddo_br_pathologyid_paresult_Datalisttype);
            ucDdo_br_pathologyid_paresult.SetProperty("DataListProc", Ddo_br_pathologyid_paresult_Datalistproc);
            ucDdo_br_pathologyid_paresult.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathologyid_paresult_Datalistupdateminimumcharacters);
            ucDdo_br_pathologyid_paresult.SetProperty("SortASC", Ddo_br_pathologyid_paresult_Sortasc);
            ucDdo_br_pathologyid_paresult.SetProperty("SortDSC", Ddo_br_pathologyid_paresult_Sortdsc);
            ucDdo_br_pathologyid_paresult.SetProperty("LoadingData", Ddo_br_pathologyid_paresult_Loadingdata);
            ucDdo_br_pathologyid_paresult.SetProperty("CleanFilter", Ddo_br_pathologyid_paresult_Cleanfilter);
            ucDdo_br_pathologyid_paresult.SetProperty("NoResultsFound", Ddo_br_pathologyid_paresult_Noresultsfound);
            ucDdo_br_pathologyid_paresult.SetProperty("SearchButtonText", Ddo_br_pathologyid_paresult_Searchbuttontext);
            ucDdo_br_pathologyid_paresult.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathologyid_paresult.SetProperty("DropDownOptionsData", AV50BR_PathologyID_PAResultTitleFilterData);
            ucDdo_br_pathologyid_paresult.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathologyid_paresult_Internalname, "DDO_BR_PATHOLOGYID_PARESULTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", 0, edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_dia_name.SetProperty("Caption", Ddo_br_pathology_dia_name_Caption);
            ucDdo_br_pathology_dia_name.SetProperty("Tooltip", Ddo_br_pathology_dia_name_Tooltip);
            ucDdo_br_pathology_dia_name.SetProperty("Cls", Ddo_br_pathology_dia_name_Cls);
            ucDdo_br_pathology_dia_name.SetProperty("DropDownOptionsType", Ddo_br_pathology_dia_name_Dropdownoptionstype);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeSortASC", Ddo_br_pathology_dia_name_Includesortasc);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeSortDSC", Ddo_br_pathology_dia_name_Includesortdsc);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeFilter", Ddo_br_pathology_dia_name_Includefilter);
            ucDdo_br_pathology_dia_name.SetProperty("FilterType", Ddo_br_pathology_dia_name_Filtertype);
            ucDdo_br_pathology_dia_name.SetProperty("FilterIsRange", Ddo_br_pathology_dia_name_Filterisrange);
            ucDdo_br_pathology_dia_name.SetProperty("IncludeDataList", Ddo_br_pathology_dia_name_Includedatalist);
            ucDdo_br_pathology_dia_name.SetProperty("DataListType", Ddo_br_pathology_dia_name_Datalisttype);
            ucDdo_br_pathology_dia_name.SetProperty("DataListProc", Ddo_br_pathology_dia_name_Datalistproc);
            ucDdo_br_pathology_dia_name.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_dia_name_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_dia_name.SetProperty("SortASC", Ddo_br_pathology_dia_name_Sortasc);
            ucDdo_br_pathology_dia_name.SetProperty("SortDSC", Ddo_br_pathology_dia_name_Sortdsc);
            ucDdo_br_pathology_dia_name.SetProperty("LoadingData", Ddo_br_pathology_dia_name_Loadingdata);
            ucDdo_br_pathology_dia_name.SetProperty("CleanFilter", Ddo_br_pathology_dia_name_Cleanfilter);
            ucDdo_br_pathology_dia_name.SetProperty("NoResultsFound", Ddo_br_pathology_dia_name_Noresultsfound);
            ucDdo_br_pathology_dia_name.SetProperty("SearchButtonText", Ddo_br_pathology_dia_name_Searchbuttontext);
            ucDdo_br_pathology_dia_name.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_dia_name.SetProperty("DropDownOptionsData", AV90BR_Pathology_Dia_NameTitleFilterData);
            ucDdo_br_pathology_dia_name.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_dia_name_Internalname, "DDO_BR_PATHOLOGY_DIA_NAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", 0, edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_t.SetProperty("Caption", Ddo_br_pathology_t_Caption);
            ucDdo_br_pathology_t.SetProperty("Tooltip", Ddo_br_pathology_t_Tooltip);
            ucDdo_br_pathology_t.SetProperty("Cls", Ddo_br_pathology_t_Cls);
            ucDdo_br_pathology_t.SetProperty("DropDownOptionsType", Ddo_br_pathology_t_Dropdownoptionstype);
            ucDdo_br_pathology_t.SetProperty("IncludeSortASC", Ddo_br_pathology_t_Includesortasc);
            ucDdo_br_pathology_t.SetProperty("IncludeSortDSC", Ddo_br_pathology_t_Includesortdsc);
            ucDdo_br_pathology_t.SetProperty("IncludeFilter", Ddo_br_pathology_t_Includefilter);
            ucDdo_br_pathology_t.SetProperty("FilterType", Ddo_br_pathology_t_Filtertype);
            ucDdo_br_pathology_t.SetProperty("FilterIsRange", Ddo_br_pathology_t_Filterisrange);
            ucDdo_br_pathology_t.SetProperty("IncludeDataList", Ddo_br_pathology_t_Includedatalist);
            ucDdo_br_pathology_t.SetProperty("SortASC", Ddo_br_pathology_t_Sortasc);
            ucDdo_br_pathology_t.SetProperty("SortDSC", Ddo_br_pathology_t_Sortdsc);
            ucDdo_br_pathology_t.SetProperty("CleanFilter", Ddo_br_pathology_t_Cleanfilter);
            ucDdo_br_pathology_t.SetProperty("RangeFilterFrom", Ddo_br_pathology_t_Rangefilterfrom);
            ucDdo_br_pathology_t.SetProperty("RangeFilterTo", Ddo_br_pathology_t_Rangefilterto);
            ucDdo_br_pathology_t.SetProperty("SearchButtonText", Ddo_br_pathology_t_Searchbuttontext);
            ucDdo_br_pathology_t.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_t.SetProperty("DropDownOptionsData", AV66BR_Pathology_TTitleFilterData);
            ucDdo_br_pathology_t.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_t_Internalname, "DDO_BR_PATHOLOGY_TContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname, AV69ddo_BR_Pathology_TTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,79);\"", 0, edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_n.SetProperty("Caption", Ddo_br_pathology_n_Caption);
            ucDdo_br_pathology_n.SetProperty("Tooltip", Ddo_br_pathology_n_Tooltip);
            ucDdo_br_pathology_n.SetProperty("Cls", Ddo_br_pathology_n_Cls);
            ucDdo_br_pathology_n.SetProperty("DropDownOptionsType", Ddo_br_pathology_n_Dropdownoptionstype);
            ucDdo_br_pathology_n.SetProperty("IncludeSortASC", Ddo_br_pathology_n_Includesortasc);
            ucDdo_br_pathology_n.SetProperty("IncludeSortDSC", Ddo_br_pathology_n_Includesortdsc);
            ucDdo_br_pathology_n.SetProperty("IncludeFilter", Ddo_br_pathology_n_Includefilter);
            ucDdo_br_pathology_n.SetProperty("IncludeDataList", Ddo_br_pathology_n_Includedatalist);
            ucDdo_br_pathology_n.SetProperty("DataListType", Ddo_br_pathology_n_Datalisttype);
            ucDdo_br_pathology_n.SetProperty("AllowMultipleSelection", Ddo_br_pathology_n_Allowmultipleselection);
            ucDdo_br_pathology_n.SetProperty("DataListFixedValues", Ddo_br_pathology_n_Datalistfixedvalues);
            ucDdo_br_pathology_n.SetProperty("SortASC", Ddo_br_pathology_n_Sortasc);
            ucDdo_br_pathology_n.SetProperty("SortDSC", Ddo_br_pathology_n_Sortdsc);
            ucDdo_br_pathology_n.SetProperty("CleanFilter", Ddo_br_pathology_n_Cleanfilter);
            ucDdo_br_pathology_n.SetProperty("SearchButtonText", Ddo_br_pathology_n_Searchbuttontext);
            ucDdo_br_pathology_n.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_n.SetProperty("DropDownOptionsData", AV70BR_Pathology_NTitleFilterData);
            ucDdo_br_pathology_n.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_n_Internalname, "DDO_BR_PATHOLOGY_NContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname, AV73ddo_BR_Pathology_NTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", 0, edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_lymphnum.SetProperty("Caption", Ddo_br_pathology_lymphnum_Caption);
            ucDdo_br_pathology_lymphnum.SetProperty("Tooltip", Ddo_br_pathology_lymphnum_Tooltip);
            ucDdo_br_pathology_lymphnum.SetProperty("Cls", Ddo_br_pathology_lymphnum_Cls);
            ucDdo_br_pathology_lymphnum.SetProperty("DropDownOptionsType", Ddo_br_pathology_lymphnum_Dropdownoptionstype);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeSortASC", Ddo_br_pathology_lymphnum_Includesortasc);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeSortDSC", Ddo_br_pathology_lymphnum_Includesortdsc);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeFilter", Ddo_br_pathology_lymphnum_Includefilter);
            ucDdo_br_pathology_lymphnum.SetProperty("FilterType", Ddo_br_pathology_lymphnum_Filtertype);
            ucDdo_br_pathology_lymphnum.SetProperty("FilterIsRange", Ddo_br_pathology_lymphnum_Filterisrange);
            ucDdo_br_pathology_lymphnum.SetProperty("IncludeDataList", Ddo_br_pathology_lymphnum_Includedatalist);
            ucDdo_br_pathology_lymphnum.SetProperty("SortASC", Ddo_br_pathology_lymphnum_Sortasc);
            ucDdo_br_pathology_lymphnum.SetProperty("SortDSC", Ddo_br_pathology_lymphnum_Sortdsc);
            ucDdo_br_pathology_lymphnum.SetProperty("CleanFilter", Ddo_br_pathology_lymphnum_Cleanfilter);
            ucDdo_br_pathology_lymphnum.SetProperty("RangeFilterFrom", Ddo_br_pathology_lymphnum_Rangefilterfrom);
            ucDdo_br_pathology_lymphnum.SetProperty("RangeFilterTo", Ddo_br_pathology_lymphnum_Rangefilterto);
            ucDdo_br_pathology_lymphnum.SetProperty("SearchButtonText", Ddo_br_pathology_lymphnum_Searchbuttontext);
            ucDdo_br_pathology_lymphnum.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_lymphnum.SetProperty("DropDownOptionsData", AV74BR_Pathology_LymphNumTitleFilterData);
            ucDdo_br_pathology_lymphnum.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_lymphnum_Internalname, "DDO_BR_PATHOLOGY_LYMPHNUMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", 0, edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_lymphrate.SetProperty("Caption", Ddo_br_pathology_lymphrate_Caption);
            ucDdo_br_pathology_lymphrate.SetProperty("Tooltip", Ddo_br_pathology_lymphrate_Tooltip);
            ucDdo_br_pathology_lymphrate.SetProperty("Cls", Ddo_br_pathology_lymphrate_Cls);
            ucDdo_br_pathology_lymphrate.SetProperty("DropDownOptionsType", Ddo_br_pathology_lymphrate_Dropdownoptionstype);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeSortASC", Ddo_br_pathology_lymphrate_Includesortasc);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeSortDSC", Ddo_br_pathology_lymphrate_Includesortdsc);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeFilter", Ddo_br_pathology_lymphrate_Includefilter);
            ucDdo_br_pathology_lymphrate.SetProperty("FilterType", Ddo_br_pathology_lymphrate_Filtertype);
            ucDdo_br_pathology_lymphrate.SetProperty("FilterIsRange", Ddo_br_pathology_lymphrate_Filterisrange);
            ucDdo_br_pathology_lymphrate.SetProperty("IncludeDataList", Ddo_br_pathology_lymphrate_Includedatalist);
            ucDdo_br_pathology_lymphrate.SetProperty("DataListType", Ddo_br_pathology_lymphrate_Datalisttype);
            ucDdo_br_pathology_lymphrate.SetProperty("DataListProc", Ddo_br_pathology_lymphrate_Datalistproc);
            ucDdo_br_pathology_lymphrate.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_lymphrate_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_lymphrate.SetProperty("SortASC", Ddo_br_pathology_lymphrate_Sortasc);
            ucDdo_br_pathology_lymphrate.SetProperty("SortDSC", Ddo_br_pathology_lymphrate_Sortdsc);
            ucDdo_br_pathology_lymphrate.SetProperty("LoadingData", Ddo_br_pathology_lymphrate_Loadingdata);
            ucDdo_br_pathology_lymphrate.SetProperty("CleanFilter", Ddo_br_pathology_lymphrate_Cleanfilter);
            ucDdo_br_pathology_lymphrate.SetProperty("NoResultsFound", Ddo_br_pathology_lymphrate_Noresultsfound);
            ucDdo_br_pathology_lymphrate.SetProperty("SearchButtonText", Ddo_br_pathology_lymphrate_Searchbuttontext);
            ucDdo_br_pathology_lymphrate.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_lymphrate.SetProperty("DropDownOptionsData", AV78BR_Pathology_LymphRateTitleFilterData);
            ucDdo_br_pathology_lymphrate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_lymphrate_Internalname, "DDO_BR_PATHOLOGY_LYMPHRATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", 0, edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_m.SetProperty("Caption", Ddo_br_pathology_m_Caption);
            ucDdo_br_pathology_m.SetProperty("Tooltip", Ddo_br_pathology_m_Tooltip);
            ucDdo_br_pathology_m.SetProperty("Cls", Ddo_br_pathology_m_Cls);
            ucDdo_br_pathology_m.SetProperty("DropDownOptionsType", Ddo_br_pathology_m_Dropdownoptionstype);
            ucDdo_br_pathology_m.SetProperty("IncludeSortASC", Ddo_br_pathology_m_Includesortasc);
            ucDdo_br_pathology_m.SetProperty("IncludeSortDSC", Ddo_br_pathology_m_Includesortdsc);
            ucDdo_br_pathology_m.SetProperty("IncludeFilter", Ddo_br_pathology_m_Includefilter);
            ucDdo_br_pathology_m.SetProperty("IncludeDataList", Ddo_br_pathology_m_Includedatalist);
            ucDdo_br_pathology_m.SetProperty("DataListType", Ddo_br_pathology_m_Datalisttype);
            ucDdo_br_pathology_m.SetProperty("AllowMultipleSelection", Ddo_br_pathology_m_Allowmultipleselection);
            ucDdo_br_pathology_m.SetProperty("DataListFixedValues", Ddo_br_pathology_m_Datalistfixedvalues);
            ucDdo_br_pathology_m.SetProperty("SortASC", Ddo_br_pathology_m_Sortasc);
            ucDdo_br_pathology_m.SetProperty("SortDSC", Ddo_br_pathology_m_Sortdsc);
            ucDdo_br_pathology_m.SetProperty("CleanFilter", Ddo_br_pathology_m_Cleanfilter);
            ucDdo_br_pathology_m.SetProperty("SearchButtonText", Ddo_br_pathology_m_Searchbuttontext);
            ucDdo_br_pathology_m.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_m.SetProperty("DropDownOptionsData", AV82BR_Pathology_MTitleFilterData);
            ucDdo_br_pathology_m.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_m_Internalname, "DDO_BR_PATHOLOGY_MContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname, AV85ddo_BR_Pathology_MTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", 0, edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucDdo_br_pathology_metaloc.SetProperty("Caption", Ddo_br_pathology_metaloc_Caption);
            ucDdo_br_pathology_metaloc.SetProperty("Tooltip", Ddo_br_pathology_metaloc_Tooltip);
            ucDdo_br_pathology_metaloc.SetProperty("Cls", Ddo_br_pathology_metaloc_Cls);
            ucDdo_br_pathology_metaloc.SetProperty("DropDownOptionsType", Ddo_br_pathology_metaloc_Dropdownoptionstype);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeSortASC", Ddo_br_pathology_metaloc_Includesortasc);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeSortDSC", Ddo_br_pathology_metaloc_Includesortdsc);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeFilter", Ddo_br_pathology_metaloc_Includefilter);
            ucDdo_br_pathology_metaloc.SetProperty("FilterType", Ddo_br_pathology_metaloc_Filtertype);
            ucDdo_br_pathology_metaloc.SetProperty("FilterIsRange", Ddo_br_pathology_metaloc_Filterisrange);
            ucDdo_br_pathology_metaloc.SetProperty("IncludeDataList", Ddo_br_pathology_metaloc_Includedatalist);
            ucDdo_br_pathology_metaloc.SetProperty("DataListType", Ddo_br_pathology_metaloc_Datalisttype);
            ucDdo_br_pathology_metaloc.SetProperty("DataListProc", Ddo_br_pathology_metaloc_Datalistproc);
            ucDdo_br_pathology_metaloc.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_pathology_metaloc_Datalistupdateminimumcharacters);
            ucDdo_br_pathology_metaloc.SetProperty("SortASC", Ddo_br_pathology_metaloc_Sortasc);
            ucDdo_br_pathology_metaloc.SetProperty("SortDSC", Ddo_br_pathology_metaloc_Sortdsc);
            ucDdo_br_pathology_metaloc.SetProperty("LoadingData", Ddo_br_pathology_metaloc_Loadingdata);
            ucDdo_br_pathology_metaloc.SetProperty("CleanFilter", Ddo_br_pathology_metaloc_Cleanfilter);
            ucDdo_br_pathology_metaloc.SetProperty("NoResultsFound", Ddo_br_pathology_metaloc_Noresultsfound);
            ucDdo_br_pathology_metaloc.SetProperty("SearchButtonText", Ddo_br_pathology_metaloc_Searchbuttontext);
            ucDdo_br_pathology_metaloc.SetProperty("DropDownOptionsTitleSettingsIcons", AV54DDO_TitleSettingsIcons);
            ucDdo_br_pathology_metaloc.SetProperty("DropDownOptionsData", AV86BR_Pathology_MetaLocTitleFilterData);
            ucDdo_br_pathology_metaloc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_pathology_metaloc_Internalname, "DDO_BR_PATHOLOGY_METALOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", 0, edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_PathologyID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,93);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_PathologyID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_PathologyID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,94);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,95);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_EncounterID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,96);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_information_patientno_Internalname, AV25TFBR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( AV25TFBR_Information_PatientNo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_information_patientno_sel_Internalname, AV26TFBR_Information_PatientNo_Sel, StringUtil.RTrim( context.localUtil.Format( AV26TFBR_Information_PatientNo_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,98);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_information_patientno_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_information_patientno_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_testid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV29TFBR_PathologyID_TestID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_testid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_testid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_testid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV30TFBR_PathologyID_TestID_To), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_testid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_testid_to_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_pathologyid_padate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_padate_Internalname, context.localUtil.Format(AV33TFBR_PathologyID_PADate, "9999/99/99"), context.localUtil.Format( AV33TFBR_PathologyID_PADate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_padate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_padate_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_pathologyid_padate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_pathologyid_padate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_PathologyWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_pathologyid_padate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_padate_to_Internalname, context.localUtil.Format(AV34TFBR_PathologyID_PADate_To, "9999/99/99"), context.localUtil.Format( AV34TFBR_PathologyID_PADate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_padate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_padate_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_pathologyid_padate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_pathologyid_padate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_PathologyWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_pathologyid_padateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_pathologyid_padateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_pathologyid_padateauxdate_Internalname, context.localUtil.Format(AV35DDO_BR_PathologyID_PADateAuxDate, "9999/99/99"), context.localUtil.Format( AV35DDO_BR_PathologyID_PADateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_pathologyid_padateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_pathologyid_padateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_PathologyWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_pathologyid_padateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_pathologyid_padateauxdateto_Internalname, context.localUtil.Format(AV36DDO_BR_PathologyID_PADateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV36DDO_BR_PathologyID_PADateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_pathologyid_padateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_pathologyid_padateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_PathologyWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_pahosp_Internalname, AV39TFBR_PathologyID_PAHosp, StringUtil.RTrim( context.localUtil.Format( AV39TFBR_PathologyID_PAHosp, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_pahosp_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_pahosp_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_pahosp_sel_Internalname, AV40TFBR_PathologyID_PAHosp_Sel, StringUtil.RTrim( context.localUtil.Format( AV40TFBR_PathologyID_PAHosp_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,107);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_pahosp_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_pahosp_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_paage_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV43TFBR_PathologyID_PAAge), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_paage_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_paage_Visible, 1, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathologyid_paage_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV44TFBR_PathologyID_PAAge_To), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathologyid_paage_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathologyid_paage_to_Visible, 1, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_pathologyid_prepadia_Internalname, AV47TFBR_PathologyID_PrePaDia, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"", 0, edtavTfbr_pathologyid_prepadia_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_pathologyid_prepadia_sel_Internalname, AV48TFBR_PathologyID_PrePaDia_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", 0, edtavTfbr_pathologyid_prepadia_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_pathologyid_paresult_Internalname, AV51TFBR_PathologyID_PAResult, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,112);\"", 0, edtavTfbr_pathologyid_paresult_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_pathologyid_paresult_sel_Internalname, AV52TFBR_PathologyID_PAResult_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,113);\"", 0, edtavTfbr_pathologyid_paresult_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_pathology_dia_name_Internalname, AV91TFBR_Pathology_Dia_Name, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"", 0, edtavTfbr_pathology_dia_name_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "3000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_pathology_dia_name_sel_Internalname, AV92TFBR_Pathology_Dia_Name_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", 0, edtavTfbr_pathology_dia_name_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "3000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_t_Internalname, StringUtil.LTrim( StringUtil.NToC( AV67TFBR_Pathology_T, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV67TFBR_Pathology_T, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_t_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_t_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_t_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV68TFBR_Pathology_T_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV68TFBR_Pathology_T_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,117);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_t_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_t_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_lymphnum_Internalname, StringUtil.LTrim( StringUtil.NToC( AV75TFBR_Pathology_LymphNum, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV75TFBR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_lymphnum_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_lymphnum_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_lymphnum_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV76TFBR_Pathology_LymphNum_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV76TFBR_Pathology_LymphNum_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,119);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_lymphnum_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_lymphnum_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_lymphrate_Internalname, AV79TFBR_Pathology_LymphRate, StringUtil.RTrim( context.localUtil.Format( AV79TFBR_Pathology_LymphRate, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,120);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_lymphrate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_lymphrate_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 121,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_lymphrate_sel_Internalname, AV80TFBR_Pathology_LymphRate_Sel, StringUtil.RTrim( context.localUtil.Format( AV80TFBR_Pathology_LymphRate_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,121);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_lymphrate_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_lymphrate_sel_Visible, 1, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_metaloc_Internalname, AV87TFBR_Pathology_MetaLoc, StringUtil.RTrim( context.localUtil.Format( AV87TFBR_Pathology_MetaLoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_metaloc_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_metaloc_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 123,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_pathology_metaloc_sel_Internalname, AV88TFBR_Pathology_MetaLoc_Sel, StringUtil.RTrim( context.localUtil.Format( AV88TFBR_Pathology_MetaLoc_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,123);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_pathology_metaloc_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_pathology_metaloc_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_PathologyWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 31 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " ����ѧ", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP5C0( ) ;
      }

      protected void WS5C2( )
      {
         START5C2( ) ;
         EVT5C2( ) ;
      }

      protected void EVT5C2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName");
               EvtGridId = cgiGet( "_EventGridId");
               EvtRowId = cgiGet( "_EventRowId");
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1);
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E115C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E125C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E135C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E145C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E155C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_TESTID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E165C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PADATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E175C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PAHOSP.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E185C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PAAGE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E195C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PREPADIA.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E205C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGYID_PARESULT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E215C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_DIA_NAME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E225C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_T.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E235C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_N.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E245C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_LYMPHNUM.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E255C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_LYMPHRATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E265C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_M.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E275C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PATHOLOGY_METALOC.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E285C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E295C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_31_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
                              SubsflControlProps_312( ) ;
                              AV59Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV59Display)) ? AV128Display_GXI : context.convertURL( context.PathToRelativeUrl( AV59Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV59Display), true);
                              AV60Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV60Update)) ? AV129Update_GXI : context.convertURL( context.PathToRelativeUrl( AV60Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV60Update), true);
                              AV62Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV62Delete)) ? AV130Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV62Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV62Delete), true);
                              A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              n19BR_EncounterID = false;
                              A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                              n36BR_Information_PatientNo = false;
                              A237BR_PathologyID_TestID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_TestID_Internalname), ".", ","));
                              n237BR_PathologyID_TestID = false;
                              A238BR_PathologyID_PADate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_PathologyID_PADate_Internalname), 0));
                              n238BR_PathologyID_PADate = false;
                              A239BR_PathologyID_PAHosp = cgiGet( edtBR_PathologyID_PAHosp_Internalname);
                              n239BR_PathologyID_PAHosp = false;
                              A240BR_PathologyID_PAAge = (short)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_PAAge_Internalname), ".", ","));
                              n240BR_PathologyID_PAAge = false;
                              A241BR_PathologyID_PrePaDia = cgiGet( edtBR_PathologyID_PrePaDia_Internalname);
                              n241BR_PathologyID_PrePaDia = false;
                              A242BR_PathologyID_PAResult = cgiGet( edtBR_PathologyID_PAResult_Internalname);
                              n242BR_PathologyID_PAResult = false;
                              A326BR_Pathology_Dia_Name = cgiGet( edtBR_Pathology_Dia_Name_Internalname);
                              n326BR_Pathology_Dia_Name = false;
                              A314BR_Pathology_T = context.localUtil.CToN( cgiGet( edtBR_Pathology_T_Internalname), ".", ",");
                              n314BR_Pathology_T = false;
                              cmbBR_Pathology_N.Name = cmbBR_Pathology_N_Internalname;
                              cmbBR_Pathology_N.CurrentValue = cgiGet( cmbBR_Pathology_N_Internalname);
                              A315BR_Pathology_N = cgiGet( cmbBR_Pathology_N_Internalname);
                              n315BR_Pathology_N = false;
                              A316BR_Pathology_LymphNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_LymphNum_Internalname), ".", ",");
                              n316BR_Pathology_LymphNum = false;
                              A317BR_Pathology_LymphRate = cgiGet( edtBR_Pathology_LymphRate_Internalname);
                              n317BR_Pathology_LymphRate = false;
                              cmbBR_Pathology_M.Name = cmbBR_Pathology_M_Internalname;
                              cmbBR_Pathology_M.CurrentValue = cgiGet( cmbBR_Pathology_M_Internalname);
                              A318BR_Pathology_M = cgiGet( cmbBR_Pathology_M_Internalname);
                              n318BR_Pathology_M = false;
                              A319BR_Pathology_MetaLoc = cgiGet( edtBR_Pathology_MetaLoc_Internalname);
                              n319BR_Pathology_MetaLoc = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E305C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E315C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E325C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID"), ".", ",") != Convert.ToDecimal( AV17TFBR_PathologyID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_PathologyID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO"), AV25TFBR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_information_patientno_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO_SEL"), AV26TFBR_Information_PatientNo_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_testid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TESTID"), ".", ",") != Convert.ToDecimal( AV29TFBR_PathologyID_TestID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_testid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TESTID_TO"), ".", ",") != Convert.ToDecimal( AV30TFBR_PathologyID_TestID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_padate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_PATHOLOGYID_PADATE"), 0) != AV33TFBR_PathologyID_PADate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_padate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_PATHOLOGYID_PADATE_TO"), 0) != AV34TFBR_PathologyID_PADate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_pahosp Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PAHOSP"), AV39TFBR_PathologyID_PAHosp) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_pahosp_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PAHOSP_SEL"), AV40TFBR_PathologyID_PAHosp_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_paage Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_PAAGE"), ".", ",") != Convert.ToDecimal( AV43TFBR_PathologyID_PAAge )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_paage_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_PAAGE_TO"), ".", ",") != Convert.ToDecimal( AV44TFBR_PathologyID_PAAge_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_prepadia Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PREPADIA"), AV47TFBR_PathologyID_PrePaDia) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_prepadia_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PREPADIA_SEL"), AV48TFBR_PathologyID_PrePaDia_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_paresult Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PARESULT"), AV51TFBR_PathologyID_PAResult) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathologyid_paresult_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PARESULT_SEL"), AV52TFBR_PathologyID_PAResult_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_dia_name Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIA_NAME"), AV91TFBR_Pathology_Dia_Name) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_dia_name_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIA_NAME_SEL"), AV92TFBR_Pathology_Dia_Name_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_t Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_T"), ".", ",") != AV67TFBR_Pathology_T )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_t_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_T_TO"), ".", ",") != AV68TFBR_Pathology_T_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_lymphnum Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHNUM"), ".", ",") != AV75TFBR_Pathology_LymphNum )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_lymphnum_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHNUM_TO"), ".", ",") != AV76TFBR_Pathology_LymphNum_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_lymphrate Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHRATE"), AV79TFBR_Pathology_LymphRate) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_lymphrate_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHRATE_SEL"), AV80TFBR_Pathology_LymphRate_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_metaloc Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_METALOC"), AV87TFBR_Pathology_MetaLoc) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_pathology_metaloc_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_METALOC_SEL"), AV88TFBR_Pathology_MetaLoc_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE5C2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA5C2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
            init_web_controls( ) ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_312( ) ;
         while ( nGXsfl_31_idx <= nRC_GXsfl_31 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFBR_PathologyID ,
                                       long AV18TFBR_PathologyID_To ,
                                       long AV21TFBR_EncounterID ,
                                       long AV22TFBR_EncounterID_To ,
                                       String AV25TFBR_Information_PatientNo ,
                                       String AV26TFBR_Information_PatientNo_Sel ,
                                       long AV29TFBR_PathologyID_TestID ,
                                       long AV30TFBR_PathologyID_TestID_To ,
                                       DateTime AV33TFBR_PathologyID_PADate ,
                                       DateTime AV34TFBR_PathologyID_PADate_To ,
                                       String AV39TFBR_PathologyID_PAHosp ,
                                       String AV40TFBR_PathologyID_PAHosp_Sel ,
                                       short AV43TFBR_PathologyID_PAAge ,
                                       short AV44TFBR_PathologyID_PAAge_To ,
                                       String AV47TFBR_PathologyID_PrePaDia ,
                                       String AV48TFBR_PathologyID_PrePaDia_Sel ,
                                       String AV51TFBR_PathologyID_PAResult ,
                                       String AV52TFBR_PathologyID_PAResult_Sel ,
                                       String AV91TFBR_Pathology_Dia_Name ,
                                       String AV92TFBR_Pathology_Dia_Name_Sel ,
                                       decimal AV67TFBR_Pathology_T ,
                                       decimal AV68TFBR_Pathology_T_To ,
                                       decimal AV75TFBR_Pathology_LymphNum ,
                                       decimal AV76TFBR_Pathology_LymphNum_To ,
                                       String AV79TFBR_Pathology_LymphRate ,
                                       String AV80TFBR_Pathology_LymphRate_Sel ,
                                       String AV87TFBR_Pathology_MetaLoc ,
                                       String AV88TFBR_Pathology_MetaLoc_Sel ,
                                       String AV19ddo_BR_PathologyIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace ,
                                       String AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace ,
                                       String AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace ,
                                       String AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace ,
                                       String AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace ,
                                       String AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace ,
                                       String AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace ,
                                       String AV69ddo_BR_Pathology_TTitleControlIdToReplace ,
                                       String AV73ddo_BR_Pathology_NTitleControlIdToReplace ,
                                       String AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace ,
                                       String AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace ,
                                       String AV85ddo_BR_Pathology_MTitleControlIdToReplace ,
                                       String AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace ,
                                       GxSimpleCollection<String> AV72TFBR_Pathology_N_Sels ,
                                       GxSimpleCollection<String> AV84TFBR_Pathology_M_Sels ,
                                       String AV131Pgmname ,
                                       bool AV61IsAuthorized_Update ,
                                       bool AV63IsAuthorized_Delete ,
                                       bool AV64IsAuthorized_BR_Information_PatientNo )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5C2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF5C2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV131Pgmname = "BR_PathologyWW";
         context.Gx_err = 0;
      }

      protected void RF5C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E315C2 ();
         nGXsfl_31_idx = 1;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
         SubsflControlProps_312( ) ;
         bGXsfl_31_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_312( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A315BR_Pathology_N ,
                                                 AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                                 A318BR_Pathology_M ,
                                                 AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                                 AV98BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                                 AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                                 AV100BR_PathologyWWDS_3_Tfbr_encounterid ,
                                                 AV101BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                                 AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                                 AV102BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                                 AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                                 AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                                 AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                                 AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                                 AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                                 AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                                 AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                                 AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                                 AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                                 AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                                 AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                                 AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                                 AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                                 AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                                 AV118BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                                 AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                                 AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                                 AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                                 AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                                 AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                                 AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                                 AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                                 AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                                 AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                                 A226BR_PathologyID ,
                                                 A19BR_EncounterID ,
                                                 A36BR_Information_PatientNo ,
                                                 A237BR_PathologyID_TestID ,
                                                 A238BR_PathologyID_PADate ,
                                                 A239BR_PathologyID_PAHosp ,
                                                 A240BR_PathologyID_PAAge ,
                                                 A241BR_PathologyID_PrePaDia ,
                                                 A242BR_PathologyID_PAResult ,
                                                 A326BR_Pathology_Dia_Name ,
                                                 A314BR_Pathology_T ,
                                                 A316BR_Pathology_LymphNum ,
                                                 A317BR_Pathology_LymphRate ,
                                                 A319BR_Pathology_MetaLoc ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                                 TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV102BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV102BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
            lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
            lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
            lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
            lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
            lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
            lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
            /* Using cursor H005C2 */
            pr_default.execute(0, new Object[] {AV98BR_PathologyWWDS_1_Tfbr_pathologyid, AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV100BR_PathologyWWDS_3_Tfbr_encounterid, AV101BR_PathologyWWDS_4_Tfbr_encounterid_to, lV102BR_PathologyWWDS_5_Tfbr_information_patientno, AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV118BR_PathologyWWDS_21_Tfbr_pathology_t, AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H005C2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005C2_n85BR_Information_ID[0];
               A319BR_Pathology_MetaLoc = H005C2_A319BR_Pathology_MetaLoc[0];
               n319BR_Pathology_MetaLoc = H005C2_n319BR_Pathology_MetaLoc[0];
               A318BR_Pathology_M = H005C2_A318BR_Pathology_M[0];
               n318BR_Pathology_M = H005C2_n318BR_Pathology_M[0];
               A317BR_Pathology_LymphRate = H005C2_A317BR_Pathology_LymphRate[0];
               n317BR_Pathology_LymphRate = H005C2_n317BR_Pathology_LymphRate[0];
               A316BR_Pathology_LymphNum = H005C2_A316BR_Pathology_LymphNum[0];
               n316BR_Pathology_LymphNum = H005C2_n316BR_Pathology_LymphNum[0];
               A315BR_Pathology_N = H005C2_A315BR_Pathology_N[0];
               n315BR_Pathology_N = H005C2_n315BR_Pathology_N[0];
               A314BR_Pathology_T = H005C2_A314BR_Pathology_T[0];
               n314BR_Pathology_T = H005C2_n314BR_Pathology_T[0];
               A326BR_Pathology_Dia_Name = H005C2_A326BR_Pathology_Dia_Name[0];
               n326BR_Pathology_Dia_Name = H005C2_n326BR_Pathology_Dia_Name[0];
               A242BR_PathologyID_PAResult = H005C2_A242BR_PathologyID_PAResult[0];
               n242BR_PathologyID_PAResult = H005C2_n242BR_PathologyID_PAResult[0];
               A241BR_PathologyID_PrePaDia = H005C2_A241BR_PathologyID_PrePaDia[0];
               n241BR_PathologyID_PrePaDia = H005C2_n241BR_PathologyID_PrePaDia[0];
               A240BR_PathologyID_PAAge = H005C2_A240BR_PathologyID_PAAge[0];
               n240BR_PathologyID_PAAge = H005C2_n240BR_PathologyID_PAAge[0];
               A239BR_PathologyID_PAHosp = H005C2_A239BR_PathologyID_PAHosp[0];
               n239BR_PathologyID_PAHosp = H005C2_n239BR_PathologyID_PAHosp[0];
               A238BR_PathologyID_PADate = H005C2_A238BR_PathologyID_PADate[0];
               n238BR_PathologyID_PADate = H005C2_n238BR_PathologyID_PADate[0];
               A237BR_PathologyID_TestID = H005C2_A237BR_PathologyID_TestID[0];
               n237BR_PathologyID_TestID = H005C2_n237BR_PathologyID_TestID[0];
               A36BR_Information_PatientNo = H005C2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005C2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H005C2_A19BR_EncounterID[0];
               n19BR_EncounterID = H005C2_n19BR_EncounterID[0];
               A226BR_PathologyID = H005C2_A226BR_PathologyID[0];
               A85BR_Information_ID = H005C2_A85BR_Information_ID[0];
               n85BR_Information_ID = H005C2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H005C2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H005C2_n36BR_Information_PatientNo[0];
               E325C2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB5C0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5C2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", AV64IsAuthorized_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV64IsAuthorized_BR_Information_PatientNo, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PATHOLOGYID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A315BR_Pathology_N ,
                                              AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                              A318BR_Pathology_M ,
                                              AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                              AV98BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                              AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                              AV100BR_PathologyWWDS_3_Tfbr_encounterid ,
                                              AV101BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                              AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                              AV102BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                              AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                              AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                              AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                              AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                              AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                              AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                              AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                              AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                              AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                              AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                              AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                              AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                              AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                              AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                              AV118BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                              AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                              AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels.Count ,
                                              AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                              AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                              AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                              AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                              AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels.Count ,
                                              AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                              AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                              A226BR_PathologyID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A237BR_PathologyID_TestID ,
                                              A238BR_PathologyID_PADate ,
                                              A239BR_PathologyID_PAHosp ,
                                              A240BR_PathologyID_PAAge ,
                                              A241BR_PathologyID_PrePaDia ,
                                              A242BR_PathologyID_PAResult ,
                                              A326BR_Pathology_Dia_Name ,
                                              A314BR_Pathology_T ,
                                              A316BR_Pathology_LymphNum ,
                                              A317BR_Pathology_LymphRate ,
                                              A319BR_Pathology_MetaLoc ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV102BR_PathologyWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV102BR_PathologyWWDS_5_Tfbr_information_patientno), "%", "");
         lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = StringUtil.Concat( StringUtil.RTrim( AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp), "%", "");
         lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = StringUtil.Concat( StringUtil.RTrim( AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia), "%", "");
         lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = StringUtil.Concat( StringUtil.RTrim( AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult), "%", "");
         lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = StringUtil.Concat( StringUtil.RTrim( AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name), "%", "");
         lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = StringUtil.Concat( StringUtil.RTrim( AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate), "%", "");
         lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = StringUtil.Concat( StringUtil.RTrim( AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc), "%", "");
         /* Using cursor H005C3 */
         pr_default.execute(1, new Object[] {AV98BR_PathologyWWDS_1_Tfbr_pathologyid, AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to, AV100BR_PathologyWWDS_3_Tfbr_encounterid, AV101BR_PathologyWWDS_4_Tfbr_encounterid_to, lV102BR_PathologyWWDS_5_Tfbr_information_patientno, AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel, AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid, AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to, AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate, AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to, lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp, AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel, AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage, AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to, lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia, AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel, lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult, AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel, lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name, AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel, AV118BR_PathologyWWDS_21_Tfbr_pathology_t, AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to, AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum, AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to, lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate, AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel, lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc, AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel});
         GRID_nRecordCount = H005C3_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_PathologyID, AV18TFBR_PathologyID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_PathologyID_TestID, AV30TFBR_PathologyID_TestID_To, AV33TFBR_PathologyID_PADate, AV34TFBR_PathologyID_PADate_To, AV39TFBR_PathologyID_PAHosp, AV40TFBR_PathologyID_PAHosp_Sel, AV43TFBR_PathologyID_PAAge, AV44TFBR_PathologyID_PAAge_To, AV47TFBR_PathologyID_PrePaDia, AV48TFBR_PathologyID_PrePaDia_Sel, AV51TFBR_PathologyID_PAResult, AV52TFBR_PathologyID_PAResult_Sel, AV91TFBR_Pathology_Dia_Name, AV92TFBR_Pathology_Dia_Name_Sel, AV67TFBR_Pathology_T, AV68TFBR_Pathology_T_To, AV75TFBR_Pathology_LymphNum, AV76TFBR_Pathology_LymphNum_To, AV79TFBR_Pathology_LymphRate, AV80TFBR_Pathology_LymphRate_Sel, AV87TFBR_Pathology_MetaLoc, AV88TFBR_Pathology_MetaLoc_Sel, AV19ddo_BR_PathologyIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV69ddo_BR_Pathology_TTitleControlIdToReplace, AV73ddo_BR_Pathology_NTitleControlIdToReplace, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV85ddo_BR_Pathology_MTitleControlIdToReplace, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, AV72TFBR_Pathology_N_Sels, AV84TFBR_Pathology_M_Sels, AV131Pgmname, AV61IsAuthorized_Update, AV63IsAuthorized_Delete, AV64IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_PathologyID, AV18TFBR_PathologyID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_PathologyID_TestID, AV30TFBR_PathologyID_TestID_To, AV33TFBR_PathologyID_PADate, AV34TFBR_PathologyID_PADate_To, AV39TFBR_PathologyID_PAHosp, AV40TFBR_PathologyID_PAHosp_Sel, AV43TFBR_PathologyID_PAAge, AV44TFBR_PathologyID_PAAge_To, AV47TFBR_PathologyID_PrePaDia, AV48TFBR_PathologyID_PrePaDia_Sel, AV51TFBR_PathologyID_PAResult, AV52TFBR_PathologyID_PAResult_Sel, AV91TFBR_Pathology_Dia_Name, AV92TFBR_Pathology_Dia_Name_Sel, AV67TFBR_Pathology_T, AV68TFBR_Pathology_T_To, AV75TFBR_Pathology_LymphNum, AV76TFBR_Pathology_LymphNum_To, AV79TFBR_Pathology_LymphRate, AV80TFBR_Pathology_LymphRate_Sel, AV87TFBR_Pathology_MetaLoc, AV88TFBR_Pathology_MetaLoc_Sel, AV19ddo_BR_PathologyIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV69ddo_BR_Pathology_TTitleControlIdToReplace, AV73ddo_BR_Pathology_NTitleControlIdToReplace, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV85ddo_BR_Pathology_MTitleControlIdToReplace, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, AV72TFBR_Pathology_N_Sels, AV84TFBR_Pathology_M_Sels, AV131Pgmname, AV61IsAuthorized_Update, AV63IsAuthorized_Delete, AV64IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_PathologyID, AV18TFBR_PathologyID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_PathologyID_TestID, AV30TFBR_PathologyID_TestID_To, AV33TFBR_PathologyID_PADate, AV34TFBR_PathologyID_PADate_To, AV39TFBR_PathologyID_PAHosp, AV40TFBR_PathologyID_PAHosp_Sel, AV43TFBR_PathologyID_PAAge, AV44TFBR_PathologyID_PAAge_To, AV47TFBR_PathologyID_PrePaDia, AV48TFBR_PathologyID_PrePaDia_Sel, AV51TFBR_PathologyID_PAResult, AV52TFBR_PathologyID_PAResult_Sel, AV91TFBR_Pathology_Dia_Name, AV92TFBR_Pathology_Dia_Name_Sel, AV67TFBR_Pathology_T, AV68TFBR_Pathology_T_To, AV75TFBR_Pathology_LymphNum, AV76TFBR_Pathology_LymphNum_To, AV79TFBR_Pathology_LymphRate, AV80TFBR_Pathology_LymphRate_Sel, AV87TFBR_Pathology_MetaLoc, AV88TFBR_Pathology_MetaLoc_Sel, AV19ddo_BR_PathologyIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV69ddo_BR_Pathology_TTitleControlIdToReplace, AV73ddo_BR_Pathology_NTitleControlIdToReplace, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV85ddo_BR_Pathology_MTitleControlIdToReplace, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, AV72TFBR_Pathology_N_Sels, AV84TFBR_Pathology_M_Sels, AV131Pgmname, AV61IsAuthorized_Update, AV63IsAuthorized_Delete, AV64IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_PathologyID, AV18TFBR_PathologyID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_PathologyID_TestID, AV30TFBR_PathologyID_TestID_To, AV33TFBR_PathologyID_PADate, AV34TFBR_PathologyID_PADate_To, AV39TFBR_PathologyID_PAHosp, AV40TFBR_PathologyID_PAHosp_Sel, AV43TFBR_PathologyID_PAAge, AV44TFBR_PathologyID_PAAge_To, AV47TFBR_PathologyID_PrePaDia, AV48TFBR_PathologyID_PrePaDia_Sel, AV51TFBR_PathologyID_PAResult, AV52TFBR_PathologyID_PAResult_Sel, AV91TFBR_Pathology_Dia_Name, AV92TFBR_Pathology_Dia_Name_Sel, AV67TFBR_Pathology_T, AV68TFBR_Pathology_T_To, AV75TFBR_Pathology_LymphNum, AV76TFBR_Pathology_LymphNum_To, AV79TFBR_Pathology_LymphRate, AV80TFBR_Pathology_LymphRate_Sel, AV87TFBR_Pathology_MetaLoc, AV88TFBR_Pathology_MetaLoc_Sel, AV19ddo_BR_PathologyIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV69ddo_BR_Pathology_TTitleControlIdToReplace, AV73ddo_BR_Pathology_NTitleControlIdToReplace, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV85ddo_BR_Pathology_MTitleControlIdToReplace, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, AV72TFBR_Pathology_N_Sels, AV84TFBR_Pathology_M_Sels, AV131Pgmname, AV61IsAuthorized_Update, AV63IsAuthorized_Delete, AV64IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_PathologyID, AV18TFBR_PathologyID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Information_PatientNo, AV26TFBR_Information_PatientNo_Sel, AV29TFBR_PathologyID_TestID, AV30TFBR_PathologyID_TestID_To, AV33TFBR_PathologyID_PADate, AV34TFBR_PathologyID_PADate_To, AV39TFBR_PathologyID_PAHosp, AV40TFBR_PathologyID_PAHosp_Sel, AV43TFBR_PathologyID_PAAge, AV44TFBR_PathologyID_PAAge_To, AV47TFBR_PathologyID_PrePaDia, AV48TFBR_PathologyID_PrePaDia_Sel, AV51TFBR_PathologyID_PAResult, AV52TFBR_PathologyID_PAResult_Sel, AV91TFBR_Pathology_Dia_Name, AV92TFBR_Pathology_Dia_Name_Sel, AV67TFBR_Pathology_T, AV68TFBR_Pathology_T_To, AV75TFBR_Pathology_LymphNum, AV76TFBR_Pathology_LymphNum_To, AV79TFBR_Pathology_LymphRate, AV80TFBR_Pathology_LymphRate_Sel, AV87TFBR_Pathology_MetaLoc, AV88TFBR_Pathology_MetaLoc_Sel, AV19ddo_BR_PathologyIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, AV69ddo_BR_Pathology_TTitleControlIdToReplace, AV73ddo_BR_Pathology_NTitleControlIdToReplace, AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, AV85ddo_BR_Pathology_MTitleControlIdToReplace, AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, AV72TFBR_Pathology_N_Sels, AV84TFBR_Pathology_M_Sels, AV131Pgmname, AV61IsAuthorized_Update, AV63IsAuthorized_Delete, AV64IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5C0( )
      {
         /* Before Start, stand alone formulas. */
         AV131Pgmname = "BR_PathologyWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E305C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV54DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYIDTITLEFILTERDATA"), AV16BR_PathologyIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV20BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV24BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA"), AV28BR_PathologyID_TestIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PADATETITLEFILTERDATA"), AV32BR_PathologyID_PADateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA"), AV38BR_PathologyID_PAHospTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PAAGETITLEFILTERDATA"), AV42BR_PathologyID_PAAgeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA"), AV46BR_PathologyID_PrePaDiaTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA"), AV50BR_PathologyID_PAResultTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA"), AV90BR_Pathology_Dia_NameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_TTITLEFILTERDATA"), AV66BR_Pathology_TTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_NTITLEFILTERDATA"), AV70BR_Pathology_NTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA"), AV74BR_Pathology_LymphNumTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA"), AV78BR_Pathology_LymphRateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_MTITLEFILTERDATA"), AV82BR_Pathology_MTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PATHOLOGY_METALOCTITLEFILTERDATA"), AV86BR_Pathology_MetaLocTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_PathologyIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_PathologyIDTitleControlIdToReplace", AV19ddo_BR_PathologyIDTitleControlIdToReplace);
            AV23ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
            AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Information_PatientNoTitleControlIdToReplace", AV27ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace", AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace);
            AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace", AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace);
            AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace", AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace);
            AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace", AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace);
            AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace", AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace);
            AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace = cgiGet( edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace", AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace);
            AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace", AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace);
            AV69ddo_BR_Pathology_TTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_BR_Pathology_TTitleControlIdToReplace", AV69ddo_BR_Pathology_TTitleControlIdToReplace);
            AV73ddo_BR_Pathology_NTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73ddo_BR_Pathology_NTitleControlIdToReplace", AV73ddo_BR_Pathology_NTitleControlIdToReplace);
            AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace", AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace);
            AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace", AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace);
            AV85ddo_BR_Pathology_MTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85ddo_BR_Pathology_MTitleControlIdToReplace", AV85ddo_BR_Pathology_MTitleControlIdToReplace);
            AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace = cgiGet( edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace", AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID");
               GX_FocusControl = edtavTfbr_pathologyid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_PathologyID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_PathologyID), 18, 0)));
            }
            else
            {
               AV17TFBR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_PathologyID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_TO");
               GX_FocusControl = edtavTfbr_pathologyid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_PathologyID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_PathologyID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_PathologyID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_PathologyID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID");
               GX_FocusControl = edtavTfbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            else
            {
               AV21TFBR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfbr_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            AV25TFBR_Information_PatientNo = cgiGet( edtavTfbr_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Information_PatientNo", AV25TFBR_Information_PatientNo);
            AV26TFBR_Information_PatientNo_Sel = cgiGet( edtavTfbr_information_patientno_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Information_PatientNo_Sel", AV26TFBR_Information_PatientNo_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_testid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_testid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_TESTID");
               GX_FocusControl = edtavTfbr_pathologyid_testid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29TFBR_PathologyID_TestID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0)));
            }
            else
            {
               AV29TFBR_PathologyID_TestID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_testid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_testid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_testid_to_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_TESTID_TO");
               GX_FocusControl = edtavTfbr_pathologyid_testid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30TFBR_PathologyID_TestID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_PathologyID_TestID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0)));
            }
            else
            {
               AV30TFBR_PathologyID_TestID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_testid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_PathologyID_TestID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_pathologyid_padate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Pathology ID_PADate"}), 1, "vTFBR_PATHOLOGYID_PADATE");
               GX_FocusControl = edtavTfbr_pathologyid_padate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV33TFBR_PathologyID_PADate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_PathologyID_PADate", context.localUtil.Format(AV33TFBR_PathologyID_PADate, "9999/99/99"));
            }
            else
            {
               AV33TFBR_PathologyID_PADate = context.localUtil.CToD( cgiGet( edtavTfbr_pathologyid_padate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_PathologyID_PADate", context.localUtil.Format(AV33TFBR_PathologyID_PADate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_pathologyid_padate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Pathology ID_PADate_To"}), 1, "vTFBR_PATHOLOGYID_PADATE_TO");
               GX_FocusControl = edtavTfbr_pathologyid_padate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV34TFBR_PathologyID_PADate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_PathologyID_PADate_To", context.localUtil.Format(AV34TFBR_PathologyID_PADate_To, "9999/99/99"));
            }
            else
            {
               AV34TFBR_PathologyID_PADate_To = context.localUtil.CToD( cgiGet( edtavTfbr_pathologyid_padate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_PathologyID_PADate_To", context.localUtil.Format(AV34TFBR_PathologyID_PADate_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_pathologyid_padateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Pathology ID_PADate Aux Date"}), 1, "vDDO_BR_PATHOLOGYID_PADATEAUXDATE");
               GX_FocusControl = edtavDdo_br_pathologyid_padateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV35DDO_BR_PathologyID_PADateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35DDO_BR_PathologyID_PADateAuxDate", context.localUtil.Format(AV35DDO_BR_PathologyID_PADateAuxDate, "9999/99/99"));
            }
            else
            {
               AV35DDO_BR_PathologyID_PADateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_pathologyid_padateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35DDO_BR_PathologyID_PADateAuxDate", context.localUtil.Format(AV35DDO_BR_PathologyID_PADateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_pathologyid_padateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Pathology ID_PADate Aux Date To"}), 1, "vDDO_BR_PATHOLOGYID_PADATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_pathologyid_padateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV36DDO_BR_PathologyID_PADateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36DDO_BR_PathologyID_PADateAuxDateTo", context.localUtil.Format(AV36DDO_BR_PathologyID_PADateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV36DDO_BR_PathologyID_PADateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_pathologyid_padateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36DDO_BR_PathologyID_PADateAuxDateTo", context.localUtil.Format(AV36DDO_BR_PathologyID_PADateAuxDateTo, "9999/99/99"));
            }
            AV39TFBR_PathologyID_PAHosp = cgiGet( edtavTfbr_pathologyid_pahosp_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_PathologyID_PAHosp", AV39TFBR_PathologyID_PAHosp);
            AV40TFBR_PathologyID_PAHosp_Sel = cgiGet( edtavTfbr_pathologyid_pahosp_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_PathologyID_PAHosp_Sel", AV40TFBR_PathologyID_PAHosp_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_paage_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_paage_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_PAAGE");
               GX_FocusControl = edtavTfbr_pathologyid_paage_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV43TFBR_PathologyID_PAAge = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0)));
            }
            else
            {
               AV43TFBR_PathologyID_PAAge = (short)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_paage_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_paage_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_paage_to_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGYID_PAAGE_TO");
               GX_FocusControl = edtavTfbr_pathologyid_paage_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV44TFBR_PathologyID_PAAge_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_PathologyID_PAAge_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0)));
            }
            else
            {
               AV44TFBR_PathologyID_PAAge_To = (short)(context.localUtil.CToN( cgiGet( edtavTfbr_pathologyid_paage_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_PathologyID_PAAge_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0)));
            }
            AV47TFBR_PathologyID_PrePaDia = cgiGet( edtavTfbr_pathologyid_prepadia_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_PathologyID_PrePaDia", AV47TFBR_PathologyID_PrePaDia);
            AV48TFBR_PathologyID_PrePaDia_Sel = cgiGet( edtavTfbr_pathologyid_prepadia_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_PathologyID_PrePaDia_Sel", AV48TFBR_PathologyID_PrePaDia_Sel);
            AV51TFBR_PathologyID_PAResult = cgiGet( edtavTfbr_pathologyid_paresult_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_PathologyID_PAResult", AV51TFBR_PathologyID_PAResult);
            AV52TFBR_PathologyID_PAResult_Sel = cgiGet( edtavTfbr_pathologyid_paresult_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_PathologyID_PAResult_Sel", AV52TFBR_PathologyID_PAResult_Sel);
            AV91TFBR_Pathology_Dia_Name = cgiGet( edtavTfbr_pathology_dia_name_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFBR_Pathology_Dia_Name", AV91TFBR_Pathology_Dia_Name);
            AV92TFBR_Pathology_Dia_Name_Sel = cgiGet( edtavTfbr_pathology_dia_name_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV92TFBR_Pathology_Dia_Name_Sel", AV92TFBR_Pathology_Dia_Name_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_t_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_t_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_T");
               GX_FocusControl = edtavTfbr_pathology_t_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV67TFBR_Pathology_T = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFBR_Pathology_T", StringUtil.LTrim( StringUtil.Str( AV67TFBR_Pathology_T, 15, 5)));
            }
            else
            {
               AV67TFBR_Pathology_T = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_t_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFBR_Pathology_T", StringUtil.LTrim( StringUtil.Str( AV67TFBR_Pathology_T, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_t_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_t_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_T_TO");
               GX_FocusControl = edtavTfbr_pathology_t_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV68TFBR_Pathology_T_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Pathology_T_To", StringUtil.LTrim( StringUtil.Str( AV68TFBR_Pathology_T_To, 15, 5)));
            }
            else
            {
               AV68TFBR_Pathology_T_To = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_t_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Pathology_T_To", StringUtil.LTrim( StringUtil.Str( AV68TFBR_Pathology_T_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_lymphnum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_lymphnum_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_LYMPHNUM");
               GX_FocusControl = edtavTfbr_pathology_lymphnum_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV75TFBR_Pathology_LymphNum = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75TFBR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( AV75TFBR_Pathology_LymphNum, 15, 5)));
            }
            else
            {
               AV75TFBR_Pathology_LymphNum = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_lymphnum_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75TFBR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( AV75TFBR_Pathology_LymphNum, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_lymphnum_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_pathology_lymphnum_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PATHOLOGY_LYMPHNUM_TO");
               GX_FocusControl = edtavTfbr_pathology_lymphnum_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV76TFBR_Pathology_LymphNum_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76TFBR_Pathology_LymphNum_To", StringUtil.LTrim( StringUtil.Str( AV76TFBR_Pathology_LymphNum_To, 15, 5)));
            }
            else
            {
               AV76TFBR_Pathology_LymphNum_To = context.localUtil.CToN( cgiGet( edtavTfbr_pathology_lymphnum_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76TFBR_Pathology_LymphNum_To", StringUtil.LTrim( StringUtil.Str( AV76TFBR_Pathology_LymphNum_To, 15, 5)));
            }
            AV79TFBR_Pathology_LymphRate = cgiGet( edtavTfbr_pathology_lymphrate_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFBR_Pathology_LymphRate", AV79TFBR_Pathology_LymphRate);
            AV80TFBR_Pathology_LymphRate_Sel = cgiGet( edtavTfbr_pathology_lymphrate_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_Pathology_LymphRate_Sel", AV80TFBR_Pathology_LymphRate_Sel);
            AV87TFBR_Pathology_MetaLoc = cgiGet( edtavTfbr_pathology_metaloc_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFBR_Pathology_MetaLoc", AV87TFBR_Pathology_MetaLoc);
            AV88TFBR_Pathology_MetaLoc_Sel = cgiGet( edtavTfbr_pathology_metaloc_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFBR_Pathology_MetaLoc_Sel", AV88TFBR_Pathology_MetaLoc_Sel);
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV56GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV58GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV57GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( "GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( "GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( "GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( "GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( "GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( "GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_pathologyid_Caption = cgiGet( "DDO_BR_PATHOLOGYID_Caption");
            Ddo_br_pathologyid_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_Tooltip");
            Ddo_br_pathologyid_Cls = cgiGet( "DDO_BR_PATHOLOGYID_Cls");
            Ddo_br_pathologyid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_set");
            Ddo_br_pathologyid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_set");
            Ddo_br_pathologyid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_Dropdownoptionstype");
            Ddo_br_pathologyid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortasc"));
            Ddo_br_pathologyid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includesortdsc"));
            Ddo_br_pathologyid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_Sortedstatus");
            Ddo_br_pathologyid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includefilter"));
            Ddo_br_pathologyid_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_Filtertype");
            Ddo_br_pathologyid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Filterisrange"));
            Ddo_br_pathologyid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_Includedatalist"));
            Ddo_br_pathologyid_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_Sortasc");
            Ddo_br_pathologyid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_Sortdsc");
            Ddo_br_pathologyid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_Cleanfilter");
            Ddo_br_pathologyid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGYID_Rangefilterfrom");
            Ddo_br_pathologyid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGYID_Rangefilterto");
            Ddo_br_pathologyid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_Searchbuttontext");
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_set");
            Ddo_br_encounterid_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_set");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Filtertype = cgiGet( "DDO_BR_ENCOUNTERID_Filtertype");
            Ddo_br_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Filterisrange"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTERID_Cleanfilter");
            Ddo_br_encounterid_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterfrom");
            Ddo_br_encounterid_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterto");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_information_patientno_Caption = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Caption");
            Ddo_br_information_patientno_Tooltip = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Tooltip");
            Ddo_br_information_patientno_Cls = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cls");
            Ddo_br_information_patientno_Filteredtext_set = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_set");
            Ddo_br_information_patientno_Selectedvalue_set = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_set");
            Ddo_br_information_patientno_Dropdownoptionstype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_br_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_br_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_br_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_br_information_patientno_Sortedstatus = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_br_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_br_information_patientno_Filtertype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filtertype");
            Ddo_br_information_patientno_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filterisrange"));
            Ddo_br_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_br_information_patientno_Datalisttype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalisttype");
            Ddo_br_information_patientno_Datalistproc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalistproc");
            Ddo_br_information_patientno_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_information_patientno_Sortasc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortasc");
            Ddo_br_information_patientno_Sortdsc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_br_information_patientno_Loadingdata = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Loadingdata");
            Ddo_br_information_patientno_Cleanfilter = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cleanfilter");
            Ddo_br_information_patientno_Noresultsfound = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Noresultsfound");
            Ddo_br_information_patientno_Searchbuttontext = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_br_pathologyid_testid_Caption = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Caption");
            Ddo_br_pathologyid_testid_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Tooltip");
            Ddo_br_pathologyid_testid_Cls = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Cls");
            Ddo_br_pathologyid_testid_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Filteredtext_set");
            Ddo_br_pathologyid_testid_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Filteredtextto_set");
            Ddo_br_pathologyid_testid_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Dropdownoptionstype");
            Ddo_br_pathologyid_testid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_testid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includesortasc"));
            Ddo_br_pathologyid_testid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includesortdsc"));
            Ddo_br_pathologyid_testid_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Sortedstatus");
            Ddo_br_pathologyid_testid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includefilter"));
            Ddo_br_pathologyid_testid_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Filtertype");
            Ddo_br_pathologyid_testid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Filterisrange"));
            Ddo_br_pathologyid_testid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Includedatalist"));
            Ddo_br_pathologyid_testid_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Sortasc");
            Ddo_br_pathologyid_testid_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Sortdsc");
            Ddo_br_pathologyid_testid_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Cleanfilter");
            Ddo_br_pathologyid_testid_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Rangefilterfrom");
            Ddo_br_pathologyid_testid_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Rangefilterto");
            Ddo_br_pathologyid_testid_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Searchbuttontext");
            Ddo_br_pathologyid_padate_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Caption");
            Ddo_br_pathologyid_padate_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Tooltip");
            Ddo_br_pathologyid_padate_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Cls");
            Ddo_br_pathologyid_padate_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Filteredtext_set");
            Ddo_br_pathologyid_padate_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Filteredtextto_set");
            Ddo_br_pathologyid_padate_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Dropdownoptionstype");
            Ddo_br_pathologyid_padate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_padate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includesortasc"));
            Ddo_br_pathologyid_padate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includesortdsc"));
            Ddo_br_pathologyid_padate_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Sortedstatus");
            Ddo_br_pathologyid_padate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includefilter"));
            Ddo_br_pathologyid_padate_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Filtertype");
            Ddo_br_pathologyid_padate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Filterisrange"));
            Ddo_br_pathologyid_padate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Includedatalist"));
            Ddo_br_pathologyid_padate_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Sortasc");
            Ddo_br_pathologyid_padate_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Sortdsc");
            Ddo_br_pathologyid_padate_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Cleanfilter");
            Ddo_br_pathologyid_padate_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Rangefilterfrom");
            Ddo_br_pathologyid_padate_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Rangefilterto");
            Ddo_br_pathologyid_padate_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Searchbuttontext");
            Ddo_br_pathologyid_pahosp_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Caption");
            Ddo_br_pathologyid_pahosp_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Tooltip");
            Ddo_br_pathologyid_pahosp_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Cls");
            Ddo_br_pathologyid_pahosp_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Filteredtext_set");
            Ddo_br_pathologyid_pahosp_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Selectedvalue_set");
            Ddo_br_pathologyid_pahosp_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Dropdownoptionstype");
            Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_pahosp_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includesortasc"));
            Ddo_br_pathologyid_pahosp_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includesortdsc"));
            Ddo_br_pathologyid_pahosp_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Sortedstatus");
            Ddo_br_pathologyid_pahosp_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includefilter"));
            Ddo_br_pathologyid_pahosp_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Filtertype");
            Ddo_br_pathologyid_pahosp_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Filterisrange"));
            Ddo_br_pathologyid_pahosp_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Includedatalist"));
            Ddo_br_pathologyid_pahosp_Datalisttype = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Datalisttype");
            Ddo_br_pathologyid_pahosp_Datalistproc = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Datalistproc");
            Ddo_br_pathologyid_pahosp_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathologyid_pahosp_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Sortasc");
            Ddo_br_pathologyid_pahosp_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Sortdsc");
            Ddo_br_pathologyid_pahosp_Loadingdata = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Loadingdata");
            Ddo_br_pathologyid_pahosp_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Cleanfilter");
            Ddo_br_pathologyid_pahosp_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Noresultsfound");
            Ddo_br_pathologyid_pahosp_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Searchbuttontext");
            Ddo_br_pathologyid_paage_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Caption");
            Ddo_br_pathologyid_paage_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Tooltip");
            Ddo_br_pathologyid_paage_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Cls");
            Ddo_br_pathologyid_paage_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Filteredtext_set");
            Ddo_br_pathologyid_paage_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Filteredtextto_set");
            Ddo_br_pathologyid_paage_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Dropdownoptionstype");
            Ddo_br_pathologyid_paage_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_paage_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includesortasc"));
            Ddo_br_pathologyid_paage_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includesortdsc"));
            Ddo_br_pathologyid_paage_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Sortedstatus");
            Ddo_br_pathologyid_paage_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includefilter"));
            Ddo_br_pathologyid_paage_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Filtertype");
            Ddo_br_pathologyid_paage_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Filterisrange"));
            Ddo_br_pathologyid_paage_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Includedatalist"));
            Ddo_br_pathologyid_paage_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Sortasc");
            Ddo_br_pathologyid_paage_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Sortdsc");
            Ddo_br_pathologyid_paage_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Cleanfilter");
            Ddo_br_pathologyid_paage_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Rangefilterfrom");
            Ddo_br_pathologyid_paage_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Rangefilterto");
            Ddo_br_pathologyid_paage_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Searchbuttontext");
            Ddo_br_pathologyid_prepadia_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Caption");
            Ddo_br_pathologyid_prepadia_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Tooltip");
            Ddo_br_pathologyid_prepadia_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Cls");
            Ddo_br_pathologyid_prepadia_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Filteredtext_set");
            Ddo_br_pathologyid_prepadia_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Selectedvalue_set");
            Ddo_br_pathologyid_prepadia_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Dropdownoptionstype");
            Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_prepadia_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includesortasc"));
            Ddo_br_pathologyid_prepadia_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includesortdsc"));
            Ddo_br_pathologyid_prepadia_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Sortedstatus");
            Ddo_br_pathologyid_prepadia_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includefilter"));
            Ddo_br_pathologyid_prepadia_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Filtertype");
            Ddo_br_pathologyid_prepadia_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Filterisrange"));
            Ddo_br_pathologyid_prepadia_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Includedatalist"));
            Ddo_br_pathologyid_prepadia_Datalisttype = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Datalisttype");
            Ddo_br_pathologyid_prepadia_Datalistproc = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Datalistproc");
            Ddo_br_pathologyid_prepadia_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathologyid_prepadia_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Sortasc");
            Ddo_br_pathologyid_prepadia_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Sortdsc");
            Ddo_br_pathologyid_prepadia_Loadingdata = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Loadingdata");
            Ddo_br_pathologyid_prepadia_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Cleanfilter");
            Ddo_br_pathologyid_prepadia_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Noresultsfound");
            Ddo_br_pathologyid_prepadia_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Searchbuttontext");
            Ddo_br_pathologyid_paresult_Caption = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Caption");
            Ddo_br_pathologyid_paresult_Tooltip = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Tooltip");
            Ddo_br_pathologyid_paresult_Cls = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Cls");
            Ddo_br_pathologyid_paresult_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Filteredtext_set");
            Ddo_br_pathologyid_paresult_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Selectedvalue_set");
            Ddo_br_pathologyid_paresult_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Dropdownoptionstype");
            Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Titlecontrolidtoreplace");
            Ddo_br_pathologyid_paresult_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includesortasc"));
            Ddo_br_pathologyid_paresult_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includesortdsc"));
            Ddo_br_pathologyid_paresult_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Sortedstatus");
            Ddo_br_pathologyid_paresult_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includefilter"));
            Ddo_br_pathologyid_paresult_Filtertype = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Filtertype");
            Ddo_br_pathologyid_paresult_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Filterisrange"));
            Ddo_br_pathologyid_paresult_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Includedatalist"));
            Ddo_br_pathologyid_paresult_Datalisttype = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Datalisttype");
            Ddo_br_pathologyid_paresult_Datalistproc = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Datalistproc");
            Ddo_br_pathologyid_paresult_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathologyid_paresult_Sortasc = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Sortasc");
            Ddo_br_pathologyid_paresult_Sortdsc = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Sortdsc");
            Ddo_br_pathologyid_paresult_Loadingdata = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Loadingdata");
            Ddo_br_pathologyid_paresult_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Cleanfilter");
            Ddo_br_pathologyid_paresult_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Noresultsfound");
            Ddo_br_pathologyid_paresult_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Searchbuttontext");
            Ddo_br_pathology_dia_name_Caption = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Caption");
            Ddo_br_pathology_dia_name_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Tooltip");
            Ddo_br_pathology_dia_name_Cls = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Cls");
            Ddo_br_pathology_dia_name_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Filteredtext_set");
            Ddo_br_pathology_dia_name_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Selectedvalue_set");
            Ddo_br_pathology_dia_name_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Dropdownoptionstype");
            Ddo_br_pathology_dia_name_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Titlecontrolidtoreplace");
            Ddo_br_pathology_dia_name_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includesortasc"));
            Ddo_br_pathology_dia_name_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includesortdsc"));
            Ddo_br_pathology_dia_name_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Sortedstatus");
            Ddo_br_pathology_dia_name_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includefilter"));
            Ddo_br_pathology_dia_name_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Filtertype");
            Ddo_br_pathology_dia_name_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Filterisrange"));
            Ddo_br_pathology_dia_name_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Includedatalist"));
            Ddo_br_pathology_dia_name_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Datalisttype");
            Ddo_br_pathology_dia_name_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Datalistproc");
            Ddo_br_pathology_dia_name_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_dia_name_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Sortasc");
            Ddo_br_pathology_dia_name_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Sortdsc");
            Ddo_br_pathology_dia_name_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Loadingdata");
            Ddo_br_pathology_dia_name_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Cleanfilter");
            Ddo_br_pathology_dia_name_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Noresultsfound");
            Ddo_br_pathology_dia_name_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Searchbuttontext");
            Ddo_br_pathology_t_Caption = cgiGet( "DDO_BR_PATHOLOGY_T_Caption");
            Ddo_br_pathology_t_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_T_Tooltip");
            Ddo_br_pathology_t_Cls = cgiGet( "DDO_BR_PATHOLOGY_T_Cls");
            Ddo_br_pathology_t_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_T_Filteredtext_set");
            Ddo_br_pathology_t_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_T_Filteredtextto_set");
            Ddo_br_pathology_t_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_T_Dropdownoptionstype");
            Ddo_br_pathology_t_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_T_Titlecontrolidtoreplace");
            Ddo_br_pathology_t_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includesortasc"));
            Ddo_br_pathology_t_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includesortdsc"));
            Ddo_br_pathology_t_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_T_Sortedstatus");
            Ddo_br_pathology_t_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includefilter"));
            Ddo_br_pathology_t_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_T_Filtertype");
            Ddo_br_pathology_t_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Filterisrange"));
            Ddo_br_pathology_t_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_T_Includedatalist"));
            Ddo_br_pathology_t_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_T_Sortasc");
            Ddo_br_pathology_t_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_T_Sortdsc");
            Ddo_br_pathology_t_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_T_Cleanfilter");
            Ddo_br_pathology_t_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_T_Rangefilterfrom");
            Ddo_br_pathology_t_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_T_Rangefilterto");
            Ddo_br_pathology_t_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_T_Searchbuttontext");
            Ddo_br_pathology_n_Caption = cgiGet( "DDO_BR_PATHOLOGY_N_Caption");
            Ddo_br_pathology_n_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_N_Tooltip");
            Ddo_br_pathology_n_Cls = cgiGet( "DDO_BR_PATHOLOGY_N_Cls");
            Ddo_br_pathology_n_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_N_Selectedvalue_set");
            Ddo_br_pathology_n_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_N_Dropdownoptionstype");
            Ddo_br_pathology_n_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_N_Titlecontrolidtoreplace");
            Ddo_br_pathology_n_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includesortasc"));
            Ddo_br_pathology_n_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includesortdsc"));
            Ddo_br_pathology_n_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_N_Sortedstatus");
            Ddo_br_pathology_n_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includefilter"));
            Ddo_br_pathology_n_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Includedatalist"));
            Ddo_br_pathology_n_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_N_Datalisttype");
            Ddo_br_pathology_n_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_N_Allowmultipleselection"));
            Ddo_br_pathology_n_Datalistfixedvalues = cgiGet( "DDO_BR_PATHOLOGY_N_Datalistfixedvalues");
            Ddo_br_pathology_n_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_N_Sortasc");
            Ddo_br_pathology_n_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_N_Sortdsc");
            Ddo_br_pathology_n_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_N_Cleanfilter");
            Ddo_br_pathology_n_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_N_Searchbuttontext");
            Ddo_br_pathology_lymphnum_Caption = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Caption");
            Ddo_br_pathology_lymphnum_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Tooltip");
            Ddo_br_pathology_lymphnum_Cls = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Cls");
            Ddo_br_pathology_lymphnum_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtext_set");
            Ddo_br_pathology_lymphnum_Filteredtextto_set = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtextto_set");
            Ddo_br_pathology_lymphnum_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Dropdownoptionstype");
            Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Titlecontrolidtoreplace");
            Ddo_br_pathology_lymphnum_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortasc"));
            Ddo_br_pathology_lymphnum_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includesortdsc"));
            Ddo_br_pathology_lymphnum_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Sortedstatus");
            Ddo_br_pathology_lymphnum_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includefilter"));
            Ddo_br_pathology_lymphnum_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Filtertype");
            Ddo_br_pathology_lymphnum_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Filterisrange"));
            Ddo_br_pathology_lymphnum_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Includedatalist"));
            Ddo_br_pathology_lymphnum_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Sortasc");
            Ddo_br_pathology_lymphnum_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Sortdsc");
            Ddo_br_pathology_lymphnum_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Cleanfilter");
            Ddo_br_pathology_lymphnum_Rangefilterfrom = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Rangefilterfrom");
            Ddo_br_pathology_lymphnum_Rangefilterto = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Rangefilterto");
            Ddo_br_pathology_lymphnum_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Searchbuttontext");
            Ddo_br_pathology_lymphrate_Caption = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Caption");
            Ddo_br_pathology_lymphrate_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Tooltip");
            Ddo_br_pathology_lymphrate_Cls = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Cls");
            Ddo_br_pathology_lymphrate_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Filteredtext_set");
            Ddo_br_pathology_lymphrate_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Selectedvalue_set");
            Ddo_br_pathology_lymphrate_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Dropdownoptionstype");
            Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Titlecontrolidtoreplace");
            Ddo_br_pathology_lymphrate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortasc"));
            Ddo_br_pathology_lymphrate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includesortdsc"));
            Ddo_br_pathology_lymphrate_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Sortedstatus");
            Ddo_br_pathology_lymphrate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includefilter"));
            Ddo_br_pathology_lymphrate_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Filtertype");
            Ddo_br_pathology_lymphrate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Filterisrange"));
            Ddo_br_pathology_lymphrate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Includedatalist"));
            Ddo_br_pathology_lymphrate_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Datalisttype");
            Ddo_br_pathology_lymphrate_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Datalistproc");
            Ddo_br_pathology_lymphrate_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_lymphrate_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Sortasc");
            Ddo_br_pathology_lymphrate_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Sortdsc");
            Ddo_br_pathology_lymphrate_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Loadingdata");
            Ddo_br_pathology_lymphrate_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Cleanfilter");
            Ddo_br_pathology_lymphrate_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Noresultsfound");
            Ddo_br_pathology_lymphrate_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Searchbuttontext");
            Ddo_br_pathology_m_Caption = cgiGet( "DDO_BR_PATHOLOGY_M_Caption");
            Ddo_br_pathology_m_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_M_Tooltip");
            Ddo_br_pathology_m_Cls = cgiGet( "DDO_BR_PATHOLOGY_M_Cls");
            Ddo_br_pathology_m_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_M_Selectedvalue_set");
            Ddo_br_pathology_m_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_M_Dropdownoptionstype");
            Ddo_br_pathology_m_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_M_Titlecontrolidtoreplace");
            Ddo_br_pathology_m_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includesortasc"));
            Ddo_br_pathology_m_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includesortdsc"));
            Ddo_br_pathology_m_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_M_Sortedstatus");
            Ddo_br_pathology_m_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includefilter"));
            Ddo_br_pathology_m_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Includedatalist"));
            Ddo_br_pathology_m_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_M_Datalisttype");
            Ddo_br_pathology_m_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_M_Allowmultipleselection"));
            Ddo_br_pathology_m_Datalistfixedvalues = cgiGet( "DDO_BR_PATHOLOGY_M_Datalistfixedvalues");
            Ddo_br_pathology_m_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_M_Sortasc");
            Ddo_br_pathology_m_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_M_Sortdsc");
            Ddo_br_pathology_m_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_M_Cleanfilter");
            Ddo_br_pathology_m_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_M_Searchbuttontext");
            Ddo_br_pathology_metaloc_Caption = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Caption");
            Ddo_br_pathology_metaloc_Tooltip = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Tooltip");
            Ddo_br_pathology_metaloc_Cls = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Cls");
            Ddo_br_pathology_metaloc_Filteredtext_set = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Filteredtext_set");
            Ddo_br_pathology_metaloc_Selectedvalue_set = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Selectedvalue_set");
            Ddo_br_pathology_metaloc_Dropdownoptionstype = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Dropdownoptionstype");
            Ddo_br_pathology_metaloc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Titlecontrolidtoreplace");
            Ddo_br_pathology_metaloc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includesortasc"));
            Ddo_br_pathology_metaloc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includesortdsc"));
            Ddo_br_pathology_metaloc_Sortedstatus = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Sortedstatus");
            Ddo_br_pathology_metaloc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includefilter"));
            Ddo_br_pathology_metaloc_Filtertype = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Filtertype");
            Ddo_br_pathology_metaloc_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Filterisrange"));
            Ddo_br_pathology_metaloc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Includedatalist"));
            Ddo_br_pathology_metaloc_Datalisttype = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Datalisttype");
            Ddo_br_pathology_metaloc_Datalistproc = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Datalistproc");
            Ddo_br_pathology_metaloc_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_PATHOLOGY_METALOC_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_pathology_metaloc_Sortasc = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Sortasc");
            Ddo_br_pathology_metaloc_Sortdsc = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Sortdsc");
            Ddo_br_pathology_metaloc_Loadingdata = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Loadingdata");
            Ddo_br_pathology_metaloc_Cleanfilter = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Cleanfilter");
            Ddo_br_pathology_metaloc_Noresultsfound = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Noresultsfound");
            Ddo_br_pathology_metaloc_Searchbuttontext = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_pathologyid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_Activeeventkey");
            Ddo_br_pathologyid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtext_get");
            Ddo_br_pathologyid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_Filteredtextto_get");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_get");
            Ddo_br_encounterid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_get");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_information_patientno_Filteredtext_get = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get");
            Ddo_br_information_patientno_Selectedvalue_get = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get");
            Ddo_br_pathologyid_testid_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Activeeventkey");
            Ddo_br_pathologyid_testid_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Filteredtext_get");
            Ddo_br_pathologyid_testid_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_TESTID_Filteredtextto_get");
            Ddo_br_pathologyid_padate_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Activeeventkey");
            Ddo_br_pathologyid_padate_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Filteredtext_get");
            Ddo_br_pathologyid_padate_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_PADATE_Filteredtextto_get");
            Ddo_br_pathologyid_pahosp_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Activeeventkey");
            Ddo_br_pathologyid_pahosp_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Filteredtext_get");
            Ddo_br_pathologyid_pahosp_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGYID_PAHOSP_Selectedvalue_get");
            Ddo_br_pathologyid_paage_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Activeeventkey");
            Ddo_br_pathologyid_paage_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Filteredtext_get");
            Ddo_br_pathologyid_paage_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGYID_PAAGE_Filteredtextto_get");
            Ddo_br_pathologyid_prepadia_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Activeeventkey");
            Ddo_br_pathologyid_prepadia_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Filteredtext_get");
            Ddo_br_pathologyid_prepadia_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGYID_PREPADIA_Selectedvalue_get");
            Ddo_br_pathologyid_paresult_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Activeeventkey");
            Ddo_br_pathologyid_paresult_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Filteredtext_get");
            Ddo_br_pathologyid_paresult_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGYID_PARESULT_Selectedvalue_get");
            Ddo_br_pathology_dia_name_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Activeeventkey");
            Ddo_br_pathology_dia_name_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Filteredtext_get");
            Ddo_br_pathology_dia_name_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_DIA_NAME_Selectedvalue_get");
            Ddo_br_pathology_t_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_T_Activeeventkey");
            Ddo_br_pathology_t_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_T_Filteredtext_get");
            Ddo_br_pathology_t_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_T_Filteredtextto_get");
            Ddo_br_pathology_n_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_N_Activeeventkey");
            Ddo_br_pathology_n_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_N_Selectedvalue_get");
            Ddo_br_pathology_lymphnum_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Activeeventkey");
            Ddo_br_pathology_lymphnum_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtext_get");
            Ddo_br_pathology_lymphnum_Filteredtextto_get = cgiGet( "DDO_BR_PATHOLOGY_LYMPHNUM_Filteredtextto_get");
            Ddo_br_pathology_lymphrate_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Activeeventkey");
            Ddo_br_pathology_lymphrate_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Filteredtext_get");
            Ddo_br_pathology_lymphrate_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_LYMPHRATE_Selectedvalue_get");
            Ddo_br_pathology_m_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_M_Activeeventkey");
            Ddo_br_pathology_m_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_M_Selectedvalue_get");
            Ddo_br_pathology_metaloc_Activeeventkey = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Activeeventkey");
            Ddo_br_pathology_metaloc_Filteredtext_get = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Filteredtext_get");
            Ddo_br_pathology_metaloc_Selectedvalue_get = cgiGet( "DDO_BR_PATHOLOGY_METALOC_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID"), ".", ",") != Convert.ToDecimal( AV17TFBR_PathologyID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_PathologyID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO"), AV25TFBR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO_SEL"), AV26TFBR_Information_PatientNo_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TESTID"), ".", ",") != Convert.ToDecimal( AV29TFBR_PathologyID_TestID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_TESTID_TO"), ".", ",") != Convert.ToDecimal( AV30TFBR_PathologyID_TestID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_PATHOLOGYID_PADATE"), 0) != AV33TFBR_PathologyID_PADate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_PATHOLOGYID_PADATE_TO"), 0) != AV34TFBR_PathologyID_PADate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PAHOSP"), AV39TFBR_PathologyID_PAHosp) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PAHOSP_SEL"), AV40TFBR_PathologyID_PAHosp_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_PAAGE"), ".", ",") != Convert.ToDecimal( AV43TFBR_PathologyID_PAAge )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGYID_PAAGE_TO"), ".", ",") != Convert.ToDecimal( AV44TFBR_PathologyID_PAAge_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PREPADIA"), AV47TFBR_PathologyID_PrePaDia) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PREPADIA_SEL"), AV48TFBR_PathologyID_PrePaDia_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PARESULT"), AV51TFBR_PathologyID_PAResult) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGYID_PARESULT_SEL"), AV52TFBR_PathologyID_PAResult_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIA_NAME"), AV91TFBR_Pathology_Dia_Name) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_DIA_NAME_SEL"), AV92TFBR_Pathology_Dia_Name_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_T"), ".", ",") != AV67TFBR_Pathology_T )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_T_TO"), ".", ",") != AV68TFBR_Pathology_T_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHNUM"), ".", ",") != AV75TFBR_Pathology_LymphNum )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHNUM_TO"), ".", ",") != AV76TFBR_Pathology_LymphNum_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHRATE"), AV79TFBR_Pathology_LymphRate) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_LYMPHRATE_SEL"), AV80TFBR_Pathology_LymphRate_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_METALOC"), AV87TFBR_Pathology_MetaLoc) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_PATHOLOGY_METALOC_SEL"), AV88TFBR_Pathology_MetaLoc_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E305C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E305C2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV64IsAuthorized_BR_Information_PatientNo;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Information", out  GXt_boolean1) ;
         AV64IsAuthorized_BR_Information_PatientNo = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64IsAuthorized_BR_Information_PatientNo", AV64IsAuthorized_BR_Information_PatientNo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV64IsAuthorized_BR_Information_PatientNo, context));
         edtavTfbr_pathologyid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_to_Visible), 5, 0)), true);
         edtavTfbr_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_Visible), 5, 0)), true);
         edtavTfbr_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_to_Visible), 5, 0)), true);
         edtavTfbr_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_information_patientno_Visible), 5, 0)), true);
         edtavTfbr_information_patientno_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_information_patientno_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_information_patientno_sel_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_testid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_testid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_testid_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_testid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_testid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_testid_to_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_padate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_padate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_padate_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_padate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_padate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_padate_to_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_pahosp_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_pahosp_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_pahosp_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_pahosp_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_pahosp_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_pahosp_sel_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_paage_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_paage_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_paage_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_paage_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_paage_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_paage_to_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_prepadia_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_prepadia_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_prepadia_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_prepadia_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_prepadia_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_prepadia_sel_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_paresult_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_paresult_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_paresult_Visible), 5, 0)), true);
         edtavTfbr_pathologyid_paresult_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathologyid_paresult_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathologyid_paresult_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_dia_name_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_dia_name_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_dia_name_Visible), 5, 0)), true);
         edtavTfbr_pathology_dia_name_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_dia_name_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_dia_name_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_t_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_t_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_t_Visible), 5, 0)), true);
         edtavTfbr_pathology_t_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_t_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_t_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_lymphnum_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_lymphnum_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_lymphnum_Visible), 5, 0)), true);
         edtavTfbr_pathology_lymphnum_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_lymphnum_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_lymphnum_to_Visible), 5, 0)), true);
         edtavTfbr_pathology_lymphrate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_lymphrate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_lymphrate_Visible), 5, 0)), true);
         edtavTfbr_pathology_lymphrate_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_lymphrate_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_lymphrate_sel_Visible), 5, 0)), true);
         edtavTfbr_pathology_metaloc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_metaloc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_metaloc_Visible), 5, 0)), true);
         edtavTfbr_pathology_metaloc_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_pathology_metaloc_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_pathology_metaloc_sel_Visible), 5, 0)), true);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_Titlecontrolidtoreplace);
         AV19ddo_BR_PathologyIDTitleControlIdToReplace = Ddo_br_pathologyid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_PathologyIDTitleControlIdToReplace", AV19ddo_BR_PathologyIDTitleControlIdToReplace);
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Information_PatientNoTitleControlIdToReplace", AV27ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_testid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_TestID";
         ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_testid_Titlecontrolidtoreplace);
         AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace = Ddo_br_pathologyid_testid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace", AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace);
         edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_padate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PADate";
         ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_padate_Titlecontrolidtoreplace);
         AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace = Ddo_br_pathologyid_padate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace", AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace);
         edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PAHosp";
         ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace);
         AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace = Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace", AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace);
         edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_paage_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PAAge";
         ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_paage_Titlecontrolidtoreplace);
         AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = Ddo_br_pathologyid_paage_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace", AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace);
         edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PrePaDia";
         ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace);
         AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace", AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace);
         edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_PathologyID_PAResult";
         ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "TitleControlIdToReplace", Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace);
         AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace = Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace", AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace);
         edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_dia_name_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_Dia_Name";
         ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_dia_name_Titlecontrolidtoreplace);
         AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = Ddo_br_pathology_dia_name_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace", AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace);
         edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_t_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_T";
         ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_t_Titlecontrolidtoreplace);
         AV69ddo_BR_Pathology_TTitleControlIdToReplace = Ddo_br_pathology_t_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_BR_Pathology_TTitleControlIdToReplace", AV69ddo_BR_Pathology_TTitleControlIdToReplace);
         edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_n_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_N";
         ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_n_Titlecontrolidtoreplace);
         AV73ddo_BR_Pathology_NTitleControlIdToReplace = Ddo_br_pathology_n_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73ddo_BR_Pathology_NTitleControlIdToReplace", AV73ddo_BR_Pathology_NTitleControlIdToReplace);
         edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_LymphNum";
         ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace);
         AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace = Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace", AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace);
         edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_LymphRate";
         ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace);
         AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace = Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace", AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace);
         edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_m_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_M";
         ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_m_Titlecontrolidtoreplace);
         AV85ddo_BR_Pathology_MTitleControlIdToReplace = Ddo_br_pathology_m_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85ddo_BR_Pathology_MTitleControlIdToReplace", AV85ddo_BR_Pathology_MTitleControlIdToReplace);
         edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_pathology_metaloc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Pathology_MetaLoc";
         ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "TitleControlIdToReplace", Ddo_br_pathology_metaloc_Titlecontrolidtoreplace);
         AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace = Ddo_br_pathology_metaloc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace", AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace);
         edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " ����ѧ";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV54DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV54DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E315C2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_PathologyID_TestIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_PathologyID_PADateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_PathologyID_PAHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_PathologyID_PAAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_PathologyID_PrePaDiaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_PathologyID_PAResultTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV90BR_Pathology_Dia_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66BR_Pathology_TTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV70BR_Pathology_NTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV74BR_Pathology_LymphNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV78BR_Pathology_LymphRateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV82BR_Pathology_MTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV86BR_Pathology_MetaLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_PathologyID_Titleformat = 2;
         edtBR_PathologyID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "����ѧ����", AV19ddo_BR_PathologyIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Title", edtBR_PathologyID_Title, !bGXsfl_31_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "������Ϣ����", AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_31_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "���߱��", AV27ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_TestID_Titleformat = 2;
         edtBR_PathologyID_TestID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "��Ŀ���", AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_TestID_Internalname, "Title", edtBR_PathologyID_TestID_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_PADate_Titleformat = 2;
         edtBR_PathologyID_PADate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "�����������", AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PADate_Internalname, "Title", edtBR_PathologyID_PADate_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_PAHosp_Titleformat = 2;
         edtBR_PathologyID_PAHosp_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "���ҽԺ", AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAHosp_Internalname, "Title", edtBR_PathologyID_PAHosp_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_PAAge_Titleformat = 2;
         edtBR_PathologyID_PAAge_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "����", AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAAge_Internalname, "Title", edtBR_PathologyID_PAAge_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_PrePaDia_Titleformat = 2;
         edtBR_PathologyID_PrePaDia_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "����ǰ���", AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PrePaDia_Internalname, "Title", edtBR_PathologyID_PrePaDia_Title, !bGXsfl_31_Refreshing);
         edtBR_PathologyID_PAResult_Titleformat = 2;
         edtBR_PathologyID_PAResult_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "��������", AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAResult_Internalname, "Title", edtBR_PathologyID_PAResult_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_Dia_Name_Titleformat = 2;
         edtBR_Pathology_Dia_Name_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "�����������", AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Dia_Name_Internalname, "Title", edtBR_Pathology_Dia_Name_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_T_Titleformat = 2;
         edtBR_Pathology_T_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "ԭ�������ּ�", AV69ddo_BR_Pathology_TTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_T_Internalname, "Title", edtBR_Pathology_T_Title, !bGXsfl_31_Refreshing);
         cmbBR_Pathology_N_Titleformat = 2;
         cmbBR_Pathology_N.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "�Ƿ��ܰͽ�ת��", AV73ddo_BR_Pathology_NTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Title", cmbBR_Pathology_N.Title.Text, !bGXsfl_31_Refreshing);
         edtBR_Pathology_LymphNum_Titleformat = 2;
         edtBR_Pathology_LymphNum_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "�ܰͽ���Ŀ", AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_LymphNum_Internalname, "Title", edtBR_Pathology_LymphNum_Title, !bGXsfl_31_Refreshing);
         edtBR_Pathology_LymphRate_Titleformat = 2;
         edtBR_Pathology_LymphRate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "�ܰͽ�ת�Ʊ���", AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_LymphRate_Internalname, "Title", edtBR_Pathology_LymphRate_Title, !bGXsfl_31_Refreshing);
         cmbBR_Pathology_M_Titleformat = 2;
         cmbBR_Pathology_M.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "�Ƿ�Զ��ת��", AV85ddo_BR_Pathology_MTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Title", cmbBR_Pathology_M.Title.Text, !bGXsfl_31_Refreshing);
         edtBR_Pathology_MetaLoc_Titleformat = 2;
         edtBR_Pathology_MetaLoc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Զ��ת�Ʋ�λ", AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_MetaLoc_Internalname, "Title", edtBR_Pathology_MetaLoc_Title, !bGXsfl_31_Refreshing);
         AV56GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56GridCurrentPage), 10, 0)));
         AV57GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV57GridPageSize), 10, 0)));
         AV58GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV58GridRecordCount), 10, 0)));
         AV98BR_PathologyWWDS_1_Tfbr_pathologyid = AV17TFBR_PathologyID;
         AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to = AV18TFBR_PathologyID_To;
         AV100BR_PathologyWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV101BR_PathologyWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = AV25TFBR_Information_PatientNo;
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = AV26TFBR_Information_PatientNo_Sel;
         AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid = AV29TFBR_PathologyID_TestID;
         AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to = AV30TFBR_PathologyID_TestID_To;
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = AV33TFBR_PathologyID_PADate;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = AV34TFBR_PathologyID_PADate_To;
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = AV39TFBR_PathologyID_PAHosp;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = AV40TFBR_PathologyID_PAHosp_Sel;
         AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage = AV43TFBR_PathologyID_PAAge;
         AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to = AV44TFBR_PathologyID_PAAge_To;
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = AV47TFBR_PathologyID_PrePaDia;
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = AV48TFBR_PathologyID_PrePaDia_Sel;
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = AV51TFBR_PathologyID_PAResult;
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = AV52TFBR_PathologyID_PAResult_Sel;
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = AV91TFBR_Pathology_Dia_Name;
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = AV92TFBR_Pathology_Dia_Name_Sel;
         AV118BR_PathologyWWDS_21_Tfbr_pathology_t = AV67TFBR_Pathology_T;
         AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to = AV68TFBR_Pathology_T_To;
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = AV72TFBR_Pathology_N_Sels;
         AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum = AV75TFBR_Pathology_LymphNum;
         AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to = AV76TFBR_Pathology_LymphNum_To;
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = AV79TFBR_Pathology_LymphRate;
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = AV80TFBR_Pathology_LymphRate_Sel;
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = AV84TFBR_Pathology_M_Sels;
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = AV87TFBR_Pathology_MetaLoc;
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = AV88TFBR_Pathology_MetaLoc_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E115C2( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
         {
            subgrid_previouspage( ) ;
         }
         else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
         {
            subgrid_nextpage( ) ;
         }
         else
         {
            AV55PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV55PageToGo) ;
         }
      }

      protected void E125C2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135C2( )
      {
         /* Ddo_br_pathologyid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_Sortedstatus = "ASC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_PathologyID = (long)(NumberUtil.Val( Ddo_br_pathologyid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_PathologyID), 18, 0)));
            AV18TFBR_PathologyID_To = (long)(NumberUtil.Val( Ddo_br_pathologyid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_PathologyID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E145C2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV21TFBR_EncounterID = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E155C2( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Information_PatientNo = Ddo_br_information_patientno_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Information_PatientNo", AV25TFBR_Information_PatientNo);
            AV26TFBR_Information_PatientNo_Sel = Ddo_br_information_patientno_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Information_PatientNo_Sel", AV26TFBR_Information_PatientNo_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E165C2( )
      {
         /* Ddo_br_pathologyid_testid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_testid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_testid_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "SortedStatus", Ddo_br_pathologyid_testid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_testid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_testid_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "SortedStatus", Ddo_br_pathologyid_testid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_testid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_PathologyID_TestID = (long)(NumberUtil.Val( Ddo_br_pathologyid_testid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0)));
            AV30TFBR_PathologyID_TestID_To = (long)(NumberUtil.Val( Ddo_br_pathologyid_testid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_PathologyID_TestID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E175C2( )
      {
         /* Ddo_br_pathologyid_padate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_padate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_padate_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "SortedStatus", Ddo_br_pathologyid_padate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_padate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_padate_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "SortedStatus", Ddo_br_pathologyid_padate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_padate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFBR_PathologyID_PADate = context.localUtil.CToD( Ddo_br_pathologyid_padate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_PathologyID_PADate", context.localUtil.Format(AV33TFBR_PathologyID_PADate, "9999/99/99"));
            AV34TFBR_PathologyID_PADate_To = context.localUtil.CToD( Ddo_br_pathologyid_padate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_PathologyID_PADate_To", context.localUtil.Format(AV34TFBR_PathologyID_PADate_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E185C2( )
      {
         /* Ddo_br_pathologyid_pahosp_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_pahosp_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_pahosp_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SortedStatus", Ddo_br_pathologyid_pahosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_pahosp_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_pahosp_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SortedStatus", Ddo_br_pathologyid_pahosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_pahosp_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV39TFBR_PathologyID_PAHosp = Ddo_br_pathologyid_pahosp_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_PathologyID_PAHosp", AV39TFBR_PathologyID_PAHosp);
            AV40TFBR_PathologyID_PAHosp_Sel = Ddo_br_pathologyid_pahosp_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_PathologyID_PAHosp_Sel", AV40TFBR_PathologyID_PAHosp_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E195C2( )
      {
         /* Ddo_br_pathologyid_paage_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_paage_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_paage_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "SortedStatus", Ddo_br_pathologyid_paage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_paage_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_paage_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "SortedStatus", Ddo_br_pathologyid_paage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_paage_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV43TFBR_PathologyID_PAAge = (short)(NumberUtil.Val( Ddo_br_pathologyid_paage_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0)));
            AV44TFBR_PathologyID_PAAge_To = (short)(NumberUtil.Val( Ddo_br_pathologyid_paage_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_PathologyID_PAAge_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E205C2( )
      {
         /* Ddo_br_pathologyid_prepadia_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_prepadia_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_prepadia_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SortedStatus", Ddo_br_pathologyid_prepadia_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_prepadia_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_prepadia_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SortedStatus", Ddo_br_pathologyid_prepadia_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_prepadia_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV47TFBR_PathologyID_PrePaDia = Ddo_br_pathologyid_prepadia_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_PathologyID_PrePaDia", AV47TFBR_PathologyID_PrePaDia);
            AV48TFBR_PathologyID_PrePaDia_Sel = Ddo_br_pathologyid_prepadia_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_PathologyID_PrePaDia_Sel", AV48TFBR_PathologyID_PrePaDia_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E215C2( )
      {
         /* Ddo_br_pathologyid_paresult_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathologyid_paresult_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_paresult_Sortedstatus = "ASC";
            ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SortedStatus", Ddo_br_pathologyid_paresult_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_paresult_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathologyid_paresult_Sortedstatus = "DSC";
            ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SortedStatus", Ddo_br_pathologyid_paresult_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathologyid_paresult_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV51TFBR_PathologyID_PAResult = Ddo_br_pathologyid_paresult_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_PathologyID_PAResult", AV51TFBR_PathologyID_PAResult);
            AV52TFBR_PathologyID_PAResult_Sel = Ddo_br_pathologyid_paresult_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_PathologyID_PAResult_Sel", AV52TFBR_PathologyID_PAResult_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E225C2( )
      {
         /* Ddo_br_pathology_dia_name_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_dia_name_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_dia_name_Sortedstatus = "ASC";
            ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SortedStatus", Ddo_br_pathology_dia_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_dia_name_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_dia_name_Sortedstatus = "DSC";
            ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SortedStatus", Ddo_br_pathology_dia_name_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_dia_name_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV91TFBR_Pathology_Dia_Name = Ddo_br_pathology_dia_name_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFBR_Pathology_Dia_Name", AV91TFBR_Pathology_Dia_Name);
            AV92TFBR_Pathology_Dia_Name_Sel = Ddo_br_pathology_dia_name_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV92TFBR_Pathology_Dia_Name_Sel", AV92TFBR_Pathology_Dia_Name_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E235C2( )
      {
         /* Ddo_br_pathology_t_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_t_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_t_Sortedstatus = "ASC";
            ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "SortedStatus", Ddo_br_pathology_t_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_t_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_t_Sortedstatus = "DSC";
            ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "SortedStatus", Ddo_br_pathology_t_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_t_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV67TFBR_Pathology_T = NumberUtil.Val( Ddo_br_pathology_t_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFBR_Pathology_T", StringUtil.LTrim( StringUtil.Str( AV67TFBR_Pathology_T, 15, 5)));
            AV68TFBR_Pathology_T_To = NumberUtil.Val( Ddo_br_pathology_t_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Pathology_T_To", StringUtil.LTrim( StringUtil.Str( AV68TFBR_Pathology_T_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E245C2( )
      {
         /* Ddo_br_pathology_n_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_n_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_n_Sortedstatus = "ASC";
            ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SortedStatus", Ddo_br_pathology_n_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_n_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_n_Sortedstatus = "DSC";
            ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SortedStatus", Ddo_br_pathology_n_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_n_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV71TFBR_Pathology_N_SelsJson = Ddo_br_pathology_n_Selectedvalue_get;
            AV72TFBR_Pathology_N_Sels.FromJSonString(AV71TFBR_Pathology_N_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV72TFBR_Pathology_N_Sels", AV72TFBR_Pathology_N_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E255C2( )
      {
         /* Ddo_br_pathology_lymphnum_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_lymphnum_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_lymphnum_Sortedstatus = "ASC";
            ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "SortedStatus", Ddo_br_pathology_lymphnum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_lymphnum_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 13;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_lymphnum_Sortedstatus = "DSC";
            ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "SortedStatus", Ddo_br_pathology_lymphnum_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_lymphnum_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV75TFBR_Pathology_LymphNum = NumberUtil.Val( Ddo_br_pathology_lymphnum_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75TFBR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( AV75TFBR_Pathology_LymphNum, 15, 5)));
            AV76TFBR_Pathology_LymphNum_To = NumberUtil.Val( Ddo_br_pathology_lymphnum_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76TFBR_Pathology_LymphNum_To", StringUtil.LTrim( StringUtil.Str( AV76TFBR_Pathology_LymphNum_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E265C2( )
      {
         /* Ddo_br_pathology_lymphrate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_lymphrate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_lymphrate_Sortedstatus = "ASC";
            ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SortedStatus", Ddo_br_pathology_lymphrate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_lymphrate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 14;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_lymphrate_Sortedstatus = "DSC";
            ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SortedStatus", Ddo_br_pathology_lymphrate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_lymphrate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV79TFBR_Pathology_LymphRate = Ddo_br_pathology_lymphrate_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFBR_Pathology_LymphRate", AV79TFBR_Pathology_LymphRate);
            AV80TFBR_Pathology_LymphRate_Sel = Ddo_br_pathology_lymphrate_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_Pathology_LymphRate_Sel", AV80TFBR_Pathology_LymphRate_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E275C2( )
      {
         /* Ddo_br_pathology_m_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_m_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_m_Sortedstatus = "ASC";
            ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SortedStatus", Ddo_br_pathology_m_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_m_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 15;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_m_Sortedstatus = "DSC";
            ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SortedStatus", Ddo_br_pathology_m_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_m_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV83TFBR_Pathology_M_SelsJson = Ddo_br_pathology_m_Selectedvalue_get;
            AV84TFBR_Pathology_M_Sels.FromJSonString(AV83TFBR_Pathology_M_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV84TFBR_Pathology_M_Sels", AV84TFBR_Pathology_M_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      protected void E285C2( )
      {
         /* Ddo_br_pathology_metaloc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_pathology_metaloc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_metaloc_Sortedstatus = "ASC";
            ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SortedStatus", Ddo_br_pathology_metaloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_metaloc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 16;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_pathology_metaloc_Sortedstatus = "DSC";
            ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SortedStatus", Ddo_br_pathology_metaloc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_pathology_metaloc_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV87TFBR_Pathology_MetaLoc = Ddo_br_pathology_metaloc_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFBR_Pathology_MetaLoc", AV87TFBR_Pathology_MetaLoc);
            AV88TFBR_Pathology_MetaLoc_Sel = Ddo_br_pathology_metaloc_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFBR_Pathology_MetaLoc_Sel", AV88TFBR_Pathology_MetaLoc_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_PathologyIDTitleFilterData", AV16BR_PathologyIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Information_PatientNoTitleFilterData", AV24BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_PathologyID_TestIDTitleFilterData", AV28BR_PathologyID_TestIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_PathologyID_PADateTitleFilterData", AV32BR_PathologyID_PADateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_PathologyID_PAHospTitleFilterData", AV38BR_PathologyID_PAHospTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_PathologyID_PAAgeTitleFilterData", AV42BR_PathologyID_PAAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46BR_PathologyID_PrePaDiaTitleFilterData", AV46BR_PathologyID_PrePaDiaTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_PathologyID_PAResultTitleFilterData", AV50BR_PathologyID_PAResultTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV90BR_Pathology_Dia_NameTitleFilterData", AV90BR_Pathology_Dia_NameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66BR_Pathology_TTitleFilterData", AV66BR_Pathology_TTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV70BR_Pathology_NTitleFilterData", AV70BR_Pathology_NTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV74BR_Pathology_LymphNumTitleFilterData", AV74BR_Pathology_LymphNumTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV78BR_Pathology_LymphRateTitleFilterData", AV78BR_Pathology_LymphRateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Pathology_MTitleFilterData", AV82BR_Pathology_MTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV86BR_Pathology_MetaLocTitleFilterData", AV86BR_Pathology_MetaLocTitleFilterData);
      }

      private void E325C2( )
      {
         /* Grid_Load Routine */
         AV59Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV59Display);
         AV128Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "��ʾ";
         edtavDisplay_Link = formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +A226BR_PathologyID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV60Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV60Update);
         AV129Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "�޸�";
         if ( AV61IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_pathology.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A226BR_PathologyID);
         }
         AV62Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV62Delete);
         AV130Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "ɾ��";
         if ( AV63IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_pathology.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A226BR_PathologyID);
         }
         if ( AV64IsAuthorized_BR_Information_PatientNo )
         {
            edtBR_Information_PatientNo_Link = formatLink("br_informationview.aspx") + "?" + UrlEncode("" +A85BR_Information_ID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         edtBR_PathologyID_TestID_Link = formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +A226BR_PathologyID) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 31;
         }
         sendrow_312( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_31_Refreshing )
         {
            context.DoAjaxLoad(31, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E295C2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_pathology.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_pathologyid_Sortedstatus = "";
         ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_information_patientno_Sortedstatus = "";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
         Ddo_br_pathologyid_testid_Sortedstatus = "";
         ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "SortedStatus", Ddo_br_pathologyid_testid_Sortedstatus);
         Ddo_br_pathologyid_padate_Sortedstatus = "";
         ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "SortedStatus", Ddo_br_pathologyid_padate_Sortedstatus);
         Ddo_br_pathologyid_pahosp_Sortedstatus = "";
         ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SortedStatus", Ddo_br_pathologyid_pahosp_Sortedstatus);
         Ddo_br_pathologyid_paage_Sortedstatus = "";
         ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "SortedStatus", Ddo_br_pathologyid_paage_Sortedstatus);
         Ddo_br_pathologyid_prepadia_Sortedstatus = "";
         ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SortedStatus", Ddo_br_pathologyid_prepadia_Sortedstatus);
         Ddo_br_pathologyid_paresult_Sortedstatus = "";
         ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SortedStatus", Ddo_br_pathologyid_paresult_Sortedstatus);
         Ddo_br_pathology_dia_name_Sortedstatus = "";
         ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SortedStatus", Ddo_br_pathology_dia_name_Sortedstatus);
         Ddo_br_pathology_t_Sortedstatus = "";
         ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "SortedStatus", Ddo_br_pathology_t_Sortedstatus);
         Ddo_br_pathology_n_Sortedstatus = "";
         ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SortedStatus", Ddo_br_pathology_n_Sortedstatus);
         Ddo_br_pathology_lymphnum_Sortedstatus = "";
         ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "SortedStatus", Ddo_br_pathology_lymphnum_Sortedstatus);
         Ddo_br_pathology_lymphrate_Sortedstatus = "";
         ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SortedStatus", Ddo_br_pathology_lymphrate_Sortedstatus);
         Ddo_br_pathology_m_Sortedstatus = "";
         ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SortedStatus", Ddo_br_pathology_m_Sortedstatus);
         Ddo_br_pathology_metaloc_Sortedstatus = "";
         ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SortedStatus", Ddo_br_pathology_metaloc_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 1 )
         {
            Ddo_br_pathologyid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "SortedStatus", Ddo_br_pathologyid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_information_patientno_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_pathologyid_testid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "SortedStatus", Ddo_br_pathologyid_testid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_pathologyid_padate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "SortedStatus", Ddo_br_pathologyid_padate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_pathologyid_pahosp_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SortedStatus", Ddo_br_pathologyid_pahosp_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_pathologyid_paage_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "SortedStatus", Ddo_br_pathologyid_paage_Sortedstatus);
         }
         else if ( AV13OrderedBy == 8 )
         {
            Ddo_br_pathologyid_prepadia_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SortedStatus", Ddo_br_pathologyid_prepadia_Sortedstatus);
         }
         else if ( AV13OrderedBy == 9 )
         {
            Ddo_br_pathologyid_paresult_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SortedStatus", Ddo_br_pathologyid_paresult_Sortedstatus);
         }
         else if ( AV13OrderedBy == 10 )
         {
            Ddo_br_pathology_dia_name_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SortedStatus", Ddo_br_pathology_dia_name_Sortedstatus);
         }
         else if ( AV13OrderedBy == 11 )
         {
            Ddo_br_pathology_t_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "SortedStatus", Ddo_br_pathology_t_Sortedstatus);
         }
         else if ( AV13OrderedBy == 12 )
         {
            Ddo_br_pathology_n_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SortedStatus", Ddo_br_pathology_n_Sortedstatus);
         }
         else if ( AV13OrderedBy == 13 )
         {
            Ddo_br_pathology_lymphnum_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "SortedStatus", Ddo_br_pathology_lymphnum_Sortedstatus);
         }
         else if ( AV13OrderedBy == 14 )
         {
            Ddo_br_pathology_lymphrate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SortedStatus", Ddo_br_pathology_lymphrate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 15 )
         {
            Ddo_br_pathology_m_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SortedStatus", Ddo_br_pathology_m_Sortedstatus);
         }
         else if ( AV13OrderedBy == 16 )
         {
            Ddo_br_pathology_metaloc_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SortedStatus", Ddo_br_pathology_metaloc_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV61IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean1) ;
         AV61IsAuthorized_Update = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV61IsAuthorized_Update", AV61IsAuthorized_Update);
         if ( ! ( AV61IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV63IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean1) ;
         AV63IsAuthorized_Delete = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV63IsAuthorized_Delete", AV63IsAuthorized_Delete);
         if ( ! ( AV63IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean1 = AV65TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean1) ;
         AV65TempBoolean = GXt_boolean1;
         if ( ! ( AV65TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV131Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV131Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV131Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV132GXV1 = 1;
         while ( AV132GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV132GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID") == 0 )
            {
               AV17TFBR_PathologyID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_PathologyID), 18, 0)));
               AV18TFBR_PathologyID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_PathologyID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_PathologyID_To), 18, 0)));
               if ( ! (0==AV17TFBR_PathologyID) )
               {
                  Ddo_br_pathologyid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_PathologyID), 18, 0);
                  ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "FilteredText_set", Ddo_br_pathologyid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_PathologyID_To) )
               {
                  Ddo_br_pathologyid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_PathologyID_To), 18, 0);
                  ucDdo_br_pathologyid.SendProperty(context, "", false, Ddo_br_pathologyid_Internalname, "FilteredTextTo_set", Ddo_br_pathologyid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
               if ( ! (0==AV21TFBR_EncounterID) )
               {
                  Ddo_br_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredText_set", Ddo_br_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_EncounterID_To) )
               {
                  Ddo_br_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredTextTo_set", Ddo_br_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV25TFBR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Information_PatientNo", AV25TFBR_Information_PatientNo);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Information_PatientNo)) )
               {
                  Ddo_br_information_patientno_Filteredtext_set = AV25TFBR_Information_PatientNo;
                  ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "FilteredText_set", Ddo_br_information_patientno_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV26TFBR_Information_PatientNo_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Information_PatientNo_Sel", AV26TFBR_Information_PatientNo_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Information_PatientNo_Sel)) )
               {
                  Ddo_br_information_patientno_Selectedvalue_set = AV26TFBR_Information_PatientNo_Sel;
                  ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SelectedValue_set", Ddo_br_information_patientno_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_TESTID") == 0 )
            {
               AV29TFBR_PathologyID_TestID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0)));
               AV30TFBR_PathologyID_TestID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_PathologyID_TestID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0)));
               if ( ! (0==AV29TFBR_PathologyID_TestID) )
               {
                  Ddo_br_pathologyid_testid_Filteredtext_set = StringUtil.Str( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0);
                  ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "FilteredText_set", Ddo_br_pathologyid_testid_Filteredtext_set);
               }
               if ( ! (0==AV30TFBR_PathologyID_TestID_To) )
               {
                  Ddo_br_pathologyid_testid_Filteredtextto_set = StringUtil.Str( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0);
                  ucDdo_br_pathologyid_testid.SendProperty(context, "", false, Ddo_br_pathologyid_testid_Internalname, "FilteredTextTo_set", Ddo_br_pathologyid_testid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PADATE") == 0 )
            {
               AV33TFBR_PathologyID_PADate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFBR_PathologyID_PADate", context.localUtil.Format(AV33TFBR_PathologyID_PADate, "9999/99/99"));
               AV34TFBR_PathologyID_PADate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_PathologyID_PADate_To", context.localUtil.Format(AV34TFBR_PathologyID_PADate_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV33TFBR_PathologyID_PADate) )
               {
                  Ddo_br_pathologyid_padate_Filteredtext_set = context.localUtil.DToC( AV33TFBR_PathologyID_PADate, 0, "/");
                  ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "FilteredText_set", Ddo_br_pathologyid_padate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV34TFBR_PathologyID_PADate_To) )
               {
                  Ddo_br_pathologyid_padate_Filteredtextto_set = context.localUtil.DToC( AV34TFBR_PathologyID_PADate_To, 0, "/");
                  ucDdo_br_pathologyid_padate.SendProperty(context, "", false, Ddo_br_pathologyid_padate_Internalname, "FilteredTextTo_set", Ddo_br_pathologyid_padate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PAHOSP") == 0 )
            {
               AV39TFBR_PathologyID_PAHosp = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_PathologyID_PAHosp", AV39TFBR_PathologyID_PAHosp);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_PathologyID_PAHosp)) )
               {
                  Ddo_br_pathologyid_pahosp_Filteredtext_set = AV39TFBR_PathologyID_PAHosp;
                  ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "FilteredText_set", Ddo_br_pathologyid_pahosp_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PAHOSP_SEL") == 0 )
            {
               AV40TFBR_PathologyID_PAHosp_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40TFBR_PathologyID_PAHosp_Sel", AV40TFBR_PathologyID_PAHosp_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV40TFBR_PathologyID_PAHosp_Sel)) )
               {
                  Ddo_br_pathologyid_pahosp_Selectedvalue_set = AV40TFBR_PathologyID_PAHosp_Sel;
                  ucDdo_br_pathologyid_pahosp.SendProperty(context, "", false, Ddo_br_pathologyid_pahosp_Internalname, "SelectedValue_set", Ddo_br_pathologyid_pahosp_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PAAGE") == 0 )
            {
               AV43TFBR_PathologyID_PAAge = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43TFBR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0)));
               AV44TFBR_PathologyID_PAAge_To = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44TFBR_PathologyID_PAAge_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0)));
               if ( ! (0==AV43TFBR_PathologyID_PAAge) )
               {
                  Ddo_br_pathologyid_paage_Filteredtext_set = StringUtil.Str( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0);
                  ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "FilteredText_set", Ddo_br_pathologyid_paage_Filteredtext_set);
               }
               if ( ! (0==AV44TFBR_PathologyID_PAAge_To) )
               {
                  Ddo_br_pathologyid_paage_Filteredtextto_set = StringUtil.Str( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0);
                  ucDdo_br_pathologyid_paage.SendProperty(context, "", false, Ddo_br_pathologyid_paage_Internalname, "FilteredTextTo_set", Ddo_br_pathologyid_paage_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PREPADIA") == 0 )
            {
               AV47TFBR_PathologyID_PrePaDia = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47TFBR_PathologyID_PrePaDia", AV47TFBR_PathologyID_PrePaDia);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFBR_PathologyID_PrePaDia)) )
               {
                  Ddo_br_pathologyid_prepadia_Filteredtext_set = AV47TFBR_PathologyID_PrePaDia;
                  ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "FilteredText_set", Ddo_br_pathologyid_prepadia_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PREPADIA_SEL") == 0 )
            {
               AV48TFBR_PathologyID_PrePaDia_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48TFBR_PathologyID_PrePaDia_Sel", AV48TFBR_PathologyID_PrePaDia_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_PathologyID_PrePaDia_Sel)) )
               {
                  Ddo_br_pathologyid_prepadia_Selectedvalue_set = AV48TFBR_PathologyID_PrePaDia_Sel;
                  ucDdo_br_pathologyid_prepadia.SendProperty(context, "", false, Ddo_br_pathologyid_prepadia_Internalname, "SelectedValue_set", Ddo_br_pathologyid_prepadia_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PARESULT") == 0 )
            {
               AV51TFBR_PathologyID_PAResult = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_PathologyID_PAResult", AV51TFBR_PathologyID_PAResult);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51TFBR_PathologyID_PAResult)) )
               {
                  Ddo_br_pathologyid_paresult_Filteredtext_set = AV51TFBR_PathologyID_PAResult;
                  ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "FilteredText_set", Ddo_br_pathologyid_paresult_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGYID_PARESULT_SEL") == 0 )
            {
               AV52TFBR_PathologyID_PAResult_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52TFBR_PathologyID_PAResult_Sel", AV52TFBR_PathologyID_PAResult_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52TFBR_PathologyID_PAResult_Sel)) )
               {
                  Ddo_br_pathologyid_paresult_Selectedvalue_set = AV52TFBR_PathologyID_PAResult_Sel;
                  ucDdo_br_pathologyid_paresult.SendProperty(context, "", false, Ddo_br_pathologyid_paresult_Internalname, "SelectedValue_set", Ddo_br_pathologyid_paresult_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIA_NAME") == 0 )
            {
               AV91TFBR_Pathology_Dia_Name = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV91TFBR_Pathology_Dia_Name", AV91TFBR_Pathology_Dia_Name);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91TFBR_Pathology_Dia_Name)) )
               {
                  Ddo_br_pathology_dia_name_Filteredtext_set = AV91TFBR_Pathology_Dia_Name;
                  ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "FilteredText_set", Ddo_br_pathology_dia_name_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_DIA_NAME_SEL") == 0 )
            {
               AV92TFBR_Pathology_Dia_Name_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV92TFBR_Pathology_Dia_Name_Sel", AV92TFBR_Pathology_Dia_Name_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92TFBR_Pathology_Dia_Name_Sel)) )
               {
                  Ddo_br_pathology_dia_name_Selectedvalue_set = AV92TFBR_Pathology_Dia_Name_Sel;
                  ucDdo_br_pathology_dia_name.SendProperty(context, "", false, Ddo_br_pathology_dia_name_Internalname, "SelectedValue_set", Ddo_br_pathology_dia_name_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_T") == 0 )
            {
               AV67TFBR_Pathology_T = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFBR_Pathology_T", StringUtil.LTrim( StringUtil.Str( AV67TFBR_Pathology_T, 15, 5)));
               AV68TFBR_Pathology_T_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFBR_Pathology_T_To", StringUtil.LTrim( StringUtil.Str( AV68TFBR_Pathology_T_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV67TFBR_Pathology_T) )
               {
                  Ddo_br_pathology_t_Filteredtext_set = StringUtil.Str( AV67TFBR_Pathology_T, 15, 5);
                  ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "FilteredText_set", Ddo_br_pathology_t_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV68TFBR_Pathology_T_To) )
               {
                  Ddo_br_pathology_t_Filteredtextto_set = StringUtil.Str( AV68TFBR_Pathology_T_To, 15, 5);
                  ucDdo_br_pathology_t.SendProperty(context, "", false, Ddo_br_pathology_t_Internalname, "FilteredTextTo_set", Ddo_br_pathology_t_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_N_SEL") == 0 )
            {
               AV71TFBR_Pathology_N_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV72TFBR_Pathology_N_Sels.FromJSonString(AV71TFBR_Pathology_N_SelsJson, null);
               if ( ! ( AV72TFBR_Pathology_N_Sels.Count == 0 ) )
               {
                  Ddo_br_pathology_n_Selectedvalue_set = AV71TFBR_Pathology_N_SelsJson;
                  ucDdo_br_pathology_n.SendProperty(context, "", false, Ddo_br_pathology_n_Internalname, "SelectedValue_set", Ddo_br_pathology_n_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_LYMPHNUM") == 0 )
            {
               AV75TFBR_Pathology_LymphNum = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75TFBR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( AV75TFBR_Pathology_LymphNum, 15, 5)));
               AV76TFBR_Pathology_LymphNum_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV76TFBR_Pathology_LymphNum_To", StringUtil.LTrim( StringUtil.Str( AV76TFBR_Pathology_LymphNum_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV75TFBR_Pathology_LymphNum) )
               {
                  Ddo_br_pathology_lymphnum_Filteredtext_set = StringUtil.Str( AV75TFBR_Pathology_LymphNum, 15, 5);
                  ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "FilteredText_set", Ddo_br_pathology_lymphnum_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV76TFBR_Pathology_LymphNum_To) )
               {
                  Ddo_br_pathology_lymphnum_Filteredtextto_set = StringUtil.Str( AV76TFBR_Pathology_LymphNum_To, 15, 5);
                  ucDdo_br_pathology_lymphnum.SendProperty(context, "", false, Ddo_br_pathology_lymphnum_Internalname, "FilteredTextTo_set", Ddo_br_pathology_lymphnum_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_LYMPHRATE") == 0 )
            {
               AV79TFBR_Pathology_LymphRate = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV79TFBR_Pathology_LymphRate", AV79TFBR_Pathology_LymphRate);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79TFBR_Pathology_LymphRate)) )
               {
                  Ddo_br_pathology_lymphrate_Filteredtext_set = AV79TFBR_Pathology_LymphRate;
                  ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "FilteredText_set", Ddo_br_pathology_lymphrate_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_LYMPHRATE_SEL") == 0 )
            {
               AV80TFBR_Pathology_LymphRate_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_Pathology_LymphRate_Sel", AV80TFBR_Pathology_LymphRate_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80TFBR_Pathology_LymphRate_Sel)) )
               {
                  Ddo_br_pathology_lymphrate_Selectedvalue_set = AV80TFBR_Pathology_LymphRate_Sel;
                  ucDdo_br_pathology_lymphrate.SendProperty(context, "", false, Ddo_br_pathology_lymphrate_Internalname, "SelectedValue_set", Ddo_br_pathology_lymphrate_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_M_SEL") == 0 )
            {
               AV83TFBR_Pathology_M_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV84TFBR_Pathology_M_Sels.FromJSonString(AV83TFBR_Pathology_M_SelsJson, null);
               if ( ! ( AV84TFBR_Pathology_M_Sels.Count == 0 ) )
               {
                  Ddo_br_pathology_m_Selectedvalue_set = AV83TFBR_Pathology_M_SelsJson;
                  ucDdo_br_pathology_m.SendProperty(context, "", false, Ddo_br_pathology_m_Internalname, "SelectedValue_set", Ddo_br_pathology_m_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_METALOC") == 0 )
            {
               AV87TFBR_Pathology_MetaLoc = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87TFBR_Pathology_MetaLoc", AV87TFBR_Pathology_MetaLoc);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87TFBR_Pathology_MetaLoc)) )
               {
                  Ddo_br_pathology_metaloc_Filteredtext_set = AV87TFBR_Pathology_MetaLoc;
                  ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "FilteredText_set", Ddo_br_pathology_metaloc_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PATHOLOGY_METALOC_SEL") == 0 )
            {
               AV88TFBR_Pathology_MetaLoc_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV88TFBR_Pathology_MetaLoc_Sel", AV88TFBR_Pathology_MetaLoc_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88TFBR_Pathology_MetaLoc_Sel)) )
               {
                  Ddo_br_pathology_metaloc_Selectedvalue_set = AV88TFBR_Pathology_MetaLoc_Sel;
                  ucDdo_br_pathology_metaloc.SendProperty(context, "", false, Ddo_br_pathology_metaloc_Internalname, "SelectedValue_set", Ddo_br_pathology_metaloc_Selectedvalue_set);
               }
            }
            AV132GXV1 = (int)(AV132GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV15Session.Get(AV131Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_PathologyID) && (0==AV18TFBR_PathologyID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_PathologyID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_PathologyID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_EncounterID) && (0==AV22TFBR_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Information_PatientNo_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_INFORMATION_PATIENTNO_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Information_PatientNo_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV29TFBR_PathologyID_TestID) && (0==AV30TFBR_PathologyID_TestID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_TESTID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV29TFBR_PathologyID_TestID), 10, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV30TFBR_PathologyID_TestID_To), 10, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV33TFBR_PathologyID_PADate) && (DateTime.MinValue==AV34TFBR_PathologyID_PADate_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PADATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV33TFBR_PathologyID_PADate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV34TFBR_PathologyID_PADate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV39TFBR_PathologyID_PAHosp)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PAHOSP";
            AV12GridStateFilterValue.gxTpr_Value = AV39TFBR_PathologyID_PAHosp;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV40TFBR_PathologyID_PAHosp_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PAHOSP_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV40TFBR_PathologyID_PAHosp_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV43TFBR_PathologyID_PAAge) && (0==AV44TFBR_PathologyID_PAAge_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PAAGE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV43TFBR_PathologyID_PAAge), 3, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV44TFBR_PathologyID_PAAge_To), 3, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV47TFBR_PathologyID_PrePaDia)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PREPADIA";
            AV12GridStateFilterValue.gxTpr_Value = AV47TFBR_PathologyID_PrePaDia;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV48TFBR_PathologyID_PrePaDia_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PREPADIA_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV48TFBR_PathologyID_PrePaDia_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51TFBR_PathologyID_PAResult)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PARESULT";
            AV12GridStateFilterValue.gxTpr_Value = AV51TFBR_PathologyID_PAResult;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV52TFBR_PathologyID_PAResult_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGYID_PARESULT_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV52TFBR_PathologyID_PAResult_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV91TFBR_Pathology_Dia_Name)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIA_NAME";
            AV12GridStateFilterValue.gxTpr_Value = AV91TFBR_Pathology_Dia_Name;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV92TFBR_Pathology_Dia_Name_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_DIA_NAME_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV92TFBR_Pathology_Dia_Name_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV67TFBR_Pathology_T) && (Convert.ToDecimal(0)==AV68TFBR_Pathology_T_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_T";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV67TFBR_Pathology_T, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV68TFBR_Pathology_T_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV72TFBR_Pathology_N_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_N_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV72TFBR_Pathology_N_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV75TFBR_Pathology_LymphNum) && (Convert.ToDecimal(0)==AV76TFBR_Pathology_LymphNum_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_LYMPHNUM";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV75TFBR_Pathology_LymphNum, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV76TFBR_Pathology_LymphNum_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV79TFBR_Pathology_LymphRate)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_LYMPHRATE";
            AV12GridStateFilterValue.gxTpr_Value = AV79TFBR_Pathology_LymphRate;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV80TFBR_Pathology_LymphRate_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_LYMPHRATE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV80TFBR_Pathology_LymphRate_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV84TFBR_Pathology_M_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_M_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV84TFBR_Pathology_M_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV87TFBR_Pathology_MetaLoc)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_METALOC";
            AV12GridStateFilterValue.gxTpr_Value = AV87TFBR_Pathology_MetaLoc;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV88TFBR_Pathology_MetaLoc_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PATHOLOGY_METALOC_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV88TFBR_Pathology_MetaLoc_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV131Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV131Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Pathology";
         AV15Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA5C2( ) ;
         WS5C2( ) ;
         WE5C2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("DVelop/DVPaginationBar/DVPaginationBar.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/fontawesome/font-awesome.min.css", "");
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815145580", true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.chs.js", "?"+GetCacheInvalidationToken( ), false);
         context.AddJavascriptSource("gxdec.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("br_pathologyww.js", "?202022815145580", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_31_idx;
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID_"+sGXsfl_31_idx;
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE_"+sGXsfl_31_idx;
         edtBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP_"+sGXsfl_31_idx;
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE_"+sGXsfl_31_idx;
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA_"+sGXsfl_31_idx;
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT_"+sGXsfl_31_idx;
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME_"+sGXsfl_31_idx;
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T_"+sGXsfl_31_idx;
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N_"+sGXsfl_31_idx;
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM_"+sGXsfl_31_idx;
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE_"+sGXsfl_31_idx;
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M_"+sGXsfl_31_idx;
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID_"+sGXsfl_31_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA_"+sGXsfl_31_fel_idx;
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T_"+sGXsfl_31_fel_idx;
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE_"+sGXsfl_31_fel_idx;
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M_"+sGXsfl_31_fel_idx;
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB5C0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_31_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)(((nGXsfl_31_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_31_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV59Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV59Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV128Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV59Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV59Display)) ? AV128Display_GXI : context.PathToRelativeUrl( AV59Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV59Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV60Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV60Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV129Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV60Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV60Update)) ? AV129Update_GXI : context.PathToRelativeUrl( AV60Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV60Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV62Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV62Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV130Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV62Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV62Delete)) ? AV130Delete_GXI : context.PathToRelativeUrl( AV62Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV62Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Information_PatientNo_Link,(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_TestID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A237BR_PathologyID_TestID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A237BR_PathologyID_TestID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_PathologyID_TestID_Link,(String)"",(String)"",(String)"",(String)edtBR_PathologyID_TestID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PADate_Internalname,context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"),context.localUtil.Format( A238BR_PathologyID_PADate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PADate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PAHosp_Internalname,(String)A239BR_PathologyID_PAHosp,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PAHosp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PAAge_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A240BR_PathologyID_PAAge), 3, 0, ".", "")),context.localUtil.Format( (decimal)(A240BR_PathologyID_PAAge), "ZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PAAge_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PrePaDia_Internalname,(String)A241BR_PathologyID_PrePaDia,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PrePaDia_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_PathologyID_PAResult_Internalname,(String)A242BR_PathologyID_PAResult,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_PathologyID_PAResult_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)9999,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_Dia_Name_Internalname,(String)A326BR_Pathology_Dia_Name,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_Dia_Name_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)3000,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_T_Internalname,StringUtil.LTrim( StringUtil.NToC( A314BR_Pathology_T, 15, 5, ".", "")),context.localUtil.Format( A314BR_Pathology_T, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_T_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Pathology_N.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PATHOLOGY_N_" + sGXsfl_31_idx;
               cmbBR_Pathology_N.Name = GXCCtl;
               cmbBR_Pathology_N.WebTags = "";
               cmbBR_Pathology_N.addItem("", "(��ѡ��)", 0);
               cmbBR_Pathology_N.addItem("��", "��", 0);
               cmbBR_Pathology_N.addItem("��", "��", 0);
               cmbBR_Pathology_N.addItem("����", "����", 0);
               if ( cmbBR_Pathology_N.ItemCount > 0 )
               {
                  A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
                  n315BR_Pathology_N = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Pathology_N,(String)cmbBR_Pathology_N_Internalname,StringUtil.RTrim( A315BR_Pathology_N),(short)1,(String)cmbBR_Pathology_N_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Pathology_N.CurrentValue = StringUtil.RTrim( A315BR_Pathology_N);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Values", (String)(cmbBR_Pathology_N.ToJavascriptSource()), !bGXsfl_31_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_LymphNum_Internalname,StringUtil.LTrim( StringUtil.NToC( A316BR_Pathology_LymphNum, 15, 5, ".", "")),context.localUtil.Format( A316BR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_LymphNum_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_LymphRate_Internalname,(String)A317BR_Pathology_LymphRate,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_LymphRate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Pathology_M.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PATHOLOGY_M_" + sGXsfl_31_idx;
               cmbBR_Pathology_M.Name = GXCCtl;
               cmbBR_Pathology_M.WebTags = "";
               cmbBR_Pathology_M.addItem("", "(��ѡ��)", 0);
               cmbBR_Pathology_M.addItem("��", "��", 0);
               cmbBR_Pathology_M.addItem("��", "��", 0);
               cmbBR_Pathology_M.addItem("����", "����", 0);
               if ( cmbBR_Pathology_M.ItemCount > 0 )
               {
                  A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
                  n318BR_Pathology_M = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Pathology_M,(String)cmbBR_Pathology_M_Internalname,StringUtil.RTrim( A318BR_Pathology_M),(short)1,(String)cmbBR_Pathology_M_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Pathology_M.CurrentValue = StringUtil.RTrim( A318BR_Pathology_M);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Values", (String)(cmbBR_Pathology_M.ToJavascriptSource()), !bGXsfl_31_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Pathology_MetaLoc_Internalname,(String)A319BR_Pathology_MetaLoc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Pathology_MetaLoc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5C2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         /* End function sendrow_312 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_PATHOLOGY_N_" + sGXsfl_31_idx;
         cmbBR_Pathology_N.Name = GXCCtl;
         cmbBR_Pathology_N.WebTags = "";
         cmbBR_Pathology_N.addItem("", "(��ѡ��)", 0);
         cmbBR_Pathology_N.addItem("��", "��", 0);
         cmbBR_Pathology_N.addItem("��", "��", 0);
         cmbBR_Pathology_N.addItem("����", "����", 0);
         if ( cmbBR_Pathology_N.ItemCount > 0 )
         {
            A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
            n315BR_Pathology_N = false;
         }
         GXCCtl = "BR_PATHOLOGY_M_" + sGXsfl_31_idx;
         cmbBR_Pathology_M.Name = GXCCtl;
         cmbBR_Pathology_M.WebTags = "";
         cmbBR_Pathology_M.addItem("", "(��ѡ��)", 0);
         cmbBR_Pathology_M.addItem("��", "��", 0);
         cmbBR_Pathology_M.addItem("��", "��", 0);
         cmbBR_Pathology_M.addItem("����", "����", 0);
         if ( cmbBR_Pathology_M.ItemCount > 0 )
         {
            A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
            n318BR_Pathology_M = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID";
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE";
         edtBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP";
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE";
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA";
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT";
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME";
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T";
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N";
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM";
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE";
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M";
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_pathologyid_Internalname = "DDO_BR_PATHOLOGYID";
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_testid_Internalname = "DDO_BR_PATHOLOGYID_TESTID";
         edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_padate_Internalname = "DDO_BR_PATHOLOGYID_PADATE";
         edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_pahosp_Internalname = "DDO_BR_PATHOLOGYID_PAHOSP";
         edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_paage_Internalname = "DDO_BR_PATHOLOGYID_PAAGE";
         edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_prepadia_Internalname = "DDO_BR_PATHOLOGYID_PREPADIA";
         edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE";
         Ddo_br_pathologyid_paresult_Internalname = "DDO_BR_PATHOLOGYID_PARESULT";
         edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_dia_name_Internalname = "DDO_BR_PATHOLOGY_DIA_NAME";
         edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_t_Internalname = "DDO_BR_PATHOLOGY_T";
         edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_n_Internalname = "DDO_BR_PATHOLOGY_N";
         edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_lymphnum_Internalname = "DDO_BR_PATHOLOGY_LYMPHNUM";
         edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_lymphrate_Internalname = "DDO_BR_PATHOLOGY_LYMPHRATE";
         edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_m_Internalname = "DDO_BR_PATHOLOGY_M";
         edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE";
         Ddo_br_pathology_metaloc_Internalname = "DDO_BR_PATHOLOGY_METALOC";
         edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname = "vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_pathologyid_Internalname = "vTFBR_PATHOLOGYID";
         edtavTfbr_pathologyid_to_Internalname = "vTFBR_PATHOLOGYID_TO";
         edtavTfbr_encounterid_Internalname = "vTFBR_ENCOUNTERID";
         edtavTfbr_encounterid_to_Internalname = "vTFBR_ENCOUNTERID_TO";
         edtavTfbr_information_patientno_Internalname = "vTFBR_INFORMATION_PATIENTNO";
         edtavTfbr_information_patientno_sel_Internalname = "vTFBR_INFORMATION_PATIENTNO_SEL";
         edtavTfbr_pathologyid_testid_Internalname = "vTFBR_PATHOLOGYID_TESTID";
         edtavTfbr_pathologyid_testid_to_Internalname = "vTFBR_PATHOLOGYID_TESTID_TO";
         edtavTfbr_pathologyid_padate_Internalname = "vTFBR_PATHOLOGYID_PADATE";
         edtavTfbr_pathologyid_padate_to_Internalname = "vTFBR_PATHOLOGYID_PADATE_TO";
         edtavDdo_br_pathologyid_padateauxdate_Internalname = "vDDO_BR_PATHOLOGYID_PADATEAUXDATE";
         edtavDdo_br_pathologyid_padateauxdateto_Internalname = "vDDO_BR_PATHOLOGYID_PADATEAUXDATETO";
         divDdo_br_pathologyid_padateauxdates_Internalname = "DDO_BR_PATHOLOGYID_PADATEAUXDATES";
         edtavTfbr_pathologyid_pahosp_Internalname = "vTFBR_PATHOLOGYID_PAHOSP";
         edtavTfbr_pathologyid_pahosp_sel_Internalname = "vTFBR_PATHOLOGYID_PAHOSP_SEL";
         edtavTfbr_pathologyid_paage_Internalname = "vTFBR_PATHOLOGYID_PAAGE";
         edtavTfbr_pathologyid_paage_to_Internalname = "vTFBR_PATHOLOGYID_PAAGE_TO";
         edtavTfbr_pathologyid_prepadia_Internalname = "vTFBR_PATHOLOGYID_PREPADIA";
         edtavTfbr_pathologyid_prepadia_sel_Internalname = "vTFBR_PATHOLOGYID_PREPADIA_SEL";
         edtavTfbr_pathologyid_paresult_Internalname = "vTFBR_PATHOLOGYID_PARESULT";
         edtavTfbr_pathologyid_paresult_sel_Internalname = "vTFBR_PATHOLOGYID_PARESULT_SEL";
         edtavTfbr_pathology_dia_name_Internalname = "vTFBR_PATHOLOGY_DIA_NAME";
         edtavTfbr_pathology_dia_name_sel_Internalname = "vTFBR_PATHOLOGY_DIA_NAME_SEL";
         edtavTfbr_pathology_t_Internalname = "vTFBR_PATHOLOGY_T";
         edtavTfbr_pathology_t_to_Internalname = "vTFBR_PATHOLOGY_T_TO";
         edtavTfbr_pathology_lymphnum_Internalname = "vTFBR_PATHOLOGY_LYMPHNUM";
         edtavTfbr_pathology_lymphnum_to_Internalname = "vTFBR_PATHOLOGY_LYMPHNUM_TO";
         edtavTfbr_pathology_lymphrate_Internalname = "vTFBR_PATHOLOGY_LYMPHRATE";
         edtavTfbr_pathology_lymphrate_sel_Internalname = "vTFBR_PATHOLOGY_LYMPHRATE_SEL";
         edtavTfbr_pathology_metaloc_Internalname = "vTFBR_PATHOLOGY_METALOC";
         edtavTfbr_pathology_metaloc_sel_Internalname = "vTFBR_PATHOLOGY_METALOC_SEL";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtBR_Pathology_MetaLoc_Jsonclick = "";
         cmbBR_Pathology_M_Jsonclick = "";
         edtBR_Pathology_LymphRate_Jsonclick = "";
         edtBR_Pathology_LymphNum_Jsonclick = "";
         cmbBR_Pathology_N_Jsonclick = "";
         edtBR_Pathology_T_Jsonclick = "";
         edtBR_Pathology_Dia_Name_Jsonclick = "";
         edtBR_PathologyID_PAResult_Jsonclick = "";
         edtBR_PathologyID_PrePaDia_Jsonclick = "";
         edtBR_PathologyID_PAAge_Jsonclick = "";
         edtBR_PathologyID_PAHosp_Jsonclick = "";
         edtBR_PathologyID_PADate_Jsonclick = "";
         edtBR_PathologyID_TestID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_PathologyID_Jsonclick = "";
         edtavTfbr_pathology_metaloc_sel_Jsonclick = "";
         edtavTfbr_pathology_metaloc_sel_Visible = 1;
         edtavTfbr_pathology_metaloc_Jsonclick = "";
         edtavTfbr_pathology_metaloc_Visible = 1;
         edtavTfbr_pathology_lymphrate_sel_Jsonclick = "";
         edtavTfbr_pathology_lymphrate_sel_Visible = 1;
         edtavTfbr_pathology_lymphrate_Jsonclick = "";
         edtavTfbr_pathology_lymphrate_Visible = 1;
         edtavTfbr_pathology_lymphnum_to_Jsonclick = "";
         edtavTfbr_pathology_lymphnum_to_Visible = 1;
         edtavTfbr_pathology_lymphnum_Jsonclick = "";
         edtavTfbr_pathology_lymphnum_Visible = 1;
         edtavTfbr_pathology_t_to_Jsonclick = "";
         edtavTfbr_pathology_t_to_Visible = 1;
         edtavTfbr_pathology_t_Jsonclick = "";
         edtavTfbr_pathology_t_Visible = 1;
         edtavTfbr_pathology_dia_name_sel_Visible = 1;
         edtavTfbr_pathology_dia_name_Visible = 1;
         edtavTfbr_pathologyid_paresult_sel_Visible = 1;
         edtavTfbr_pathologyid_paresult_Visible = 1;
         edtavTfbr_pathologyid_prepadia_sel_Visible = 1;
         edtavTfbr_pathologyid_prepadia_Visible = 1;
         edtavTfbr_pathologyid_paage_to_Jsonclick = "";
         edtavTfbr_pathologyid_paage_to_Visible = 1;
         edtavTfbr_pathologyid_paage_Jsonclick = "";
         edtavTfbr_pathologyid_paage_Visible = 1;
         edtavTfbr_pathologyid_pahosp_sel_Jsonclick = "";
         edtavTfbr_pathologyid_pahosp_sel_Visible = 1;
         edtavTfbr_pathologyid_pahosp_Jsonclick = "";
         edtavTfbr_pathologyid_pahosp_Visible = 1;
         edtavDdo_br_pathologyid_padateauxdateto_Jsonclick = "";
         edtavDdo_br_pathologyid_padateauxdate_Jsonclick = "";
         edtavTfbr_pathologyid_padate_to_Jsonclick = "";
         edtavTfbr_pathologyid_padate_to_Visible = 1;
         edtavTfbr_pathologyid_padate_Jsonclick = "";
         edtavTfbr_pathologyid_padate_Visible = 1;
         edtavTfbr_pathologyid_testid_to_Jsonclick = "";
         edtavTfbr_pathologyid_testid_to_Visible = 1;
         edtavTfbr_pathologyid_testid_Jsonclick = "";
         edtavTfbr_pathologyid_testid_Visible = 1;
         edtavTfbr_information_patientno_sel_Jsonclick = "";
         edtavTfbr_information_patientno_sel_Visible = 1;
         edtavTfbr_information_patientno_Jsonclick = "";
         edtavTfbr_information_patientno_Visible = 1;
         edtavTfbr_encounterid_to_Jsonclick = "";
         edtavTfbr_encounterid_to_Visible = 1;
         edtavTfbr_encounterid_Jsonclick = "";
         edtavTfbr_encounterid_Visible = 1;
         edtavTfbr_pathologyid_to_Jsonclick = "";
         edtavTfbr_pathologyid_to_Visible = 1;
         edtavTfbr_pathologyid_Jsonclick = "";
         edtavTfbr_pathologyid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_PathologyID_TestID_Link = "";
         edtBR_Information_PatientNo_Link = "";
         edtavDelete_Tooltiptext = "ɾ��";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "�޸�";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "��ʾ";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Pathology_MetaLoc_Titleformat = 0;
         edtBR_Pathology_MetaLoc_Title = "Զ��ת�Ʋ�λ";
         cmbBR_Pathology_M_Titleformat = 0;
         cmbBR_Pathology_M.Title.Text = "�Ƿ�Զ��ת��";
         edtBR_Pathology_LymphRate_Titleformat = 0;
         edtBR_Pathology_LymphRate_Title = "�ܰͽ�ת�Ʊ���";
         edtBR_Pathology_LymphNum_Titleformat = 0;
         edtBR_Pathology_LymphNum_Title = "�ܰͽ���Ŀ";
         cmbBR_Pathology_N_Titleformat = 0;
         cmbBR_Pathology_N.Title.Text = "�Ƿ��ܰͽ�ת��";
         edtBR_Pathology_T_Titleformat = 0;
         edtBR_Pathology_T_Title = "ԭ�������ּ�";
         edtBR_Pathology_Dia_Name_Titleformat = 0;
         edtBR_Pathology_Dia_Name_Title = "�����������";
         edtBR_PathologyID_PAResult_Titleformat = 0;
         edtBR_PathologyID_PAResult_Title = "��������";
         edtBR_PathologyID_PrePaDia_Titleformat = 0;
         edtBR_PathologyID_PrePaDia_Title = "����ǰ���";
         edtBR_PathologyID_PAAge_Titleformat = 0;
         edtBR_PathologyID_PAAge_Title = "����";
         edtBR_PathologyID_PAHosp_Titleformat = 0;
         edtBR_PathologyID_PAHosp_Title = "���ҽԺ";
         edtBR_PathologyID_PADate_Titleformat = 0;
         edtBR_PathologyID_PADate_Title = "�����������";
         edtBR_PathologyID_TestID_Titleformat = 0;
         edtBR_PathologyID_TestID_Title = "��Ŀ���";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "���߱��";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "������Ϣ����";
         edtBR_PathologyID_Titleformat = 0;
         edtBR_PathologyID_Title = "����ѧ����";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_pathology_metaloc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_metaloc_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_metaloc_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_metaloc_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_metaloc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_metaloc_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_metaloc_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_metaloc_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_pathology_metaloc_Datalisttype = "Dynamic";
         Ddo_br_pathology_metaloc_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_metaloc_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_metaloc_Filtertype = "Character";
         Ddo_br_pathology_metaloc_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_metaloc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_metaloc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_metaloc_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_metaloc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_metaloc_Cls = "ColumnSettings";
         Ddo_br_pathology_metaloc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_metaloc_Caption = "";
         Ddo_br_pathology_m_Searchbuttontext = "WWP_FilterSelected";
         Ddo_br_pathology_m_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_m_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_m_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_m_Datalistfixedvalues = "��:��,��:��,����:����";
         Ddo_br_pathology_m_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_br_pathology_m_Datalisttype = "FixedValues";
         Ddo_br_pathology_m_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_m_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_m_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_m_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_m_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_m_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_m_Cls = "ColumnSettings";
         Ddo_br_pathology_m_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_m_Caption = "";
         Ddo_br_pathology_lymphrate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_lymphrate_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_lymphrate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_lymphrate_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_lymphrate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_lymphrate_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_lymphrate_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_lymphrate_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_pathology_lymphrate_Datalisttype = "Dynamic";
         Ddo_br_pathology_lymphrate_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphrate_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_lymphrate_Filtertype = "Character";
         Ddo_br_pathology_lymphrate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphrate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphrate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_lymphrate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_lymphrate_Cls = "ColumnSettings";
         Ddo_br_pathology_lymphrate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_lymphrate_Caption = "";
         Ddo_br_pathology_lymphnum_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_lymphnum_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_lymphnum_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_lymphnum_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_lymphnum_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_lymphnum_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_lymphnum_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_lymphnum_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphnum_Filtertype = "Numeric";
         Ddo_br_pathology_lymphnum_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphnum_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphnum_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_lymphnum_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_lymphnum_Cls = "ColumnSettings";
         Ddo_br_pathology_lymphnum_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_lymphnum_Caption = "";
         Ddo_br_pathology_n_Searchbuttontext = "WWP_FilterSelected";
         Ddo_br_pathology_n_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_n_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_n_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_n_Datalistfixedvalues = "��:��,��:��,����:����";
         Ddo_br_pathology_n_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_br_pathology_n_Datalisttype = "FixedValues";
         Ddo_br_pathology_n_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_n_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_pathology_n_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_n_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_n_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_n_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_n_Cls = "ColumnSettings";
         Ddo_br_pathology_n_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_n_Caption = "";
         Ddo_br_pathology_t_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_t_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathology_t_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathology_t_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_t_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_t_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_t_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathology_t_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathology_t_Filtertype = "Numeric";
         Ddo_br_pathology_t_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_t_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_t_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_t_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_t_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_t_Cls = "ColumnSettings";
         Ddo_br_pathology_t_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_t_Caption = "";
         Ddo_br_pathology_dia_name_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathology_dia_name_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathology_dia_name_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathology_dia_name_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathology_dia_name_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathology_dia_name_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathology_dia_name_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathology_dia_name_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_pathology_dia_name_Datalisttype = "Dynamic";
         Ddo_br_pathology_dia_name_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathology_dia_name_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathology_dia_name_Filtertype = "Character";
         Ddo_br_pathology_dia_name_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathology_dia_name_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathology_dia_name_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathology_dia_name_Titlecontrolidtoreplace = "";
         Ddo_br_pathology_dia_name_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathology_dia_name_Cls = "ColumnSettings";
         Ddo_br_pathology_dia_name_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathology_dia_name_Caption = "";
         Ddo_br_pathologyid_paresult_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_paresult_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathologyid_paresult_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_paresult_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathologyid_paresult_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_paresult_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_paresult_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathologyid_paresult_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_pathologyid_paresult_Datalisttype = "Dynamic";
         Ddo_br_pathologyid_paresult_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paresult_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_paresult_Filtertype = "Character";
         Ddo_br_pathologyid_paresult_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paresult_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paresult_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_paresult_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_paresult_Cls = "ColumnSettings";
         Ddo_br_pathologyid_paresult_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_paresult_Caption = "";
         Ddo_br_pathologyid_prepadia_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_prepadia_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathologyid_prepadia_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_prepadia_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathologyid_prepadia_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_prepadia_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_prepadia_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathologyid_prepadia_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_pathologyid_prepadia_Datalisttype = "Dynamic";
         Ddo_br_pathologyid_prepadia_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_prepadia_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_prepadia_Filtertype = "Character";
         Ddo_br_pathologyid_prepadia_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_prepadia_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_prepadia_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_prepadia_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_prepadia_Cls = "ColumnSettings";
         Ddo_br_pathologyid_prepadia_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_prepadia_Caption = "";
         Ddo_br_pathologyid_paage_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_paage_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathologyid_paage_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathologyid_paage_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_paage_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_paage_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_paage_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_paage_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paage_Filtertype = "Numeric";
         Ddo_br_pathologyid_paage_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paage_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paage_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_paage_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_paage_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_paage_Cls = "ColumnSettings";
         Ddo_br_pathologyid_paage_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_paage_Caption = "";
         Ddo_br_pathologyid_pahosp_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_pahosp_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_pathologyid_pahosp_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_pahosp_Loadingdata = "WWP_TSLoading";
         Ddo_br_pathologyid_pahosp_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_pahosp_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_pahosp_Datalistupdateminimumcharacters = 0;
         Ddo_br_pathologyid_pahosp_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_pathologyid_pahosp_Datalisttype = "Dynamic";
         Ddo_br_pathologyid_pahosp_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_pahosp_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_pahosp_Filtertype = "Character";
         Ddo_br_pathologyid_pahosp_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_pahosp_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_pahosp_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_pahosp_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_pahosp_Cls = "ColumnSettings";
         Ddo_br_pathologyid_pahosp_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_pahosp_Caption = "";
         Ddo_br_pathologyid_padate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_padate_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathologyid_padate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathologyid_padate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_padate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_padate_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_padate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_padate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_padate_Filtertype = "Date";
         Ddo_br_pathologyid_padate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_padate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_padate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_padate_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_padate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_padate_Cls = "ColumnSettings";
         Ddo_br_pathologyid_padate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_padate_Caption = "";
         Ddo_br_pathologyid_testid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_testid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathologyid_testid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathologyid_testid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_testid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_testid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_testid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_testid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_testid_Filtertype = "Numeric";
         Ddo_br_pathologyid_testid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_testid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_testid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_testid_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_testid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_testid_Cls = "ColumnSettings";
         Ddo_br_pathologyid_testid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_testid_Caption = "";
         Ddo_br_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_information_patientno_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_information_patientno_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_information_patientno_Loadingdata = "WWP_TSLoading";
         Ddo_br_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_br_information_patientno_Datalistupdateminimumcharacters = 0;
         Ddo_br_information_patientno_Datalistproc = "BR_PathologyWWGetFilterData";
         Ddo_br_information_patientno_Datalisttype = "Dynamic";
         Ddo_br_information_patientno_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Filtertype = "Character";
         Ddo_br_information_patientno_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_br_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_information_patientno_Cls = "ColumnSettings";
         Ddo_br_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_information_patientno_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Filtertype = "Numeric";
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
         Ddo_br_pathologyid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_pathologyid_Rangefilterto = "WWP_TSTo";
         Ddo_br_pathologyid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_pathologyid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_pathologyid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_pathologyid_Sortasc = "WWP_TSSortASC";
         Ddo_br_pathologyid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_pathologyid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Filtertype = "Numeric";
         Ddo_br_pathologyid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_pathologyid_Titlecontrolidtoreplace = "";
         Ddo_br_pathologyid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_pathologyid_Cls = "ColumnSettings";
         Ddo_br_pathologyid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_pathologyid_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridpaginationbar_Rowsperpageselectedvalue = 10;
         Gridpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridpaginationbar_Pagingcaptionposition = "Left";
         Gridpaginationbar_Pagingbuttonsposition = "Right";
         Gridpaginationbar_Pagestoshow = 5;
         Gridpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridpaginationbar_Caption = "<CURRENT_PAGE>ҳ/<TOTAL_PAGES>ҳ ��¼��<TOTAL_RECORDS>��";
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Class = "PaginationBar";
         Dvpanel_tableheader_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Iconposition = "left";
         Dvpanel_tableheader_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Title = "ѡ��";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = " ����ѧ";
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED","{handler:'E135C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E145C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_br_encounterid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_br_encounterid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E155C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'Ddo_br_information_patientno_Filteredtext_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'Ddo_br_information_patientno_Selectedvalue_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_TESTID.ONOPTIONCLICKED","{handler:'E165C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_testid_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_testid_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_testid_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_TESTID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PADATE.ONOPTIONCLICKED","{handler:'E175C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_padate_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_padate_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_padate_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PADATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAHOSP.ONOPTIONCLICKED","{handler:'E185C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_pahosp_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_pahosp_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_pahosp_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAHOSP.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAAGE.ONOPTIONCLICKED","{handler:'E195C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_paage_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_paage_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_paage_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PAAGE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PREPADIA.ONOPTIONCLICKED","{handler:'E205C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_prepadia_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_prepadia_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_prepadia_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PREPADIA.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGYID_PARESULT.ONOPTIONCLICKED","{handler:'E215C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathologyid_paresult_Activeeventkey',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'ActiveEventKey'},{av:'Ddo_br_pathologyid_paresult_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'FilteredText_get'},{av:'Ddo_br_pathologyid_paresult_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGYID_PARESULT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_DIA_NAME.ONOPTIONCLICKED","{handler:'E225C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_dia_name_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_dia_name_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'FilteredText_get'},{av:'Ddo_br_pathology_dia_name_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_DIA_NAME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_T.ONOPTIONCLICKED","{handler:'E235C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_t_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_T',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_t_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_T',prop:'FilteredText_get'},{av:'Ddo_br_pathology_t_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_T',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_T.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_N.ONOPTIONCLICKED","{handler:'E245C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_n_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_N',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_n_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_N.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHNUM.ONOPTIONCLICKED","{handler:'E255C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_lymphnum_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_lymphnum_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'FilteredText_get'},{av:'Ddo_br_pathology_lymphnum_Filteredtextto_get',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHNUM.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHRATE.ONOPTIONCLICKED","{handler:'E265C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_lymphrate_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_lymphrate_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'FilteredText_get'},{av:'Ddo_br_pathology_lymphrate_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_LYMPHRATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_M.ONOPTIONCLICKED","{handler:'E275C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_m_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_M',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_m_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_M.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PATHOLOGY_METALOC.ONOPTIONCLICKED","{handler:'E285C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_PathologyID',fld:'vTFBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_PathologyID_To',fld:'vTFBR_PATHOLOGYID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV26TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV29TFBR_PathologyID_TestID',fld:'vTFBR_PATHOLOGYID_TESTID',pic:'ZZZZZZZZZZ'},{av:'AV30TFBR_PathologyID_TestID_To',fld:'vTFBR_PATHOLOGYID_TESTID_TO',pic:'ZZZZZZZZZZ'},{av:'AV33TFBR_PathologyID_PADate',fld:'vTFBR_PATHOLOGYID_PADATE',pic:''},{av:'AV34TFBR_PathologyID_PADate_To',fld:'vTFBR_PATHOLOGYID_PADATE_TO',pic:''},{av:'AV39TFBR_PathologyID_PAHosp',fld:'vTFBR_PATHOLOGYID_PAHOSP',pic:''},{av:'AV40TFBR_PathologyID_PAHosp_Sel',fld:'vTFBR_PATHOLOGYID_PAHOSP_SEL',pic:''},{av:'AV43TFBR_PathologyID_PAAge',fld:'vTFBR_PATHOLOGYID_PAAGE',pic:'ZZZ'},{av:'AV44TFBR_PathologyID_PAAge_To',fld:'vTFBR_PATHOLOGYID_PAAGE_TO',pic:'ZZZ'},{av:'AV47TFBR_PathologyID_PrePaDia',fld:'vTFBR_PATHOLOGYID_PREPADIA',pic:''},{av:'AV48TFBR_PathologyID_PrePaDia_Sel',fld:'vTFBR_PATHOLOGYID_PREPADIA_SEL',pic:''},{av:'AV51TFBR_PathologyID_PAResult',fld:'vTFBR_PATHOLOGYID_PARESULT',pic:''},{av:'AV52TFBR_PathologyID_PAResult_Sel',fld:'vTFBR_PATHOLOGYID_PARESULT_SEL',pic:''},{av:'AV91TFBR_Pathology_Dia_Name',fld:'vTFBR_PATHOLOGY_DIA_NAME',pic:''},{av:'AV92TFBR_Pathology_Dia_Name_Sel',fld:'vTFBR_PATHOLOGY_DIA_NAME_SEL',pic:''},{av:'AV67TFBR_Pathology_T',fld:'vTFBR_PATHOLOGY_T',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV68TFBR_Pathology_T_To',fld:'vTFBR_PATHOLOGY_T_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV75TFBR_Pathology_LymphNum',fld:'vTFBR_PATHOLOGY_LYMPHNUM',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV76TFBR_Pathology_LymphNum_To',fld:'vTFBR_PATHOLOGY_LYMPHNUM_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV79TFBR_Pathology_LymphRate',fld:'vTFBR_PATHOLOGY_LYMPHRATE',pic:''},{av:'AV80TFBR_Pathology_LymphRate_Sel',fld:'vTFBR_PATHOLOGY_LYMPHRATE_SEL',pic:''},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'AV19ddo_BR_PathologyIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_TESTIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PADATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PAAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PREPADIATITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGYID_PARESULTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_DIA_NAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_BR_Pathology_TTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_TTITLECONTROLIDTOREPLACE',pic:''},{av:'AV73ddo_BR_Pathology_NTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_NTITLECONTROLIDTOREPLACE',pic:''},{av:'AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHNUMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_LYMPHRATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV85ddo_BR_Pathology_MTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_MTITLECONTROLIDTOREPLACE',pic:''},{av:'AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace',fld:'vDDO_BR_PATHOLOGY_METALOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV72TFBR_Pathology_N_Sels',fld:'vTFBR_PATHOLOGY_N_SELS',pic:''},{av:'AV84TFBR_Pathology_M_Sels',fld:'vTFBR_PATHOLOGY_M_SELS',pic:''},{av:'AV131Pgmname',fld:'vPGMNAME',pic:''},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_pathology_metaloc_Activeeventkey',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'ActiveEventKey'},{av:'Ddo_br_pathology_metaloc_Filteredtext_get',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'FilteredText_get'},{av:'Ddo_br_pathology_metaloc_Selectedvalue_get',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PATHOLOGY_METALOC.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_pathology_metaloc_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_METALOC',prop:'SortedStatus'},{av:'AV87TFBR_Pathology_MetaLoc',fld:'vTFBR_PATHOLOGY_METALOC',pic:''},{av:'AV88TFBR_Pathology_MetaLoc_Sel',fld:'vTFBR_PATHOLOGY_METALOC_SEL',pic:''},{av:'Ddo_br_pathologyid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_testid_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_TESTID',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_padate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PADATE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_pahosp_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAHOSP',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paage_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PAAGE',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_prepadia_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PREPADIA',prop:'SortedStatus'},{av:'Ddo_br_pathologyid_paresult_Sortedstatus',ctrl:'DDO_BR_PATHOLOGYID_PARESULT',prop:'SortedStatus'},{av:'Ddo_br_pathology_dia_name_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_DIA_NAME',prop:'SortedStatus'},{av:'Ddo_br_pathology_t_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_T',prop:'SortedStatus'},{av:'Ddo_br_pathology_n_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_N',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphnum_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHNUM',prop:'SortedStatus'},{av:'Ddo_br_pathology_lymphrate_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_LYMPHRATE',prop:'SortedStatus'},{av:'Ddo_br_pathology_m_Sortedstatus',ctrl:'DDO_BR_PATHOLOGY_M',prop:'SortedStatus'},{av:'AV16BR_PathologyIDTitleFilterData',fld:'vBR_PATHOLOGYIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV28BR_PathologyID_TestIDTitleFilterData',fld:'vBR_PATHOLOGYID_TESTIDTITLEFILTERDATA',pic:''},{av:'AV32BR_PathologyID_PADateTitleFilterData',fld:'vBR_PATHOLOGYID_PADATETITLEFILTERDATA',pic:''},{av:'AV38BR_PathologyID_PAHospTitleFilterData',fld:'vBR_PATHOLOGYID_PAHOSPTITLEFILTERDATA',pic:''},{av:'AV42BR_PathologyID_PAAgeTitleFilterData',fld:'vBR_PATHOLOGYID_PAAGETITLEFILTERDATA',pic:''},{av:'AV46BR_PathologyID_PrePaDiaTitleFilterData',fld:'vBR_PATHOLOGYID_PREPADIATITLEFILTERDATA',pic:''},{av:'AV50BR_PathologyID_PAResultTitleFilterData',fld:'vBR_PATHOLOGYID_PARESULTTITLEFILTERDATA',pic:''},{av:'AV90BR_Pathology_Dia_NameTitleFilterData',fld:'vBR_PATHOLOGY_DIA_NAMETITLEFILTERDATA',pic:''},{av:'AV66BR_Pathology_TTitleFilterData',fld:'vBR_PATHOLOGY_TTITLEFILTERDATA',pic:''},{av:'AV70BR_Pathology_NTitleFilterData',fld:'vBR_PATHOLOGY_NTITLEFILTERDATA',pic:''},{av:'AV74BR_Pathology_LymphNumTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHNUMTITLEFILTERDATA',pic:''},{av:'AV78BR_Pathology_LymphRateTitleFilterData',fld:'vBR_PATHOLOGY_LYMPHRATETITLEFILTERDATA',pic:''},{av:'AV82BR_Pathology_MTitleFilterData',fld:'vBR_PATHOLOGY_MTITLEFILTERDATA',pic:''},{av:'AV86BR_Pathology_MetaLocTitleFilterData',fld:'vBR_PATHOLOGY_METALOCTITLEFILTERDATA',pic:''},{av:'edtBR_PathologyID_Titleformat',ctrl:'BR_PATHOLOGYID',prop:'Titleformat'},{av:'edtBR_PathologyID_Title',ctrl:'BR_PATHOLOGYID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_PathologyID_TestID_Titleformat',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Titleformat'},{av:'edtBR_PathologyID_TestID_Title',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Title'},{av:'edtBR_PathologyID_PADate_Titleformat',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Titleformat'},{av:'edtBR_PathologyID_PADate_Title',ctrl:'BR_PATHOLOGYID_PADATE',prop:'Title'},{av:'edtBR_PathologyID_PAHosp_Titleformat',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Titleformat'},{av:'edtBR_PathologyID_PAHosp_Title',ctrl:'BR_PATHOLOGYID_PAHOSP',prop:'Title'},{av:'edtBR_PathologyID_PAAge_Titleformat',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Titleformat'},{av:'edtBR_PathologyID_PAAge_Title',ctrl:'BR_PATHOLOGYID_PAAGE',prop:'Title'},{av:'edtBR_PathologyID_PrePaDia_Titleformat',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Titleformat'},{av:'edtBR_PathologyID_PrePaDia_Title',ctrl:'BR_PATHOLOGYID_PREPADIA',prop:'Title'},{av:'edtBR_PathologyID_PAResult_Titleformat',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Titleformat'},{av:'edtBR_PathologyID_PAResult_Title',ctrl:'BR_PATHOLOGYID_PARESULT',prop:'Title'},{av:'edtBR_Pathology_Dia_Name_Titleformat',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Titleformat'},{av:'edtBR_Pathology_Dia_Name_Title',ctrl:'BR_PATHOLOGY_DIA_NAME',prop:'Title'},{av:'edtBR_Pathology_T_Titleformat',ctrl:'BR_PATHOLOGY_T',prop:'Titleformat'},{av:'edtBR_Pathology_T_Title',ctrl:'BR_PATHOLOGY_T',prop:'Title'},{av:'cmbBR_Pathology_N'},{av:'edtBR_Pathology_LymphNum_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Titleformat'},{av:'edtBR_Pathology_LymphNum_Title',ctrl:'BR_PATHOLOGY_LYMPHNUM',prop:'Title'},{av:'edtBR_Pathology_LymphRate_Titleformat',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Titleformat'},{av:'edtBR_Pathology_LymphRate_Title',ctrl:'BR_PATHOLOGY_LYMPHRATE',prop:'Title'},{av:'cmbBR_Pathology_M'},{av:'edtBR_Pathology_MetaLoc_Titleformat',ctrl:'BR_PATHOLOGY_METALOC',prop:'Titleformat'},{av:'edtBR_Pathology_MetaLoc_Title',ctrl:'BR_PATHOLOGY_METALOC',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV57GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV58GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E325C2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV61IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV63IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV64IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV59Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV60Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV62Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Information_PatientNo_Link',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Link'},{av:'edtBR_PathologyID_TestID_Link',ctrl:'BR_PATHOLOGYID_TESTID',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E295C2',iparms:[{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_pathologyid_Activeeventkey = "";
         Ddo_br_pathologyid_Filteredtext_get = "";
         Ddo_br_pathologyid_Filteredtextto_get = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterid_Filteredtext_get = "";
         Ddo_br_encounterid_Filteredtextto_get = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_information_patientno_Filteredtext_get = "";
         Ddo_br_information_patientno_Selectedvalue_get = "";
         Ddo_br_pathologyid_testid_Activeeventkey = "";
         Ddo_br_pathologyid_testid_Filteredtext_get = "";
         Ddo_br_pathologyid_testid_Filteredtextto_get = "";
         Ddo_br_pathologyid_padate_Activeeventkey = "";
         Ddo_br_pathologyid_padate_Filteredtext_get = "";
         Ddo_br_pathologyid_padate_Filteredtextto_get = "";
         Ddo_br_pathologyid_pahosp_Activeeventkey = "";
         Ddo_br_pathologyid_pahosp_Filteredtext_get = "";
         Ddo_br_pathologyid_pahosp_Selectedvalue_get = "";
         Ddo_br_pathologyid_paage_Activeeventkey = "";
         Ddo_br_pathologyid_paage_Filteredtext_get = "";
         Ddo_br_pathologyid_paage_Filteredtextto_get = "";
         Ddo_br_pathologyid_prepadia_Activeeventkey = "";
         Ddo_br_pathologyid_prepadia_Filteredtext_get = "";
         Ddo_br_pathologyid_prepadia_Selectedvalue_get = "";
         Ddo_br_pathologyid_paresult_Activeeventkey = "";
         Ddo_br_pathologyid_paresult_Filteredtext_get = "";
         Ddo_br_pathologyid_paresult_Selectedvalue_get = "";
         Ddo_br_pathology_dia_name_Activeeventkey = "";
         Ddo_br_pathology_dia_name_Filteredtext_get = "";
         Ddo_br_pathology_dia_name_Selectedvalue_get = "";
         Ddo_br_pathology_t_Activeeventkey = "";
         Ddo_br_pathology_t_Filteredtext_get = "";
         Ddo_br_pathology_t_Filteredtextto_get = "";
         Ddo_br_pathology_n_Activeeventkey = "";
         Ddo_br_pathology_n_Selectedvalue_get = "";
         Ddo_br_pathology_lymphnum_Activeeventkey = "";
         Ddo_br_pathology_lymphnum_Filteredtext_get = "";
         Ddo_br_pathology_lymphnum_Filteredtextto_get = "";
         Ddo_br_pathology_lymphrate_Activeeventkey = "";
         Ddo_br_pathology_lymphrate_Filteredtext_get = "";
         Ddo_br_pathology_lymphrate_Selectedvalue_get = "";
         Ddo_br_pathology_m_Activeeventkey = "";
         Ddo_br_pathology_m_Selectedvalue_get = "";
         Ddo_br_pathology_metaloc_Activeeventkey = "";
         Ddo_br_pathology_metaloc_Filteredtext_get = "";
         Ddo_br_pathology_metaloc_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Information_PatientNo = "";
         AV26TFBR_Information_PatientNo_Sel = "";
         AV33TFBR_PathologyID_PADate = DateTime.MinValue;
         AV34TFBR_PathologyID_PADate_To = DateTime.MinValue;
         AV39TFBR_PathologyID_PAHosp = "";
         AV40TFBR_PathologyID_PAHosp_Sel = "";
         AV47TFBR_PathologyID_PrePaDia = "";
         AV48TFBR_PathologyID_PrePaDia_Sel = "";
         AV51TFBR_PathologyID_PAResult = "";
         AV52TFBR_PathologyID_PAResult_Sel = "";
         AV91TFBR_Pathology_Dia_Name = "";
         AV92TFBR_Pathology_Dia_Name_Sel = "";
         AV79TFBR_Pathology_LymphRate = "";
         AV80TFBR_Pathology_LymphRate_Sel = "";
         AV87TFBR_Pathology_MetaLoc = "";
         AV88TFBR_Pathology_MetaLoc_Sel = "";
         AV19ddo_BR_PathologyIDTitleControlIdToReplace = "";
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV27ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace = "";
         AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace = "";
         AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace = "";
         AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace = "";
         AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace = "";
         AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace = "";
         AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace = "";
         AV69ddo_BR_Pathology_TTitleControlIdToReplace = "";
         AV73ddo_BR_Pathology_NTitleControlIdToReplace = "";
         AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace = "";
         AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace = "";
         AV85ddo_BR_Pathology_MTitleControlIdToReplace = "";
         AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace = "";
         AV72TFBR_Pathology_N_Sels = new GxSimpleCollection<String>();
         AV84TFBR_Pathology_M_Sels = new GxSimpleCollection<String>();
         AV131Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV54DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_PathologyIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_PathologyID_TestIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_PathologyID_PADateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_PathologyID_PAHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_PathologyID_PAAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46BR_PathologyID_PrePaDiaTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_PathologyID_PAResultTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV90BR_Pathology_Dia_NameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66BR_Pathology_TTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV70BR_Pathology_NTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV74BR_Pathology_LymphNumTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV78BR_Pathology_LymphRateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV82BR_Pathology_MTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV86BR_Pathology_MetaLocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_pathologyid_Filteredtext_set = "";
         Ddo_br_pathologyid_Filteredtextto_set = "";
         Ddo_br_pathologyid_Sortedstatus = "";
         Ddo_br_encounterid_Filteredtext_set = "";
         Ddo_br_encounterid_Filteredtextto_set = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Filteredtext_set = "";
         Ddo_br_information_patientno_Selectedvalue_set = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_pathologyid_testid_Filteredtext_set = "";
         Ddo_br_pathologyid_testid_Filteredtextto_set = "";
         Ddo_br_pathologyid_testid_Sortedstatus = "";
         Ddo_br_pathologyid_padate_Filteredtext_set = "";
         Ddo_br_pathologyid_padate_Filteredtextto_set = "";
         Ddo_br_pathologyid_padate_Sortedstatus = "";
         Ddo_br_pathologyid_pahosp_Filteredtext_set = "";
         Ddo_br_pathologyid_pahosp_Selectedvalue_set = "";
         Ddo_br_pathologyid_pahosp_Sortedstatus = "";
         Ddo_br_pathologyid_paage_Filteredtext_set = "";
         Ddo_br_pathologyid_paage_Filteredtextto_set = "";
         Ddo_br_pathologyid_paage_Sortedstatus = "";
         Ddo_br_pathologyid_prepadia_Filteredtext_set = "";
         Ddo_br_pathologyid_prepadia_Selectedvalue_set = "";
         Ddo_br_pathologyid_prepadia_Sortedstatus = "";
         Ddo_br_pathologyid_paresult_Filteredtext_set = "";
         Ddo_br_pathologyid_paresult_Selectedvalue_set = "";
         Ddo_br_pathologyid_paresult_Sortedstatus = "";
         Ddo_br_pathology_dia_name_Filteredtext_set = "";
         Ddo_br_pathology_dia_name_Selectedvalue_set = "";
         Ddo_br_pathology_dia_name_Sortedstatus = "";
         Ddo_br_pathology_t_Filteredtext_set = "";
         Ddo_br_pathology_t_Filteredtextto_set = "";
         Ddo_br_pathology_t_Sortedstatus = "";
         Ddo_br_pathology_n_Selectedvalue_set = "";
         Ddo_br_pathology_n_Sortedstatus = "";
         Ddo_br_pathology_lymphnum_Filteredtext_set = "";
         Ddo_br_pathology_lymphnum_Filteredtextto_set = "";
         Ddo_br_pathology_lymphnum_Sortedstatus = "";
         Ddo_br_pathology_lymphrate_Filteredtext_set = "";
         Ddo_br_pathology_lymphrate_Selectedvalue_set = "";
         Ddo_br_pathology_lymphrate_Sortedstatus = "";
         Ddo_br_pathology_m_Selectedvalue_set = "";
         Ddo_br_pathology_m_Sortedstatus = "";
         Ddo_br_pathology_metaloc_Filteredtext_set = "";
         Ddo_br_pathology_metaloc_Selectedvalue_set = "";
         Ddo_br_pathology_metaloc_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV59Display = "";
         AV60Update = "";
         AV62Delete = "";
         A36BR_Information_PatientNo = "";
         A238BR_PathologyID_PADate = DateTime.MinValue;
         A239BR_PathologyID_PAHosp = "";
         A241BR_PathologyID_PrePaDia = "";
         A242BR_PathologyID_PAResult = "";
         A326BR_Pathology_Dia_Name = "";
         A315BR_Pathology_N = "";
         A317BR_Pathology_LymphRate = "";
         A318BR_Pathology_M = "";
         A319BR_Pathology_MetaLoc = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_pathologyid = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_pathologyid_testid = new GXUserControl();
         ucDdo_br_pathologyid_padate = new GXUserControl();
         ucDdo_br_pathologyid_pahosp = new GXUserControl();
         ucDdo_br_pathologyid_paage = new GXUserControl();
         ucDdo_br_pathologyid_prepadia = new GXUserControl();
         ucDdo_br_pathologyid_paresult = new GXUserControl();
         ucDdo_br_pathology_dia_name = new GXUserControl();
         ucDdo_br_pathology_t = new GXUserControl();
         ucDdo_br_pathology_n = new GXUserControl();
         ucDdo_br_pathology_lymphnum = new GXUserControl();
         ucDdo_br_pathology_lymphrate = new GXUserControl();
         ucDdo_br_pathology_m = new GXUserControl();
         ucDdo_br_pathology_metaloc = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV35DDO_BR_PathologyID_PADateAuxDate = DateTime.MinValue;
         AV36DDO_BR_PathologyID_PADateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV128Display_GXI = "";
         AV129Update_GXI = "";
         AV130Delete_GXI = "";
         AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels = new GxSimpleCollection<String>();
         AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels = new GxSimpleCollection<String>();
         scmdbuf = "";
         lV102BR_PathologyWWDS_5_Tfbr_information_patientno = "";
         lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = "";
         lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = "";
         lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = "";
         lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = "";
         lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = "";
         lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = "";
         AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel = "";
         AV102BR_PathologyWWDS_5_Tfbr_information_patientno = "";
         AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate = DateTime.MinValue;
         AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to = DateTime.MinValue;
         AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel = "";
         AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp = "";
         AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel = "";
         AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia = "";
         AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel = "";
         AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult = "";
         AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel = "";
         AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name = "";
         AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel = "";
         AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate = "";
         AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel = "";
         AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc = "";
         H005C2_A85BR_Information_ID = new long[1] ;
         H005C2_n85BR_Information_ID = new bool[] {false} ;
         H005C2_A319BR_Pathology_MetaLoc = new String[] {""} ;
         H005C2_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         H005C2_A318BR_Pathology_M = new String[] {""} ;
         H005C2_n318BR_Pathology_M = new bool[] {false} ;
         H005C2_A317BR_Pathology_LymphRate = new String[] {""} ;
         H005C2_n317BR_Pathology_LymphRate = new bool[] {false} ;
         H005C2_A316BR_Pathology_LymphNum = new decimal[1] ;
         H005C2_n316BR_Pathology_LymphNum = new bool[] {false} ;
         H005C2_A315BR_Pathology_N = new String[] {""} ;
         H005C2_n315BR_Pathology_N = new bool[] {false} ;
         H005C2_A314BR_Pathology_T = new decimal[1] ;
         H005C2_n314BR_Pathology_T = new bool[] {false} ;
         H005C2_A326BR_Pathology_Dia_Name = new String[] {""} ;
         H005C2_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         H005C2_A242BR_PathologyID_PAResult = new String[] {""} ;
         H005C2_n242BR_PathologyID_PAResult = new bool[] {false} ;
         H005C2_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         H005C2_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         H005C2_A240BR_PathologyID_PAAge = new short[1] ;
         H005C2_n240BR_PathologyID_PAAge = new bool[] {false} ;
         H005C2_A239BR_PathologyID_PAHosp = new String[] {""} ;
         H005C2_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         H005C2_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         H005C2_n238BR_PathologyID_PADate = new bool[] {false} ;
         H005C2_A237BR_PathologyID_TestID = new long[1] ;
         H005C2_n237BR_PathologyID_TestID = new bool[] {false} ;
         H005C2_A36BR_Information_PatientNo = new String[] {""} ;
         H005C2_n36BR_Information_PatientNo = new bool[] {false} ;
         H005C2_A19BR_EncounterID = new long[1] ;
         H005C2_n19BR_EncounterID = new bool[] {false} ;
         H005C2_A226BR_PathologyID = new long[1] ;
         H005C3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV71TFBR_Pathology_N_SelsJson = "";
         AV83TFBR_Pathology_M_SelsJson = "";
         GridRow = new GXWebRow();
         AV15Session = context.GetSession();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathologyww__default(),
            new Object[][] {
                new Object[] {
               H005C2_A85BR_Information_ID, H005C2_n85BR_Information_ID, H005C2_A319BR_Pathology_MetaLoc, H005C2_n319BR_Pathology_MetaLoc, H005C2_A318BR_Pathology_M, H005C2_n318BR_Pathology_M, H005C2_A317BR_Pathology_LymphRate, H005C2_n317BR_Pathology_LymphRate, H005C2_A316BR_Pathology_LymphNum, H005C2_n316BR_Pathology_LymphNum,
               H005C2_A315BR_Pathology_N, H005C2_n315BR_Pathology_N, H005C2_A314BR_Pathology_T, H005C2_n314BR_Pathology_T, H005C2_A326BR_Pathology_Dia_Name, H005C2_n326BR_Pathology_Dia_Name, H005C2_A242BR_PathologyID_PAResult, H005C2_n242BR_PathologyID_PAResult, H005C2_A241BR_PathologyID_PrePaDia, H005C2_n241BR_PathologyID_PrePaDia,
               H005C2_A240BR_PathologyID_PAAge, H005C2_n240BR_PathologyID_PAAge, H005C2_A239BR_PathologyID_PAHosp, H005C2_n239BR_PathologyID_PAHosp, H005C2_A238BR_PathologyID_PADate, H005C2_n238BR_PathologyID_PADate, H005C2_A237BR_PathologyID_TestID, H005C2_n237BR_PathologyID_TestID, H005C2_A36BR_Information_PatientNo, H005C2_n36BR_Information_PatientNo,
               H005C2_A19BR_EncounterID, H005C2_n19BR_EncounterID, H005C2_A226BR_PathologyID
               }
               , new Object[] {
               H005C3_AGRID_nRecordCount
               }
            }
         );
         AV131Pgmname = "BR_PathologyWW";
         /* GeneXus formulas. */
         AV131Pgmname = "BR_PathologyWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_31 ;
      private short nGXsfl_31_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short AV43TFBR_PathologyID_PAAge ;
      private short AV44TFBR_PathologyID_PAAge_To ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_PathologyID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_PathologyID_TestID_Titleformat ;
      private short edtBR_PathologyID_PADate_Titleformat ;
      private short edtBR_PathologyID_PAHosp_Titleformat ;
      private short edtBR_PathologyID_PAAge_Titleformat ;
      private short edtBR_PathologyID_PrePaDia_Titleformat ;
      private short edtBR_PathologyID_PAResult_Titleformat ;
      private short edtBR_Pathology_Dia_Name_Titleformat ;
      private short edtBR_Pathology_T_Titleformat ;
      private short cmbBR_Pathology_N_Titleformat ;
      private short edtBR_Pathology_LymphNum_Titleformat ;
      private short edtBR_Pathology_LymphRate_Titleformat ;
      private short cmbBR_Pathology_M_Titleformat ;
      private short edtBR_Pathology_MetaLoc_Titleformat ;
      private short subGrid_Sortable ;
      private short A240BR_PathologyID_PAAge ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage ;
      private short AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_br_information_patientno_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathologyid_pahosp_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathologyid_prepadia_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathologyid_paresult_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_dia_name_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_lymphrate_Datalistupdateminimumcharacters ;
      private int Ddo_br_pathology_metaloc_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_pathologyidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_ttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_ntitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_mtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_pathologyid_Visible ;
      private int edtavTfbr_pathologyid_to_Visible ;
      private int edtavTfbr_encounterid_Visible ;
      private int edtavTfbr_encounterid_to_Visible ;
      private int edtavTfbr_information_patientno_Visible ;
      private int edtavTfbr_information_patientno_sel_Visible ;
      private int edtavTfbr_pathologyid_testid_Visible ;
      private int edtavTfbr_pathologyid_testid_to_Visible ;
      private int edtavTfbr_pathologyid_padate_Visible ;
      private int edtavTfbr_pathologyid_padate_to_Visible ;
      private int edtavTfbr_pathologyid_pahosp_Visible ;
      private int edtavTfbr_pathologyid_pahosp_sel_Visible ;
      private int edtavTfbr_pathologyid_paage_Visible ;
      private int edtavTfbr_pathologyid_paage_to_Visible ;
      private int edtavTfbr_pathologyid_prepadia_Visible ;
      private int edtavTfbr_pathologyid_prepadia_sel_Visible ;
      private int edtavTfbr_pathologyid_paresult_Visible ;
      private int edtavTfbr_pathologyid_paresult_sel_Visible ;
      private int edtavTfbr_pathology_dia_name_Visible ;
      private int edtavTfbr_pathology_dia_name_sel_Visible ;
      private int edtavTfbr_pathology_t_Visible ;
      private int edtavTfbr_pathology_t_to_Visible ;
      private int edtavTfbr_pathology_lymphnum_Visible ;
      private int edtavTfbr_pathology_lymphnum_to_Visible ;
      private int edtavTfbr_pathology_lymphrate_Visible ;
      private int edtavTfbr_pathology_lymphrate_sel_Visible ;
      private int edtavTfbr_pathology_metaloc_Visible ;
      private int edtavTfbr_pathology_metaloc_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ;
      private int AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ;
      private int AV55PageToGo ;
      private int AV132GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_PathologyID ;
      private long AV18TFBR_PathologyID_To ;
      private long AV21TFBR_EncounterID ;
      private long AV22TFBR_EncounterID_To ;
      private long AV29TFBR_PathologyID_TestID ;
      private long AV30TFBR_PathologyID_TestID_To ;
      private long AV56GridCurrentPage ;
      private long AV58GridRecordCount ;
      private long AV57GridPageSize ;
      private long A85BR_Information_ID ;
      private long A226BR_PathologyID ;
      private long A19BR_EncounterID ;
      private long A237BR_PathologyID_TestID ;
      private long GRID_nCurrentRecord ;
      private long AV98BR_PathologyWWDS_1_Tfbr_pathologyid ;
      private long AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to ;
      private long AV100BR_PathologyWWDS_3_Tfbr_encounterid ;
      private long AV101BR_PathologyWWDS_4_Tfbr_encounterid_to ;
      private long AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid ;
      private long AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ;
      private long GRID_nRecordCount ;
      private decimal AV67TFBR_Pathology_T ;
      private decimal AV68TFBR_Pathology_T_To ;
      private decimal AV75TFBR_Pathology_LymphNum ;
      private decimal AV76TFBR_Pathology_LymphNum_To ;
      private decimal A314BR_Pathology_T ;
      private decimal A316BR_Pathology_LymphNum ;
      private decimal AV118BR_PathologyWWDS_21_Tfbr_pathology_t ;
      private decimal AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to ;
      private decimal AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ;
      private decimal AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_pathologyid_Activeeventkey ;
      private String Ddo_br_pathologyid_Filteredtext_get ;
      private String Ddo_br_pathologyid_Filteredtextto_get ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterid_Filteredtext_get ;
      private String Ddo_br_encounterid_Filteredtextto_get ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_information_patientno_Filteredtext_get ;
      private String Ddo_br_information_patientno_Selectedvalue_get ;
      private String Ddo_br_pathologyid_testid_Activeeventkey ;
      private String Ddo_br_pathologyid_testid_Filteredtext_get ;
      private String Ddo_br_pathologyid_testid_Filteredtextto_get ;
      private String Ddo_br_pathologyid_padate_Activeeventkey ;
      private String Ddo_br_pathologyid_padate_Filteredtext_get ;
      private String Ddo_br_pathologyid_padate_Filteredtextto_get ;
      private String Ddo_br_pathologyid_pahosp_Activeeventkey ;
      private String Ddo_br_pathologyid_pahosp_Filteredtext_get ;
      private String Ddo_br_pathologyid_pahosp_Selectedvalue_get ;
      private String Ddo_br_pathologyid_paage_Activeeventkey ;
      private String Ddo_br_pathologyid_paage_Filteredtext_get ;
      private String Ddo_br_pathologyid_paage_Filteredtextto_get ;
      private String Ddo_br_pathologyid_prepadia_Activeeventkey ;
      private String Ddo_br_pathologyid_prepadia_Filteredtext_get ;
      private String Ddo_br_pathologyid_prepadia_Selectedvalue_get ;
      private String Ddo_br_pathologyid_paresult_Activeeventkey ;
      private String Ddo_br_pathologyid_paresult_Filteredtext_get ;
      private String Ddo_br_pathologyid_paresult_Selectedvalue_get ;
      private String Ddo_br_pathology_dia_name_Activeeventkey ;
      private String Ddo_br_pathology_dia_name_Filteredtext_get ;
      private String Ddo_br_pathology_dia_name_Selectedvalue_get ;
      private String Ddo_br_pathology_t_Activeeventkey ;
      private String Ddo_br_pathology_t_Filteredtext_get ;
      private String Ddo_br_pathology_t_Filteredtextto_get ;
      private String Ddo_br_pathology_n_Activeeventkey ;
      private String Ddo_br_pathology_n_Selectedvalue_get ;
      private String Ddo_br_pathology_lymphnum_Activeeventkey ;
      private String Ddo_br_pathology_lymphnum_Filteredtext_get ;
      private String Ddo_br_pathology_lymphnum_Filteredtextto_get ;
      private String Ddo_br_pathology_lymphrate_Activeeventkey ;
      private String Ddo_br_pathology_lymphrate_Filteredtext_get ;
      private String Ddo_br_pathology_lymphrate_Selectedvalue_get ;
      private String Ddo_br_pathology_m_Activeeventkey ;
      private String Ddo_br_pathology_m_Selectedvalue_get ;
      private String Ddo_br_pathology_metaloc_Activeeventkey ;
      private String Ddo_br_pathology_metaloc_Filteredtext_get ;
      private String Ddo_br_pathology_metaloc_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV131Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Gridpaginationbar_Class ;
      private String Gridpaginationbar_Previous ;
      private String Gridpaginationbar_Next ;
      private String Gridpaginationbar_Caption ;
      private String Gridpaginationbar_Pagingbuttonsposition ;
      private String Gridpaginationbar_Pagingcaptionposition ;
      private String Gridpaginationbar_Emptygridclass ;
      private String Gridpaginationbar_Rowsperpageoptions ;
      private String Gridpaginationbar_Emptygridcaption ;
      private String Gridpaginationbar_Rowsperpagecaption ;
      private String Ddo_br_pathologyid_Caption ;
      private String Ddo_br_pathologyid_Tooltip ;
      private String Ddo_br_pathologyid_Cls ;
      private String Ddo_br_pathologyid_Filteredtext_set ;
      private String Ddo_br_pathologyid_Filteredtextto_set ;
      private String Ddo_br_pathologyid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_Sortedstatus ;
      private String Ddo_br_pathologyid_Filtertype ;
      private String Ddo_br_pathologyid_Sortasc ;
      private String Ddo_br_pathologyid_Sortdsc ;
      private String Ddo_br_pathologyid_Cleanfilter ;
      private String Ddo_br_pathologyid_Rangefilterfrom ;
      private String Ddo_br_pathologyid_Rangefilterto ;
      private String Ddo_br_pathologyid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Filteredtext_set ;
      private String Ddo_br_encounterid_Filteredtextto_set ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Filtertype ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Cleanfilter ;
      private String Ddo_br_encounterid_Rangefilterfrom ;
      private String Ddo_br_encounterid_Rangefilterto ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Filteredtext_set ;
      private String Ddo_br_information_patientno_Selectedvalue_set ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Filtertype ;
      private String Ddo_br_information_patientno_Datalisttype ;
      private String Ddo_br_information_patientno_Datalistproc ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Loadingdata ;
      private String Ddo_br_information_patientno_Cleanfilter ;
      private String Ddo_br_information_patientno_Noresultsfound ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String Ddo_br_pathologyid_testid_Caption ;
      private String Ddo_br_pathologyid_testid_Tooltip ;
      private String Ddo_br_pathologyid_testid_Cls ;
      private String Ddo_br_pathologyid_testid_Filteredtext_set ;
      private String Ddo_br_pathologyid_testid_Filteredtextto_set ;
      private String Ddo_br_pathologyid_testid_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_testid_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_testid_Sortedstatus ;
      private String Ddo_br_pathologyid_testid_Filtertype ;
      private String Ddo_br_pathologyid_testid_Sortasc ;
      private String Ddo_br_pathologyid_testid_Sortdsc ;
      private String Ddo_br_pathologyid_testid_Cleanfilter ;
      private String Ddo_br_pathologyid_testid_Rangefilterfrom ;
      private String Ddo_br_pathologyid_testid_Rangefilterto ;
      private String Ddo_br_pathologyid_testid_Searchbuttontext ;
      private String Ddo_br_pathologyid_padate_Caption ;
      private String Ddo_br_pathologyid_padate_Tooltip ;
      private String Ddo_br_pathologyid_padate_Cls ;
      private String Ddo_br_pathologyid_padate_Filteredtext_set ;
      private String Ddo_br_pathologyid_padate_Filteredtextto_set ;
      private String Ddo_br_pathologyid_padate_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_padate_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_padate_Sortedstatus ;
      private String Ddo_br_pathologyid_padate_Filtertype ;
      private String Ddo_br_pathologyid_padate_Sortasc ;
      private String Ddo_br_pathologyid_padate_Sortdsc ;
      private String Ddo_br_pathologyid_padate_Cleanfilter ;
      private String Ddo_br_pathologyid_padate_Rangefilterfrom ;
      private String Ddo_br_pathologyid_padate_Rangefilterto ;
      private String Ddo_br_pathologyid_padate_Searchbuttontext ;
      private String Ddo_br_pathologyid_pahosp_Caption ;
      private String Ddo_br_pathologyid_pahosp_Tooltip ;
      private String Ddo_br_pathologyid_pahosp_Cls ;
      private String Ddo_br_pathologyid_pahosp_Filteredtext_set ;
      private String Ddo_br_pathologyid_pahosp_Selectedvalue_set ;
      private String Ddo_br_pathologyid_pahosp_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_pahosp_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_pahosp_Sortedstatus ;
      private String Ddo_br_pathologyid_pahosp_Filtertype ;
      private String Ddo_br_pathologyid_pahosp_Datalisttype ;
      private String Ddo_br_pathologyid_pahosp_Datalistproc ;
      private String Ddo_br_pathologyid_pahosp_Sortasc ;
      private String Ddo_br_pathologyid_pahosp_Sortdsc ;
      private String Ddo_br_pathologyid_pahosp_Loadingdata ;
      private String Ddo_br_pathologyid_pahosp_Cleanfilter ;
      private String Ddo_br_pathologyid_pahosp_Noresultsfound ;
      private String Ddo_br_pathologyid_pahosp_Searchbuttontext ;
      private String Ddo_br_pathologyid_paage_Caption ;
      private String Ddo_br_pathologyid_paage_Tooltip ;
      private String Ddo_br_pathologyid_paage_Cls ;
      private String Ddo_br_pathologyid_paage_Filteredtext_set ;
      private String Ddo_br_pathologyid_paage_Filteredtextto_set ;
      private String Ddo_br_pathologyid_paage_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_paage_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_paage_Sortedstatus ;
      private String Ddo_br_pathologyid_paage_Filtertype ;
      private String Ddo_br_pathologyid_paage_Sortasc ;
      private String Ddo_br_pathologyid_paage_Sortdsc ;
      private String Ddo_br_pathologyid_paage_Cleanfilter ;
      private String Ddo_br_pathologyid_paage_Rangefilterfrom ;
      private String Ddo_br_pathologyid_paage_Rangefilterto ;
      private String Ddo_br_pathologyid_paage_Searchbuttontext ;
      private String Ddo_br_pathologyid_prepadia_Caption ;
      private String Ddo_br_pathologyid_prepadia_Tooltip ;
      private String Ddo_br_pathologyid_prepadia_Cls ;
      private String Ddo_br_pathologyid_prepadia_Filteredtext_set ;
      private String Ddo_br_pathologyid_prepadia_Selectedvalue_set ;
      private String Ddo_br_pathologyid_prepadia_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_prepadia_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_prepadia_Sortedstatus ;
      private String Ddo_br_pathologyid_prepadia_Filtertype ;
      private String Ddo_br_pathologyid_prepadia_Datalisttype ;
      private String Ddo_br_pathologyid_prepadia_Datalistproc ;
      private String Ddo_br_pathologyid_prepadia_Sortasc ;
      private String Ddo_br_pathologyid_prepadia_Sortdsc ;
      private String Ddo_br_pathologyid_prepadia_Loadingdata ;
      private String Ddo_br_pathologyid_prepadia_Cleanfilter ;
      private String Ddo_br_pathologyid_prepadia_Noresultsfound ;
      private String Ddo_br_pathologyid_prepadia_Searchbuttontext ;
      private String Ddo_br_pathologyid_paresult_Caption ;
      private String Ddo_br_pathologyid_paresult_Tooltip ;
      private String Ddo_br_pathologyid_paresult_Cls ;
      private String Ddo_br_pathologyid_paresult_Filteredtext_set ;
      private String Ddo_br_pathologyid_paresult_Selectedvalue_set ;
      private String Ddo_br_pathologyid_paresult_Dropdownoptionstype ;
      private String Ddo_br_pathologyid_paresult_Titlecontrolidtoreplace ;
      private String Ddo_br_pathologyid_paresult_Sortedstatus ;
      private String Ddo_br_pathologyid_paresult_Filtertype ;
      private String Ddo_br_pathologyid_paresult_Datalisttype ;
      private String Ddo_br_pathologyid_paresult_Datalistproc ;
      private String Ddo_br_pathologyid_paresult_Sortasc ;
      private String Ddo_br_pathologyid_paresult_Sortdsc ;
      private String Ddo_br_pathologyid_paresult_Loadingdata ;
      private String Ddo_br_pathologyid_paresult_Cleanfilter ;
      private String Ddo_br_pathologyid_paresult_Noresultsfound ;
      private String Ddo_br_pathologyid_paresult_Searchbuttontext ;
      private String Ddo_br_pathology_dia_name_Caption ;
      private String Ddo_br_pathology_dia_name_Tooltip ;
      private String Ddo_br_pathology_dia_name_Cls ;
      private String Ddo_br_pathology_dia_name_Filteredtext_set ;
      private String Ddo_br_pathology_dia_name_Selectedvalue_set ;
      private String Ddo_br_pathology_dia_name_Dropdownoptionstype ;
      private String Ddo_br_pathology_dia_name_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_dia_name_Sortedstatus ;
      private String Ddo_br_pathology_dia_name_Filtertype ;
      private String Ddo_br_pathology_dia_name_Datalisttype ;
      private String Ddo_br_pathology_dia_name_Datalistproc ;
      private String Ddo_br_pathology_dia_name_Sortasc ;
      private String Ddo_br_pathology_dia_name_Sortdsc ;
      private String Ddo_br_pathology_dia_name_Loadingdata ;
      private String Ddo_br_pathology_dia_name_Cleanfilter ;
      private String Ddo_br_pathology_dia_name_Noresultsfound ;
      private String Ddo_br_pathology_dia_name_Searchbuttontext ;
      private String Ddo_br_pathology_t_Caption ;
      private String Ddo_br_pathology_t_Tooltip ;
      private String Ddo_br_pathology_t_Cls ;
      private String Ddo_br_pathology_t_Filteredtext_set ;
      private String Ddo_br_pathology_t_Filteredtextto_set ;
      private String Ddo_br_pathology_t_Dropdownoptionstype ;
      private String Ddo_br_pathology_t_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_t_Sortedstatus ;
      private String Ddo_br_pathology_t_Filtertype ;
      private String Ddo_br_pathology_t_Sortasc ;
      private String Ddo_br_pathology_t_Sortdsc ;
      private String Ddo_br_pathology_t_Cleanfilter ;
      private String Ddo_br_pathology_t_Rangefilterfrom ;
      private String Ddo_br_pathology_t_Rangefilterto ;
      private String Ddo_br_pathology_t_Searchbuttontext ;
      private String Ddo_br_pathology_n_Caption ;
      private String Ddo_br_pathology_n_Tooltip ;
      private String Ddo_br_pathology_n_Cls ;
      private String Ddo_br_pathology_n_Selectedvalue_set ;
      private String Ddo_br_pathology_n_Dropdownoptionstype ;
      private String Ddo_br_pathology_n_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_n_Sortedstatus ;
      private String Ddo_br_pathology_n_Datalisttype ;
      private String Ddo_br_pathology_n_Datalistfixedvalues ;
      private String Ddo_br_pathology_n_Sortasc ;
      private String Ddo_br_pathology_n_Sortdsc ;
      private String Ddo_br_pathology_n_Cleanfilter ;
      private String Ddo_br_pathology_n_Searchbuttontext ;
      private String Ddo_br_pathology_lymphnum_Caption ;
      private String Ddo_br_pathology_lymphnum_Tooltip ;
      private String Ddo_br_pathology_lymphnum_Cls ;
      private String Ddo_br_pathology_lymphnum_Filteredtext_set ;
      private String Ddo_br_pathology_lymphnum_Filteredtextto_set ;
      private String Ddo_br_pathology_lymphnum_Dropdownoptionstype ;
      private String Ddo_br_pathology_lymphnum_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_lymphnum_Sortedstatus ;
      private String Ddo_br_pathology_lymphnum_Filtertype ;
      private String Ddo_br_pathology_lymphnum_Sortasc ;
      private String Ddo_br_pathology_lymphnum_Sortdsc ;
      private String Ddo_br_pathology_lymphnum_Cleanfilter ;
      private String Ddo_br_pathology_lymphnum_Rangefilterfrom ;
      private String Ddo_br_pathology_lymphnum_Rangefilterto ;
      private String Ddo_br_pathology_lymphnum_Searchbuttontext ;
      private String Ddo_br_pathology_lymphrate_Caption ;
      private String Ddo_br_pathology_lymphrate_Tooltip ;
      private String Ddo_br_pathology_lymphrate_Cls ;
      private String Ddo_br_pathology_lymphrate_Filteredtext_set ;
      private String Ddo_br_pathology_lymphrate_Selectedvalue_set ;
      private String Ddo_br_pathology_lymphrate_Dropdownoptionstype ;
      private String Ddo_br_pathology_lymphrate_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_lymphrate_Sortedstatus ;
      private String Ddo_br_pathology_lymphrate_Filtertype ;
      private String Ddo_br_pathology_lymphrate_Datalisttype ;
      private String Ddo_br_pathology_lymphrate_Datalistproc ;
      private String Ddo_br_pathology_lymphrate_Sortasc ;
      private String Ddo_br_pathology_lymphrate_Sortdsc ;
      private String Ddo_br_pathology_lymphrate_Loadingdata ;
      private String Ddo_br_pathology_lymphrate_Cleanfilter ;
      private String Ddo_br_pathology_lymphrate_Noresultsfound ;
      private String Ddo_br_pathology_lymphrate_Searchbuttontext ;
      private String Ddo_br_pathology_m_Caption ;
      private String Ddo_br_pathology_m_Tooltip ;
      private String Ddo_br_pathology_m_Cls ;
      private String Ddo_br_pathology_m_Selectedvalue_set ;
      private String Ddo_br_pathology_m_Dropdownoptionstype ;
      private String Ddo_br_pathology_m_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_m_Sortedstatus ;
      private String Ddo_br_pathology_m_Datalisttype ;
      private String Ddo_br_pathology_m_Datalistfixedvalues ;
      private String Ddo_br_pathology_m_Sortasc ;
      private String Ddo_br_pathology_m_Sortdsc ;
      private String Ddo_br_pathology_m_Cleanfilter ;
      private String Ddo_br_pathology_m_Searchbuttontext ;
      private String Ddo_br_pathology_metaloc_Caption ;
      private String Ddo_br_pathology_metaloc_Tooltip ;
      private String Ddo_br_pathology_metaloc_Cls ;
      private String Ddo_br_pathology_metaloc_Filteredtext_set ;
      private String Ddo_br_pathology_metaloc_Selectedvalue_set ;
      private String Ddo_br_pathology_metaloc_Dropdownoptionstype ;
      private String Ddo_br_pathology_metaloc_Titlecontrolidtoreplace ;
      private String Ddo_br_pathology_metaloc_Sortedstatus ;
      private String Ddo_br_pathology_metaloc_Filtertype ;
      private String Ddo_br_pathology_metaloc_Datalisttype ;
      private String Ddo_br_pathology_metaloc_Datalistproc ;
      private String Ddo_br_pathology_metaloc_Sortasc ;
      private String Ddo_br_pathology_metaloc_Sortdsc ;
      private String Ddo_br_pathology_metaloc_Loadingdata ;
      private String Ddo_br_pathology_metaloc_Cleanfilter ;
      private String Ddo_br_pathology_metaloc_Noresultsfound ;
      private String Ddo_br_pathology_metaloc_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_PathologyID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_PathologyID_TestID_Title ;
      private String edtBR_PathologyID_PADate_Title ;
      private String edtBR_PathologyID_PAHosp_Title ;
      private String edtBR_PathologyID_PAAge_Title ;
      private String edtBR_PathologyID_PrePaDia_Title ;
      private String edtBR_PathologyID_PAResult_Title ;
      private String edtBR_Pathology_Dia_Name_Title ;
      private String edtBR_Pathology_T_Title ;
      private String edtBR_Pathology_LymphNum_Title ;
      private String edtBR_Pathology_LymphRate_Title ;
      private String edtBR_Pathology_MetaLoc_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Information_PatientNo_Link ;
      private String edtBR_PathologyID_TestID_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_pathologyid_Internalname ;
      private String edtavDdo_br_pathologyidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_testid_Internalname ;
      private String edtavDdo_br_pathologyid_testidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_padate_Internalname ;
      private String edtavDdo_br_pathologyid_padatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_pahosp_Internalname ;
      private String edtavDdo_br_pathologyid_pahosptitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_paage_Internalname ;
      private String edtavDdo_br_pathologyid_paagetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_prepadia_Internalname ;
      private String edtavDdo_br_pathologyid_prepadiatitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathologyid_paresult_Internalname ;
      private String edtavDdo_br_pathologyid_paresulttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_dia_name_Internalname ;
      private String edtavDdo_br_pathology_dia_nametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_t_Internalname ;
      private String edtavDdo_br_pathology_ttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_n_Internalname ;
      private String edtavDdo_br_pathology_ntitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_lymphnum_Internalname ;
      private String edtavDdo_br_pathology_lymphnumtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_lymphrate_Internalname ;
      private String edtavDdo_br_pathology_lymphratetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_m_Internalname ;
      private String edtavDdo_br_pathology_mtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_pathology_metaloc_Internalname ;
      private String edtavDdo_br_pathology_metaloctitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_pathologyid_Internalname ;
      private String edtavTfbr_pathologyid_Jsonclick ;
      private String edtavTfbr_pathologyid_to_Internalname ;
      private String edtavTfbr_pathologyid_to_Jsonclick ;
      private String edtavTfbr_encounterid_Internalname ;
      private String edtavTfbr_encounterid_Jsonclick ;
      private String edtavTfbr_encounterid_to_Internalname ;
      private String edtavTfbr_encounterid_to_Jsonclick ;
      private String edtavTfbr_information_patientno_Internalname ;
      private String edtavTfbr_information_patientno_Jsonclick ;
      private String edtavTfbr_information_patientno_sel_Internalname ;
      private String edtavTfbr_information_patientno_sel_Jsonclick ;
      private String edtavTfbr_pathologyid_testid_Internalname ;
      private String edtavTfbr_pathologyid_testid_Jsonclick ;
      private String edtavTfbr_pathologyid_testid_to_Internalname ;
      private String edtavTfbr_pathologyid_testid_to_Jsonclick ;
      private String edtavTfbr_pathologyid_padate_Internalname ;
      private String edtavTfbr_pathologyid_padate_Jsonclick ;
      private String edtavTfbr_pathologyid_padate_to_Internalname ;
      private String edtavTfbr_pathologyid_padate_to_Jsonclick ;
      private String divDdo_br_pathologyid_padateauxdates_Internalname ;
      private String edtavDdo_br_pathologyid_padateauxdate_Internalname ;
      private String edtavDdo_br_pathologyid_padateauxdate_Jsonclick ;
      private String edtavDdo_br_pathologyid_padateauxdateto_Internalname ;
      private String edtavDdo_br_pathologyid_padateauxdateto_Jsonclick ;
      private String edtavTfbr_pathologyid_pahosp_Internalname ;
      private String edtavTfbr_pathologyid_pahosp_Jsonclick ;
      private String edtavTfbr_pathologyid_pahosp_sel_Internalname ;
      private String edtavTfbr_pathologyid_pahosp_sel_Jsonclick ;
      private String edtavTfbr_pathologyid_paage_Internalname ;
      private String edtavTfbr_pathologyid_paage_Jsonclick ;
      private String edtavTfbr_pathologyid_paage_to_Internalname ;
      private String edtavTfbr_pathologyid_paage_to_Jsonclick ;
      private String edtavTfbr_pathologyid_prepadia_Internalname ;
      private String edtavTfbr_pathologyid_prepadia_sel_Internalname ;
      private String edtavTfbr_pathologyid_paresult_Internalname ;
      private String edtavTfbr_pathologyid_paresult_sel_Internalname ;
      private String edtavTfbr_pathology_dia_name_Internalname ;
      private String edtavTfbr_pathology_dia_name_sel_Internalname ;
      private String edtavTfbr_pathology_t_Internalname ;
      private String edtavTfbr_pathology_t_Jsonclick ;
      private String edtavTfbr_pathology_t_to_Internalname ;
      private String edtavTfbr_pathology_t_to_Jsonclick ;
      private String edtavTfbr_pathology_lymphnum_Internalname ;
      private String edtavTfbr_pathology_lymphnum_Jsonclick ;
      private String edtavTfbr_pathology_lymphnum_to_Internalname ;
      private String edtavTfbr_pathology_lymphnum_to_Jsonclick ;
      private String edtavTfbr_pathology_lymphrate_Internalname ;
      private String edtavTfbr_pathology_lymphrate_Jsonclick ;
      private String edtavTfbr_pathology_lymphrate_sel_Internalname ;
      private String edtavTfbr_pathology_lymphrate_sel_Jsonclick ;
      private String edtavTfbr_pathology_metaloc_Internalname ;
      private String edtavTfbr_pathology_metaloc_Jsonclick ;
      private String edtavTfbr_pathology_metaloc_sel_Internalname ;
      private String edtavTfbr_pathology_metaloc_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_PathologyID_TestID_Internalname ;
      private String edtBR_PathologyID_PADate_Internalname ;
      private String edtBR_PathologyID_PAHosp_Internalname ;
      private String edtBR_PathologyID_PAAge_Internalname ;
      private String edtBR_PathologyID_PrePaDia_Internalname ;
      private String edtBR_PathologyID_PAResult_Internalname ;
      private String edtBR_Pathology_Dia_Name_Internalname ;
      private String edtBR_Pathology_T_Internalname ;
      private String cmbBR_Pathology_N_Internalname ;
      private String edtBR_Pathology_LymphNum_Internalname ;
      private String edtBR_Pathology_LymphRate_Internalname ;
      private String cmbBR_Pathology_M_Internalname ;
      private String edtBR_Pathology_MetaLoc_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_PathologyID_TestID_Jsonclick ;
      private String edtBR_PathologyID_PADate_Jsonclick ;
      private String edtBR_PathologyID_PAHosp_Jsonclick ;
      private String edtBR_PathologyID_PAAge_Jsonclick ;
      private String edtBR_PathologyID_PrePaDia_Jsonclick ;
      private String edtBR_PathologyID_PAResult_Jsonclick ;
      private String edtBR_Pathology_Dia_Name_Jsonclick ;
      private String edtBR_Pathology_T_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Pathology_N_Jsonclick ;
      private String edtBR_Pathology_LymphNum_Jsonclick ;
      private String edtBR_Pathology_LymphRate_Jsonclick ;
      private String cmbBR_Pathology_M_Jsonclick ;
      private String edtBR_Pathology_MetaLoc_Jsonclick ;
      private DateTime AV33TFBR_PathologyID_PADate ;
      private DateTime AV34TFBR_PathologyID_PADate_To ;
      private DateTime A238BR_PathologyID_PADate ;
      private DateTime AV35DDO_BR_PathologyID_PADateAuxDate ;
      private DateTime AV36DDO_BR_PathologyID_PADateAuxDateTo ;
      private DateTime AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate ;
      private DateTime AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV61IsAuthorized_Update ;
      private bool AV63IsAuthorized_Delete ;
      private bool AV64IsAuthorized_BR_Information_PatientNo ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_pathologyid_Includesortasc ;
      private bool Ddo_br_pathologyid_Includesortdsc ;
      private bool Ddo_br_pathologyid_Includefilter ;
      private bool Ddo_br_pathologyid_Filterisrange ;
      private bool Ddo_br_pathologyid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Filterisrange ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Filterisrange ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_pathologyid_testid_Includesortasc ;
      private bool Ddo_br_pathologyid_testid_Includesortdsc ;
      private bool Ddo_br_pathologyid_testid_Includefilter ;
      private bool Ddo_br_pathologyid_testid_Filterisrange ;
      private bool Ddo_br_pathologyid_testid_Includedatalist ;
      private bool Ddo_br_pathologyid_padate_Includesortasc ;
      private bool Ddo_br_pathologyid_padate_Includesortdsc ;
      private bool Ddo_br_pathologyid_padate_Includefilter ;
      private bool Ddo_br_pathologyid_padate_Filterisrange ;
      private bool Ddo_br_pathologyid_padate_Includedatalist ;
      private bool Ddo_br_pathologyid_pahosp_Includesortasc ;
      private bool Ddo_br_pathologyid_pahosp_Includesortdsc ;
      private bool Ddo_br_pathologyid_pahosp_Includefilter ;
      private bool Ddo_br_pathologyid_pahosp_Filterisrange ;
      private bool Ddo_br_pathologyid_pahosp_Includedatalist ;
      private bool Ddo_br_pathologyid_paage_Includesortasc ;
      private bool Ddo_br_pathologyid_paage_Includesortdsc ;
      private bool Ddo_br_pathologyid_paage_Includefilter ;
      private bool Ddo_br_pathologyid_paage_Filterisrange ;
      private bool Ddo_br_pathologyid_paage_Includedatalist ;
      private bool Ddo_br_pathologyid_prepadia_Includesortasc ;
      private bool Ddo_br_pathologyid_prepadia_Includesortdsc ;
      private bool Ddo_br_pathologyid_prepadia_Includefilter ;
      private bool Ddo_br_pathologyid_prepadia_Filterisrange ;
      private bool Ddo_br_pathologyid_prepadia_Includedatalist ;
      private bool Ddo_br_pathologyid_paresult_Includesortasc ;
      private bool Ddo_br_pathologyid_paresult_Includesortdsc ;
      private bool Ddo_br_pathologyid_paresult_Includefilter ;
      private bool Ddo_br_pathologyid_paresult_Filterisrange ;
      private bool Ddo_br_pathologyid_paresult_Includedatalist ;
      private bool Ddo_br_pathology_dia_name_Includesortasc ;
      private bool Ddo_br_pathology_dia_name_Includesortdsc ;
      private bool Ddo_br_pathology_dia_name_Includefilter ;
      private bool Ddo_br_pathology_dia_name_Filterisrange ;
      private bool Ddo_br_pathology_dia_name_Includedatalist ;
      private bool Ddo_br_pathology_t_Includesortasc ;
      private bool Ddo_br_pathology_t_Includesortdsc ;
      private bool Ddo_br_pathology_t_Includefilter ;
      private bool Ddo_br_pathology_t_Filterisrange ;
      private bool Ddo_br_pathology_t_Includedatalist ;
      private bool Ddo_br_pathology_n_Includesortasc ;
      private bool Ddo_br_pathology_n_Includesortdsc ;
      private bool Ddo_br_pathology_n_Includefilter ;
      private bool Ddo_br_pathology_n_Includedatalist ;
      private bool Ddo_br_pathology_n_Allowmultipleselection ;
      private bool Ddo_br_pathology_lymphnum_Includesortasc ;
      private bool Ddo_br_pathology_lymphnum_Includesortdsc ;
      private bool Ddo_br_pathology_lymphnum_Includefilter ;
      private bool Ddo_br_pathology_lymphnum_Filterisrange ;
      private bool Ddo_br_pathology_lymphnum_Includedatalist ;
      private bool Ddo_br_pathology_lymphrate_Includesortasc ;
      private bool Ddo_br_pathology_lymphrate_Includesortdsc ;
      private bool Ddo_br_pathology_lymphrate_Includefilter ;
      private bool Ddo_br_pathology_lymphrate_Filterisrange ;
      private bool Ddo_br_pathology_lymphrate_Includedatalist ;
      private bool Ddo_br_pathology_m_Includesortasc ;
      private bool Ddo_br_pathology_m_Includesortdsc ;
      private bool Ddo_br_pathology_m_Includefilter ;
      private bool Ddo_br_pathology_m_Includedatalist ;
      private bool Ddo_br_pathology_m_Allowmultipleselection ;
      private bool Ddo_br_pathology_metaloc_Includesortasc ;
      private bool Ddo_br_pathology_metaloc_Includesortdsc ;
      private bool Ddo_br_pathology_metaloc_Includefilter ;
      private bool Ddo_br_pathology_metaloc_Filterisrange ;
      private bool Ddo_br_pathology_metaloc_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n19BR_EncounterID ;
      private bool n36BR_Information_PatientNo ;
      private bool n237BR_PathologyID_TestID ;
      private bool n238BR_PathologyID_PADate ;
      private bool n239BR_PathologyID_PAHosp ;
      private bool n240BR_PathologyID_PAAge ;
      private bool n241BR_PathologyID_PrePaDia ;
      private bool n242BR_PathologyID_PAResult ;
      private bool n326BR_Pathology_Dia_Name ;
      private bool n314BR_Pathology_T ;
      private bool n315BR_Pathology_N ;
      private bool n316BR_Pathology_LymphNum ;
      private bool n317BR_Pathology_LymphRate ;
      private bool n318BR_Pathology_M ;
      private bool n319BR_Pathology_MetaLoc ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV65TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV59Display_IsBlob ;
      private bool AV60Update_IsBlob ;
      private bool AV62Delete_IsBlob ;
      private String AV71TFBR_Pathology_N_SelsJson ;
      private String AV83TFBR_Pathology_M_SelsJson ;
      private String AV25TFBR_Information_PatientNo ;
      private String AV26TFBR_Information_PatientNo_Sel ;
      private String AV39TFBR_PathologyID_PAHosp ;
      private String AV40TFBR_PathologyID_PAHosp_Sel ;
      private String AV47TFBR_PathologyID_PrePaDia ;
      private String AV48TFBR_PathologyID_PrePaDia_Sel ;
      private String AV51TFBR_PathologyID_PAResult ;
      private String AV52TFBR_PathologyID_PAResult_Sel ;
      private String AV91TFBR_Pathology_Dia_Name ;
      private String AV92TFBR_Pathology_Dia_Name_Sel ;
      private String AV79TFBR_Pathology_LymphRate ;
      private String AV80TFBR_Pathology_LymphRate_Sel ;
      private String AV87TFBR_Pathology_MetaLoc ;
      private String AV88TFBR_Pathology_MetaLoc_Sel ;
      private String AV19ddo_BR_PathologyIDTitleControlIdToReplace ;
      private String AV23ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV31ddo_BR_PathologyID_TestIDTitleControlIdToReplace ;
      private String AV37ddo_BR_PathologyID_PADateTitleControlIdToReplace ;
      private String AV41ddo_BR_PathologyID_PAHospTitleControlIdToReplace ;
      private String AV45ddo_BR_PathologyID_PAAgeTitleControlIdToReplace ;
      private String AV49ddo_BR_PathologyID_PrePaDiaTitleControlIdToReplace ;
      private String AV53ddo_BR_PathologyID_PAResultTitleControlIdToReplace ;
      private String AV93ddo_BR_Pathology_Dia_NameTitleControlIdToReplace ;
      private String AV69ddo_BR_Pathology_TTitleControlIdToReplace ;
      private String AV73ddo_BR_Pathology_NTitleControlIdToReplace ;
      private String AV77ddo_BR_Pathology_LymphNumTitleControlIdToReplace ;
      private String AV81ddo_BR_Pathology_LymphRateTitleControlIdToReplace ;
      private String AV85ddo_BR_Pathology_MTitleControlIdToReplace ;
      private String AV89ddo_BR_Pathology_MetaLocTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A239BR_PathologyID_PAHosp ;
      private String A241BR_PathologyID_PrePaDia ;
      private String A242BR_PathologyID_PAResult ;
      private String A326BR_Pathology_Dia_Name ;
      private String A315BR_Pathology_N ;
      private String A317BR_Pathology_LymphRate ;
      private String A318BR_Pathology_M ;
      private String A319BR_Pathology_MetaLoc ;
      private String AV128Display_GXI ;
      private String AV129Update_GXI ;
      private String AV130Delete_GXI ;
      private String lV102BR_PathologyWWDS_5_Tfbr_information_patientno ;
      private String lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ;
      private String lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ;
      private String lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ;
      private String lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name ;
      private String lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ;
      private String lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc ;
      private String AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel ;
      private String AV102BR_PathologyWWDS_5_Tfbr_information_patientno ;
      private String AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ;
      private String AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ;
      private String AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ;
      private String AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ;
      private String AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ;
      private String AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ;
      private String AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ;
      private String AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name ;
      private String AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ;
      private String AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ;
      private String AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ;
      private String AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc ;
      private String AV59Display ;
      private String AV60Update ;
      private String AV62Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_pathologyid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_pathologyid_testid ;
      private GXUserControl ucDdo_br_pathologyid_padate ;
      private GXUserControl ucDdo_br_pathologyid_pahosp ;
      private GXUserControl ucDdo_br_pathologyid_paage ;
      private GXUserControl ucDdo_br_pathologyid_prepadia ;
      private GXUserControl ucDdo_br_pathologyid_paresult ;
      private GXUserControl ucDdo_br_pathology_dia_name ;
      private GXUserControl ucDdo_br_pathology_t ;
      private GXUserControl ucDdo_br_pathology_n ;
      private GXUserControl ucDdo_br_pathology_lymphnum ;
      private GXUserControl ucDdo_br_pathology_lymphrate ;
      private GXUserControl ucDdo_br_pathology_m ;
      private GXUserControl ucDdo_br_pathology_metaloc ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Pathology_N ;
      private GXCombobox cmbBR_Pathology_M ;
      private IDataStoreProvider pr_default ;
      private long[] H005C2_A85BR_Information_ID ;
      private bool[] H005C2_n85BR_Information_ID ;
      private String[] H005C2_A319BR_Pathology_MetaLoc ;
      private bool[] H005C2_n319BR_Pathology_MetaLoc ;
      private String[] H005C2_A318BR_Pathology_M ;
      private bool[] H005C2_n318BR_Pathology_M ;
      private String[] H005C2_A317BR_Pathology_LymphRate ;
      private bool[] H005C2_n317BR_Pathology_LymphRate ;
      private decimal[] H005C2_A316BR_Pathology_LymphNum ;
      private bool[] H005C2_n316BR_Pathology_LymphNum ;
      private String[] H005C2_A315BR_Pathology_N ;
      private bool[] H005C2_n315BR_Pathology_N ;
      private decimal[] H005C2_A314BR_Pathology_T ;
      private bool[] H005C2_n314BR_Pathology_T ;
      private String[] H005C2_A326BR_Pathology_Dia_Name ;
      private bool[] H005C2_n326BR_Pathology_Dia_Name ;
      private String[] H005C2_A242BR_PathologyID_PAResult ;
      private bool[] H005C2_n242BR_PathologyID_PAResult ;
      private String[] H005C2_A241BR_PathologyID_PrePaDia ;
      private bool[] H005C2_n241BR_PathologyID_PrePaDia ;
      private short[] H005C2_A240BR_PathologyID_PAAge ;
      private bool[] H005C2_n240BR_PathologyID_PAAge ;
      private String[] H005C2_A239BR_PathologyID_PAHosp ;
      private bool[] H005C2_n239BR_PathologyID_PAHosp ;
      private DateTime[] H005C2_A238BR_PathologyID_PADate ;
      private bool[] H005C2_n238BR_PathologyID_PADate ;
      private long[] H005C2_A237BR_PathologyID_TestID ;
      private bool[] H005C2_n237BR_PathologyID_TestID ;
      private String[] H005C2_A36BR_Information_PatientNo ;
      private bool[] H005C2_n36BR_Information_PatientNo ;
      private long[] H005C2_A19BR_EncounterID ;
      private bool[] H005C2_n19BR_EncounterID ;
      private long[] H005C2_A226BR_PathologyID ;
      private long[] H005C3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GxSimpleCollection<String> AV72TFBR_Pathology_N_Sels ;
      private GxSimpleCollection<String> AV84TFBR_Pathology_M_Sels ;
      private GxSimpleCollection<String> AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels ;
      private GxSimpleCollection<String> AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_PathologyIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_PathologyID_TestIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_PathologyID_PADateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_PathologyID_PAHospTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42BR_PathologyID_PAAgeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV46BR_PathologyID_PrePaDiaTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_PathologyID_PAResultTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV90BR_Pathology_Dia_NameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV66BR_Pathology_TTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV70BR_Pathology_NTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV74BR_Pathology_LymphNumTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV78BR_Pathology_LymphRateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV82BR_Pathology_MTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV86BR_Pathology_MetaLocTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV54DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_pathologyww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005C2( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV98BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV100BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV101BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV102BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV118BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [31] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Pathology_MetaLoc], T1.[BR_Pathology_M], T1.[BR_Pathology_LymphRate], T1.[BR_Pathology_LymphNum], T1.[BR_Pathology_N], T1.[BR_Pathology_T], T1.[BR_Pathology_Dia_Name], T1.[BR_PathologyID_PAResult], T1.[BR_PathologyID_PrePaDia], T1.[BR_PathologyID_PAAge], T1.[BR_PathologyID_PAHosp], T1.[BR_PathologyID_PADate], T1.[BR_PathologyID_TestID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_PathologyID]";
         sFromString = " FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ! (0==AV98BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV98BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV98BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV100BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV100BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV100BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV101BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV101BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV101BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV102BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV102BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV102BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (0==AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! (0==AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (0==AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int3[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int3[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int3[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int3[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int3[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int3[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV118BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV118BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV118BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int3[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int3[21] = 1;
         }
         if ( AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int3[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int3[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int3[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int3[25] = 1;
         }
         if ( AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int3[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
         }
         else
         {
            GXv_int3[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_TestID]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_TestID] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PADate]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PADate] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAHosp]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAHosp] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAAge]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAAge] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PrePaDia]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PrePaDia] DESC";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAResult]";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID_PAResult] DESC";
         }
         else if ( ( AV13OrderedBy == 10 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_Dia_Name]";
         }
         else if ( ( AV13OrderedBy == 10 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_Dia_Name] DESC";
         }
         else if ( ( AV13OrderedBy == 11 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_T]";
         }
         else if ( ( AV13OrderedBy == 11 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_T] DESC";
         }
         else if ( ( AV13OrderedBy == 12 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_N]";
         }
         else if ( ( AV13OrderedBy == 12 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_N] DESC";
         }
         else if ( ( AV13OrderedBy == 13 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphNum]";
         }
         else if ( ( AV13OrderedBy == 13 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphNum] DESC";
         }
         else if ( ( AV13OrderedBy == 14 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphRate]";
         }
         else if ( ( AV13OrderedBy == 14 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_LymphRate] DESC";
         }
         else if ( ( AV13OrderedBy == 15 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_M]";
         }
         else if ( ( AV13OrderedBy == 15 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_M] DESC";
         }
         else if ( ( AV13OrderedBy == 16 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_MetaLoc]";
         }
         else if ( ( AV13OrderedBy == 16 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Pathology_MetaLoc] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_PathologyID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005C3( IGxContext context ,
                                             String A315BR_Pathology_N ,
                                             GxSimpleCollection<String> AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels ,
                                             String A318BR_Pathology_M ,
                                             GxSimpleCollection<String> AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels ,
                                             long AV98BR_PathologyWWDS_1_Tfbr_pathologyid ,
                                             long AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to ,
                                             long AV100BR_PathologyWWDS_3_Tfbr_encounterid ,
                                             long AV101BR_PathologyWWDS_4_Tfbr_encounterid_to ,
                                             String AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV102BR_PathologyWWDS_5_Tfbr_information_patientno ,
                                             long AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid ,
                                             long AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to ,
                                             DateTime AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate ,
                                             DateTime AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to ,
                                             String AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel ,
                                             String AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp ,
                                             short AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage ,
                                             short AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to ,
                                             String AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel ,
                                             String AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia ,
                                             String AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel ,
                                             String AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult ,
                                             String AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel ,
                                             String AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name ,
                                             decimal AV118BR_PathologyWWDS_21_Tfbr_pathology_t ,
                                             decimal AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to ,
                                             int AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count ,
                                             decimal AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum ,
                                             decimal AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to ,
                                             String AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel ,
                                             String AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate ,
                                             int AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count ,
                                             String AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel ,
                                             String AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc ,
                                             long A226BR_PathologyID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A237BR_PathologyID_TestID ,
                                             DateTime A238BR_PathologyID_PADate ,
                                             String A239BR_PathologyID_PAHosp ,
                                             short A240BR_PathologyID_PAAge ,
                                             String A241BR_PathologyID_PrePaDia ,
                                             String A242BR_PathologyID_PAResult ,
                                             String A326BR_Pathology_Dia_Name ,
                                             decimal A314BR_Pathology_T ,
                                             decimal A316BR_Pathology_LymphNum ,
                                             String A317BR_Pathology_LymphRate ,
                                             String A319BR_Pathology_MetaLoc ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [28] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Pathology] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV98BR_PathologyWWDS_1_Tfbr_pathologyid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] >= @AV98BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] >= @AV98BR_PathologyWWDS_1_Tfbr_pathologyid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID] <= @AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID] <= @AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV100BR_PathologyWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV100BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV100BR_PathologyWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV101BR_PathologyWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV101BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV101BR_PathologyWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV102BR_PathologyWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV102BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV102BR_PathologyWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] >= @AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] >= @AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (0==AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_TestID] <= @AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_TestID] <= @AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] >= @AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] >= @AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PADate] <= @AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PADate] <= @AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] like @lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] like @lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAHosp] = @AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAHosp] = @AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! (0==AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] >= @AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] >= @AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (0==AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAAge] <= @AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAAge] <= @AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] like @lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] like @lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia)";
            }
         }
         else
         {
            GXv_int5[14] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PrePaDia] = @AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PrePaDia] = @AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel)";
            }
         }
         else
         {
            GXv_int5[15] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] like @lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] like @lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult)";
            }
         }
         else
         {
            GXv_int5[16] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_PathologyID_PAResult] = @AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_PathologyID_PAResult] = @AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel)";
            }
         }
         else
         {
            GXv_int5[17] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] like @lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] like @lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name)";
            }
         }
         else
         {
            GXv_int5[18] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_Dia_Name] = @AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_Dia_Name] = @AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel)";
            }
         }
         else
         {
            GXv_int5[19] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV118BR_PathologyWWDS_21_Tfbr_pathology_t) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] >= @AV118BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] >= @AV118BR_PathologyWWDS_21_Tfbr_pathology_t)";
            }
         }
         else
         {
            GXv_int5[20] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_T] <= @AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_T] <= @AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to)";
            }
         }
         else
         {
            GXv_int5[21] = 1;
         }
         if ( AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV120BR_PathologyWWDS_23_Tfbr_pathology_n_sels, "T1.[BR_Pathology_N] IN (", ")") + ")";
            }
         }
         if ( ! (Convert.ToDecimal(0)==AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] >= @AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] >= @AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum)";
            }
         }
         else
         {
            GXv_int5[22] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphNum] <= @AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphNum] <= @AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to)";
            }
         }
         else
         {
            GXv_int5[23] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] like @lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] like @lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate)";
            }
         }
         else
         {
            GXv_int5[24] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_LymphRate] = @AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_LymphRate] = @AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel)";
            }
         }
         else
         {
            GXv_int5[25] = 1;
         }
         if ( AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125BR_PathologyWWDS_28_Tfbr_pathology_m_sels, "T1.[BR_Pathology_M] IN (", ")") + ")";
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] like @lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] like @lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc)";
            }
         }
         else
         {
            GXv_int5[26] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Pathology_MetaLoc] = @AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Pathology_MetaLoc] = @AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel)";
            }
         }
         else
         {
            GXv_int5[27] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 10 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 10 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 11 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 11 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 12 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 12 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 13 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 13 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 14 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 14 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 15 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 15 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 16 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 16 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H005C2(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] , (short)dynConstraints[48] , (bool)dynConstraints[49] );
               case 1 :
                     return conditional_H005C3(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (DateTime)dynConstraints[12] , (DateTime)dynConstraints[13] , (String)dynConstraints[14] , (String)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] , (String)dynConstraints[20] , (String)dynConstraints[21] , (String)dynConstraints[22] , (String)dynConstraints[23] , (decimal)dynConstraints[24] , (decimal)dynConstraints[25] , (int)dynConstraints[26] , (decimal)dynConstraints[27] , (decimal)dynConstraints[28] , (String)dynConstraints[29] , (String)dynConstraints[30] , (int)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] , (long)dynConstraints[34] , (long)dynConstraints[35] , (String)dynConstraints[36] , (long)dynConstraints[37] , (DateTime)dynConstraints[38] , (String)dynConstraints[39] , (short)dynConstraints[40] , (String)dynConstraints[41] , (String)dynConstraints[42] , (String)dynConstraints[43] , (decimal)dynConstraints[44] , (decimal)dynConstraints[45] , (String)dynConstraints[46] , (String)dynConstraints[47] , (short)dynConstraints[48] , (bool)dynConstraints[49] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          /* Definition of lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmH005C2 ;
          prmH005C2 = new Object[] {
          new Object[] {"@AV98BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV100BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV101BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV102BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV118BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          /* Definition of lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult changed to svchar length 4000 decimals 0 */
          /* Definition of AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel changed to svchar length 4000 decimals 0 */
          Object[] prmH005C3 ;
          prmH005C3 = new Object[] {
          new Object[] {"@AV98BR_PathologyWWDS_1_Tfbr_pathologyid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV99BR_PathologyWWDS_2_Tfbr_pathologyid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV100BR_PathologyWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV101BR_PathologyWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV102BR_PathologyWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV103BR_PathologyWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV104BR_PathologyWWDS_7_Tfbr_pathologyid_testid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV105BR_PathologyWWDS_8_Tfbr_pathologyid_testid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV106BR_PathologyWWDS_9_Tfbr_pathologyid_padate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV107BR_PathologyWWDS_10_Tfbr_pathologyid_padate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV108BR_PathologyWWDS_11_Tfbr_pathologyid_pahosp",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV109BR_PathologyWWDS_12_Tfbr_pathologyid_pahosp_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV110BR_PathologyWWDS_13_Tfbr_pathologyid_paage",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@AV111BR_PathologyWWDS_14_Tfbr_pathologyid_paage_to",SqlDbType.SmallInt,3,0} ,
          new Object[] {"@lV112BR_PathologyWWDS_15_Tfbr_pathologyid_prepadia",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV113BR_PathologyWWDS_16_Tfbr_pathologyid_prepadia_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV114BR_PathologyWWDS_17_Tfbr_pathologyid_paresult",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV115BR_PathologyWWDS_18_Tfbr_pathologyid_paresult_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV116BR_PathologyWWDS_19_Tfbr_pathology_dia_name",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV117BR_PathologyWWDS_20_Tfbr_pathology_dia_name_sel",SqlDbType.NVarChar,3000,0} ,
          new Object[] {"@AV118BR_PathologyWWDS_21_Tfbr_pathology_t",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV119BR_PathologyWWDS_22_Tfbr_pathology_t_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV121BR_PathologyWWDS_24_Tfbr_pathology_lymphnum",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV122BR_PathologyWWDS_25_Tfbr_pathology_lymphnum_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@lV123BR_PathologyWWDS_26_Tfbr_pathology_lymphrate",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@AV124BR_PathologyWWDS_27_Tfbr_pathology_lymphrate_sel",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV126BR_PathologyWWDS_29_Tfbr_pathology_metaloc",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV127BR_PathologyWWDS_30_Tfbr_pathology_metaloc_sel",SqlDbType.NVarChar,100,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005C2,11,0,true,false )
             ,new CursorDef("H005C3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005C3,1,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((short[]) buf[20])[0] = rslt.getShort(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((String[]) buf[22])[0] = rslt.getVarchar(12) ;
                ((bool[]) buf[23])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[24])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[25])[0] = rslt.wasNull(13);
                ((long[]) buf[26])[0] = rslt.getLong(14) ;
                ((bool[]) buf[27])[0] = rslt.wasNull(14);
                ((String[]) buf[28])[0] = rslt.getVarchar(15) ;
                ((bool[]) buf[29])[0] = rslt.wasNull(15);
                ((long[]) buf[30])[0] = rslt.getLong(16) ;
                ((bool[]) buf[31])[0] = rslt.wasNull(16);
                ((long[]) buf[32])[0] = rslt.getLong(17) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[32]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[33]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[35]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[36]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[37]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[38]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[39]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[40]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[41]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[43]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[44]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[48]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[49]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[50]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[52]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[53]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[54]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[56]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[57]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[58]);
                }
                if ( (short)parms[28] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[59]);
                }
                if ( (short)parms[29] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[60]);
                }
                if ( (short)parms[30] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[61]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[28]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[29]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[30]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[31]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[34]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[35]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[36]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[37]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[38]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[39]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[40]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[41]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[42]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[43]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[44]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[45]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[46]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[47]);
                }
                if ( (short)parms[20] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[48]);
                }
                if ( (short)parms[21] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[49]);
                }
                if ( (short)parms[22] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[50]);
                }
                if ( (short)parms[23] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[51]);
                }
                if ( (short)parms[24] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[52]);
                }
                if ( (short)parms[25] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[53]);
                }
                if ( (short)parms[26] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[54]);
                }
                if ( (short)parms[27] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[55]);
                }
                return;
       }
    }

 }

}