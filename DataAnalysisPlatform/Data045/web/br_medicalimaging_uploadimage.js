/*!   GeneXus C# 16_0_0-127771 on 2/28/2020 15:7:53.86
*/
gx.evt.autoSkip=!1;gx.define("br_medicalimaging_uploadimage",!0,function(n){var t,i;this.ServerClass="br_medicalimaging_uploadimage";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.A225BR_MedicalImagingID=gx.fn.getIntegerValue("BR_MEDICALIMAGINGID",",")};this.e136r2_client=function(){return this.executeServerEvent("'DOGENERATEQRCODE'",!1,null,!1,!1)};this.e146r2_client=function(){return this.executeServerEvent("'DOLOADIMAGE'",!1,null,!1,!1)};this.e156r2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e166r2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29];this.GXLastCtrlId=29;this.DVPANEL_TABLEHEADERContainer=gx.uc.getNew(this,10,0,"BootstrapPanel",this.CmpContext+"DVPANEL_TABLEHEADERContainer","Dvpanel_tableheader","DVPANEL_TABLEHEADER");i=this.DVPANEL_TABLEHEADERContainer;i.setProp("Class","Class","","char");i.setProp("Enabled","Enabled",!0,"boolean");i.setProp("Width","Width","100%","str");i.setProp("Height","Height","100","str");i.setProp("AutoWidth","Autowidth",!1,"bool");i.setProp("AutoHeight","Autoheight",!0,"bool");i.setProp("Cls","Cls","PanelNoHeader","str");i.setProp("ShowHeader","Showheader",!0,"bool");i.setProp("Title","Title","选项","str");i.setProp("Collapsible","Collapsible",!0,"bool");i.setProp("Collapsed","Collapsed",!1,"bool");i.setProp("ShowCollapseIcon","Showcollapseicon",!1,"bool");i.setProp("IconPosition","Iconposition","left","str");i.setProp("AutoScroll","Autoscroll",!1,"bool");i.setProp("Visible","Visible",!0,"bool");i.setC2ShowFunction(function(n){n.show()});this.setUserControl(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"UNNAMEDTABLE1",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"HTML_DVPANEL_TABLEHEADER",grid:0};t[12]={id:12,fld:"LAYOUT_TABLEHEADER",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"TABLEHEADER",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"TABLEACTIONS",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"BTNGENERATEQRCODE",grid:0};t[23]={id:23,fld:"",grid:0};t[24]={id:24,fld:"BTNLOADIMAGE",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,fld:"",grid:0};t[27]={id:27,fld:"UNNAMEDTABLE2",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"",grid:0};this.A225BR_MedicalImagingID=0;this.Events={e136r2_client:["'DOGENERATEQRCODE'",!0],e146r2_client:["'DOLOADIMAGE'",!0],e156r2_client:["ENTER",!0],e166r2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"A225BR_MedicalImagingID",fld:"BR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ"},{av:"AV20Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_MedicalImagingID",fld:"vBR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[{ctrl:"FCKEDITOR"},{av:'gx.fn.getCtrlProperty("TABLEHEADER","Visible")',ctrl:"TABLEHEADER",prop:"Visible"}]];this.EvtParms.LOAD=[[],[]];this.EvtParms["'DOGENERATEQRCODE'"]=[[{av:"A225BR_MedicalImagingID",fld:"BR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms["'DOLOADIMAGE'"]=[[{av:"A225BR_MedicalImagingID",fld:"BR_MEDICALIMAGINGID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.setVCMap("A225BR_MedicalImagingID","BR_MEDICALIMAGINGID",0,"int",18,0);this.Initialize();this.setComponent({id:"FCKEDITOR",GXClass:null,Prefix:"W0030",lvl:1})})