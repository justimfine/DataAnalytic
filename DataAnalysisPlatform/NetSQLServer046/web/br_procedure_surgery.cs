/*
               File: BR_Procedure_Surgery
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:41.8
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
   public class br_procedure_surgery : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action9") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_9_1037( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action10") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_10_1037( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action11") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_11_1037( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A139BR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_13( A139BR_ProcedureID) ;
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
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7BR_Procedure_SurgeryID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Procedure_SurgeryID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PROCEDURE_SURGERYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
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
         GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_procedure_surgery( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_surgery( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           long aP1_BR_Procedure_SurgeryID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Procedure_SurgeryID = aP1_BR_Procedure_SurgeryID;
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

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
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

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMainTransaction", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablecontent_Internalname, 1, 0, "px", 0, "px", "TableContent", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableattributes.SetProperty("Width", Dvpanel_tableattributes_Width);
            ucDvpanel_tableattributes.SetProperty("AutoWidth", Dvpanel_tableattributes_Autowidth);
            ucDvpanel_tableattributes.SetProperty("AutoHeight", Dvpanel_tableattributes_Autoheight);
            ucDvpanel_tableattributes.SetProperty("Cls", Dvpanel_tableattributes_Cls);
            ucDvpanel_tableattributes.SetProperty("Title", Dvpanel_tableattributes_Title);
            ucDvpanel_tableattributes.SetProperty("Collapsible", Dvpanel_tableattributes_Collapsible);
            ucDvpanel_tableattributes.SetProperty("Collapsed", Dvpanel_tableattributes_Collapsed);
            ucDvpanel_tableattributes.SetProperty("ShowCollapseIcon", Dvpanel_tableattributes_Showcollapseicon);
            ucDvpanel_tableattributes.SetProperty("IconPosition", Dvpanel_tableattributes_Iconposition);
            ucDvpanel_tableattributes.SetProperty("AutoScroll", Dvpanel_tableattributes_Autoscroll);
            ucDvpanel_tableattributes.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableattributes_Internalname, "DVPANEL_TABLEATTRIBUTESContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEATTRIBUTESContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableattributes_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableattributes_Internalname, 1, 0, "px", 0, "px", "TableData", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_surgery_name_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_surgery_name_Internalname, "手术名称", "", "", lblTextblockbr_procedure_surgery_name_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure_Surgery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_Surgery_Name_Internalname, "手术名称", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_Surgery_Name_Internalname, A321BR_Procedure_Surgery_Name, StringUtil.RTrim( context.localUtil.Format( A321BR_Procedure_Surgery_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_Surgery_Name_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Procedure_Surgery_Name_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_Surgery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_surgery_loc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_surgery_loc_Internalname, "手术部位", "", "", lblTextblockbr_procedure_surgery_loc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure_Surgery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_Surgery_Loc_Internalname, "手术部位", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_Surgery_Loc_Internalname, A322BR_Procedure_Surgery_Loc, StringUtil.RTrim( context.localUtil.Format( A322BR_Procedure_Surgery_Loc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_Surgery_Loc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Procedure_Surgery_Loc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure_Surgery.htm");
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group TrnActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure_Surgery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure_Surgery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure_Surgery.htm");
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
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_SurgeryID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A320BR_Procedure_SurgeryID), 18, 0, ".", "")), ((edtBR_Procedure_SurgeryID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_SurgeryID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Procedure_SurgeryID_Visible, edtBR_Procedure_SurgeryID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Procedure_Surgery.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_ProcedureID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_ProcedureID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_ProcedureID_Visible, edtBR_ProcedureID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Procedure_Surgery.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11102 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A321BR_Procedure_Surgery_Name = cgiGet( edtBR_Procedure_Surgery_Name_Internalname);
               n321BR_Procedure_Surgery_Name = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321BR_Procedure_Surgery_Name", A321BR_Procedure_Surgery_Name);
               n321BR_Procedure_Surgery_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A321BR_Procedure_Surgery_Name)) ? true : false);
               A322BR_Procedure_Surgery_Loc = cgiGet( edtBR_Procedure_Surgery_Loc_Internalname);
               n322BR_Procedure_Surgery_Loc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322BR_Procedure_Surgery_Loc", A322BR_Procedure_Surgery_Loc);
               n322BR_Procedure_Surgery_Loc = (String.IsNullOrEmpty(StringUtil.RTrim( A322BR_Procedure_Surgery_Loc)) ? true : false);
               A320BR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_SurgeryID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PROCEDUREID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_ProcedureID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A139BR_ProcedureID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
               }
               else
               {
                  A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
               }
               /* Read saved values. */
               Z320BR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( "Z320BR_Procedure_SurgeryID"), ".", ","));
               Z321BR_Procedure_Surgery_Name = cgiGet( "Z321BR_Procedure_Surgery_Name");
               n321BR_Procedure_Surgery_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A321BR_Procedure_Surgery_Name)) ? true : false);
               Z322BR_Procedure_Surgery_Loc = cgiGet( "Z322BR_Procedure_Surgery_Loc");
               n322BR_Procedure_Surgery_Loc = (String.IsNullOrEmpty(StringUtil.RTrim( A322BR_Procedure_Surgery_Loc)) ? true : false);
               Z139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( "Z139BR_ProcedureID"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( "N139BR_ProcedureID"), ".", ","));
               AV7BR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( "vBR_PROCEDURE_SURGERYID"), ".", ","));
               AV13Insert_BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_PROCEDUREID"), ".", ","));
               AV17Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               Dvpanel_tableattributes_Objectcall = cgiGet( "DVPANEL_TABLEATTRIBUTES_Objectcall");
               Dvpanel_tableattributes_Class = cgiGet( "DVPANEL_TABLEATTRIBUTES_Class");
               Dvpanel_tableattributes_Enabled = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Enabled"));
               Dvpanel_tableattributes_Width = cgiGet( "DVPANEL_TABLEATTRIBUTES_Width");
               Dvpanel_tableattributes_Height = cgiGet( "DVPANEL_TABLEATTRIBUTES_Height");
               Dvpanel_tableattributes_Cls = cgiGet( "DVPANEL_TABLEATTRIBUTES_Cls");
               Dvpanel_tableattributes_Title = cgiGet( "DVPANEL_TABLEATTRIBUTES_Title");
               Dvpanel_tableattributes_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsible"));
               Dvpanel_tableattributes_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Collapsed"));
               Dvpanel_tableattributes_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autowidth"));
               Dvpanel_tableattributes_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoheight"));
               Dvpanel_tableattributes_Showheader = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showheader"));
               Dvpanel_tableattributes_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Showcollapseicon"));
               Dvpanel_tableattributes_Iconposition = cgiGet( "DVPANEL_TABLEATTRIBUTES_Iconposition");
               Dvpanel_tableattributes_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Autoscroll"));
               Dvpanel_tableattributes_Visible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEATTRIBUTES_Visible"));
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = "hsh" + "BR_Procedure_Surgery";
               A320BR_Procedure_SurgeryID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_SurgeryID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_procedure_surgery:[SecurityCheckFailed value for]"+"BR_Procedure_SurgeryID:"+context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_procedure_surgery:[SecurityCheckFailed value for]"+"Insert_BR_ProcedureID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_procedure_surgery:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A320BR_Procedure_SurgeryID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
                  {
                     sMode37 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode37;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound37 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_100( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_PROCEDURE_SURGERYID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Procedure_SurgeryID_Internalname;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11102 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12102 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( StringUtil.StrCmp(Gx_mode, "DSP") != 0 )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12102 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1037( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
            if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
            {
               bttBtntrn_enter_Visible = 0;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
            }
            DisableAttributes1037( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_100( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1037( ) ;
            }
            else
            {
               CheckExtendedTable1037( ) ;
               CloseExtendedTableCursors1037( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption100( )
      {
      }

      protected void E11102( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Surgery", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Surgery", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_ProcedureID") == 0 )
               {
                  AV13Insert_BR_ProcedureID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_ProcedureID), 18, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
         edtBR_Procedure_SurgeryID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_SurgeryID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_SurgeryID_Visible), 5, 0)), true);
         edtBR_ProcedureID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Visible), 5, 0)), true);
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure_Surgery", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
      }

      protected void E12102( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_procedure_surgeryww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM1037( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z321BR_Procedure_Surgery_Name = T00103_A321BR_Procedure_Surgery_Name[0];
               Z322BR_Procedure_Surgery_Loc = T00103_A322BR_Procedure_Surgery_Loc[0];
               Z139BR_ProcedureID = T00103_A139BR_ProcedureID[0];
            }
            else
            {
               Z321BR_Procedure_Surgery_Name = A321BR_Procedure_Surgery_Name;
               Z322BR_Procedure_Surgery_Loc = A322BR_Procedure_Surgery_Loc;
               Z139BR_ProcedureID = A139BR_ProcedureID;
            }
         }
         if ( GX_JID == -12 )
         {
            Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
            Z321BR_Procedure_Surgery_Name = A321BR_Procedure_Surgery_Name;
            Z322BR_Procedure_Surgery_Loc = A322BR_Procedure_Surgery_Loc;
            Z139BR_ProcedureID = A139BR_ProcedureID;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_Procedure_SurgeryID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_SurgeryID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_SurgeryID_Enabled), 5, 0)), true);
         edtBR_Procedure_SurgeryID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_SurgeryID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_SurgeryID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Procedure_SurgeryID) )
         {
            A320BR_Procedure_SurgeryID = AV7BR_Procedure_SurgeryID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_ProcedureID) )
         {
            edtBR_ProcedureID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_ProcedureID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_ProcedureID) )
         {
            A139BR_ProcedureID = AV13Insert_BR_ProcedureID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         }
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_enter_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Enabled), 5, 0)), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV17Pgmname = "BR_Procedure_Surgery";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         }
      }

      protected void Load1037( )
      {
         /* Using cursor T00105 */
         pr_default.execute(3, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound37 = 1;
            A321BR_Procedure_Surgery_Name = T00105_A321BR_Procedure_Surgery_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321BR_Procedure_Surgery_Name", A321BR_Procedure_Surgery_Name);
            n321BR_Procedure_Surgery_Name = T00105_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = T00105_A322BR_Procedure_Surgery_Loc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322BR_Procedure_Surgery_Loc", A322BR_Procedure_Surgery_Loc);
            n322BR_Procedure_Surgery_Loc = T00105_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = T00105_A139BR_ProcedureID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
            ZM1037( -12) ;
         }
         pr_default.close(3);
         OnLoadActions1037( ) ;
      }

      protected void OnLoadActions1037( )
      {
         AV17Pgmname = "BR_Procedure_Surgery";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
      }

      protected void CheckExtendedTable1037( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "BR_Procedure_Surgery";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         /* Using cursor T00104 */
         pr_default.execute(2, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T19'", "ForeignKeyNotFound", 1, "BR_PROCEDUREID");
            AnyError = 1;
            GX_FocusControl = edtBR_ProcedureID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A321BR_Procedure_Surgery_Name)) )
         {
            GX_msglist.addItem("手术名称是必须填写的。", 1, "BR_PROCEDURE_SURGERY_NAME");
            AnyError = 1;
            GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1037( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_13( long A139BR_ProcedureID )
      {
         /* Using cursor T00106 */
         pr_default.execute(4, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("不匹配' T19'", "ForeignKeyNotFound", 1, "BR_PROCEDUREID");
            AnyError = 1;
            GX_FocusControl = edtBR_ProcedureID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey1037( )
      {
         /* Using cursor T00107 */
         pr_default.execute(5, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound37 = 1;
         }
         else
         {
            RcdFound37 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00103 */
         pr_default.execute(1, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1037( 12) ;
            RcdFound37 = 1;
            A320BR_Procedure_SurgeryID = T00103_A320BR_Procedure_SurgeryID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
            A321BR_Procedure_Surgery_Name = T00103_A321BR_Procedure_Surgery_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321BR_Procedure_Surgery_Name", A321BR_Procedure_Surgery_Name);
            n321BR_Procedure_Surgery_Name = T00103_n321BR_Procedure_Surgery_Name[0];
            A322BR_Procedure_Surgery_Loc = T00103_A322BR_Procedure_Surgery_Loc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322BR_Procedure_Surgery_Loc", A322BR_Procedure_Surgery_Loc);
            n322BR_Procedure_Surgery_Loc = T00103_n322BR_Procedure_Surgery_Loc[0];
            A139BR_ProcedureID = T00103_A139BR_ProcedureID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
            Z320BR_Procedure_SurgeryID = A320BR_Procedure_SurgeryID;
            sMode37 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1037( ) ;
            if ( AnyError == 1 )
            {
               RcdFound37 = 0;
               InitializeNonKey1037( ) ;
            }
            Gx_mode = sMode37;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound37 = 0;
            InitializeNonKey1037( ) ;
            sMode37 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode37;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1037( ) ;
         if ( RcdFound37 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound37 = 0;
         /* Using cursor T00108 */
         pr_default.execute(6, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00108_A320BR_Procedure_SurgeryID[0] < A320BR_Procedure_SurgeryID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00108_A320BR_Procedure_SurgeryID[0] > A320BR_Procedure_SurgeryID ) ) )
            {
               A320BR_Procedure_SurgeryID = T00108_A320BR_Procedure_SurgeryID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
               RcdFound37 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound37 = 0;
         /* Using cursor T00109 */
         pr_default.execute(7, new Object[] {A320BR_Procedure_SurgeryID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00109_A320BR_Procedure_SurgeryID[0] > A320BR_Procedure_SurgeryID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00109_A320BR_Procedure_SurgeryID[0] < A320BR_Procedure_SurgeryID ) ) )
            {
               A320BR_Procedure_SurgeryID = T00109_A320BR_Procedure_SurgeryID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
               RcdFound37 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1037( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1037( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound37 == 1 )
            {
               if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
               {
                  A320BR_Procedure_SurgeryID = Z320BR_Procedure_SurgeryID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_PROCEDURE_SURGERYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Procedure_SurgeryID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update1037( ) ;
                  GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1037( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_PROCEDURE_SURGERYID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Procedure_SurgeryID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1037( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A320BR_Procedure_SurgeryID != Z320BR_Procedure_SurgeryID )
         {
            A320BR_Procedure_SurgeryID = Z320BR_Procedure_SurgeryID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_PROCEDURE_SURGERYID");
            AnyError = 1;
            GX_FocusControl = edtBR_Procedure_SurgeryID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Procedure_Surgery_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1037( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00102 */
            pr_default.execute(0, new Object[] {A320BR_Procedure_SurgeryID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure_Surgery"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z321BR_Procedure_Surgery_Name, T00102_A321BR_Procedure_Surgery_Name[0]) != 0 ) || ( StringUtil.StrCmp(Z322BR_Procedure_Surgery_Loc, T00102_A322BR_Procedure_Surgery_Loc[0]) != 0 ) || ( Z139BR_ProcedureID != T00102_A139BR_ProcedureID[0] ) )
            {
               if ( StringUtil.StrCmp(Z321BR_Procedure_Surgery_Name, T00102_A321BR_Procedure_Surgery_Name[0]) != 0 )
               {
                  GXUtil.WriteLog("br_procedure_surgery:[seudo value changed for attri]"+"BR_Procedure_Surgery_Name");
                  GXUtil.WriteLogRaw("Old: ",Z321BR_Procedure_Surgery_Name);
                  GXUtil.WriteLogRaw("Current: ",T00102_A321BR_Procedure_Surgery_Name[0]);
               }
               if ( StringUtil.StrCmp(Z322BR_Procedure_Surgery_Loc, T00102_A322BR_Procedure_Surgery_Loc[0]) != 0 )
               {
                  GXUtil.WriteLog("br_procedure_surgery:[seudo value changed for attri]"+"BR_Procedure_Surgery_Loc");
                  GXUtil.WriteLogRaw("Old: ",Z322BR_Procedure_Surgery_Loc);
                  GXUtil.WriteLogRaw("Current: ",T00102_A322BR_Procedure_Surgery_Loc[0]);
               }
               if ( Z139BR_ProcedureID != T00102_A139BR_ProcedureID[0] )
               {
                  GXUtil.WriteLog("br_procedure_surgery:[seudo value changed for attri]"+"BR_ProcedureID");
                  GXUtil.WriteLogRaw("Old: ",Z139BR_ProcedureID);
                  GXUtil.WriteLogRaw("Current: ",T00102_A139BR_ProcedureID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Procedure_Surgery"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1037( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1037( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1037( 0) ;
            CheckOptimisticConcurrency1037( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1037( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1037( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001010 */
                     pr_default.execute(8, new Object[] {n321BR_Procedure_Surgery_Name, A321BR_Procedure_Surgery_Name, n322BR_Procedure_Surgery_Loc, A322BR_Procedure_Surgery_Loc, A139BR_ProcedureID});
                     A320BR_Procedure_SurgeryID = T001010_A320BR_Procedure_SurgeryID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption100( ) ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load1037( ) ;
            }
            EndLevel1037( ) ;
         }
         CloseExtendedTableCursors1037( ) ;
      }

      protected void Update1037( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1037( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1037( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1037( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1037( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001011 */
                     pr_default.execute(9, new Object[] {n321BR_Procedure_Surgery_Name, A321BR_Procedure_Surgery_Name, n322BR_Procedure_Surgery_Loc, A322BR_Procedure_Surgery_Loc, A139BR_ProcedureID, A320BR_Procedure_SurgeryID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure_Surgery"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1037( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Update",  1) ;
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel1037( ) ;
         }
         CloseExtendedTableCursors1037( ) ;
      }

      protected void DeferredUpdate1037( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1037( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1037( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1037( ) ;
            AfterConfirm1037( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1037( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001012 */
                  pr_default.execute(10, new Object[] {A320BR_Procedure_SurgeryID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure_Surgery") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Delete",  1) ;
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        if ( ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
                        {
                           if ( AnyError == 0 )
                           {
                              context.nUserReturn = 1;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode37 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1037( ) ;
         Gx_mode = sMode37;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1037( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Procedure_Surgery";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         }
      }

      protected void EndLevel1037( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1037( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("br_procedure_surgery",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues100( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("br_procedure_surgery",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1037( )
      {
         /* Scan By routine */
         /* Using cursor T001013 */
         pr_default.execute(11);
         RcdFound37 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound37 = 1;
            A320BR_Procedure_SurgeryID = T001013_A320BR_Procedure_SurgeryID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1037( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound37 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound37 = 1;
            A320BR_Procedure_SurgeryID = T001013_A320BR_Procedure_SurgeryID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
         }
      }

      protected void ScanEnd1037( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm1037( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1037( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate1037( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete1037( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1037( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1037( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1037( )
      {
         edtBR_Procedure_Surgery_Name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Surgery_Name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_Surgery_Name_Enabled), 5, 0)), true);
         edtBR_Procedure_Surgery_Loc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Surgery_Loc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_Surgery_Loc_Enabled), 5, 0)), true);
         edtBR_Procedure_SurgeryID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_SurgeryID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_SurgeryID_Enabled), 5, 0)), true);
         edtBR_ProcedureID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1037( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues100( )
      {
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
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022711574236", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedure_surgery.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Procedure_SurgeryID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Procedure_Surgery";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_procedure_surgery:[SendSecurityCheck value for]"+"BR_Procedure_SurgeryID:"+context.localUtil.Format( (decimal)(A320BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_procedure_surgery:[SendSecurityCheck value for]"+"Insert_BR_ProcedureID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_procedure_surgery:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z320BR_Procedure_SurgeryID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z321BR_Procedure_Surgery_Name", Z321BR_Procedure_Surgery_Name);
         GxWebStd.gx_hidden_field( context, "Z322BR_Procedure_Surgery_Loc", Z322BR_Procedure_Surgery_Loc);
         GxWebStd.gx_hidden_field( context, "Z139BR_ProcedureID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z139BR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N139BR_ProcedureID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_PROCEDURE_SURGERYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Procedure_SurgeryID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PROCEDURE_SURGERYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Procedure_SurgeryID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Objectcall", StringUtil.RTrim( Dvpanel_tableattributes_Objectcall));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Enabled", StringUtil.BoolToStr( Dvpanel_tableattributes_Enabled));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Width", StringUtil.RTrim( Dvpanel_tableattributes_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Cls", StringUtil.RTrim( Dvpanel_tableattributes_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Title", StringUtil.RTrim( Dvpanel_tableattributes_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsible", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Collapsed", StringUtil.BoolToStr( Dvpanel_tableattributes_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autowidth", StringUtil.BoolToStr( Dvpanel_tableattributes_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoheight", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableattributes_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Iconposition", StringUtil.RTrim( Dvpanel_tableattributes_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEATTRIBUTES_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableattributes_Autoscroll));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
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

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_procedure_surgery.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Procedure_SurgeryID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Procedure_Surgery" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey1037( )
      {
         A139BR_ProcedureID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         A321BR_Procedure_Surgery_Name = "";
         n321BR_Procedure_Surgery_Name = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A321BR_Procedure_Surgery_Name", A321BR_Procedure_Surgery_Name);
         n321BR_Procedure_Surgery_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A321BR_Procedure_Surgery_Name)) ? true : false);
         A322BR_Procedure_Surgery_Loc = "";
         n322BR_Procedure_Surgery_Loc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A322BR_Procedure_Surgery_Loc", A322BR_Procedure_Surgery_Loc);
         n322BR_Procedure_Surgery_Loc = (String.IsNullOrEmpty(StringUtil.RTrim( A322BR_Procedure_Surgery_Loc)) ? true : false);
         Z321BR_Procedure_Surgery_Name = "";
         Z322BR_Procedure_Surgery_Loc = "";
         Z139BR_ProcedureID = 0;
      }

      protected void InitAll1037( )
      {
         A320BR_Procedure_SurgeryID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A320BR_Procedure_SurgeryID", StringUtil.LTrim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)));
         InitializeNonKey1037( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711574257", true);
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
         context.AddJavascriptSource("br_procedure_surgery.js", "?202022711574257", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_procedure_surgery_name_Internalname = "TEXTBLOCKBR_PROCEDURE_SURGERY_NAME";
         edtBR_Procedure_Surgery_Name_Internalname = "BR_PROCEDURE_SURGERY_NAME";
         divUnnamedtablebr_procedure_surgery_name_Internalname = "UNNAMEDTABLEBR_PROCEDURE_SURGERY_NAME";
         lblTextblockbr_procedure_surgery_loc_Internalname = "TEXTBLOCKBR_PROCEDURE_SURGERY_LOC";
         edtBR_Procedure_Surgery_Loc_Internalname = "BR_PROCEDURE_SURGERY_LOC";
         divUnnamedtablebr_procedure_surgery_loc_Internalname = "UNNAMEDTABLEBR_PROCEDURE_SURGERY_LOC";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Procedure_SurgeryID_Internalname = "BR_PROCEDURE_SURGERYID";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_ProcedureID_Enabled = 1;
         edtBR_ProcedureID_Visible = 1;
         edtBR_Procedure_SurgeryID_Jsonclick = "";
         edtBR_Procedure_SurgeryID_Enabled = 0;
         edtBR_Procedure_SurgeryID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Procedure_Surgery_Loc_Jsonclick = "";
         edtBR_Procedure_Surgery_Loc_Enabled = 1;
         edtBR_Procedure_Surgery_Name_Jsonclick = "";
         edtBR_Procedure_Surgery_Name_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "手术信息";
         Dvpanel_tableattributes_Cls = "PanelCard_BaseColor";
         Dvpanel_tableattributes_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableattributes_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Width = "100%";
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void XC_9_1037( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Create",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_10_1037( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Update",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_11_1037( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  StringUtil.Trim( StringUtil.Str( (decimal)(A320BR_Procedure_SurgeryID), 18, 0)),  "手术信息",  "Delete",  1) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      public void Valid_Br_procedureid( long GX_Parm1 )
      {
         A139BR_ProcedureID = GX_Parm1;
         /* Using cursor T001014 */
         pr_default.execute(12, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            GX_msglist.addItem("不匹配' T19'", "ForeignKeyNotFound", 1, "BR_PROCEDUREID");
            AnyError = 1;
            GX_FocusControl = edtBR_ProcedureID_Internalname;
         }
         pr_default.close(12);
         dynload_actions( ) ;
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Procedure_SurgeryID',fld:'vBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Procedure_SurgeryID',fld:'vBR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A320BR_Procedure_SurgeryID',fld:'BR_PROCEDURE_SURGERYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_ProcedureID',fld:'vINSERT_BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12102',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
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
         pr_default.close(1);
         pr_default.close(12);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z321BR_Procedure_Surgery_Name = "";
         Z322BR_Procedure_Surgery_Loc = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_procedure_surgery_name_Jsonclick = "";
         TempTags = "";
         A321BR_Procedure_Surgery_Name = "";
         lblTextblockbr_procedure_surgery_loc_Jsonclick = "";
         A322BR_Procedure_Surgery_Loc = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV17Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode37 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T00105_A320BR_Procedure_SurgeryID = new long[1] ;
         T00105_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         T00105_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         T00105_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         T00105_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         T00105_A139BR_ProcedureID = new long[1] ;
         T00104_A139BR_ProcedureID = new long[1] ;
         T00106_A139BR_ProcedureID = new long[1] ;
         T00107_A320BR_Procedure_SurgeryID = new long[1] ;
         T00103_A320BR_Procedure_SurgeryID = new long[1] ;
         T00103_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         T00103_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         T00103_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         T00103_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         T00103_A139BR_ProcedureID = new long[1] ;
         T00108_A320BR_Procedure_SurgeryID = new long[1] ;
         T00109_A320BR_Procedure_SurgeryID = new long[1] ;
         T00102_A320BR_Procedure_SurgeryID = new long[1] ;
         T00102_A321BR_Procedure_Surgery_Name = new String[] {""} ;
         T00102_n321BR_Procedure_Surgery_Name = new bool[] {false} ;
         T00102_A322BR_Procedure_Surgery_Loc = new String[] {""} ;
         T00102_n322BR_Procedure_Surgery_Loc = new bool[] {false} ;
         T00102_A139BR_ProcedureID = new long[1] ;
         T001010_A320BR_Procedure_SurgeryID = new long[1] ;
         T001013_A320BR_Procedure_SurgeryID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T001014_A139BR_ProcedureID = new long[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgery__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_surgery__default(),
            new Object[][] {
                new Object[] {
               T00102_A320BR_Procedure_SurgeryID, T00102_A321BR_Procedure_Surgery_Name, T00102_n321BR_Procedure_Surgery_Name, T00102_A322BR_Procedure_Surgery_Loc, T00102_n322BR_Procedure_Surgery_Loc, T00102_A139BR_ProcedureID
               }
               , new Object[] {
               T00103_A320BR_Procedure_SurgeryID, T00103_A321BR_Procedure_Surgery_Name, T00103_n321BR_Procedure_Surgery_Name, T00103_A322BR_Procedure_Surgery_Loc, T00103_n322BR_Procedure_Surgery_Loc, T00103_A139BR_ProcedureID
               }
               , new Object[] {
               T00104_A139BR_ProcedureID
               }
               , new Object[] {
               T00105_A320BR_Procedure_SurgeryID, T00105_A321BR_Procedure_Surgery_Name, T00105_n321BR_Procedure_Surgery_Name, T00105_A322BR_Procedure_Surgery_Loc, T00105_n322BR_Procedure_Surgery_Loc, T00105_A139BR_ProcedureID
               }
               , new Object[] {
               T00106_A139BR_ProcedureID
               }
               , new Object[] {
               T00107_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               T00108_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               T00109_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               T001010_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001013_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               T001014_A139BR_ProcedureID
               }
            }
         );
         AV17Pgmname = "BR_Procedure_Surgery";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound37 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Procedure_Surgery_Name_Enabled ;
      private int edtBR_Procedure_Surgery_Loc_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Procedure_SurgeryID_Enabled ;
      private int edtBR_Procedure_SurgeryID_Visible ;
      private int edtBR_ProcedureID_Visible ;
      private int edtBR_ProcedureID_Enabled ;
      private int AV18GXV1 ;
      private int idxLst ;
      private long wcpOAV7BR_Procedure_SurgeryID ;
      private long Z320BR_Procedure_SurgeryID ;
      private long Z139BR_ProcedureID ;
      private long N139BR_ProcedureID ;
      private long A139BR_ProcedureID ;
      private long AV7BR_Procedure_SurgeryID ;
      private long A320BR_Procedure_SurgeryID ;
      private long AV13Insert_BR_ProcedureID ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBR_Procedure_Surgery_Name_Internalname ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String divTablecontent_Internalname ;
      private String divHtml_dvpanel_tableattributes_Internalname ;
      private String Dvpanel_tableattributes_Width ;
      private String Dvpanel_tableattributes_Cls ;
      private String Dvpanel_tableattributes_Title ;
      private String Dvpanel_tableattributes_Iconposition ;
      private String Dvpanel_tableattributes_Internalname ;
      private String divLayout_tableattributes_Internalname ;
      private String divTableattributes_Internalname ;
      private String divUnnamedtablebr_procedure_surgery_name_Internalname ;
      private String lblTextblockbr_procedure_surgery_name_Internalname ;
      private String lblTextblockbr_procedure_surgery_name_Jsonclick ;
      private String TempTags ;
      private String edtBR_Procedure_Surgery_Name_Jsonclick ;
      private String divUnnamedtablebr_procedure_surgery_loc_Internalname ;
      private String lblTextblockbr_procedure_surgery_loc_Internalname ;
      private String lblTextblockbr_procedure_surgery_loc_Jsonclick ;
      private String edtBR_Procedure_Surgery_Loc_Internalname ;
      private String edtBR_Procedure_Surgery_Loc_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Procedure_SurgeryID_Internalname ;
      private String edtBR_Procedure_SurgeryID_Jsonclick ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String AV17Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode37 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n321BR_Procedure_Surgery_Name ;
      private bool n322BR_Procedure_Surgery_Loc ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool AV15TempBoolean ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private String Z321BR_Procedure_Surgery_Name ;
      private String Z322BR_Procedure_Surgery_Loc ;
      private String A321BR_Procedure_Surgery_Name ;
      private String A322BR_Procedure_Surgery_Loc ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T00105_A320BR_Procedure_SurgeryID ;
      private String[] T00105_A321BR_Procedure_Surgery_Name ;
      private bool[] T00105_n321BR_Procedure_Surgery_Name ;
      private String[] T00105_A322BR_Procedure_Surgery_Loc ;
      private bool[] T00105_n322BR_Procedure_Surgery_Loc ;
      private long[] T00105_A139BR_ProcedureID ;
      private long[] T00104_A139BR_ProcedureID ;
      private long[] T00106_A139BR_ProcedureID ;
      private long[] T00107_A320BR_Procedure_SurgeryID ;
      private long[] T00103_A320BR_Procedure_SurgeryID ;
      private String[] T00103_A321BR_Procedure_Surgery_Name ;
      private bool[] T00103_n321BR_Procedure_Surgery_Name ;
      private String[] T00103_A322BR_Procedure_Surgery_Loc ;
      private bool[] T00103_n322BR_Procedure_Surgery_Loc ;
      private long[] T00103_A139BR_ProcedureID ;
      private long[] T00108_A320BR_Procedure_SurgeryID ;
      private long[] T00109_A320BR_Procedure_SurgeryID ;
      private long[] T00102_A320BR_Procedure_SurgeryID ;
      private String[] T00102_A321BR_Procedure_Surgery_Name ;
      private bool[] T00102_n321BR_Procedure_Surgery_Name ;
      private String[] T00102_A322BR_Procedure_Surgery_Loc ;
      private bool[] T00102_n322BR_Procedure_Surgery_Loc ;
      private long[] T00102_A139BR_ProcedureID ;
      private long[] T001010_A320BR_Procedure_SurgeryID ;
      private long[] T001013_A320BR_Procedure_SurgeryID ;
      private long[] T001014_A139BR_ProcedureID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_procedure_surgery__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_procedure_surgery__default : DataStoreHelperBase, IDataStoreHelper
 {
    public ICursor[] getCursors( )
    {
       cursorDefinitions();
       return new Cursor[] {
        new ForEachCursor(def[0])
       ,new ForEachCursor(def[1])
       ,new ForEachCursor(def[2])
       ,new ForEachCursor(def[3])
       ,new ForEachCursor(def[4])
       ,new ForEachCursor(def[5])
       ,new ForEachCursor(def[6])
       ,new ForEachCursor(def[7])
       ,new ForEachCursor(def[8])
       ,new UpdateCursor(def[9])
       ,new UpdateCursor(def[10])
       ,new ForEachCursor(def[11])
       ,new ForEachCursor(def[12])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00105 ;
        prmT00105 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00104 ;
        prmT00104 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00106 ;
        prmT00106 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00107 ;
        prmT00107 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00103 ;
        prmT00103 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00108 ;
        prmT00108 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00109 ;
        prmT00109 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00102 ;
        prmT00102 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001010 ;
        prmT001010 = new Object[] {
        new Object[] {"@BR_Procedure_Surgery_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Procedure_Surgery_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001011 ;
        prmT001011 = new Object[] {
        new Object[] {"@BR_Procedure_Surgery_Name",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Procedure_Surgery_Loc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001012 ;
        prmT001012 = new Object[] {
        new Object[] {"@BR_Procedure_SurgeryID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001013 ;
        prmT001013 = new Object[] {
        } ;
        Object[] prmT001014 ;
        prmT001014 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00102", "SELECT [BR_Procedure_SurgeryID], [BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID] FROM [BR_Procedure_Surgery] WITH (UPDLOCK) WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00102,1,0,true,false )
           ,new CursorDef("T00103", "SELECT [BR_Procedure_SurgeryID], [BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00103,1,0,true,false )
           ,new CursorDef("T00104", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00104,1,0,true,false )
           ,new CursorDef("T00105", "SELECT TM1.[BR_Procedure_SurgeryID], TM1.[BR_Procedure_Surgery_Name], TM1.[BR_Procedure_Surgery_Loc], TM1.[BR_ProcedureID] FROM [BR_Procedure_Surgery] TM1 WITH (NOLOCK) WHERE TM1.[BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID ORDER BY TM1.[BR_Procedure_SurgeryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00105,100,0,true,false )
           ,new CursorDef("T00106", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00106,1,0,true,false )
           ,new CursorDef("T00107", "SELECT [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00107,1,0,true,false )
           ,new CursorDef("T00108", "SELECT TOP 1 [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE ( [BR_Procedure_SurgeryID] > @BR_Procedure_SurgeryID) ORDER BY [BR_Procedure_SurgeryID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00108,1,0,true,true )
           ,new CursorDef("T00109", "SELECT TOP 1 [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE ( [BR_Procedure_SurgeryID] < @BR_Procedure_SurgeryID) ORDER BY [BR_Procedure_SurgeryID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00109,1,0,true,true )
           ,new CursorDef("T001010", "INSERT INTO [BR_Procedure_Surgery]([BR_Procedure_Surgery_Name], [BR_Procedure_Surgery_Loc], [BR_ProcedureID]) VALUES(@BR_Procedure_Surgery_Name, @BR_Procedure_Surgery_Loc, @BR_ProcedureID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT001010)
           ,new CursorDef("T001011", "UPDATE [BR_Procedure_Surgery] SET [BR_Procedure_Surgery_Name]=@BR_Procedure_Surgery_Name, [BR_Procedure_Surgery_Loc]=@BR_Procedure_Surgery_Loc, [BR_ProcedureID]=@BR_ProcedureID  WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID", GxErrorMask.GX_NOMASK,prmT001011)
           ,new CursorDef("T001012", "DELETE FROM [BR_Procedure_Surgery]  WHERE [BR_Procedure_SurgeryID] = @BR_Procedure_SurgeryID", GxErrorMask.GX_NOMASK,prmT001012)
           ,new CursorDef("T001013", "SELECT [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) ORDER BY [BR_Procedure_SurgeryID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001013,100,0,true,false )
           ,new CursorDef("T001014", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001014,1,0,true,false )
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 12 :
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
           case 1 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 2 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 3 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 4 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 5 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 6 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
              return;
           case 9 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(1, (String)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
              stmt.SetParameter(4, (long)parms[5]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
