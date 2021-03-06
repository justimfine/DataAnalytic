/*
               File: BR_EncounterCheckBR_MedicalImagingWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:5:14.97
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
   public class br_encountercheckbr_medicalimagingwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckbr_medicalimagingwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public br_encountercheckbr_medicalimagingwc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID )
      {
         this.AV8BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_EncounterID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_12_idx = GetNextPar( );
                  sPrefix = GetNextPar( );
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
                  AV14OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV15OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace = GetNextPar( );
                  AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = GetNextPar( );
                  AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = GetNextPar( );
                  AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = GetNextPar( );
                  AV62Pgmname = GetNextPar( );
                  AV50IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV62Pgmname, AV50IsAuthorized_Display, sPrefix) ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA5J2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV62Pgmname = "BR_EncounterCheckBR_MedicalImagingWC";
               context.Gx_err = 0;
               WS5J2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Data Mgmt Portal - RAAP") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202281551517", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckbr_medicalimagingwc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV15OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV17BR_MedicalImagingIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICALIMAGINGIDTITLEFILTERDATA", AV17BR_MedicalImagingIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA", AV25BR_MedicalImaging_ImageHospTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV62Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV50IsAuthorized_Display);
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Caption", StringUtil.RTrim( Ddo_br_medicalimagingid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Tooltip", StringUtil.RTrim( Ddo_br_medicalimagingid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Cls", StringUtil.RTrim( Ddo_br_medicalimagingid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimagingid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimagingid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimagingid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Sortasc", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimagingid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimagingid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imageage_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagename_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Caption", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Tooltip", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Cls", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortedstatus", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includefilter", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicalimaging_imagehosp_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortasc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortdsc", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGINGID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimagingid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imageage_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagename_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Activeeventkey", StringUtil.RTrim( Ddo_br_medicalimaging_imagehosp_Activeeventkey));
      }

      protected void RenderHtmlCloseForm5J2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckbr_medicalimagingwc.js", "?20202281551769", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterCheckBR_MedicalImagingWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB5J0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckbr_medicalimagingwc.aspx");
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
               context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablegridheader_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"12\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImagingID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImagingID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImagingID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageAge_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageAge_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageAge_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_MedicalImaging_ImageHosp_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicalImaging_ImageHosp_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicalImaging_ImageHosp_Title) ;
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
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV49Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImagingID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImagingID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageAge_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageAge_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A228BR_MedicalImaging_ImageName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A230BR_MedicalImaging_ImageHosp);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicalImaging_ImageHosp_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicalImaging_ImageHosp_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 12 )
         {
            wbEnd = 0;
            nRC_GXsfl_12 = (short)(nGXsfl_12_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV42GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV44GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV43GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, sPrefix+"GRIDPAGINATIONBARContainer");
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
            ucDdo_br_medicalimagingid.SetProperty("Caption", Ddo_br_medicalimagingid_Caption);
            ucDdo_br_medicalimagingid.SetProperty("Tooltip", Ddo_br_medicalimagingid_Tooltip);
            ucDdo_br_medicalimagingid.SetProperty("Cls", Ddo_br_medicalimagingid_Cls);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsType", Ddo_br_medicalimagingid_Dropdownoptionstype);
            ucDdo_br_medicalimagingid.SetProperty("IncludeSortASC", Ddo_br_medicalimagingid_Includesortasc);
            ucDdo_br_medicalimagingid.SetProperty("IncludeSortDSC", Ddo_br_medicalimagingid_Includesortdsc);
            ucDdo_br_medicalimagingid.SetProperty("IncludeFilter", Ddo_br_medicalimagingid_Includefilter);
            ucDdo_br_medicalimagingid.SetProperty("IncludeDataList", Ddo_br_medicalimagingid_Includedatalist);
            ucDdo_br_medicalimagingid.SetProperty("SortASC", Ddo_br_medicalimagingid_Sortasc);
            ucDdo_br_medicalimagingid.SetProperty("SortDSC", Ddo_br_medicalimagingid_Sortdsc);
            ucDdo_br_medicalimagingid.SetProperty("SearchButtonText", Ddo_br_medicalimagingid_Searchbuttontext);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimagingid.SetProperty("DropDownOptionsData", AV17BR_MedicalImagingIDTitleFilterData);
            ucDdo_br_medicalimagingid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimagingid_Internalname, sPrefix+"DDO_BR_MEDICALIMAGINGIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", 0, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imageage.SetProperty("Caption", Ddo_br_medicalimaging_imageage_Caption);
            ucDdo_br_medicalimaging_imageage.SetProperty("Tooltip", Ddo_br_medicalimaging_imageage_Tooltip);
            ucDdo_br_medicalimaging_imageage.SetProperty("Cls", Ddo_br_medicalimaging_imageage_Cls);
            ucDdo_br_medicalimaging_imageage.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imageage_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imageage_Includesortasc);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imageage_Includesortdsc);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imageage_Includefilter);
            ucDdo_br_medicalimaging_imageage.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imageage_Includedatalist);
            ucDdo_br_medicalimaging_imageage.SetProperty("SortASC", Ddo_br_medicalimaging_imageage_Sortasc);
            ucDdo_br_medicalimaging_imageage.SetProperty("SortDSC", Ddo_br_medicalimaging_imageage_Sortdsc);
            ucDdo_br_medicalimaging_imageage.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imageage_Searchbuttontext);
            ucDdo_br_medicalimaging_imageage.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imageage.SetProperty("DropDownOptionsData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
            ucDdo_br_medicalimaging_imageage.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imageage_Internalname, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagename.SetProperty("Caption", Ddo_br_medicalimaging_imagename_Caption);
            ucDdo_br_medicalimaging_imagename.SetProperty("Tooltip", Ddo_br_medicalimaging_imagename_Tooltip);
            ucDdo_br_medicalimaging_imagename.SetProperty("Cls", Ddo_br_medicalimaging_imagename_Cls);
            ucDdo_br_medicalimaging_imagename.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagename_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagename_Includesortasc);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagename_Includesortdsc);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagename_Includefilter);
            ucDdo_br_medicalimaging_imagename.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagename_Includedatalist);
            ucDdo_br_medicalimaging_imagename.SetProperty("SortASC", Ddo_br_medicalimaging_imagename_Sortasc);
            ucDdo_br_medicalimaging_imagename.SetProperty("SortDSC", Ddo_br_medicalimaging_imagename_Sortdsc);
            ucDdo_br_medicalimaging_imagename.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagename_Searchbuttontext);
            ucDdo_br_medicalimaging_imagename.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagename.SetProperty("DropDownOptionsData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
            ucDdo_br_medicalimaging_imagename.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagename_Internalname, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagedate.SetProperty("Caption", Ddo_br_medicalimaging_imagedate_Caption);
            ucDdo_br_medicalimaging_imagedate.SetProperty("Tooltip", Ddo_br_medicalimaging_imagedate_Tooltip);
            ucDdo_br_medicalimaging_imagedate.SetProperty("Cls", Ddo_br_medicalimaging_imagedate_Cls);
            ucDdo_br_medicalimaging_imagedate.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagedate_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagedate_Includesortasc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagedate_Includesortdsc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagedate_Includefilter);
            ucDdo_br_medicalimaging_imagedate.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagedate_Includedatalist);
            ucDdo_br_medicalimaging_imagedate.SetProperty("SortASC", Ddo_br_medicalimaging_imagedate_Sortasc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("SortDSC", Ddo_br_medicalimaging_imagedate_Sortdsc);
            ucDdo_br_medicalimaging_imagedate.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagedate_Searchbuttontext);
            ucDdo_br_medicalimaging_imagedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagedate.SetProperty("DropDownOptionsData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
            ucDdo_br_medicalimaging_imagedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagedate_Internalname, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* User Defined Control */
            ucDdo_br_medicalimaging_imagehosp.SetProperty("Caption", Ddo_br_medicalimaging_imagehosp_Caption);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("Tooltip", Ddo_br_medicalimaging_imagehosp_Tooltip);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("Cls", Ddo_br_medicalimaging_imagehosp_Cls);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("DropDownOptionsType", Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeSortASC", Ddo_br_medicalimaging_imagehosp_Includesortasc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeSortDSC", Ddo_br_medicalimaging_imagehosp_Includesortdsc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeFilter", Ddo_br_medicalimaging_imagehosp_Includefilter);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("IncludeDataList", Ddo_br_medicalimaging_imagehosp_Includedatalist);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("SortASC", Ddo_br_medicalimaging_imagehosp_Sortasc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("SortDSC", Ddo_br_medicalimaging_imagehosp_Sortdsc);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("SearchButtonText", Ddo_br_medicalimaging_imagehosp_Searchbuttontext);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_medicalimaging_imagehosp.SetProperty("DropDownOptionsData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
            ucDdo_br_medicalimaging_imagehosp.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicalimaging_imagehosp_Internalname, sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSPContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterCheckBR_MedicalImagingWC.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 12 )
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
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START5J2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP5J0( ) ;
            }
         }
      }

      protected void WS5J2( )
      {
         START5J2( ) ;
         EVT5J2( ) ;
      }

      protected void EVT5J2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E115J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E125J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E135J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E145J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E155J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E165J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E175J2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP5J0( ) ;
                              }
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                              SubsflControlProps_122( ) ;
                              AV49Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)) ? AV61Display_GXI : context.convertURL( context.PathToRelativeUrl( AV49Display))), !bGXsfl_12_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV49Display), true);
                              A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImagingID_Internalname), ".", ","));
                              A231BR_MedicalImaging_ImageAge = (short)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ImageAge_Internalname), ".", ","));
                              n231BR_MedicalImaging_ImageAge = false;
                              A228BR_MedicalImaging_ImageName = cgiGet( edtBR_MedicalImaging_ImageName_Internalname);
                              n228BR_MedicalImaging_ImageName = false;
                              A229BR_MedicalImaging_ImageDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_MedicalImaging_ImageDate_Internalname), 0));
                              n229BR_MedicalImaging_ImageDate = false;
                              A230BR_MedicalImaging_ImageHosp = cgiGet( edtBR_MedicalImaging_ImageHosp_Internalname);
                              n230BR_MedicalImaging_ImageHosp = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E185J2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E195J2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E205J2 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP5J0( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE5J2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm5J2( ) ;
            }
         }
      }

      protected void PA5J2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
         SubsflControlProps_122( ) ;
         while ( nGXsfl_12_idx <= nRC_GXsfl_12 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       long AV8BR_EncounterID ,
                                       String AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace ,
                                       String AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace ,
                                       String AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace ,
                                       String AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace ,
                                       String AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace ,
                                       String AV62Pgmname ,
                                       bool AV50IsAuthorized_Display ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF5J2( ) ;
         /* End function gxgrGrid_refresh */
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
         RF5J2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV62Pgmname = "BR_EncounterCheckBR_MedicalImagingWC";
         context.Gx_err = 0;
      }

      protected void RF5J2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E195J2 ();
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         bGXsfl_12_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
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
            SubsflControlProps_122( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV8BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H005J2 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H005J2_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = H005J2_n19BR_EncounterID[0];
               A230BR_MedicalImaging_ImageHosp = H005J2_A230BR_MedicalImaging_ImageHosp[0];
               n230BR_MedicalImaging_ImageHosp = H005J2_n230BR_MedicalImaging_ImageHosp[0];
               A229BR_MedicalImaging_ImageDate = H005J2_A229BR_MedicalImaging_ImageDate[0];
               n229BR_MedicalImaging_ImageDate = H005J2_n229BR_MedicalImaging_ImageDate[0];
               A228BR_MedicalImaging_ImageName = H005J2_A228BR_MedicalImaging_ImageName[0];
               n228BR_MedicalImaging_ImageName = H005J2_n228BR_MedicalImaging_ImageName[0];
               A231BR_MedicalImaging_ImageAge = H005J2_A231BR_MedicalImaging_ImageAge[0];
               n231BR_MedicalImaging_ImageAge = H005J2_n231BR_MedicalImaging_ImageAge[0];
               A225BR_MedicalImagingID = H005J2_A225BR_MedicalImagingID[0];
               E205J2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB5J0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes5J2( )
      {
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV8BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H005J3 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID});
         GRID_nRecordCount = H005J3_AGRID_nRecordCount[0];
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
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV62Pgmname, AV50IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV62Pgmname, AV50IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV62Pgmname, AV50IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV62Pgmname, AV50IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, AV62Pgmname, AV50IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP5J0( )
      {
         /* Before Start, stand alone formulas. */
         AV62Pgmname = "BR_EncounterCheckBR_MedicalImagingWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E185J2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV39DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICALIMAGINGIDTITLEFILTERDATA"), AV17BR_MedicalImagingIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA"), AV27BR_MedicalImaging_ImageAgeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA"), AV21BR_MedicalImaging_ImageNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA"), AV23BR_MedicalImaging_ImageDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA"), AV25BR_MedicalImaging_ImageHospTitleFilterData);
            /* Read variables values. */
            AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace);
            AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace", AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace);
            AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace", AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace);
            AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace", AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace);
            AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = cgiGet( edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace", AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            else
            {
               AV14OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            AV15OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_12"), ".", ","));
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV44GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV43GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Class = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_medicalimagingid_Caption = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Caption");
            Ddo_br_medicalimagingid_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Tooltip");
            Ddo_br_medicalimagingid_Cls = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Cls");
            Ddo_br_medicalimagingid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Dropdownoptionstype");
            Ddo_br_medicalimagingid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Titlecontrolidtoreplace");
            Ddo_br_medicalimagingid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Includesortasc"));
            Ddo_br_medicalimagingid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Includesortdsc"));
            Ddo_br_medicalimagingid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Sortedstatus");
            Ddo_br_medicalimagingid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Includefilter"));
            Ddo_br_medicalimagingid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Includedatalist"));
            Ddo_br_medicalimagingid_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Sortasc");
            Ddo_br_medicalimagingid_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Sortdsc");
            Ddo_br_medicalimagingid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Searchbuttontext");
            Ddo_br_medicalimaging_imageage_Caption = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Caption");
            Ddo_br_medicalimaging_imageage_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Tooltip");
            Ddo_br_medicalimaging_imageage_Cls = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Cls");
            Ddo_br_medicalimaging_imageage_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imageage_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortasc"));
            Ddo_br_medicalimaging_imageage_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includesortdsc"));
            Ddo_br_medicalimaging_imageage_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortedstatus");
            Ddo_br_medicalimaging_imageage_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includefilter"));
            Ddo_br_medicalimaging_imageage_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Includedatalist"));
            Ddo_br_medicalimaging_imageage_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortasc");
            Ddo_br_medicalimaging_imageage_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Sortdsc");
            Ddo_br_medicalimaging_imageage_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Searchbuttontext");
            Ddo_br_medicalimaging_imagename_Caption = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Caption");
            Ddo_br_medicalimaging_imagename_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Tooltip");
            Ddo_br_medicalimaging_imagename_Cls = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Cls");
            Ddo_br_medicalimaging_imagename_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagename_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortasc"));
            Ddo_br_medicalimaging_imagename_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includesortdsc"));
            Ddo_br_medicalimaging_imagename_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Sortedstatus");
            Ddo_br_medicalimaging_imagename_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includefilter"));
            Ddo_br_medicalimaging_imagename_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Includedatalist"));
            Ddo_br_medicalimaging_imagename_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Sortasc");
            Ddo_br_medicalimaging_imagename_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Sortdsc");
            Ddo_br_medicalimaging_imagename_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Searchbuttontext");
            Ddo_br_medicalimaging_imagedate_Caption = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Caption");
            Ddo_br_medicalimaging_imagedate_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Tooltip");
            Ddo_br_medicalimaging_imagedate_Cls = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Cls");
            Ddo_br_medicalimaging_imagedate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagedate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortasc"));
            Ddo_br_medicalimaging_imagedate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includesortdsc"));
            Ddo_br_medicalimaging_imagedate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortedstatus");
            Ddo_br_medicalimaging_imagedate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includefilter"));
            Ddo_br_medicalimaging_imagedate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Includedatalist"));
            Ddo_br_medicalimaging_imagedate_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortasc");
            Ddo_br_medicalimaging_imagedate_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Sortdsc");
            Ddo_br_medicalimaging_imagedate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Searchbuttontext");
            Ddo_br_medicalimaging_imagehosp_Caption = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Caption");
            Ddo_br_medicalimaging_imagehosp_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Tooltip");
            Ddo_br_medicalimaging_imagehosp_Cls = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Cls");
            Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Dropdownoptionstype");
            Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Titlecontrolidtoreplace");
            Ddo_br_medicalimaging_imagehosp_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortasc"));
            Ddo_br_medicalimaging_imagehosp_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includesortdsc"));
            Ddo_br_medicalimaging_imagehosp_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortedstatus");
            Ddo_br_medicalimaging_imagehosp_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includefilter"));
            Ddo_br_medicalimaging_imagehosp_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Includedatalist"));
            Ddo_br_medicalimaging_imagehosp_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortasc");
            Ddo_br_medicalimaging_imagehosp_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Sortdsc");
            Ddo_br_medicalimaging_imagehosp_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medicalimagingid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGINGID_Activeeventkey");
            Ddo_br_medicalimaging_imageage_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE_Activeeventkey");
            Ddo_br_medicalimaging_imagename_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME_Activeeventkey");
            Ddo_br_medicalimaging_imagedate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE_Activeeventkey");
            Ddo_br_medicalimaging_imagehosp_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
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
         E185J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E185J2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImagingID";
         ucDdo_br_medicalimagingid.SendProperty(context, sPrefix, false, Ddo_br_medicalimagingid_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimagingid_Titlecontrolidtoreplace);
         AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace = Ddo_br_medicalimagingid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace", AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace);
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageAge";
         ucDdo_br_medicalimaging_imageage.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imageage_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace);
         AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace", AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageName";
         ucDdo_br_medicalimaging_imagename.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagename_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace);
         AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace", AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageDate";
         ucDdo_br_medicalimaging_imagedate.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagedate_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace);
         AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace", AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicalImaging_ImageHosp";
         ucDdo_br_medicalimaging_imagehosp.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagehosp_Internalname, "TitleControlIdToReplace", Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace);
         AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace", AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace);
         edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
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
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV14OrderedBy < 1 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV39DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV39DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E195J2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_MedicalImaging_ImageAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_MedicalImaging_ImageNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_MedicalImaging_ImageDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_MedicalImaging_ImageHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_MedicalImagingID_Titleformat = 2;
         edtBR_MedicalImagingID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImagingID_Internalname, "Title", edtBR_MedicalImagingID_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageAge_Titleformat = 2;
         edtBR_MedicalImaging_ImageAge_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "年龄", AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_ImageAge_Internalname, "Title", edtBR_MedicalImaging_ImageAge_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageName_Titleformat = 2;
         edtBR_MedicalImaging_ImageName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "影像名称", AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_ImageName_Internalname, "Title", edtBR_MedicalImaging_ImageName_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageDate_Titleformat = 2;
         edtBR_MedicalImaging_ImageDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "检查日期", AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_ImageDate_Internalname, "Title", edtBR_MedicalImaging_ImageDate_Title, !bGXsfl_12_Refreshing);
         edtBR_MedicalImaging_ImageHosp_Titleformat = 2;
         edtBR_MedicalImaging_ImageHosp_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "行检医院", AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicalImaging_ImageHosp_Internalname, "Title", edtBR_MedicalImaging_ImageHosp_Title, !bGXsfl_12_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicalImagingIDTitleFilterData", AV17BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
      }

      protected void E115J2( )
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
            AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV41PageToGo) ;
         }
      }

      protected void E125J2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E135J2( )
      {
         /* Ddo_br_medicalimagingid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimagingid_Sortedstatus = "ASC";
            ucDdo_br_medicalimagingid.SendProperty(context, sPrefix, false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimagingid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimagingid_Sortedstatus = "DSC";
            ucDdo_br_medicalimagingid.SendProperty(context, sPrefix, false, Ddo_br_medicalimagingid_Internalname, "SortedStatus", Ddo_br_medicalimagingid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicalImagingIDTitleFilterData", AV17BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
      }

      protected void E145J2( )
      {
         /* Ddo_br_medicalimaging_imageage_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageage_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imageage_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imageage.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imageage_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imageage_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imageage_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imageage.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imageage_Internalname, "SortedStatus", Ddo_br_medicalimaging_imageage_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicalImagingIDTitleFilterData", AV17BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
      }

      protected void E155J2( )
      {
         /* Ddo_br_medicalimaging_imagename_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagename_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imagename_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagename.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagename_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagename_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imagename_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagename.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagename_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagename_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicalImagingIDTitleFilterData", AV17BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
      }

      protected void E165J2( )
      {
         /* Ddo_br_medicalimaging_imagedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imagedate_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagedate.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagedate_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imagedate_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagedate.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagedate_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicalImagingIDTitleFilterData", AV17BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
      }

      protected void E175J2( )
      {
         /* Ddo_br_medicalimaging_imagehosp_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehosp_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imagehosp_Sortedstatus = "ASC";
            ucDdo_br_medicalimaging_imagehosp.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagehosp_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicalimaging_imagehosp_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicalimaging_imagehosp_Sortedstatus = "DSC";
            ucDdo_br_medicalimaging_imagehosp.SendProperty(context, sPrefix, false, Ddo_br_medicalimaging_imagehosp_Internalname, "SortedStatus", Ddo_br_medicalimaging_imagehosp_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicalImagingIDTitleFilterData", AV17BR_MedicalImagingIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_MedicalImaging_ImageAgeTitleFilterData", AV27BR_MedicalImaging_ImageAgeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_MedicalImaging_ImageNameTitleFilterData", AV21BR_MedicalImaging_ImageNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_MedicalImaging_ImageDateTitleFilterData", AV23BR_MedicalImaging_ImageDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_MedicalImaging_ImageHospTitleFilterData", AV25BR_MedicalImaging_ImageHospTitleFilterData);
      }

      private void E205J2( )
      {
         /* Grid_Load Routine */
         AV49Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV49Display);
         AV61Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV50IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_medicalimagingview.aspx") + "?" + UrlEncode("" +A225BR_MedicalImagingID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12;
         }
         sendrow_122( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_12_Refreshing )
         {
            context.DoAjaxLoad(12, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV50IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
         AV50IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV50IsAuthorized_Display", AV50IsAuthorized_Display);
         if ( ! ( AV50IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_12_Refreshing);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV62Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV62Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV62Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV14OrderedBy = AV12GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         AV15OrderedDsc = AV12GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV12GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV12GridState.FromXml(AV16Session.Get(AV62Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV62Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV62Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_MedicalImaging";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
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
         PA5J2( ) ;
         WS5J2( ) ;
         WE5J2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV8BR_EncounterID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA5J2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckbr_medicalimagingwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA5J2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_EncounterID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
         }
         wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_EncounterID != wcpOAV8BR_EncounterID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_EncounterID = AV8BR_EncounterID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_EncounterID = cgiGet( sPrefix+"AV8BR_EncounterID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_EncounterID) > 0 )
         {
            AV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_EncounterID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
         }
         else
         {
            AV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_EncounterID_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA5J2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS5J2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS5J2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_EncounterID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_EncounterID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_EncounterID_CTRL", StringUtil.RTrim( sCtrlAV8BR_EncounterID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE5J2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281552868", true);
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
         context.AddJavascriptSource("br_encountercheckbr_medicalimagingwc.js", "?20202281552868", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_12_idx;
         edtBR_MedicalImagingID_Internalname = sPrefix+"BR_MEDICALIMAGINGID_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageAge_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEAGE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageName_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGENAME_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageDate_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEDATE_"+sGXsfl_12_idx;
         edtBR_MedicalImaging_ImageHosp_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEHOSP_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImagingID_Internalname = sPrefix+"BR_MEDICALIMAGINGID_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageAge_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEAGE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageName_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGENAME_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageDate_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEDATE_"+sGXsfl_12_fel_idx;
         edtBR_MedicalImaging_ImageHosp_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEHOSP_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB5J0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_12_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_12_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV49Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV49Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV61Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)) ? AV61Display_GXI : context.PathToRelativeUrl( AV49Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV49Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImagingID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImagingID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageAge_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0, ".", "")),context.localUtil.Format( (decimal)(A231BR_MedicalImaging_ImageAge), "ZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageAge_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)3,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageName_Internalname,(String)A228BR_MedicalImaging_ImageName,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageDate_Internalname,context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"),context.localUtil.Format( A229BR_MedicalImaging_ImageDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicalImaging_ImageHosp_Internalname,(String)A230BR_MedicalImaging_ImageHosp,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicalImaging_ImageHosp_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes5J2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtBR_MedicalImagingID_Internalname = sPrefix+"BR_MEDICALIMAGINGID";
         edtBR_MedicalImaging_ImageAge_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEAGE";
         edtBR_MedicalImaging_ImageName_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGENAME";
         edtBR_MedicalImaging_ImageDate_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEDATE";
         edtBR_MedicalImaging_ImageHosp_Internalname = sPrefix+"BR_MEDICALIMAGING_IMAGEHOSP";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_medicalimagingid_Internalname = sPrefix+"DDO_BR_MEDICALIMAGINGID";
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imageage_Internalname = sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEAGE";
         edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagename_Internalname = sPrefix+"DDO_BR_MEDICALIMAGING_IMAGENAME";
         edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagedate_Internalname = sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEDATE";
         edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE";
         Ddo_br_medicalimaging_imagehosp_Internalname = sPrefix+"DDO_BR_MEDICALIMAGING_IMAGEHOSP";
         edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtBR_MedicalImaging_ImageHosp_Jsonclick = "";
         edtBR_MedicalImaging_ImageDate_Jsonclick = "";
         edtBR_MedicalImaging_ImageName_Jsonclick = "";
         edtBR_MedicalImaging_ImageAge_Jsonclick = "";
         edtBR_MedicalImagingID_Jsonclick = "";
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_MedicalImaging_ImageHosp_Titleformat = 0;
         edtBR_MedicalImaging_ImageHosp_Title = "行检医院";
         edtBR_MedicalImaging_ImageDate_Titleformat = 0;
         edtBR_MedicalImaging_ImageDate_Title = "检查日期";
         edtBR_MedicalImaging_ImageName_Titleformat = 0;
         edtBR_MedicalImaging_ImageName_Title = "影像名称";
         edtBR_MedicalImaging_ImageAge_Titleformat = 0;
         edtBR_MedicalImaging_ImageAge_Title = "年龄";
         edtBR_MedicalImagingID_Titleformat = 0;
         edtBR_MedicalImagingID_Title = "序号";
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_br_medicalimaging_imagehosp_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagehosp_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagehosp_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagehosp_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehosp_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagehosp_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehosp_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagehosp_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagehosp_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagehosp_Caption = "";
         Ddo_br_medicalimaging_imagedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagedate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagedate_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagedate_Caption = "";
         Ddo_br_medicalimaging_imagename_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imagename_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imagename_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imagename_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagename_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imagename_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagename_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imagename_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imagename_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imagename_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imagename_Caption = "";
         Ddo_br_medicalimaging_imageage_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimaging_imageage_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimaging_imageage_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimaging_imageage_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageage_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimaging_imageage_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageage_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimaging_imageage_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimaging_imageage_Cls = "ColumnSettings";
         Ddo_br_medicalimaging_imageage_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimaging_imageage_Caption = "";
         Ddo_br_medicalimagingid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicalimagingid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicalimagingid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicalimagingid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicalimagingid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicalimagingid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicalimagingid_Titlecontrolidtoreplace = "";
         Ddo_br_medicalimagingid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicalimagingid_Cls = "ColumnSettings";
         Ddo_br_medicalimagingid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicalimagingid_Caption = "";
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
         Gridpaginationbar_Caption = "<CURRENT_PAGE>页/<TOTAL_PAGES>页 记录：<TOTAL_RECORDS>条";
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Class = "PaginationBar";
         subGrid_Rows = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E115J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E125J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED","{handler:'E135J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medicalimagingid_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGINGID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimagingid_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGINGID',prop:'SortedStatus'},{av:'AV17BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED","{handler:'E145J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medicalimaging_imageage_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEAGE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imageage_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEAGE',prop:'SortedStatus'},{av:'AV17BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED","{handler:'E155J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medicalimaging_imagename_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGENAME.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagename_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGENAME',prop:'SortedStatus'},{av:'AV17BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED","{handler:'E165J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medicalimaging_imagedate_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagedate_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEDATE',prop:'SortedStatus'},{av:'AV17BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED","{handler:'E175J2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGINGIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEAGETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGENAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace',fld:'vDDO_BR_MEDICALIMAGING_IMAGEHOSPTITLECONTROLIDTOREPLACE',pic:''},{av:'AV62Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medicalimaging_imagehosp_Activeeventkey',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICALIMAGING_IMAGEHOSP.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicalimaging_imagehosp_Sortedstatus',ctrl:'DDO_BR_MEDICALIMAGING_IMAGEHOSP',prop:'SortedStatus'},{av:'AV17BR_MedicalImagingIDTitleFilterData',fld:'vBR_MEDICALIMAGINGIDTITLEFILTERDATA',pic:''},{av:'AV27BR_MedicalImaging_ImageAgeTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEAGETITLEFILTERDATA',pic:''},{av:'AV21BR_MedicalImaging_ImageNameTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGENAMETITLEFILTERDATA',pic:''},{av:'AV23BR_MedicalImaging_ImageDateTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEDATETITLEFILTERDATA',pic:''},{av:'AV25BR_MedicalImaging_ImageHospTitleFilterData',fld:'vBR_MEDICALIMAGING_IMAGEHOSPTITLEFILTERDATA',pic:''},{av:'edtBR_MedicalImagingID_Titleformat',ctrl:'BR_MEDICALIMAGINGID',prop:'Titleformat'},{av:'edtBR_MedicalImagingID_Title',ctrl:'BR_MEDICALIMAGINGID',prop:'Title'},{av:'edtBR_MedicalImaging_ImageAge_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageAge_Title',ctrl:'BR_MEDICALIMAGING_IMAGEAGE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageName_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageName_Title',ctrl:'BR_MEDICALIMAGING_IMAGENAME',prop:'Title'},{av:'edtBR_MedicalImaging_ImageDate_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageDate_Title',ctrl:'BR_MEDICALIMAGING_IMAGEDATE',prop:'Title'},{av:'edtBR_MedicalImaging_ImageHosp_Titleformat',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Titleformat'},{av:'edtBR_MedicalImaging_ImageHosp_Title',ctrl:'BR_MEDICALIMAGING_IMAGEHOSP',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E205J2',iparms:[{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV49Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'}]}");
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
         Ddo_br_medicalimagingid_Activeeventkey = "";
         Ddo_br_medicalimaging_imageage_Activeeventkey = "";
         Ddo_br_medicalimaging_imagename_Activeeventkey = "";
         Ddo_br_medicalimaging_imagedate_Activeeventkey = "";
         Ddo_br_medicalimaging_imagehosp_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace = "";
         AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace = "";
         AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace = "";
         AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace = "";
         AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace = "";
         AV62Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV39DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_MedicalImagingIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_MedicalImaging_ImageAgeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_MedicalImaging_ImageNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_MedicalImaging_ImageDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_MedicalImaging_ImageHospTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medicalimagingid_Sortedstatus = "";
         Ddo_br_medicalimaging_imageage_Sortedstatus = "";
         Ddo_br_medicalimaging_imagename_Sortedstatus = "";
         Ddo_br_medicalimaging_imagedate_Sortedstatus = "";
         Ddo_br_medicalimaging_imagehosp_Sortedstatus = "";
         GX_FocusControl = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV49Display = "";
         A228BR_MedicalImaging_ImageName = "";
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         A230BR_MedicalImaging_ImageHosp = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medicalimagingid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_medicalimaging_imageage = new GXUserControl();
         ucDdo_br_medicalimaging_imagename = new GXUserControl();
         ucDdo_br_medicalimaging_imagedate = new GXUserControl();
         ucDdo_br_medicalimaging_imagehosp = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV61Display_GXI = "";
         scmdbuf = "";
         H005J2_A19BR_EncounterID = new long[1] ;
         H005J2_n19BR_EncounterID = new bool[] {false} ;
         H005J2_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         H005J2_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         H005J2_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         H005J2_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         H005J2_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         H005J2_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         H005J2_A231BR_MedicalImaging_ImageAge = new short[1] ;
         H005J2_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         H005J2_A225BR_MedicalImagingID = new long[1] ;
         H005J3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_EncounterID = "";
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckbr_medicalimagingwc__default(),
            new Object[][] {
                new Object[] {
               H005J2_A19BR_EncounterID, H005J2_n19BR_EncounterID, H005J2_A230BR_MedicalImaging_ImageHosp, H005J2_n230BR_MedicalImaging_ImageHosp, H005J2_A229BR_MedicalImaging_ImageDate, H005J2_n229BR_MedicalImaging_ImageDate, H005J2_A228BR_MedicalImaging_ImageName, H005J2_n228BR_MedicalImaging_ImageName, H005J2_A231BR_MedicalImaging_ImageAge, H005J2_n231BR_MedicalImaging_ImageAge,
               H005J2_A225BR_MedicalImagingID
               }
               , new Object[] {
               H005J3_AGRID_nRecordCount
               }
            }
         );
         AV62Pgmname = "BR_EncounterCheckBR_MedicalImagingWC";
         /* GeneXus formulas. */
         AV62Pgmname = "BR_EncounterCheckBR_MedicalImagingWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV14OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_MedicalImagingID_Titleformat ;
      private short edtBR_MedicalImaging_ImageAge_Titleformat ;
      private short edtBR_MedicalImaging_ImageName_Titleformat ;
      private short edtBR_MedicalImaging_ImageDate_Titleformat ;
      private short edtBR_MedicalImaging_ImageHosp_Titleformat ;
      private short subGrid_Sortable ;
      private short A231BR_MedicalImaging_ImageAge ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDisplay_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A225BR_MedicalImagingID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medicalimagingid_Activeeventkey ;
      private String Ddo_br_medicalimaging_imageage_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagename_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagedate_Activeeventkey ;
      private String Ddo_br_medicalimaging_imagehosp_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_12_idx="0001" ;
      private String AV62Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String Ddo_br_medicalimagingid_Caption ;
      private String Ddo_br_medicalimagingid_Tooltip ;
      private String Ddo_br_medicalimagingid_Cls ;
      private String Ddo_br_medicalimagingid_Dropdownoptionstype ;
      private String Ddo_br_medicalimagingid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimagingid_Sortedstatus ;
      private String Ddo_br_medicalimagingid_Sortasc ;
      private String Ddo_br_medicalimagingid_Sortdsc ;
      private String Ddo_br_medicalimagingid_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imageage_Caption ;
      private String Ddo_br_medicalimaging_imageage_Tooltip ;
      private String Ddo_br_medicalimaging_imageage_Cls ;
      private String Ddo_br_medicalimaging_imageage_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imageage_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imageage_Sortedstatus ;
      private String Ddo_br_medicalimaging_imageage_Sortasc ;
      private String Ddo_br_medicalimaging_imageage_Sortdsc ;
      private String Ddo_br_medicalimaging_imageage_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagename_Caption ;
      private String Ddo_br_medicalimaging_imagename_Tooltip ;
      private String Ddo_br_medicalimaging_imagename_Cls ;
      private String Ddo_br_medicalimaging_imagename_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagename_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagename_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagename_Sortasc ;
      private String Ddo_br_medicalimaging_imagename_Sortdsc ;
      private String Ddo_br_medicalimaging_imagename_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagedate_Caption ;
      private String Ddo_br_medicalimaging_imagedate_Tooltip ;
      private String Ddo_br_medicalimaging_imagedate_Cls ;
      private String Ddo_br_medicalimaging_imagedate_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagedate_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagedate_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagedate_Sortasc ;
      private String Ddo_br_medicalimaging_imagedate_Sortdsc ;
      private String Ddo_br_medicalimaging_imagedate_Searchbuttontext ;
      private String Ddo_br_medicalimaging_imagehosp_Caption ;
      private String Ddo_br_medicalimaging_imagehosp_Tooltip ;
      private String Ddo_br_medicalimaging_imagehosp_Cls ;
      private String Ddo_br_medicalimaging_imagehosp_Dropdownoptionstype ;
      private String Ddo_br_medicalimaging_imagehosp_Titlecontrolidtoreplace ;
      private String Ddo_br_medicalimaging_imagehosp_Sortedstatus ;
      private String Ddo_br_medicalimaging_imagehosp_Sortasc ;
      private String Ddo_br_medicalimaging_imagehosp_Sortdsc ;
      private String Ddo_br_medicalimaging_imagehosp_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_MedicalImagingID_Title ;
      private String edtBR_MedicalImaging_ImageAge_Title ;
      private String edtBR_MedicalImaging_ImageName_Title ;
      private String edtBR_MedicalImaging_ImageDate_Title ;
      private String edtBR_MedicalImaging_ImageHosp_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medicalimagingid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medicalimagingidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imageage_Internalname ;
      private String edtavDdo_br_medicalimaging_imageagetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagename_Internalname ;
      private String edtavDdo_br_medicalimaging_imagenametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagedate_Internalname ;
      private String edtavDdo_br_medicalimaging_imagedatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medicalimaging_imagehosp_Internalname ;
      private String edtavDdo_br_medicalimaging_imagehosptitlecontrolidtoreplace_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_MedicalImaging_ImageAge_Internalname ;
      private String edtBR_MedicalImaging_ImageName_Internalname ;
      private String edtBR_MedicalImaging_ImageDate_Internalname ;
      private String edtBR_MedicalImaging_ImageHosp_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String edtBR_MedicalImaging_ImageAge_Jsonclick ;
      private String edtBR_MedicalImaging_ImageName_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDate_Jsonclick ;
      private String edtBR_MedicalImaging_ImageHosp_Jsonclick ;
      private DateTime A229BR_MedicalImaging_ImageDate ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV50IsAuthorized_Display ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medicalimagingid_Includesortasc ;
      private bool Ddo_br_medicalimagingid_Includesortdsc ;
      private bool Ddo_br_medicalimagingid_Includefilter ;
      private bool Ddo_br_medicalimagingid_Includedatalist ;
      private bool Ddo_br_medicalimaging_imageage_Includesortasc ;
      private bool Ddo_br_medicalimaging_imageage_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imageage_Includefilter ;
      private bool Ddo_br_medicalimaging_imageage_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagename_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagename_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagename_Includefilter ;
      private bool Ddo_br_medicalimaging_imagename_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagedate_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagedate_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagedate_Includefilter ;
      private bool Ddo_br_medicalimaging_imagedate_Includedatalist ;
      private bool Ddo_br_medicalimaging_imagehosp_Includesortasc ;
      private bool Ddo_br_medicalimaging_imagehosp_Includesortdsc ;
      private bool Ddo_br_medicalimaging_imagehosp_Includefilter ;
      private bool Ddo_br_medicalimaging_imagehosp_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n231BR_MedicalImaging_ImageAge ;
      private bool n228BR_MedicalImaging_ImageName ;
      private bool n229BR_MedicalImaging_ImageDate ;
      private bool n230BR_MedicalImaging_ImageHosp ;
      private bool gxdyncontrolsrefreshing ;
      private bool n19BR_EncounterID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean2 ;
      private bool AV49Display_IsBlob ;
      private String AV18ddo_BR_MedicalImagingIDTitleControlIdToReplace ;
      private String AV28ddo_BR_MedicalImaging_ImageAgeTitleControlIdToReplace ;
      private String AV22ddo_BR_MedicalImaging_ImageNameTitleControlIdToReplace ;
      private String AV24ddo_BR_MedicalImaging_ImageDateTitleControlIdToReplace ;
      private String AV26ddo_BR_MedicalImaging_ImageHospTitleControlIdToReplace ;
      private String A228BR_MedicalImaging_ImageName ;
      private String A230BR_MedicalImaging_ImageHosp ;
      private String AV61Display_GXI ;
      private String AV49Display ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medicalimagingid ;
      private GXUserControl ucDdo_br_medicalimaging_imageage ;
      private GXUserControl ucDdo_br_medicalimaging_imagename ;
      private GXUserControl ucDdo_br_medicalimaging_imagedate ;
      private GXUserControl ucDdo_br_medicalimaging_imagehosp ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H005J2_A19BR_EncounterID ;
      private bool[] H005J2_n19BR_EncounterID ;
      private String[] H005J2_A230BR_MedicalImaging_ImageHosp ;
      private bool[] H005J2_n230BR_MedicalImaging_ImageHosp ;
      private DateTime[] H005J2_A229BR_MedicalImaging_ImageDate ;
      private bool[] H005J2_n229BR_MedicalImaging_ImageDate ;
      private String[] H005J2_A228BR_MedicalImaging_ImageName ;
      private bool[] H005J2_n228BR_MedicalImaging_ImageName ;
      private short[] H005J2_A231BR_MedicalImaging_ImageAge ;
      private bool[] H005J2_n231BR_MedicalImaging_ImageAge ;
      private long[] H005J2_A225BR_MedicalImagingID ;
      private long[] H005J3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_MedicalImagingIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_MedicalImaging_ImageAgeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_MedicalImaging_ImageNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_MedicalImaging_ImageDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_MedicalImaging_ImageHospTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV39DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encountercheckbr_medicalimagingwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H005J2( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [4] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_EncounterID], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageAge], [BR_MedicalImagingID]";
         sFromString = " FROM [BR_MedicalImaging] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_MedicalImaging_ImageAge]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_MedicalImaging_ImageAge] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_MedicalImaging_ImageName]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_MedicalImaging_ImageName] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_MedicalImaging_ImageDate]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_MedicalImaging_ImageDate] DESC";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_MedicalImaging_ImageHosp]";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_MedicalImaging_ImageHosp] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicalImagingID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H005J3( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_MedicalImaging] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
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
                     return conditional_H005J2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
               case 1 :
                     return conditional_H005J3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
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
          Object[] prmH005J2 ;
          prmH005J2 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH005J3 ;
          prmH005J3 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H005J2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005J2,11,0,true,false )
             ,new CursorDef("H005J3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH005J3,1,0,true,false )
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
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
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
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[1]);
                }
                return;
       }
    }

 }

}
