/*
               File: BR_EncounterCheck
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:1:8.62
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
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_encountercheck : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheck( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encountercheck( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID ,
                           String aP1_TabCode )
      {
         this.AV10BR_EncounterID = aP0_BR_EncounterID;
         this.AV8TabCode = aP1_TabCode;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp;
            }
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV10BR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_EncounterID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8TabCode = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
               }
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
         PA3S2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3S2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227121899", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode))+"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBCBR_ENCOUNTER", AV16BCBR_Encounter);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBCBR_ENCOUNTER", AV16BCBR_Encounter);
         }
         GxWebStd.gx_hidden_field( context, "vTVFLAG", AV27tvflag);
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vWWPCONTEXT", AV6WWPContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vWWPCONTEXT", AV6WWPContext);
         }
         GxWebStd.gx_hidden_field( context, "vTPAGERETURN", AV25tPageReturn);
         GxWebStd.gx_hidden_field( context, "gxhash_vTPAGERETURN", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV25tPageReturn, "")), context));
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV12SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV8TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TABS_Class", StringUtil.RTrim( Tabs_Class));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TABS_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tabs_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TABS_Historymanagement", StringUtil.BoolToStr( Tabs_Historymanagement));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Title", StringUtil.RTrim( Dvelop_confirmpanel_check_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_check_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_check_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_check_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_check_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_check_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_check_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Title", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Title", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Title", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Title", StringUtil.RTrim( Dvelop_confirmpanel_edit_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_edit_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_edit_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_edit_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_edit_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_edit_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_edit_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_check_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Result", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Result", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Result", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Result", StringUtil.RTrim( Dvelop_confirmpanel_edit_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_check_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_CHECKR_Result", StringUtil.RTrim( Dvelop_confirmpanel_checkr_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVERIGHT_Result", StringUtil.RTrim( Dvelop_confirmpanel_approveright_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_APPROVEWRONG_Result", StringUtil.RTrim( Dvelop_confirmpanel_approvewrong_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_EDIT_Result", StringUtil.RTrim( Dvelop_confirmpanel_edit_Result));
         GxWebStd.gx_hidden_field( context, "TABS_Activepagecontrolname", StringUtil.RTrim( Tabs_Activepagecontrolname));
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            WebComp_Generalwc.componentjscripts();
         }
         if ( ! ( WebComp_Checkdemographicswc == null ) )
         {
            WebComp_Checkdemographicswc.componentjscripts();
         }
         if ( ! ( WebComp_Checkbehaviorwc == null ) )
         {
            WebComp_Checkbehaviorwc.componentjscripts();
         }
         if ( ! ( WebComp_Checkcomorbiditywc == null ) )
         {
            WebComp_Checkcomorbiditywc.componentjscripts();
         }
         if ( ! ( WebComp_Checkdeathwc == null ) )
         {
            WebComp_Checkdeathwc.componentjscripts();
         }
         if ( ! ( WebComp_Checkvitalwc == null ) )
         {
            WebComp_Checkvitalwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_diagnosiswc == null ) )
         {
            WebComp_Br_diagnosiswc.componentjscripts();
         }
         if ( ! ( WebComp_Br_labwc == null ) )
         {
            WebComp_Br_labwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_medicationwc == null ) )
         {
            WebComp_Br_medicationwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_schemewc == null ) )
         {
            WebComp_Br_schemewc.componentjscripts();
         }
         if ( ! ( WebComp_Br_procedurewc == null ) )
         {
            WebComp_Br_procedurewc.componentjscripts();
         }
         if ( ! ( WebComp_Br_medicalimagingwc == null ) )
         {
            WebComp_Br_medicalimagingwc.componentjscripts();
         }
         if ( ! ( WebComp_Br_pathologywc == null ) )
         {
            WebComp_Br_pathologywc.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE3S2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3S2( ) ;
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
         return formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim(AV8TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterCheck" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB3S0( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainViewWithShadow", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheck_Internalname, "", "初审抽查通过", bttBtncheck_Jsonclick, 7, "初审抽查通过", "", StyleString, ClassString, bttBtncheck_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e113s1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckr_Internalname, "", "初审抽查不通过", bttBtncheckr_Jsonclick, 7, "初审抽查不通过", "", StyleString, ClassString, bttBtncheckr_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e123s1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnapproveright_Internalname, "", "复审抽查通过", bttBtnapproveright_Jsonclick, 7, "复审抽查通过", "", StyleString, ClassString, bttBtnapproveright_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e133s1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnapprovewrong_Internalname, "", "复审抽查不通过", bttBtnapprovewrong_Jsonclick, 7, "复审抽查不通过", "", StyleString, ClassString, bttBtnapprovewrong_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e143s1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnedit_Internalname, "", "修改", bttBtnedit_Jsonclick, 7, "修改", "", StyleString, ClassString, bttBtnedit_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e153s1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnreturn_Internalname, "", "返回", bttBtnreturn_Jsonclick, 5, "返回", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DORETURN\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTabsPosition CellPaddingTop10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtableviewcontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellTextBlockTitleWWP", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTxttabtitle_Internalname, lblTxttabtitle_Caption, "", "", lblTxttabtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlockTitleWWPTab", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellViewTab", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTabs.SetProperty("PageCount", Tabs_Pagecount);
            ucTabs.SetProperty("Class", Tabs_Class);
            ucTabs.SetProperty("HistoryManagement", Tabs_Historymanagement);
            ucTabs.Render(context, "tab", Tabs_Internalname, "TABSContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "就诊信息", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablegeneral_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0038"+"", StringUtil.RTrim( WebComp_Generalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0038"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
                  }
                  WebComp_Generalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCheckdemographics_title_Internalname, "人口信息学", "", "", lblCheckdemographics_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CheckDemographics") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablecheckdemographics_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0046"+"", StringUtil.RTrim( WebComp_Checkdemographicswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0046"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Checkdemographicswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckdemographicswc), StringUtil.Lower( WebComp_Checkdemographicswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
                  }
                  WebComp_Checkdemographicswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckdemographicswc), StringUtil.Lower( WebComp_Checkdemographicswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCheckbehavior_title_Internalname, "个人史", "", "", lblCheckbehavior_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CheckBehavior") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablecheckbehavior_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0054"+"", StringUtil.RTrim( WebComp_Checkbehaviorwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0054"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Checkbehaviorwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckbehaviorwc), StringUtil.Lower( WebComp_Checkbehaviorwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0054"+"");
                  }
                  WebComp_Checkbehaviorwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckbehaviorwc), StringUtil.Lower( WebComp_Checkbehaviorwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title4"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCheckcomorbidity_title_Internalname, "既往病史", "", "", lblCheckcomorbidity_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CheckComorbidity") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel4"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablecheckcomorbidity_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0062"+"", StringUtil.RTrim( WebComp_Checkcomorbiditywc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0062"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Checkcomorbiditywc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckcomorbiditywc), StringUtil.Lower( WebComp_Checkcomorbiditywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0062"+"");
                  }
                  WebComp_Checkcomorbiditywc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckcomorbiditywc), StringUtil.Lower( WebComp_Checkcomorbiditywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title5"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCheckdeath_title_Internalname, "死亡情况", "", "", lblCheckdeath_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CheckDeath") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel5"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablecheckdeath_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0070"+"", StringUtil.RTrim( WebComp_Checkdeathwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0070"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Checkdeathwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckdeathwc), StringUtil.Lower( WebComp_Checkdeathwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0070"+"");
                  }
                  WebComp_Checkdeathwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckdeathwc), StringUtil.Lower( WebComp_Checkdeathwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title6"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblCheckvital_title_Internalname, "生命体征", "", "", lblCheckvital_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "CheckVital") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel6"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablecheckvital_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0078"+"", StringUtil.RTrim( WebComp_Checkvitalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0078"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Checkvitalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckvitalwc), StringUtil.Lower( WebComp_Checkvitalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0078"+"");
                  }
                  WebComp_Checkvitalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldCheckvitalwc), StringUtil.Lower( WebComp_Checkvitalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title7"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_diagnosis_title_Internalname, "诊断", "", "", lblBr_diagnosis_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Diagnosis") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel7"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_diagnosis_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0086"+"", StringUtil.RTrim( WebComp_Br_diagnosiswc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0086"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_diagnosiswc), StringUtil.Lower( WebComp_Br_diagnosiswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0086"+"");
                  }
                  WebComp_Br_diagnosiswc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_diagnosiswc), StringUtil.Lower( WebComp_Br_diagnosiswc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title8"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_lab_title_Internalname, "实验室检查", "", "", lblBr_lab_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Lab") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel8"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0094"+"", StringUtil.RTrim( WebComp_Br_labwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0094"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_labwc), StringUtil.Lower( WebComp_Br_labwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0094"+"");
                  }
                  WebComp_Br_labwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_labwc), StringUtil.Lower( WebComp_Br_labwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title9"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_medication_title_Internalname, "药物治疗", "", "", lblBr_medication_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Medication") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel9"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medication_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0102"+"", StringUtil.RTrim( WebComp_Br_medicationwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0102"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicationwc), StringUtil.Lower( WebComp_Br_medicationwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0102"+"");
                  }
                  WebComp_Br_medicationwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicationwc), StringUtil.Lower( WebComp_Br_medicationwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title10"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_scheme_title_Internalname, "化疗方案", "", "", lblBr_scheme_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Scheme") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel10"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0110"+"", StringUtil.RTrim( WebComp_Br_schemewc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0110"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_schemewc), StringUtil.Lower( WebComp_Br_schemewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0110"+"");
                  }
                  WebComp_Br_schemewc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_schemewc), StringUtil.Lower( WebComp_Br_schemewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title11"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_procedure_title_Internalname, "诊疗处理", "", "", lblBr_procedure_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Procedure") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel11"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0118"+"", StringUtil.RTrim( WebComp_Br_procedurewc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0118"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_procedurewc), StringUtil.Lower( WebComp_Br_procedurewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0118"+"");
                  }
                  WebComp_Br_procedurewc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_procedurewc), StringUtil.Lower( WebComp_Br_procedurewc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title12"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_medicalimaging_title_Internalname, "影像学", "", "", lblBr_medicalimaging_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_MedicalImaging") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel12"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0126"+"", StringUtil.RTrim( WebComp_Br_medicalimagingwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0126"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicalimagingwc), StringUtil.Lower( WebComp_Br_medicalimagingwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0126"+"");
                  }
                  WebComp_Br_medicalimagingwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_medicalimagingwc), StringUtil.Lower( WebComp_Br_medicalimagingwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"title13"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_pathology_title_Internalname, "病理学", "", "", lblBr_pathology_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_BR_EncounterCheck.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "BR_Pathology") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABSContainer"+"panel13"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_Internalname, 1, 0, "px", 0, "px", "TableViewTab", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0134"+"", StringUtil.RTrim( WebComp_Br_pathologywc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0134"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathologywc), StringUtil.Lower( WebComp_Br_pathologywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0134"+"");
                  }
                  WebComp_Br_pathologywc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldBr_pathologywc), StringUtil.Lower( WebComp_Br_pathologywc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg CellPaddingBottom", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtabletabscontainer_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_general_Internalname, divCell_general_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtngeneral_Internalname, "", "就诊信息", bttBtngeneral_Jsonclick, 5, "就诊信息", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'GENERAL\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_checkdemographics_Internalname, divCell_checkdemographics_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckdemographics_Internalname, "", "人口信息学", bttBtncheckdemographics_Jsonclick, 5, "人口信息学", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CHECKDEMOGRAPHICS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_checkbehavior_Internalname, divCell_checkbehavior_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 146,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckbehavior_Internalname, "", "个人史", bttBtncheckbehavior_Jsonclick, 5, "个人史", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CHECKBEHAVIOR\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_checkcomorbidity_Internalname, divCell_checkcomorbidity_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckcomorbidity_Internalname, "", "既往病史", bttBtncheckcomorbidity_Jsonclick, 5, "既往病史", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CHECKCOMORBIDITY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_checkdeath_Internalname, divCell_checkdeath_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckdeath_Internalname, "", "死亡情况", bttBtncheckdeath_Jsonclick, 5, "死亡情况", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CHECKDEATH\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_checkvital_Internalname, divCell_checkvital_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 155,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtncheckvital_Internalname, "", "生命体征", bttBtncheckvital_Jsonclick, 5, "生命体征", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'CHECKVITAL\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_diagnosis_Internalname, divCell_br_diagnosis_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_diagnosis_Internalname, "", "诊断", bttBtnbr_diagnosis_Jsonclick, 5, "诊断", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_DIAGNOSIS\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_lab_Internalname, divCell_br_lab_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 161,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_lab_Internalname, "", "实验室检查", bttBtnbr_lab_Jsonclick, 5, "实验室检查", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_LAB\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_medication_Internalname, divCell_br_medication_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 164,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_medication_Internalname, "", "药物治疗", bttBtnbr_medication_Jsonclick, 5, "药物治疗", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_MEDICATION\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_scheme_Internalname, divCell_br_scheme_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 167,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_scheme_Internalname, "", "化疗方案", bttBtnbr_scheme_Jsonclick, 5, "化疗方案", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_SCHEME\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_procedure_Internalname, divCell_br_procedure_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 170,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_procedure_Internalname, "", "诊疗处理", bttBtnbr_procedure_Jsonclick, 5, "诊疗处理", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PROCEDURE\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_medicalimaging_Internalname, divCell_br_medicalimaging_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 173,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_medicalimaging_Internalname, "", "影像学", bttBtnbr_medicalimaging_Jsonclick, 5, "影像学", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_MEDICALIMAGING\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divCell_br_pathology_Internalname, divCell_br_pathology_Visible, 0, "px", 0, "px", "col-xs-12 CellMarginTop", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 176,'',false,'',0)\"";
            ClassString = "btn_Master btn-large btn-block Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbr_pathology_Internalname, "", "病理学", bttBtnbr_pathology_Jsonclick, 5, "病理学", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'BR_PATHOLOGY\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterCheck.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            wb_table1_180_3S2( true) ;
         }
         else
         {
            wb_table1_180_3S2( false) ;
         }
         return  ;
      }

      protected void wb_table1_180_3S2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table2_185_3S2( true) ;
         }
         else
         {
            wb_table2_185_3S2( false) ;
         }
         return  ;
      }

      protected void wb_table2_185_3S2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_190_3S2( true) ;
         }
         else
         {
            wb_table3_190_3S2( false) ;
         }
         return  ;
      }

      protected void wb_table3_190_3S2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table4_195_3S2( true) ;
         }
         else
         {
            wb_table4_195_3S2( false) ;
         }
         return  ;
      }

      protected void wb_table4_195_3S2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table5_200_3S2( true) ;
         }
         else
         {
            wb_table5_200_3S2( false) ;
         }
         return  ;
      }

      protected void wb_table5_200_3S2e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START3S2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3S0( ) ;
      }

      protected void WS3S2( )
      {
         START3S2( ) ;
         EVT3S2( ) ;
      }

      protected void EVT3S2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "TABS.TABCHANGED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E163S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_CHECK.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E173S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_CHECKR.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E183S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_APPROVERIGHT.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E193S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_APPROVEWRONG.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E203S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_EDIT.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E213S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E223S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Refresh */
                              E233S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E243S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DORETURN'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Doreturn' */
                              E253S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'GENERAL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'General' */
                              E263S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CHECKDEMOGRAPHICS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'CheckDemographics' */
                              E273S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CHECKBEHAVIOR'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'CheckBehavior' */
                              E283S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CHECKCOMORBIDITY'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'CheckComorbidity' */
                              E293S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CHECKDEATH'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'CheckDeath' */
                              E303S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CHECKVITAL'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'CheckVital' */
                              E313S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_DIAGNOSIS'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Diagnosis' */
                              E323S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_LAB'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Lab' */
                              E333S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_MEDICATION'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Medication' */
                              E343S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_SCHEME'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Scheme' */
                              E353S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PROCEDURE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Procedure' */
                              E363S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_MEDICALIMAGING'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_MedicalImaging' */
                              E373S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'BR_PATHOLOGY'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'BR_Pathology' */
                              E383S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOREFUSE'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'Dorefuse' */
                              E393S2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
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
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 38 )
                        {
                           OldGeneralwc = cgiGet( "W0038");
                           if ( ( StringUtil.Len( OldGeneralwc) == 0 ) || ( StringUtil.StrCmp(OldGeneralwc, WebComp_Generalwc_Component) != 0 ) )
                           {
                              WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", OldGeneralwc, new Object[] {context} );
                              WebComp_Generalwc.ComponentInit();
                              WebComp_Generalwc.Name = "OldGeneralwc";
                              WebComp_Generalwc_Component = OldGeneralwc;
                           }
                           if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                           {
                              WebComp_Generalwc.componentprocess("W0038", "", sEvt);
                           }
                           WebComp_Generalwc_Component = OldGeneralwc;
                        }
                        else if ( nCmpId == 46 )
                        {
                           OldCheckdemographicswc = cgiGet( "W0046");
                           if ( ( StringUtil.Len( OldCheckdemographicswc) == 0 ) || ( StringUtil.StrCmp(OldCheckdemographicswc, WebComp_Checkdemographicswc_Component) != 0 ) )
                           {
                              WebComp_Checkdemographicswc = getWebComponent(GetType(), "GeneXus.Programs", OldCheckdemographicswc, new Object[] {context} );
                              WebComp_Checkdemographicswc.ComponentInit();
                              WebComp_Checkdemographicswc.Name = "OldCheckdemographicswc";
                              WebComp_Checkdemographicswc_Component = OldCheckdemographicswc;
                           }
                           if ( StringUtil.Len( WebComp_Checkdemographicswc_Component) != 0 )
                           {
                              WebComp_Checkdemographicswc.componentprocess("W0046", "", sEvt);
                           }
                           WebComp_Checkdemographicswc_Component = OldCheckdemographicswc;
                        }
                        else if ( nCmpId == 54 )
                        {
                           OldCheckbehaviorwc = cgiGet( "W0054");
                           if ( ( StringUtil.Len( OldCheckbehaviorwc) == 0 ) || ( StringUtil.StrCmp(OldCheckbehaviorwc, WebComp_Checkbehaviorwc_Component) != 0 ) )
                           {
                              WebComp_Checkbehaviorwc = getWebComponent(GetType(), "GeneXus.Programs", OldCheckbehaviorwc, new Object[] {context} );
                              WebComp_Checkbehaviorwc.ComponentInit();
                              WebComp_Checkbehaviorwc.Name = "OldCheckbehaviorwc";
                              WebComp_Checkbehaviorwc_Component = OldCheckbehaviorwc;
                           }
                           if ( StringUtil.Len( WebComp_Checkbehaviorwc_Component) != 0 )
                           {
                              WebComp_Checkbehaviorwc.componentprocess("W0054", "", sEvt);
                           }
                           WebComp_Checkbehaviorwc_Component = OldCheckbehaviorwc;
                        }
                        else if ( nCmpId == 62 )
                        {
                           OldCheckcomorbiditywc = cgiGet( "W0062");
                           if ( ( StringUtil.Len( OldCheckcomorbiditywc) == 0 ) || ( StringUtil.StrCmp(OldCheckcomorbiditywc, WebComp_Checkcomorbiditywc_Component) != 0 ) )
                           {
                              WebComp_Checkcomorbiditywc = getWebComponent(GetType(), "GeneXus.Programs", OldCheckcomorbiditywc, new Object[] {context} );
                              WebComp_Checkcomorbiditywc.ComponentInit();
                              WebComp_Checkcomorbiditywc.Name = "OldCheckcomorbiditywc";
                              WebComp_Checkcomorbiditywc_Component = OldCheckcomorbiditywc;
                           }
                           if ( StringUtil.Len( WebComp_Checkcomorbiditywc_Component) != 0 )
                           {
                              WebComp_Checkcomorbiditywc.componentprocess("W0062", "", sEvt);
                           }
                           WebComp_Checkcomorbiditywc_Component = OldCheckcomorbiditywc;
                        }
                        else if ( nCmpId == 70 )
                        {
                           OldCheckdeathwc = cgiGet( "W0070");
                           if ( ( StringUtil.Len( OldCheckdeathwc) == 0 ) || ( StringUtil.StrCmp(OldCheckdeathwc, WebComp_Checkdeathwc_Component) != 0 ) )
                           {
                              WebComp_Checkdeathwc = getWebComponent(GetType(), "GeneXus.Programs", OldCheckdeathwc, new Object[] {context} );
                              WebComp_Checkdeathwc.ComponentInit();
                              WebComp_Checkdeathwc.Name = "OldCheckdeathwc";
                              WebComp_Checkdeathwc_Component = OldCheckdeathwc;
                           }
                           if ( StringUtil.Len( WebComp_Checkdeathwc_Component) != 0 )
                           {
                              WebComp_Checkdeathwc.componentprocess("W0070", "", sEvt);
                           }
                           WebComp_Checkdeathwc_Component = OldCheckdeathwc;
                        }
                        else if ( nCmpId == 78 )
                        {
                           OldCheckvitalwc = cgiGet( "W0078");
                           if ( ( StringUtil.Len( OldCheckvitalwc) == 0 ) || ( StringUtil.StrCmp(OldCheckvitalwc, WebComp_Checkvitalwc_Component) != 0 ) )
                           {
                              WebComp_Checkvitalwc = getWebComponent(GetType(), "GeneXus.Programs", OldCheckvitalwc, new Object[] {context} );
                              WebComp_Checkvitalwc.ComponentInit();
                              WebComp_Checkvitalwc.Name = "OldCheckvitalwc";
                              WebComp_Checkvitalwc_Component = OldCheckvitalwc;
                           }
                           if ( StringUtil.Len( WebComp_Checkvitalwc_Component) != 0 )
                           {
                              WebComp_Checkvitalwc.componentprocess("W0078", "", sEvt);
                           }
                           WebComp_Checkvitalwc_Component = OldCheckvitalwc;
                        }
                        else if ( nCmpId == 86 )
                        {
                           OldBr_diagnosiswc = cgiGet( "W0086");
                           if ( ( StringUtil.Len( OldBr_diagnosiswc) == 0 ) || ( StringUtil.StrCmp(OldBr_diagnosiswc, WebComp_Br_diagnosiswc_Component) != 0 ) )
                           {
                              WebComp_Br_diagnosiswc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_diagnosiswc, new Object[] {context} );
                              WebComp_Br_diagnosiswc.ComponentInit();
                              WebComp_Br_diagnosiswc.Name = "OldBr_diagnosiswc";
                              WebComp_Br_diagnosiswc_Component = OldBr_diagnosiswc;
                           }
                           if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
                           {
                              WebComp_Br_diagnosiswc.componentprocess("W0086", "", sEvt);
                           }
                           WebComp_Br_diagnosiswc_Component = OldBr_diagnosiswc;
                        }
                        else if ( nCmpId == 94 )
                        {
                           OldBr_labwc = cgiGet( "W0094");
                           if ( ( StringUtil.Len( OldBr_labwc) == 0 ) || ( StringUtil.StrCmp(OldBr_labwc, WebComp_Br_labwc_Component) != 0 ) )
                           {
                              WebComp_Br_labwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_labwc, new Object[] {context} );
                              WebComp_Br_labwc.ComponentInit();
                              WebComp_Br_labwc.Name = "OldBr_labwc";
                              WebComp_Br_labwc_Component = OldBr_labwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
                           {
                              WebComp_Br_labwc.componentprocess("W0094", "", sEvt);
                           }
                           WebComp_Br_labwc_Component = OldBr_labwc;
                        }
                        else if ( nCmpId == 102 )
                        {
                           OldBr_medicationwc = cgiGet( "W0102");
                           if ( ( StringUtil.Len( OldBr_medicationwc) == 0 ) || ( StringUtil.StrCmp(OldBr_medicationwc, WebComp_Br_medicationwc_Component) != 0 ) )
                           {
                              WebComp_Br_medicationwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_medicationwc, new Object[] {context} );
                              WebComp_Br_medicationwc.ComponentInit();
                              WebComp_Br_medicationwc.Name = "OldBr_medicationwc";
                              WebComp_Br_medicationwc_Component = OldBr_medicationwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
                           {
                              WebComp_Br_medicationwc.componentprocess("W0102", "", sEvt);
                           }
                           WebComp_Br_medicationwc_Component = OldBr_medicationwc;
                        }
                        else if ( nCmpId == 110 )
                        {
                           OldBr_schemewc = cgiGet( "W0110");
                           if ( ( StringUtil.Len( OldBr_schemewc) == 0 ) || ( StringUtil.StrCmp(OldBr_schemewc, WebComp_Br_schemewc_Component) != 0 ) )
                           {
                              WebComp_Br_schemewc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_schemewc, new Object[] {context} );
                              WebComp_Br_schemewc.ComponentInit();
                              WebComp_Br_schemewc.Name = "OldBr_schemewc";
                              WebComp_Br_schemewc_Component = OldBr_schemewc;
                           }
                           if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
                           {
                              WebComp_Br_schemewc.componentprocess("W0110", "", sEvt);
                           }
                           WebComp_Br_schemewc_Component = OldBr_schemewc;
                        }
                        else if ( nCmpId == 118 )
                        {
                           OldBr_procedurewc = cgiGet( "W0118");
                           if ( ( StringUtil.Len( OldBr_procedurewc) == 0 ) || ( StringUtil.StrCmp(OldBr_procedurewc, WebComp_Br_procedurewc_Component) != 0 ) )
                           {
                              WebComp_Br_procedurewc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_procedurewc, new Object[] {context} );
                              WebComp_Br_procedurewc.ComponentInit();
                              WebComp_Br_procedurewc.Name = "OldBr_procedurewc";
                              WebComp_Br_procedurewc_Component = OldBr_procedurewc;
                           }
                           if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
                           {
                              WebComp_Br_procedurewc.componentprocess("W0118", "", sEvt);
                           }
                           WebComp_Br_procedurewc_Component = OldBr_procedurewc;
                        }
                        else if ( nCmpId == 126 )
                        {
                           OldBr_medicalimagingwc = cgiGet( "W0126");
                           if ( ( StringUtil.Len( OldBr_medicalimagingwc) == 0 ) || ( StringUtil.StrCmp(OldBr_medicalimagingwc, WebComp_Br_medicalimagingwc_Component) != 0 ) )
                           {
                              WebComp_Br_medicalimagingwc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_medicalimagingwc, new Object[] {context} );
                              WebComp_Br_medicalimagingwc.ComponentInit();
                              WebComp_Br_medicalimagingwc.Name = "OldBr_medicalimagingwc";
                              WebComp_Br_medicalimagingwc_Component = OldBr_medicalimagingwc;
                           }
                           if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
                           {
                              WebComp_Br_medicalimagingwc.componentprocess("W0126", "", sEvt);
                           }
                           WebComp_Br_medicalimagingwc_Component = OldBr_medicalimagingwc;
                        }
                        else if ( nCmpId == 134 )
                        {
                           OldBr_pathologywc = cgiGet( "W0134");
                           if ( ( StringUtil.Len( OldBr_pathologywc) == 0 ) || ( StringUtil.StrCmp(OldBr_pathologywc, WebComp_Br_pathologywc_Component) != 0 ) )
                           {
                              WebComp_Br_pathologywc = getWebComponent(GetType(), "GeneXus.Programs", OldBr_pathologywc, new Object[] {context} );
                              WebComp_Br_pathologywc.ComponentInit();
                              WebComp_Br_pathologywc.Name = "OldBr_pathologywc";
                              WebComp_Br_pathologywc_Component = OldBr_pathologywc;
                           }
                           if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
                           {
                              WebComp_Br_pathologywc.componentprocess("W0134", "", sEvt);
                           }
                           WebComp_Br_pathologywc_Component = OldBr_pathologywc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE3S2( )
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

      protected void PA3S2( )
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
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
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
         RF3S2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF3S2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E233S2 ();
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  WebComp_Generalwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Checkdemographicswc_Component) != 0 )
               {
                  WebComp_Checkdemographicswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Checkbehaviorwc_Component) != 0 )
               {
                  WebComp_Checkbehaviorwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Checkcomorbiditywc_Component) != 0 )
               {
                  WebComp_Checkcomorbiditywc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Checkdeathwc_Component) != 0 )
               {
                  WebComp_Checkdeathwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Checkvitalwc_Component) != 0 )
               {
                  WebComp_Checkvitalwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
               {
                  WebComp_Br_diagnosiswc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
               {
                  WebComp_Br_labwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
               {
                  WebComp_Br_medicationwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
               {
                  WebComp_Br_schemewc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
               {
                  WebComp_Br_procedurewc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
               {
                  WebComp_Br_medicalimagingwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
               {
                  WebComp_Br_pathologywc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E243S2 ();
            WB3S0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes3S2( )
      {
         GxWebStd.gx_hidden_field( context, "vTPAGERETURN", AV25tPageReturn);
         GxWebStd.gx_hidden_field( context, "gxhash_vTPAGERETURN", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV25tPageReturn, "")), context));
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
      }

      protected void STRUP3S0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E223S2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            Tabs_Class = cgiGet( "TABS_Class");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            Tabs_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TABS_Pagecount"), ".", ","));
            Tabs_Historymanagement = StringUtil.StrToBool( cgiGet( "TABS_Historymanagement"));
            Dvelop_confirmpanel_check_Title = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Title");
            Dvelop_confirmpanel_check_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Confirmationtext");
            Dvelop_confirmpanel_check_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Yesbuttoncaption");
            Dvelop_confirmpanel_check_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Nobuttoncaption");
            Dvelop_confirmpanel_check_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Cancelbuttoncaption");
            Dvelop_confirmpanel_check_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Yesbuttonposition");
            Dvelop_confirmpanel_check_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Confirmtype");
            Dvelop_confirmpanel_checkr_Title = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Title");
            Dvelop_confirmpanel_checkr_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Confirmationtext");
            Dvelop_confirmpanel_checkr_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Yesbuttoncaption");
            Dvelop_confirmpanel_checkr_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Nobuttoncaption");
            Dvelop_confirmpanel_checkr_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Cancelbuttoncaption");
            Dvelop_confirmpanel_checkr_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Yesbuttonposition");
            Dvelop_confirmpanel_checkr_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Confirmtype");
            Dvelop_confirmpanel_approveright_Title = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Title");
            Dvelop_confirmpanel_approveright_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Confirmationtext");
            Dvelop_confirmpanel_approveright_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Yesbuttoncaption");
            Dvelop_confirmpanel_approveright_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Nobuttoncaption");
            Dvelop_confirmpanel_approveright_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Cancelbuttoncaption");
            Dvelop_confirmpanel_approveright_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Yesbuttonposition");
            Dvelop_confirmpanel_approveright_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Confirmtype");
            Dvelop_confirmpanel_approvewrong_Title = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Title");
            Dvelop_confirmpanel_approvewrong_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Confirmationtext");
            Dvelop_confirmpanel_approvewrong_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Yesbuttoncaption");
            Dvelop_confirmpanel_approvewrong_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Nobuttoncaption");
            Dvelop_confirmpanel_approvewrong_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Cancelbuttoncaption");
            Dvelop_confirmpanel_approvewrong_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Yesbuttonposition");
            Dvelop_confirmpanel_approvewrong_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Confirmtype");
            Dvelop_confirmpanel_edit_Title = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Title");
            Dvelop_confirmpanel_edit_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Confirmationtext");
            Dvelop_confirmpanel_edit_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Yesbuttoncaption");
            Dvelop_confirmpanel_edit_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Nobuttoncaption");
            Dvelop_confirmpanel_edit_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Cancelbuttoncaption");
            Dvelop_confirmpanel_edit_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Yesbuttonposition");
            Dvelop_confirmpanel_edit_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Confirmtype");
            Dvelop_confirmpanel_check_Result = cgiGet( "DVELOP_CONFIRMPANEL_CHECK_Result");
            Dvelop_confirmpanel_checkr_Result = cgiGet( "DVELOP_CONFIRMPANEL_CHECKR_Result");
            Dvelop_confirmpanel_approveright_Result = cgiGet( "DVELOP_CONFIRMPANEL_APPROVERIGHT_Result");
            Dvelop_confirmpanel_approvewrong_Result = cgiGet( "DVELOP_CONFIRMPANEL_APPROVEWRONG_Result");
            Dvelop_confirmpanel_edit_Result = cgiGet( "DVELOP_CONFIRMPANEL_EDIT_Result");
            Tabs_Activepagecontrolname = cgiGet( "TABS_Activepagecontrolname");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E223S2 ();
         if (returnInSub) return;
      }

      protected void E223S2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV34GXLvl9 = 0;
         /* Using cursor H003S2 */
         pr_default.execute(0, new Object[] {AV10BR_EncounterID});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A19BR_EncounterID = H003S2_A19BR_EncounterID[0];
            AV34GXLvl9 = 1;
            Form.Caption = "Data Mgmt Portal - RAAP";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         if ( AV34GXLvl9 == 0 )
         {
            Form.Caption = "记录未找到";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
            AV9Exists = false;
         }
         if ( AV9Exists )
         {
            AV12SelectedTabCode = AV8TabCode;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
            Tabs_Activepagecontrolname = AV12SelectedTabCode;
            ucTabs.SendProperty(context, "", false, Tabs_Internalname, "ActivePageControlName", Tabs_Activepagecontrolname);
            /* Execute user subroutine: 'LOADTABS' */
            S112 ();
            if (returnInSub) return;
         }
         AV24WebSession.Set("Br_EncounterType", "check");
         AV25tPageReturn = StringUtil.Trim( AV24WebSession.Get("Br_EncounterReturnPage"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25tPageReturn", AV25tPageReturn);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTPAGERETURN", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV25tPageReturn, "")), context));
         AV16BCBR_Encounter.Load(AV10BR_EncounterID);
      }

      protected void E233S2( )
      {
         /* Refresh Routine */
         AV23IsComplete = false;
         AV22IsDenyApprove = false;
         AV20IsDenyCheck = false;
         AV17IsUpdateEncounter = false;
         AV21IsWaitApprove = false;
         AV19IsWaitCheck = false;
         AV18tBR_Encounter_Status.Clear();
         GXt_boolean1 = AV19IsWaitCheck;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_WaitCheck", out  GXt_boolean1) ;
         AV19IsWaitCheck = GXt_boolean1;
         if ( AV19IsWaitCheck )
         {
            AV18tBR_Encounter_Status.Add(2, 0);
         }
         GXt_boolean1 = AV20IsDenyCheck;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_DenyCheck", out  GXt_boolean1) ;
         AV20IsDenyCheck = GXt_boolean1;
         if ( AV20IsDenyCheck )
         {
            AV18tBR_Encounter_Status.Add(3, 0);
         }
         GXt_boolean1 = AV21IsWaitApprove;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_WaitApprove", out  GXt_boolean1) ;
         AV21IsWaitApprove = GXt_boolean1;
         if ( AV21IsWaitApprove )
         {
            AV18tBR_Encounter_Status.Add(4, 0);
         }
         GXt_boolean1 = AV22IsDenyApprove;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_DenyApprove", out  GXt_boolean1) ;
         AV22IsDenyApprove = GXt_boolean1;
         if ( AV22IsDenyApprove )
         {
            AV18tBR_Encounter_Status.Add(5, 0);
         }
         GXt_boolean1 = AV23IsComplete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_FlowStatus_Complete", out  GXt_boolean1) ;
         AV23IsComplete = GXt_boolean1;
         if ( AV23IsComplete )
         {
            AV18tBR_Encounter_Status.Add(6, 0);
         }
         if ( (AV18tBR_Encounter_Status.IndexOf(AV16BCBR_Encounter.gxTpr_Br_encounter_status)>0) )
         {
            bttBtnedit_Visible = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnedit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnedit_Visible), 5, 0)), true);
         }
         else
         {
            bttBtnedit_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnedit_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnedit_Visible), 5, 0)), true);
         }
         if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 2 )
         {
            if ( AV16BCBR_Encounter.gxTpr_Br_encounter_israndapprove )
            {
               bttBtncheck_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
               bttBtncheckr_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheckr_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheckr_Visible), 5, 0)), true);
            }
            else
            {
               bttBtncheck_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
               bttBtncheckr_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheckr_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheckr_Visible), 5, 0)), true);
            }
         }
         else
         {
            bttBtncheck_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
            bttBtncheckr_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheckr_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheckr_Visible), 5, 0)), true);
         }
         if ( AV16BCBR_Encounter.gxTpr_Br_encounter_status == 4 )
         {
            if ( AV16BCBR_Encounter.gxTpr_Br_encounter_israndrecheck )
            {
               bttBtnapproveright_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapproveright_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapproveright_Visible), 5, 0)), true);
               bttBtnapprovewrong_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapprovewrong_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapprovewrong_Visible), 5, 0)), true);
            }
            else
            {
               bttBtnapproveright_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapproveright_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapproveright_Visible), 5, 0)), true);
               bttBtnapprovewrong_Visible = 1;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapprovewrong_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapprovewrong_Visible), 5, 0)), true);
            }
         }
         else
         {
            bttBtnapproveright_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapproveright_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapproveright_Visible), 5, 0)), true);
            bttBtnapprovewrong_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapprovewrong_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapprovewrong_Visible), 5, 0)), true);
         }
         if ( StringUtil.StrCmp(AV27tvflag, "hao") == 0 )
         {
            CallWebObject(formatLink("br_encounterlist.aspx") );
            context.wjLocDisableFrm = 1;
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtncheck_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheck_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtncheckr_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtncheckr_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtncheckr_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnapproveright_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapproveright_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapproveright_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV13TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean1) ;
         AV13TempBoolean = GXt_boolean1;
         if ( ! ( AV13TempBoolean ) )
         {
            bttBtnapprovewrong_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnapprovewrong_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnapprovewrong_Visible), 5, 0)), true);
         }
         /*  Sending Event outputs  */
      }

      protected void nextLoad( )
      {
      }

      protected void E243S2( )
      {
         /* Load Routine */
      }

      protected void E173S2( )
      {
         /* Dvelop_confirmpanel_check_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_check_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION CHECK' */
            S122 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BCBR_Encounter", AV16BCBR_Encounter);
      }

      protected void E183S2( )
      {
         /* Dvelop_confirmpanel_checkr_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_checkr_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION CHECKR' */
            S132 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E193S2( )
      {
         /* Dvelop_confirmpanel_approveright_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_approveright_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION APPROVERIGHT' */
            S142 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BCBR_Encounter", AV16BCBR_Encounter);
      }

      protected void E203S2( )
      {
         /* Dvelop_confirmpanel_approvewrong_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_approvewrong_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION APPROVEWRONG' */
            S152 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
      }

      protected void E213S2( )
      {
         /* Dvelop_confirmpanel_edit_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_edit_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION EDIT' */
            S162 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BCBR_Encounter", AV16BCBR_Encounter);
      }

      protected void E253S2( )
      {
         /* 'Doreturn' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            AV24WebSession.Remove("Br_EncounterReturnPage");
            if ( StringUtil.StrCmp(AV25tPageReturn, "br_encounter") == 0 )
            {
               CallWebObject(formatLink("br_encounterlist.aspx") );
               context.wjLocDisableFrm = 1;
            }
            else
            {
               CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
               context.wjLocDisableFrm = 1;
            }
         }
      }

      protected void E163S2( )
      {
         /* Tabs_Tabchanged Routine */
         AV12SelectedTabCode = Tabs_Activepagecontrolname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E263S2( )
      {
         /* 'General' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)1});
         AV12SelectedTabCode = "General";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E273S2( )
      {
         /* 'CheckDemographics' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)2});
         AV12SelectedTabCode = "CheckDemographics";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E283S2( )
      {
         /* 'CheckBehavior' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)3});
         AV12SelectedTabCode = "CheckBehavior";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E293S2( )
      {
         /* 'CheckComorbidity' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)4});
         AV12SelectedTabCode = "CheckComorbidity";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E303S2( )
      {
         /* 'CheckDeath' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)5});
         AV12SelectedTabCode = "CheckDeath";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E313S2( )
      {
         /* 'CheckVital' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)6});
         AV12SelectedTabCode = "CheckVital";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E323S2( )
      {
         /* 'BR_Diagnosis' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)7});
         AV12SelectedTabCode = "BR_Diagnosis";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E333S2( )
      {
         /* 'BR_Lab' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)8});
         AV12SelectedTabCode = "BR_Lab";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E343S2( )
      {
         /* 'BR_Medication' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)9});
         AV12SelectedTabCode = "BR_Medication";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E353S2( )
      {
         /* 'BR_Scheme' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)10});
         AV12SelectedTabCode = "BR_Scheme";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E363S2( )
      {
         /* 'BR_Procedure' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)11});
         AV12SelectedTabCode = "BR_Procedure";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E373S2( )
      {
         /* 'BR_MedicalImaging' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)12});
         AV12SelectedTabCode = "BR_MedicalImaging";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void E383S2( )
      {
         /* 'BR_Pathology' Routine */
         new zutil_setsession(context ).execute(  AV6WWPContext) ;
         this.executeUsercontrolMethod("", false, "TABSContainer", "SelectTab", "", new Object[] {(short)13});
         AV12SelectedTabCode = "BR_Pathology";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12SelectedTabCode", AV12SelectedTabCode);
         AV11LoadAllTabs = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         /* Execute user subroutine: 'LOADTABS' */
         S112 ();
         if (returnInSub) return;
         /*  Sending Event outputs  */
      }

      protected void S122( )
      {
         /* 'DO ACTION CHECK' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndapprove = true;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndapprover = AV6WWPContext.gxTpr_Userdisplayname;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndapprovedate = DateTimeUtil.ServerNow( context, pr_default);
            AV16BCBR_Encounter.gxTpr_Br_encounter_status = 4;
            AV16BCBR_Encounter.Save();
            if ( AV16BCBR_Encounter.Success() )
            {
               new zutil_recordlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV16BCBR_Encounter.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  "Randomcheckpass",  1) ;
               context.CommitDataStores("br_encountercheck",pr_default);
               AV24WebSession.Remove("Br_EncounterReturnPage");
               if ( StringUtil.StrCmp(AV25tPageReturn, "br_encounter") == 0 )
               {
                  CallWebObject(formatLink("br_encounterlist.aspx") );
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
                  context.wjLocDisableFrm = 1;
               }
            }
            else
            {
               GX_msglist.addItem("保存失败");
            }
         }
      }

      protected void S132( )
      {
         /* 'DO ACTION CHECKR' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            context.PopUp(formatLink("br_enteringsubmit.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("")), new Object[] {"AV27tvflag"});
            context.DoAjaxRefresh();
         }
      }

      protected void S142( )
      {
         /* 'DO ACTION APPROVERIGHT' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndrecheck = true;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndrecheckr = AV6WWPContext.gxTpr_Userdisplayname;
            AV16BCBR_Encounter.gxTpr_Br_encounter_israndrecheckdate = DateTimeUtil.ServerNow( context, pr_default);
            AV16BCBR_Encounter.gxTpr_Br_encounter_status = 6;
            AV16BCBR_Encounter.Save();
            if ( AV16BCBR_Encounter.Success() )
            {
               new zutil_recordlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV16BCBR_Encounter.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  "Randomapprovepass",  1) ;
               context.CommitDataStores("br_encountercheck",pr_default);
               AV24WebSession.Remove("Br_EncounterReturnPage");
               if ( StringUtil.StrCmp(AV25tPageReturn, "br_encounter") == 0 )
               {
                  CallWebObject(formatLink("br_encounterlist.aspx") );
                  context.wjLocDisableFrm = 1;
               }
               else
               {
                  CallWebObject(formatLink("br_informationview.aspx") + "?" + UrlEncode("" +AV16BCBR_Encounter.gxTpr_Br_information_id) + "," + UrlEncode(StringUtil.RTrim("br_encounter")));
                  context.wjLocDisableFrm = 1;
               }
            }
            else
            {
               GX_msglist.addItem("保存失败");
            }
         }
      }

      protected void S152( )
      {
         /* 'DO ACTION APPROVEWRONG' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            context.PopUp(formatLink("br_enteringreaptcheck.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("")), new Object[] {"AV27tvflag"});
            context.DoAjaxRefresh();
         }
      }

      protected void S162( )
      {
         /* 'DO ACTION EDIT' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            AV16BCBR_Encounter.Load(AV10BR_EncounterID);
            AV16BCBR_Encounter.gxTpr_Br_encounter_upddate = DateTimeUtil.ServerNow( context, pr_default);
            AV16BCBR_Encounter.gxTpr_Br_encounter_upduser = AV6WWPContext.gxTpr_Userdisplayname;
            AV16BCBR_Encounter.gxTpr_Br_encounter_isupdate = true;
            AV16BCBR_Encounter.Save();
            if ( AV16BCBR_Encounter.Success() )
            {
               new zutil_recordlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(AV16BCBR_Encounter.gxTpr_Br_encounterid), 18, 0)),  "就诊信息",  "Reupdate",  1) ;
               context.CommitDataStores("br_encountercheck",pr_default);
               AV24WebSession.Set("Permisstion_Update", "yes");
               CallWebObject(formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("BR_Encounter")));
               context.wjLocDisableFrm = 1;
            }
            else
            {
               GX_msglist.addItem("跳转失败");
            }
         }
      }

      protected void S112( )
      {
         /* 'LOADTABS' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         divCell_general_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "BR_EncounterCheckGeneral")) != 0 )
            {
               WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckgeneral", new Object[] {context} );
               WebComp_Generalwc.ComponentInit();
               WebComp_Generalwc.Name = "BR_EncounterCheckGeneral";
               WebComp_Generalwc_Component = "BR_EncounterCheckGeneral";
            }
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.setjustcreated();
               WebComp_Generalwc.componentprepare(new Object[] {(String)"W0038",(String)"",(long)AV10BR_EncounterID});
               WebComp_Generalwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
               WebComp_Generalwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "就诊信息";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( ( StringUtil.StrCmp(AV12SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV12SelectedTabCode, "General") == 0 ) )
            {
               divCell_general_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_general_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_general_Visible), 5, 0)), true);
            }
         }
         divCell_checkdemographics_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkdemographics_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkdemographics_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckDemographics") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Checkdemographicswc_Component), StringUtil.Lower( "BR_EncounterCheckDemographics")) != 0 )
            {
               WebComp_Checkdemographicswc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckdemographics", new Object[] {context} );
               WebComp_Checkdemographicswc.ComponentInit();
               WebComp_Checkdemographicswc.Name = "BR_EncounterCheckDemographics";
               WebComp_Checkdemographicswc_Component = "BR_EncounterCheckDemographics";
            }
            if ( StringUtil.Len( WebComp_Checkdemographicswc_Component) != 0 )
            {
               WebComp_Checkdemographicswc.setjustcreated();
               WebComp_Checkdemographicswc.componentprepare(new Object[] {(String)"W0046",(String)"",(long)AV10BR_EncounterID});
               WebComp_Checkdemographicswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
               WebComp_Checkdemographicswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "人口信息学";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckDemographics") == 0 )
            {
               divCell_checkdemographics_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkdemographics_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkdemographics_Visible), 5, 0)), true);
            }
         }
         divCell_checkbehavior_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkbehavior_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkbehavior_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckBehavior") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Checkbehaviorwc_Component), StringUtil.Lower( "BR_EncounterCheckBehavior")) != 0 )
            {
               WebComp_Checkbehaviorwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbehavior", new Object[] {context} );
               WebComp_Checkbehaviorwc.ComponentInit();
               WebComp_Checkbehaviorwc.Name = "BR_EncounterCheckBehavior";
               WebComp_Checkbehaviorwc_Component = "BR_EncounterCheckBehavior";
            }
            if ( StringUtil.Len( WebComp_Checkbehaviorwc_Component) != 0 )
            {
               WebComp_Checkbehaviorwc.setjustcreated();
               WebComp_Checkbehaviorwc.componentprepare(new Object[] {(String)"W0054",(String)"",(long)AV10BR_EncounterID});
               WebComp_Checkbehaviorwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0054"+"");
               WebComp_Checkbehaviorwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "个人史";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckBehavior") == 0 )
            {
               divCell_checkbehavior_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkbehavior_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkbehavior_Visible), 5, 0)), true);
            }
         }
         divCell_checkcomorbidity_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkcomorbidity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkcomorbidity_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckComorbidity") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Checkcomorbiditywc_Component), StringUtil.Lower( "BR_EncounterCheckComorbidity")) != 0 )
            {
               WebComp_Checkcomorbiditywc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckcomorbidity", new Object[] {context} );
               WebComp_Checkcomorbiditywc.ComponentInit();
               WebComp_Checkcomorbiditywc.Name = "BR_EncounterCheckComorbidity";
               WebComp_Checkcomorbiditywc_Component = "BR_EncounterCheckComorbidity";
            }
            if ( StringUtil.Len( WebComp_Checkcomorbiditywc_Component) != 0 )
            {
               WebComp_Checkcomorbiditywc.setjustcreated();
               WebComp_Checkcomorbiditywc.componentprepare(new Object[] {(String)"W0062",(String)"",(long)AV10BR_EncounterID});
               WebComp_Checkcomorbiditywc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0062"+"");
               WebComp_Checkcomorbiditywc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "既往病史";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckComorbidity") == 0 )
            {
               divCell_checkcomorbidity_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkcomorbidity_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkcomorbidity_Visible), 5, 0)), true);
            }
         }
         divCell_checkdeath_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkdeath_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkdeath_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckDeath") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Checkdeathwc_Component), StringUtil.Lower( "BR_EncounterCheckDeath")) != 0 )
            {
               WebComp_Checkdeathwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckdeath", new Object[] {context} );
               WebComp_Checkdeathwc.ComponentInit();
               WebComp_Checkdeathwc.Name = "BR_EncounterCheckDeath";
               WebComp_Checkdeathwc_Component = "BR_EncounterCheckDeath";
            }
            if ( StringUtil.Len( WebComp_Checkdeathwc_Component) != 0 )
            {
               WebComp_Checkdeathwc.setjustcreated();
               WebComp_Checkdeathwc.componentprepare(new Object[] {(String)"W0070",(String)"",(long)AV10BR_EncounterID});
               WebComp_Checkdeathwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0070"+"");
               WebComp_Checkdeathwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "死亡情况";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckDeath") == 0 )
            {
               divCell_checkdeath_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkdeath_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkdeath_Visible), 5, 0)), true);
            }
         }
         divCell_checkvital_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkvital_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkvital_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckVital") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Checkvitalwc_Component), StringUtil.Lower( "BR_EncounterCheckVitalWC")) != 0 )
            {
               WebComp_Checkvitalwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckvitalwc", new Object[] {context} );
               WebComp_Checkvitalwc.ComponentInit();
               WebComp_Checkvitalwc.Name = "BR_EncounterCheckVitalWC";
               WebComp_Checkvitalwc_Component = "BR_EncounterCheckVitalWC";
            }
            if ( StringUtil.Len( WebComp_Checkvitalwc_Component) != 0 )
            {
               WebComp_Checkvitalwc.setjustcreated();
               WebComp_Checkvitalwc.componentprepare(new Object[] {(String)"W0078",(String)"",(long)AV10BR_EncounterID});
               WebComp_Checkvitalwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0078"+"");
               WebComp_Checkvitalwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "生命体征";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "CheckVital") == 0 )
            {
               divCell_checkvital_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_checkvital_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_checkvital_Visible), 5, 0)), true);
            }
         }
         divCell_br_diagnosis_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_diagnosis_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_diagnosis_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Diagnosis") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_diagnosiswc_Component), StringUtil.Lower( "BR_EncounterCheckBR_DiagnosisWC")) != 0 )
            {
               WebComp_Br_diagnosiswc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_diagnosiswc", new Object[] {context} );
               WebComp_Br_diagnosiswc.ComponentInit();
               WebComp_Br_diagnosiswc.Name = "BR_EncounterCheckBR_DiagnosisWC";
               WebComp_Br_diagnosiswc_Component = "BR_EncounterCheckBR_DiagnosisWC";
            }
            if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
            {
               WebComp_Br_diagnosiswc.setjustcreated();
               WebComp_Br_diagnosiswc.componentprepare(new Object[] {(String)"W0086",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_diagnosiswc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0086"+"");
               WebComp_Br_diagnosiswc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "诊断";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Diagnosis") == 0 )
            {
               divCell_br_diagnosis_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_diagnosis_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_diagnosis_Visible), 5, 0)), true);
            }
         }
         divCell_br_lab_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_lab_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_lab_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Lab") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_labwc_Component), StringUtil.Lower( "BR_EncounterCheckBR_LabWC")) != 0 )
            {
               WebComp_Br_labwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_labwc", new Object[] {context} );
               WebComp_Br_labwc.ComponentInit();
               WebComp_Br_labwc.Name = "BR_EncounterCheckBR_LabWC";
               WebComp_Br_labwc_Component = "BR_EncounterCheckBR_LabWC";
            }
            if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
            {
               WebComp_Br_labwc.setjustcreated();
               WebComp_Br_labwc.componentprepare(new Object[] {(String)"W0094",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_labwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0094"+"");
               WebComp_Br_labwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "实验室检查";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Lab") == 0 )
            {
               divCell_br_lab_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_lab_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_lab_Visible), 5, 0)), true);
            }
         }
         divCell_br_medication_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medication_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Medication") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_medicationwc_Component), StringUtil.Lower( "BR_EncounterCheckBR_MedicationWC")) != 0 )
            {
               WebComp_Br_medicationwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_medicationwc", new Object[] {context} );
               WebComp_Br_medicationwc.ComponentInit();
               WebComp_Br_medicationwc.Name = "BR_EncounterCheckBR_MedicationWC";
               WebComp_Br_medicationwc_Component = "BR_EncounterCheckBR_MedicationWC";
            }
            if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
            {
               WebComp_Br_medicationwc.setjustcreated();
               WebComp_Br_medicationwc.componentprepare(new Object[] {(String)"W0102",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_medicationwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0102"+"");
               WebComp_Br_medicationwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "药物治疗";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Medication") == 0 )
            {
               divCell_br_medication_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medication_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medication_Visible), 5, 0)), true);
            }
         }
         divCell_br_scheme_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_scheme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_scheme_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Scheme") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_schemewc_Component), StringUtil.Lower( "BR_EncounterCheckBR_SchemeWC")) != 0 )
            {
               WebComp_Br_schemewc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_schemewc", new Object[] {context} );
               WebComp_Br_schemewc.ComponentInit();
               WebComp_Br_schemewc.Name = "BR_EncounterCheckBR_SchemeWC";
               WebComp_Br_schemewc_Component = "BR_EncounterCheckBR_SchemeWC";
            }
            if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
            {
               WebComp_Br_schemewc.setjustcreated();
               WebComp_Br_schemewc.componentprepare(new Object[] {(String)"W0110",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_schemewc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0110"+"");
               WebComp_Br_schemewc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "化疗方案";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Scheme") == 0 )
            {
               divCell_br_scheme_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_scheme_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_scheme_Visible), 5, 0)), true);
            }
         }
         divCell_br_procedure_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_procedure_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_procedure_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Procedure") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_procedurewc_Component), StringUtil.Lower( "BR_EncounterCheckBR_ProcedureWC")) != 0 )
            {
               WebComp_Br_procedurewc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_procedurewc", new Object[] {context} );
               WebComp_Br_procedurewc.ComponentInit();
               WebComp_Br_procedurewc.Name = "BR_EncounterCheckBR_ProcedureWC";
               WebComp_Br_procedurewc_Component = "BR_EncounterCheckBR_ProcedureWC";
            }
            if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
            {
               WebComp_Br_procedurewc.setjustcreated();
               WebComp_Br_procedurewc.componentprepare(new Object[] {(String)"W0118",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_procedurewc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0118"+"");
               WebComp_Br_procedurewc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "诊疗处理";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Procedure") == 0 )
            {
               divCell_br_procedure_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_procedure_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_procedure_Visible), 5, 0)), true);
            }
         }
         divCell_br_medicalimaging_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medicalimaging_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medicalimaging_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_MedicalImaging") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_medicalimagingwc_Component), StringUtil.Lower( "BR_EncounterCheckBR_MedicalImagingWC")) != 0 )
            {
               WebComp_Br_medicalimagingwc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_medicalimagingwc", new Object[] {context} );
               WebComp_Br_medicalimagingwc.ComponentInit();
               WebComp_Br_medicalimagingwc.Name = "BR_EncounterCheckBR_MedicalImagingWC";
               WebComp_Br_medicalimagingwc_Component = "BR_EncounterCheckBR_MedicalImagingWC";
            }
            if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
            {
               WebComp_Br_medicalimagingwc.setjustcreated();
               WebComp_Br_medicalimagingwc.componentprepare(new Object[] {(String)"W0126",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_medicalimagingwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0126"+"");
               WebComp_Br_medicalimagingwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "影像学";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_MedicalImaging") == 0 )
            {
               divCell_br_medicalimaging_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_medicalimaging_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_medicalimaging_Visible), 5, 0)), true);
            }
         }
         divCell_br_pathology_Visible = 1;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_Visible), 5, 0)), true);
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Br_pathologywc_Component), StringUtil.Lower( "BR_EncounterCheckBR_PathologyWC")) != 0 )
            {
               WebComp_Br_pathologywc = getWebComponent(GetType(), "GeneXus.Programs", "br_encountercheckbr_pathologywc", new Object[] {context} );
               WebComp_Br_pathologywc.ComponentInit();
               WebComp_Br_pathologywc.Name = "BR_EncounterCheckBR_PathologyWC";
               WebComp_Br_pathologywc_Component = "BR_EncounterCheckBR_PathologyWC";
            }
            if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
            {
               WebComp_Br_pathologywc.setjustcreated();
               WebComp_Br_pathologywc.componentprepare(new Object[] {(String)"W0134",(String)"",(long)AV10BR_EncounterID});
               WebComp_Br_pathologywc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0134"+"");
               WebComp_Br_pathologywc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            lblTxttabtitle_Caption = "病理学";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, lblTxttabtitle_Internalname, "Caption", lblTxttabtitle_Caption, true);
            if ( StringUtil.StrCmp(AV12SelectedTabCode, "BR_Pathology") == 0 )
            {
               divCell_br_pathology_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divCell_br_pathology_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divCell_br_pathology_Visible), 5, 0)), true);
            }
         }
      }

      protected void E393S2( )
      {
         /* 'Dorefuse' Routine */
         new zutil_checksession(context ).execute( out  AV30tCheckFlag) ;
         if ( ! AV30tCheckFlag )
         {
            context.PopUp(formatLink("br_enteringsubmit.aspx") + "?" + UrlEncode("" +AV10BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("")), new Object[] {"AV27tvflag"});
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
      }

      protected void wb_table5_200_3S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_edit_Internalname, tblTabledvelop_confirmpanel_edit_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_edit.SetProperty("Title", Dvelop_confirmpanel_edit_Title);
            ucDvelop_confirmpanel_edit.SetProperty("ConfirmationText", Dvelop_confirmpanel_edit_Confirmationtext);
            ucDvelop_confirmpanel_edit.SetProperty("YesButtonCaption", Dvelop_confirmpanel_edit_Yesbuttoncaption);
            ucDvelop_confirmpanel_edit.SetProperty("NoButtonCaption", Dvelop_confirmpanel_edit_Nobuttoncaption);
            ucDvelop_confirmpanel_edit.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_edit_Cancelbuttoncaption);
            ucDvelop_confirmpanel_edit.SetProperty("YesButtonPosition", Dvelop_confirmpanel_edit_Yesbuttonposition);
            ucDvelop_confirmpanel_edit.SetProperty("ConfirmType", Dvelop_confirmpanel_edit_Confirmtype);
            ucDvelop_confirmpanel_edit.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_edit_Internalname, "DVELOP_CONFIRMPANEL_EDITContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_EDITContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_200_3S2e( true) ;
         }
         else
         {
            wb_table5_200_3S2e( false) ;
         }
      }

      protected void wb_table4_195_3S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_approvewrong_Internalname, tblTabledvelop_confirmpanel_approvewrong_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_approvewrong.SetProperty("Title", Dvelop_confirmpanel_approvewrong_Title);
            ucDvelop_confirmpanel_approvewrong.SetProperty("ConfirmationText", Dvelop_confirmpanel_approvewrong_Confirmationtext);
            ucDvelop_confirmpanel_approvewrong.SetProperty("YesButtonCaption", Dvelop_confirmpanel_approvewrong_Yesbuttoncaption);
            ucDvelop_confirmpanel_approvewrong.SetProperty("NoButtonCaption", Dvelop_confirmpanel_approvewrong_Nobuttoncaption);
            ucDvelop_confirmpanel_approvewrong.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_approvewrong_Cancelbuttoncaption);
            ucDvelop_confirmpanel_approvewrong.SetProperty("YesButtonPosition", Dvelop_confirmpanel_approvewrong_Yesbuttonposition);
            ucDvelop_confirmpanel_approvewrong.SetProperty("ConfirmType", Dvelop_confirmpanel_approvewrong_Confirmtype);
            ucDvelop_confirmpanel_approvewrong.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_approvewrong_Internalname, "DVELOP_CONFIRMPANEL_APPROVEWRONGContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_APPROVEWRONGContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_195_3S2e( true) ;
         }
         else
         {
            wb_table4_195_3S2e( false) ;
         }
      }

      protected void wb_table3_190_3S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_approveright_Internalname, tblTabledvelop_confirmpanel_approveright_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_approveright.SetProperty("Title", Dvelop_confirmpanel_approveright_Title);
            ucDvelop_confirmpanel_approveright.SetProperty("ConfirmationText", Dvelop_confirmpanel_approveright_Confirmationtext);
            ucDvelop_confirmpanel_approveright.SetProperty("YesButtonCaption", Dvelop_confirmpanel_approveright_Yesbuttoncaption);
            ucDvelop_confirmpanel_approveright.SetProperty("NoButtonCaption", Dvelop_confirmpanel_approveright_Nobuttoncaption);
            ucDvelop_confirmpanel_approveright.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_approveright_Cancelbuttoncaption);
            ucDvelop_confirmpanel_approveright.SetProperty("YesButtonPosition", Dvelop_confirmpanel_approveright_Yesbuttonposition);
            ucDvelop_confirmpanel_approveright.SetProperty("ConfirmType", Dvelop_confirmpanel_approveright_Confirmtype);
            ucDvelop_confirmpanel_approveright.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_approveright_Internalname, "DVELOP_CONFIRMPANEL_APPROVERIGHTContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_APPROVERIGHTContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_190_3S2e( true) ;
         }
         else
         {
            wb_table3_190_3S2e( false) ;
         }
      }

      protected void wb_table2_185_3S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_checkr_Internalname, tblTabledvelop_confirmpanel_checkr_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_checkr.SetProperty("Title", Dvelop_confirmpanel_checkr_Title);
            ucDvelop_confirmpanel_checkr.SetProperty("ConfirmationText", Dvelop_confirmpanel_checkr_Confirmationtext);
            ucDvelop_confirmpanel_checkr.SetProperty("YesButtonCaption", Dvelop_confirmpanel_checkr_Yesbuttoncaption);
            ucDvelop_confirmpanel_checkr.SetProperty("NoButtonCaption", Dvelop_confirmpanel_checkr_Nobuttoncaption);
            ucDvelop_confirmpanel_checkr.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_checkr_Cancelbuttoncaption);
            ucDvelop_confirmpanel_checkr.SetProperty("YesButtonPosition", Dvelop_confirmpanel_checkr_Yesbuttonposition);
            ucDvelop_confirmpanel_checkr.SetProperty("ConfirmType", Dvelop_confirmpanel_checkr_Confirmtype);
            ucDvelop_confirmpanel_checkr.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_checkr_Internalname, "DVELOP_CONFIRMPANEL_CHECKRContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_CHECKRContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_185_3S2e( true) ;
         }
         else
         {
            wb_table2_185_3S2e( false) ;
         }
      }

      protected void wb_table1_180_3S2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_check_Internalname, tblTabledvelop_confirmpanel_check_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_check.SetProperty("Title", Dvelop_confirmpanel_check_Title);
            ucDvelop_confirmpanel_check.SetProperty("ConfirmationText", Dvelop_confirmpanel_check_Confirmationtext);
            ucDvelop_confirmpanel_check.SetProperty("YesButtonCaption", Dvelop_confirmpanel_check_Yesbuttoncaption);
            ucDvelop_confirmpanel_check.SetProperty("NoButtonCaption", Dvelop_confirmpanel_check_Nobuttoncaption);
            ucDvelop_confirmpanel_check.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_check_Cancelbuttoncaption);
            ucDvelop_confirmpanel_check.SetProperty("YesButtonPosition", Dvelop_confirmpanel_check_Yesbuttonposition);
            ucDvelop_confirmpanel_check.SetProperty("ConfirmType", Dvelop_confirmpanel_check_Confirmtype);
            ucDvelop_confirmpanel_check.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_check_Internalname, "DVELOP_CONFIRMPANEL_CHECKContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_CHECKContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_180_3S2e( true) ;
         }
         else
         {
            wb_table1_180_3S2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10BR_EncounterID), 18, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV10BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         AV8TabCode = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8TabCode", AV8TabCode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV8TabCode, "")), context));
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
         PA3S2( ) ;
         WS3S2( ) ;
         WE3S2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         if ( ! ( WebComp_Generalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Checkdemographicswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Checkdemographicswc_Component) != 0 )
            {
               WebComp_Checkdemographicswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Checkbehaviorwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Checkbehaviorwc_Component) != 0 )
            {
               WebComp_Checkbehaviorwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Checkcomorbiditywc == null ) )
         {
            if ( StringUtil.Len( WebComp_Checkcomorbiditywc_Component) != 0 )
            {
               WebComp_Checkcomorbiditywc.componentthemes();
            }
         }
         if ( ! ( WebComp_Checkdeathwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Checkdeathwc_Component) != 0 )
            {
               WebComp_Checkdeathwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Checkvitalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Checkvitalwc_Component) != 0 )
            {
               WebComp_Checkvitalwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_diagnosiswc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_diagnosiswc_Component) != 0 )
            {
               WebComp_Br_diagnosiswc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_labwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_labwc_Component) != 0 )
            {
               WebComp_Br_labwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_medicationwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_medicationwc_Component) != 0 )
            {
               WebComp_Br_medicationwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_schemewc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_schemewc_Component) != 0 )
            {
               WebComp_Br_schemewc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_procedurewc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_procedurewc_Component) != 0 )
            {
               WebComp_Br_procedurewc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_medicalimagingwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_medicalimagingwc_Component) != 0 )
            {
               WebComp_Br_medicalimagingwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Br_pathologywc == null ) )
         {
            if ( StringUtil.Len( WebComp_Br_pathologywc_Component) != 0 )
            {
               WebComp_Br_pathologywc.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271211653", true);
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
         context.AddJavascriptSource("br_encountercheck.js", "?20202271211653", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false);
         context.AddJavascriptSource("Tab/TabRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtncheck_Internalname = "BTNCHECK";
         bttBtncheckr_Internalname = "BTNCHECKR";
         bttBtnapproveright_Internalname = "BTNAPPROVERIGHT";
         bttBtnapprovewrong_Internalname = "BTNAPPROVEWRONG";
         bttBtnedit_Internalname = "BTNEDIT";
         bttBtnreturn_Internalname = "BTNRETURN";
         lblTxttabtitle_Internalname = "TXTTABTITLE";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divUnnamedtablegeneral_Internalname = "UNNAMEDTABLEGENERAL";
         lblCheckdemographics_title_Internalname = "CHECKDEMOGRAPHICS_TITLE";
         divUnnamedtablecheckdemographics_Internalname = "UNNAMEDTABLECHECKDEMOGRAPHICS";
         lblCheckbehavior_title_Internalname = "CHECKBEHAVIOR_TITLE";
         divUnnamedtablecheckbehavior_Internalname = "UNNAMEDTABLECHECKBEHAVIOR";
         lblCheckcomorbidity_title_Internalname = "CHECKCOMORBIDITY_TITLE";
         divUnnamedtablecheckcomorbidity_Internalname = "UNNAMEDTABLECHECKCOMORBIDITY";
         lblCheckdeath_title_Internalname = "CHECKDEATH_TITLE";
         divUnnamedtablecheckdeath_Internalname = "UNNAMEDTABLECHECKDEATH";
         lblCheckvital_title_Internalname = "CHECKVITAL_TITLE";
         divUnnamedtablecheckvital_Internalname = "UNNAMEDTABLECHECKVITAL";
         lblBr_diagnosis_title_Internalname = "BR_DIAGNOSIS_TITLE";
         divUnnamedtablebr_diagnosis_Internalname = "UNNAMEDTABLEBR_DIAGNOSIS";
         lblBr_lab_title_Internalname = "BR_LAB_TITLE";
         divUnnamedtablebr_lab_Internalname = "UNNAMEDTABLEBR_LAB";
         lblBr_medication_title_Internalname = "BR_MEDICATION_TITLE";
         divUnnamedtablebr_medication_Internalname = "UNNAMEDTABLEBR_MEDICATION";
         lblBr_scheme_title_Internalname = "BR_SCHEME_TITLE";
         divUnnamedtablebr_scheme_Internalname = "UNNAMEDTABLEBR_SCHEME";
         lblBr_procedure_title_Internalname = "BR_PROCEDURE_TITLE";
         divUnnamedtablebr_procedure_Internalname = "UNNAMEDTABLEBR_PROCEDURE";
         lblBr_medicalimaging_title_Internalname = "BR_MEDICALIMAGING_TITLE";
         divUnnamedtablebr_medicalimaging_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING";
         lblBr_pathology_title_Internalname = "BR_PATHOLOGY_TITLE";
         divUnnamedtablebr_pathology_Internalname = "UNNAMEDTABLEBR_PATHOLOGY";
         Tabs_Internalname = "TABS";
         bttBtngeneral_Internalname = "BTNGENERAL";
         divCell_general_Internalname = "CELL_GENERAL";
         bttBtncheckdemographics_Internalname = "BTNCHECKDEMOGRAPHICS";
         divCell_checkdemographics_Internalname = "CELL_CHECKDEMOGRAPHICS";
         bttBtncheckbehavior_Internalname = "BTNCHECKBEHAVIOR";
         divCell_checkbehavior_Internalname = "CELL_CHECKBEHAVIOR";
         bttBtncheckcomorbidity_Internalname = "BTNCHECKCOMORBIDITY";
         divCell_checkcomorbidity_Internalname = "CELL_CHECKCOMORBIDITY";
         bttBtncheckdeath_Internalname = "BTNCHECKDEATH";
         divCell_checkdeath_Internalname = "CELL_CHECKDEATH";
         bttBtncheckvital_Internalname = "BTNCHECKVITAL";
         divCell_checkvital_Internalname = "CELL_CHECKVITAL";
         bttBtnbr_diagnosis_Internalname = "BTNBR_DIAGNOSIS";
         divCell_br_diagnosis_Internalname = "CELL_BR_DIAGNOSIS";
         bttBtnbr_lab_Internalname = "BTNBR_LAB";
         divCell_br_lab_Internalname = "CELL_BR_LAB";
         bttBtnbr_medication_Internalname = "BTNBR_MEDICATION";
         divCell_br_medication_Internalname = "CELL_BR_MEDICATION";
         bttBtnbr_scheme_Internalname = "BTNBR_SCHEME";
         divCell_br_scheme_Internalname = "CELL_BR_SCHEME";
         bttBtnbr_procedure_Internalname = "BTNBR_PROCEDURE";
         divCell_br_procedure_Internalname = "CELL_BR_PROCEDURE";
         bttBtnbr_medicalimaging_Internalname = "BTNBR_MEDICALIMAGING";
         divCell_br_medicalimaging_Internalname = "CELL_BR_MEDICALIMAGING";
         bttBtnbr_pathology_Internalname = "BTNBR_PATHOLOGY";
         divCell_br_pathology_Internalname = "CELL_BR_PATHOLOGY";
         divUnnamedtabletabscontainer_Internalname = "UNNAMEDTABLETABSCONTAINER";
         divUnnamedtableviewcontainer_Internalname = "UNNAMEDTABLEVIEWCONTAINER";
         divTablemain_Internalname = "TABLEMAIN";
         Dvelop_confirmpanel_check_Internalname = "DVELOP_CONFIRMPANEL_CHECK";
         tblTabledvelop_confirmpanel_check_Internalname = "TABLEDVELOP_CONFIRMPANEL_CHECK";
         Dvelop_confirmpanel_checkr_Internalname = "DVELOP_CONFIRMPANEL_CHECKR";
         tblTabledvelop_confirmpanel_checkr_Internalname = "TABLEDVELOP_CONFIRMPANEL_CHECKR";
         Dvelop_confirmpanel_approveright_Internalname = "DVELOP_CONFIRMPANEL_APPROVERIGHT";
         tblTabledvelop_confirmpanel_approveright_Internalname = "TABLEDVELOP_CONFIRMPANEL_APPROVERIGHT";
         Dvelop_confirmpanel_approvewrong_Internalname = "DVELOP_CONFIRMPANEL_APPROVEWRONG";
         tblTabledvelop_confirmpanel_approvewrong_Internalname = "TABLEDVELOP_CONFIRMPANEL_APPROVEWRONG";
         Dvelop_confirmpanel_edit_Internalname = "DVELOP_CONFIRMPANEL_EDIT";
         tblTabledvelop_confirmpanel_edit_Internalname = "TABLEDVELOP_CONFIRMPANEL_EDIT";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         divCell_br_pathology_Visible = 1;
         divCell_br_medicalimaging_Visible = 1;
         divCell_br_procedure_Visible = 1;
         divCell_br_scheme_Visible = 1;
         divCell_br_medication_Visible = 1;
         divCell_br_lab_Visible = 1;
         divCell_br_diagnosis_Visible = 1;
         divCell_checkvital_Visible = 1;
         divCell_checkdeath_Visible = 1;
         divCell_checkcomorbidity_Visible = 1;
         divCell_checkbehavior_Visible = 1;
         divCell_checkdemographics_Visible = 1;
         divCell_general_Visible = 1;
         lblTxttabtitle_Caption = "Title";
         bttBtnedit_Visible = 1;
         bttBtnapprovewrong_Visible = 1;
         bttBtnapproveright_Visible = 1;
         bttBtncheckr_Visible = 1;
         bttBtncheck_Visible = 1;
         Dvelop_confirmpanel_edit_Confirmtype = "1";
         Dvelop_confirmpanel_edit_Yesbuttonposition = "left";
         Dvelop_confirmpanel_edit_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_edit_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_edit_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_edit_Confirmationtext = "进入修改界面？";
         Dvelop_confirmpanel_edit_Title = "";
         Dvelop_confirmpanel_approvewrong_Confirmtype = "1";
         Dvelop_confirmpanel_approvewrong_Yesbuttonposition = "left";
         Dvelop_confirmpanel_approvewrong_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_approvewrong_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_approvewrong_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_approvewrong_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_approvewrong_Title = "";
         Dvelop_confirmpanel_approveright_Confirmtype = "1";
         Dvelop_confirmpanel_approveright_Yesbuttonposition = "left";
         Dvelop_confirmpanel_approveright_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_approveright_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_approveright_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_approveright_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_approveright_Title = "";
         Dvelop_confirmpanel_checkr_Confirmtype = "1";
         Dvelop_confirmpanel_checkr_Yesbuttonposition = "left";
         Dvelop_confirmpanel_checkr_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_checkr_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_checkr_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_checkr_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_checkr_Title = "";
         Dvelop_confirmpanel_check_Confirmtype = "1";
         Dvelop_confirmpanel_check_Yesbuttonposition = "left";
         Dvelop_confirmpanel_check_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_check_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_check_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_check_Confirmationtext = "确认提交？";
         Dvelop_confirmpanel_check_Title = "";
         Tabs_Historymanagement = Convert.ToBoolean( -1);
         Tabs_Pagecount = 13;
         Tabs_Class = "ViewTab Tab";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV27tvflag',fld:'vTVFLAG',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{ctrl:'BTNEDIT',prop:'Visible'},{ctrl:'BTNCHECK',prop:'Visible'},{ctrl:'BTNCHECKR',prop:'Visible'},{ctrl:'BTNAPPROVERIGHT',prop:'Visible'},{ctrl:'BTNAPPROVEWRONG',prop:'Visible'}]}");
         setEventMetadata("'DOCHECK'","{handler:'E113S1',iparms:[]");
         setEventMetadata("'DOCHECK'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_CHECK.CLOSE","{handler:'E173S2',iparms:[{av:'Dvelop_confirmpanel_check_Result',ctrl:'DVELOP_CONFIRMPANEL_CHECK',prop:'Result'},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_CHECK.CLOSE",",oparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DOCHECKR'","{handler:'E123S1',iparms:[]");
         setEventMetadata("'DOCHECKR'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_CHECKR.CLOSE","{handler:'E183S2',iparms:[{av:'Dvelop_confirmpanel_checkr_Result',ctrl:'DVELOP_CONFIRMPANEL_CHECKR',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_CHECKR.CLOSE",",oparms:[{av:'AV27tvflag',fld:'vTVFLAG',pic:''}]}");
         setEventMetadata("'DOAPPROVERIGHT'","{handler:'E133S1',iparms:[]");
         setEventMetadata("'DOAPPROVERIGHT'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_APPROVERIGHT.CLOSE","{handler:'E193S2',iparms:[{av:'Dvelop_confirmpanel_approveright_Result',ctrl:'DVELOP_CONFIRMPANEL_APPROVERIGHT',prop:'Result'},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_APPROVERIGHT.CLOSE",",oparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DOAPPROVEWRONG'","{handler:'E143S1',iparms:[]");
         setEventMetadata("'DOAPPROVEWRONG'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_APPROVEWRONG.CLOSE","{handler:'E203S2',iparms:[{av:'Dvelop_confirmpanel_approvewrong_Result',ctrl:'DVELOP_CONFIRMPANEL_APPROVEWRONG',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_APPROVEWRONG.CLOSE",",oparms:[{av:'AV27tvflag',fld:'vTVFLAG',pic:''}]}");
         setEventMetadata("'DOEDIT'","{handler:'E153S1',iparms:[]");
         setEventMetadata("'DOEDIT'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_EDIT.CLOSE","{handler:'E213S2',iparms:[{av:'Dvelop_confirmpanel_edit_Result',ctrl:'DVELOP_CONFIRMPANEL_EDIT',prop:'Result'},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_EDIT.CLOSE",",oparms:[{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]}");
         setEventMetadata("'DORETURN'","{handler:'E253S2',iparms:[{av:'AV25tPageReturn',fld:'vTPAGERETURN',pic:'',hsh:true},{av:'AV16BCBR_Encounter',fld:'vBCBR_ENCOUNTER',pic:''}]");
         setEventMetadata("'DORETURN'",",oparms:[]}");
         setEventMetadata("TABS.TABCHANGED","{handler:'E163S2',iparms:[{av:'Tabs_Activepagecontrolname',ctrl:'TABS',prop:'ActivePageControlName'},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("TABS.TABCHANGED",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'GENERAL'","{handler:'E263S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'GENERAL'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'CHECKDEMOGRAPHICS'","{handler:'E273S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'CHECKDEMOGRAPHICS'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'CHECKBEHAVIOR'","{handler:'E283S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'CHECKBEHAVIOR'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'CHECKCOMORBIDITY'","{handler:'E293S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'CHECKCOMORBIDITY'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'CHECKDEATH'","{handler:'E303S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'CHECKDEATH'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'CHECKVITAL'","{handler:'E313S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'CHECKVITAL'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_DIAGNOSIS'","{handler:'E323S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_DIAGNOSIS'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_LAB'","{handler:'E333S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_LAB'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_MEDICATION'","{handler:'E343S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_MEDICATION'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_SCHEME'","{handler:'E353S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_SCHEME'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_PROCEDURE'","{handler:'E363S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_PROCEDURE'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_MEDICALIMAGING'","{handler:'E373S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_MEDICALIMAGING'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'BR_PATHOLOGY'","{handler:'E383S2',iparms:[{av:'AV6WWPContext',fld:'vWWPCONTEXT',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'BR_PATHOLOGY'",",oparms:[{av:'AV12SelectedTabCode',fld:'vSELECTEDTABCODE',pic:''},{av:'AV11LoadAllTabs',fld:'vLOADALLTABS',pic:''},{av:'divCell_general_Visible',ctrl:'CELL_GENERAL',prop:'Visible'},{ctrl:'GENERALWC'},{av:'lblTxttabtitle_Caption',ctrl:'TXTTABTITLE',prop:'Caption'},{av:'divCell_checkdemographics_Visible',ctrl:'CELL_CHECKDEMOGRAPHICS',prop:'Visible'},{ctrl:'CHECKDEMOGRAPHICSWC'},{av:'divCell_checkbehavior_Visible',ctrl:'CELL_CHECKBEHAVIOR',prop:'Visible'},{ctrl:'CHECKBEHAVIORWC'},{av:'divCell_checkcomorbidity_Visible',ctrl:'CELL_CHECKCOMORBIDITY',prop:'Visible'},{ctrl:'CHECKCOMORBIDITYWC'},{av:'divCell_checkdeath_Visible',ctrl:'CELL_CHECKDEATH',prop:'Visible'},{ctrl:'CHECKDEATHWC'},{av:'divCell_checkvital_Visible',ctrl:'CELL_CHECKVITAL',prop:'Visible'},{ctrl:'CHECKVITALWC'},{av:'divCell_br_diagnosis_Visible',ctrl:'CELL_BR_DIAGNOSIS',prop:'Visible'},{ctrl:'BR_DIAGNOSISWC'},{av:'divCell_br_lab_Visible',ctrl:'CELL_BR_LAB',prop:'Visible'},{ctrl:'BR_LABWC'},{av:'divCell_br_medication_Visible',ctrl:'CELL_BR_MEDICATION',prop:'Visible'},{ctrl:'BR_MEDICATIONWC'},{av:'divCell_br_scheme_Visible',ctrl:'CELL_BR_SCHEME',prop:'Visible'},{ctrl:'BR_SCHEMEWC'},{av:'divCell_br_procedure_Visible',ctrl:'CELL_BR_PROCEDURE',prop:'Visible'},{ctrl:'BR_PROCEDUREWC'},{av:'divCell_br_medicalimaging_Visible',ctrl:'CELL_BR_MEDICALIMAGING',prop:'Visible'},{ctrl:'BR_MEDICALIMAGINGWC'},{av:'divCell_br_pathology_Visible',ctrl:'CELL_BR_PATHOLOGY',prop:'Visible'},{ctrl:'BR_PATHOLOGYWC'}]}");
         setEventMetadata("'DOREFUSE'","{handler:'E393S2',iparms:[{av:'AV10BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOREFUSE'",",oparms:[{av:'AV27tvflag',fld:'vTVFLAG',pic:''}]}");
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
         wcpOAV8TabCode = "";
         Dvelop_confirmpanel_check_Result = "";
         Dvelop_confirmpanel_checkr_Result = "";
         Dvelop_confirmpanel_approveright_Result = "";
         Dvelop_confirmpanel_approvewrong_Result = "";
         Dvelop_confirmpanel_edit_Result = "";
         Tabs_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         AV16BCBR_Encounter = new SdtBR_Encounter(context);
         AV27tvflag = "";
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV25tPageReturn = "";
         AV12SelectedTabCode = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtncheck_Jsonclick = "";
         bttBtncheckr_Jsonclick = "";
         bttBtnapproveright_Jsonclick = "";
         bttBtnapprovewrong_Jsonclick = "";
         bttBtnedit_Jsonclick = "";
         bttBtnreturn_Jsonclick = "";
         lblTxttabtitle_Jsonclick = "";
         ucTabs = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         lblCheckdemographics_title_Jsonclick = "";
         WebComp_Checkdemographicswc_Component = "";
         OldCheckdemographicswc = "";
         lblCheckbehavior_title_Jsonclick = "";
         WebComp_Checkbehaviorwc_Component = "";
         OldCheckbehaviorwc = "";
         lblCheckcomorbidity_title_Jsonclick = "";
         WebComp_Checkcomorbiditywc_Component = "";
         OldCheckcomorbiditywc = "";
         lblCheckdeath_title_Jsonclick = "";
         WebComp_Checkdeathwc_Component = "";
         OldCheckdeathwc = "";
         lblCheckvital_title_Jsonclick = "";
         WebComp_Checkvitalwc_Component = "";
         OldCheckvitalwc = "";
         lblBr_diagnosis_title_Jsonclick = "";
         WebComp_Br_diagnosiswc_Component = "";
         OldBr_diagnosiswc = "";
         lblBr_lab_title_Jsonclick = "";
         WebComp_Br_labwc_Component = "";
         OldBr_labwc = "";
         lblBr_medication_title_Jsonclick = "";
         WebComp_Br_medicationwc_Component = "";
         OldBr_medicationwc = "";
         lblBr_scheme_title_Jsonclick = "";
         WebComp_Br_schemewc_Component = "";
         OldBr_schemewc = "";
         lblBr_procedure_title_Jsonclick = "";
         WebComp_Br_procedurewc_Component = "";
         OldBr_procedurewc = "";
         lblBr_medicalimaging_title_Jsonclick = "";
         WebComp_Br_medicalimagingwc_Component = "";
         OldBr_medicalimagingwc = "";
         lblBr_pathology_title_Jsonclick = "";
         WebComp_Br_pathologywc_Component = "";
         OldBr_pathologywc = "";
         bttBtngeneral_Jsonclick = "";
         bttBtncheckdemographics_Jsonclick = "";
         bttBtncheckbehavior_Jsonclick = "";
         bttBtncheckcomorbidity_Jsonclick = "";
         bttBtncheckdeath_Jsonclick = "";
         bttBtncheckvital_Jsonclick = "";
         bttBtnbr_diagnosis_Jsonclick = "";
         bttBtnbr_lab_Jsonclick = "";
         bttBtnbr_medication_Jsonclick = "";
         bttBtnbr_scheme_Jsonclick = "";
         bttBtnbr_procedure_Jsonclick = "";
         bttBtnbr_medicalimaging_Jsonclick = "";
         bttBtnbr_pathology_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H003S2_A19BR_EncounterID = new long[1] ;
         AV24WebSession = context.GetSession();
         AV18tBR_Encounter_Status = new GxSimpleCollection<short>();
         sStyleString = "";
         ucDvelop_confirmpanel_edit = new GXUserControl();
         ucDvelop_confirmpanel_approvewrong = new GXUserControl();
         ucDvelop_confirmpanel_approveright = new GXUserControl();
         ucDvelop_confirmpanel_checkr = new GXUserControl();
         ucDvelop_confirmpanel_check = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheck__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheck__default(),
            new Object[][] {
                new Object[] {
               H003S2_A19BR_EncounterID
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Checkdemographicswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Checkbehaviorwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Checkcomorbiditywc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Checkdeathwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Checkvitalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_diagnosiswc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_labwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_medicationwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_schemewc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_procedurewc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_medicalimagingwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Br_pathologywc = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV34GXLvl9 ;
      private short nGXWrapped ;
      private int Tabs_Pagecount ;
      private int bttBtncheck_Visible ;
      private int bttBtncheckr_Visible ;
      private int bttBtnapproveright_Visible ;
      private int bttBtnapprovewrong_Visible ;
      private int bttBtnedit_Visible ;
      private int divCell_general_Visible ;
      private int divCell_checkdemographics_Visible ;
      private int divCell_checkbehavior_Visible ;
      private int divCell_checkcomorbidity_Visible ;
      private int divCell_checkdeath_Visible ;
      private int divCell_checkvital_Visible ;
      private int divCell_br_diagnosis_Visible ;
      private int divCell_br_lab_Visible ;
      private int divCell_br_medication_Visible ;
      private int divCell_br_scheme_Visible ;
      private int divCell_br_procedure_Visible ;
      private int divCell_br_medicalimaging_Visible ;
      private int divCell_br_pathology_Visible ;
      private int idxLst ;
      private long AV10BR_EncounterID ;
      private long wcpOAV10BR_EncounterID ;
      private long A19BR_EncounterID ;
      private String AV8TabCode ;
      private String wcpOAV8TabCode ;
      private String Dvelop_confirmpanel_check_Result ;
      private String Dvelop_confirmpanel_checkr_Result ;
      private String Dvelop_confirmpanel_approveright_Result ;
      private String Dvelop_confirmpanel_approvewrong_Result ;
      private String Dvelop_confirmpanel_edit_Result ;
      private String Tabs_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String AV12SelectedTabCode ;
      private String Tabs_Class ;
      private String Dvelop_confirmpanel_check_Title ;
      private String Dvelop_confirmpanel_check_Confirmationtext ;
      private String Dvelop_confirmpanel_check_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_check_Nobuttoncaption ;
      private String Dvelop_confirmpanel_check_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_check_Yesbuttonposition ;
      private String Dvelop_confirmpanel_check_Confirmtype ;
      private String Dvelop_confirmpanel_checkr_Title ;
      private String Dvelop_confirmpanel_checkr_Confirmationtext ;
      private String Dvelop_confirmpanel_checkr_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_checkr_Nobuttoncaption ;
      private String Dvelop_confirmpanel_checkr_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_checkr_Yesbuttonposition ;
      private String Dvelop_confirmpanel_checkr_Confirmtype ;
      private String Dvelop_confirmpanel_approveright_Title ;
      private String Dvelop_confirmpanel_approveright_Confirmationtext ;
      private String Dvelop_confirmpanel_approveright_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_approveright_Nobuttoncaption ;
      private String Dvelop_confirmpanel_approveright_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_approveright_Yesbuttonposition ;
      private String Dvelop_confirmpanel_approveright_Confirmtype ;
      private String Dvelop_confirmpanel_approvewrong_Title ;
      private String Dvelop_confirmpanel_approvewrong_Confirmationtext ;
      private String Dvelop_confirmpanel_approvewrong_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_approvewrong_Nobuttoncaption ;
      private String Dvelop_confirmpanel_approvewrong_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_approvewrong_Yesbuttonposition ;
      private String Dvelop_confirmpanel_approvewrong_Confirmtype ;
      private String Dvelop_confirmpanel_edit_Title ;
      private String Dvelop_confirmpanel_edit_Confirmationtext ;
      private String Dvelop_confirmpanel_edit_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_edit_Nobuttoncaption ;
      private String Dvelop_confirmpanel_edit_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_edit_Yesbuttonposition ;
      private String Dvelop_confirmpanel_edit_Confirmtype ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtncheck_Internalname ;
      private String bttBtncheck_Jsonclick ;
      private String bttBtncheckr_Internalname ;
      private String bttBtncheckr_Jsonclick ;
      private String bttBtnapproveright_Internalname ;
      private String bttBtnapproveright_Jsonclick ;
      private String bttBtnapprovewrong_Internalname ;
      private String bttBtnapprovewrong_Jsonclick ;
      private String bttBtnedit_Internalname ;
      private String bttBtnedit_Jsonclick ;
      private String bttBtnreturn_Internalname ;
      private String bttBtnreturn_Jsonclick ;
      private String divUnnamedtableviewcontainer_Internalname ;
      private String lblTxttabtitle_Internalname ;
      private String lblTxttabtitle_Caption ;
      private String lblTxttabtitle_Jsonclick ;
      private String Tabs_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divUnnamedtablegeneral_Internalname ;
      private String WebComp_Generalwc_Component ;
      private String OldGeneralwc ;
      private String lblCheckdemographics_title_Internalname ;
      private String lblCheckdemographics_title_Jsonclick ;
      private String divUnnamedtablecheckdemographics_Internalname ;
      private String WebComp_Checkdemographicswc_Component ;
      private String OldCheckdemographicswc ;
      private String lblCheckbehavior_title_Internalname ;
      private String lblCheckbehavior_title_Jsonclick ;
      private String divUnnamedtablecheckbehavior_Internalname ;
      private String WebComp_Checkbehaviorwc_Component ;
      private String OldCheckbehaviorwc ;
      private String lblCheckcomorbidity_title_Internalname ;
      private String lblCheckcomorbidity_title_Jsonclick ;
      private String divUnnamedtablecheckcomorbidity_Internalname ;
      private String WebComp_Checkcomorbiditywc_Component ;
      private String OldCheckcomorbiditywc ;
      private String lblCheckdeath_title_Internalname ;
      private String lblCheckdeath_title_Jsonclick ;
      private String divUnnamedtablecheckdeath_Internalname ;
      private String WebComp_Checkdeathwc_Component ;
      private String OldCheckdeathwc ;
      private String lblCheckvital_title_Internalname ;
      private String lblCheckvital_title_Jsonclick ;
      private String divUnnamedtablecheckvital_Internalname ;
      private String WebComp_Checkvitalwc_Component ;
      private String OldCheckvitalwc ;
      private String lblBr_diagnosis_title_Internalname ;
      private String lblBr_diagnosis_title_Jsonclick ;
      private String divUnnamedtablebr_diagnosis_Internalname ;
      private String WebComp_Br_diagnosiswc_Component ;
      private String OldBr_diagnosiswc ;
      private String lblBr_lab_title_Internalname ;
      private String lblBr_lab_title_Jsonclick ;
      private String divUnnamedtablebr_lab_Internalname ;
      private String WebComp_Br_labwc_Component ;
      private String OldBr_labwc ;
      private String lblBr_medication_title_Internalname ;
      private String lblBr_medication_title_Jsonclick ;
      private String divUnnamedtablebr_medication_Internalname ;
      private String WebComp_Br_medicationwc_Component ;
      private String OldBr_medicationwc ;
      private String lblBr_scheme_title_Internalname ;
      private String lblBr_scheme_title_Jsonclick ;
      private String divUnnamedtablebr_scheme_Internalname ;
      private String WebComp_Br_schemewc_Component ;
      private String OldBr_schemewc ;
      private String lblBr_procedure_title_Internalname ;
      private String lblBr_procedure_title_Jsonclick ;
      private String divUnnamedtablebr_procedure_Internalname ;
      private String WebComp_Br_procedurewc_Component ;
      private String OldBr_procedurewc ;
      private String lblBr_medicalimaging_title_Internalname ;
      private String lblBr_medicalimaging_title_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_Internalname ;
      private String WebComp_Br_medicalimagingwc_Component ;
      private String OldBr_medicalimagingwc ;
      private String lblBr_pathology_title_Internalname ;
      private String lblBr_pathology_title_Jsonclick ;
      private String divUnnamedtablebr_pathology_Internalname ;
      private String WebComp_Br_pathologywc_Component ;
      private String OldBr_pathologywc ;
      private String divUnnamedtabletabscontainer_Internalname ;
      private String divCell_general_Internalname ;
      private String bttBtngeneral_Internalname ;
      private String bttBtngeneral_Jsonclick ;
      private String divCell_checkdemographics_Internalname ;
      private String bttBtncheckdemographics_Internalname ;
      private String bttBtncheckdemographics_Jsonclick ;
      private String divCell_checkbehavior_Internalname ;
      private String bttBtncheckbehavior_Internalname ;
      private String bttBtncheckbehavior_Jsonclick ;
      private String divCell_checkcomorbidity_Internalname ;
      private String bttBtncheckcomorbidity_Internalname ;
      private String bttBtncheckcomorbidity_Jsonclick ;
      private String divCell_checkdeath_Internalname ;
      private String bttBtncheckdeath_Internalname ;
      private String bttBtncheckdeath_Jsonclick ;
      private String divCell_checkvital_Internalname ;
      private String bttBtncheckvital_Internalname ;
      private String bttBtncheckvital_Jsonclick ;
      private String divCell_br_diagnosis_Internalname ;
      private String bttBtnbr_diagnosis_Internalname ;
      private String bttBtnbr_diagnosis_Jsonclick ;
      private String divCell_br_lab_Internalname ;
      private String bttBtnbr_lab_Internalname ;
      private String bttBtnbr_lab_Jsonclick ;
      private String divCell_br_medication_Internalname ;
      private String bttBtnbr_medication_Internalname ;
      private String bttBtnbr_medication_Jsonclick ;
      private String divCell_br_scheme_Internalname ;
      private String bttBtnbr_scheme_Internalname ;
      private String bttBtnbr_scheme_Jsonclick ;
      private String divCell_br_procedure_Internalname ;
      private String bttBtnbr_procedure_Internalname ;
      private String bttBtnbr_procedure_Jsonclick ;
      private String divCell_br_medicalimaging_Internalname ;
      private String bttBtnbr_medicalimaging_Internalname ;
      private String bttBtnbr_medicalimaging_Jsonclick ;
      private String divCell_br_pathology_Internalname ;
      private String bttBtnbr_pathology_Internalname ;
      private String bttBtnbr_pathology_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String scmdbuf ;
      private String sStyleString ;
      private String tblTabledvelop_confirmpanel_edit_Internalname ;
      private String Dvelop_confirmpanel_edit_Internalname ;
      private String tblTabledvelop_confirmpanel_approvewrong_Internalname ;
      private String Dvelop_confirmpanel_approvewrong_Internalname ;
      private String tblTabledvelop_confirmpanel_approveright_Internalname ;
      private String Dvelop_confirmpanel_approveright_Internalname ;
      private String tblTabledvelop_confirmpanel_checkr_Internalname ;
      private String Dvelop_confirmpanel_checkr_Internalname ;
      private String tblTabledvelop_confirmpanel_check_Internalname ;
      private String Dvelop_confirmpanel_check_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV11LoadAllTabs ;
      private bool Tabs_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9Exists ;
      private bool AV23IsComplete ;
      private bool AV22IsDenyApprove ;
      private bool AV20IsDenyCheck ;
      private bool AV17IsUpdateEncounter ;
      private bool AV21IsWaitApprove ;
      private bool AV19IsWaitCheck ;
      private bool AV13TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV30tCheckFlag ;
      private String AV27tvflag ;
      private String AV25tPageReturn ;
      private GxSimpleCollection<short> AV18tBR_Encounter_Status ;
      private GXWebComponent WebComp_Generalwc ;
      private GXWebComponent WebComp_Checkdemographicswc ;
      private GXWebComponent WebComp_Checkbehaviorwc ;
      private GXWebComponent WebComp_Checkcomorbiditywc ;
      private GXWebComponent WebComp_Checkdeathwc ;
      private GXWebComponent WebComp_Checkvitalwc ;
      private GXWebComponent WebComp_Br_diagnosiswc ;
      private GXWebComponent WebComp_Br_labwc ;
      private GXWebComponent WebComp_Br_medicationwc ;
      private GXWebComponent WebComp_Br_schemewc ;
      private GXWebComponent WebComp_Br_procedurewc ;
      private GXWebComponent WebComp_Br_medicalimagingwc ;
      private GXWebComponent WebComp_Br_pathologywc ;
      private GXUserControl ucTabs ;
      private GXUserControl ucDvelop_confirmpanel_edit ;
      private GXUserControl ucDvelop_confirmpanel_approvewrong ;
      private GXUserControl ucDvelop_confirmpanel_approveright ;
      private GXUserControl ucDvelop_confirmpanel_checkr ;
      private GXUserControl ucDvelop_confirmpanel_check ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H003S2_A19BR_EncounterID ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_datastore1 ;
      private IGxSession AV24WebSession ;
      private GXWebForm Form ;
      private SdtBR_Encounter AV16BCBR_Encounter ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_encountercheck__datastore1 : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

    public String getDataStoreName( )
    {
       return "DATASTORE1";
    }

 }

 public class br_encountercheck__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmH003S2 ;
        prmH003S2 = new Object[] {
        new Object[] {"@AV10BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("H003S2", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @AV10BR_EncounterID ORDER BY [BR_EncounterID] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003S2,1,0,false,true )
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
              return;
     }
  }

  public void setParameters( int cursor ,
                             IFieldSetter stmt ,
                             Object[] parms )
  {
     switch ( cursor )
     {
           case 0 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
