/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:6:19.43
*/
gx.evt.autoSkip = false;
gx.define('br_choosetenent', false, function () {
   this.ServerClass =  "br_choosetenent" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = false;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV36tUserType=gx.fn.getControlValue("vTUSERTYPE") ;
      this.A401BAS_TenantIsDeleted=gx.fn.getIntegerValue("BAS_TENANTISDELETED",',') ;
      this.A395HospitalName=gx.fn.getControlValue("HOSPITALNAME") ;
      this.A360BAS_TenantTenantCode=gx.fn.getControlValue("BAS_TENANTTENANTCODE") ;
      this.AV12iTenantsCode=gx.fn.getControlValue("vITENANTSCODE") ;
      this.AV28iReturnUrl=gx.fn.getControlValue("vIRETURNURL") ;
      this.AV36tUserType=gx.fn.getControlValue("vTUSERTYPE") ;
      this.A401BAS_TenantIsDeleted=gx.fn.getIntegerValue("BAS_TENANTISDELETED",',') ;
      this.A395HospitalName=gx.fn.getControlValue("HOSPITALNAME") ;
      this.A360BAS_TenantTenantCode=gx.fn.getControlValue("BAS_TENANTTENANTCODE") ;
      this.AV12iTenantsCode=gx.fn.getControlValue("vITENANTSCODE") ;
   };
   this.e117l2_client=function()
   {
      return this.executeServerEvent("HOSPITALDISTRICT.CLICK", true, arguments[0], false, true);
   };
   this.e147l2_client=function()
   {
      return this.executeServerEvent("ENTER", true, arguments[0], false, false);
   };
   this.e157l2_client=function()
   {
      return this.executeServerEvent("CANCEL", true, arguments[0], false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,34,35,36,37];
   this.GXLastCtrlId =37;
   this.TenentsshowContainer = new gx.grid.grid(this, 2,"WbpLvl2",15,"Tenentsshow","Tenentsshow","TenentsshowContainer",this.CmpContext,this.IsMasterPage,"br_choosetenent",[],true,1,true,true,0,false,false,false,"",0,"px",0,"px","澧炲姞绌虹櫧琛?,false,false,false,null,null,false,"",true,[1,1,1,1],false,0,false,false);
   var TenentsshowContainer = this.TenentsshowContainer;
   TenentsshowContainer.startDiv(16,"Unnamedtablefstenentsshow","0px","0px");
   TenentsshowContainer.startDiv(17,"","0px","0px");
   TenentsshowContainer.startDiv(18,"","0px","0px");
   TenentsshowContainer.startDiv(19,"Hospitaldistrict","0px","0px");
   TenentsshowContainer.startDiv(20,"","0px","0px");
   TenentsshowContainer.startDiv(21,"","0px","0px");
   TenentsshowContainer.startDiv(22,"Unnamedtablevhosiptalname","0px","0px");
   TenentsshowContainer.startDiv(23,"","0px","0px");
   TenentsshowContainer.startDiv(24,"","0px","0px");
   TenentsshowContainer.addTextBlock('TEXTBLOCKVHOSIPTALNAME',null,25);
   TenentsshowContainer.endDiv();
   TenentsshowContainer.startDiv(26,"","0px","0px");
   TenentsshowContainer.startDiv(27,"","0px","0px");
   TenentsshowContainer.addLabel();
   TenentsshowContainer.addMultipleLineEdit("Vhosiptalname",28,"vVHOSIPTALNAME","","vHosiptalName","svchar",80,"chr",5,"row","400",400,"left",null,true,false,0,"");
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.startDiv(29,"","0px","0px");
   TenentsshowContainer.startDiv(30,"","0px","0px");
   TenentsshowContainer.startTable("Unnamedtablecontentfstenentsshow",31,"0px");
   TenentsshowContainer.startRow("","","","","","");
   TenentsshowContainer.startCell("","","","","","","","","","");
   TenentsshowContainer.startDiv(34,"","0px","0px");
   TenentsshowContainer.addLabel();
   TenentsshowContainer.addSingleLineEdit("Vcode",35,"vVCODE","","","vCode","svchar",80,"chr",100,80,"left",null,[],"Vcode","vCode",true,0,false,false,"Attribute",1,"");
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endCell();
   TenentsshowContainer.endRow();
   TenentsshowContainer.endTable();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   TenentsshowContainer.endDiv();
   this.TenentsshowContainer.emptyText = "";
   this.setGrid(TenentsshowContainer);
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TABLECONTENT",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"CHOOSETENANT", format:0,grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[16]={ id: 16, fld:"UNNAMEDTABLEFSTENENTSSHOW",grid:15};
   GXValidFnc[17]={ id: 17, fld:"",grid:15};
   GXValidFnc[18]={ id: 18, fld:"",grid:15};
   GXValidFnc[19]={ id: 19, fld:"HOSPITALDISTRICT",grid:15,evt:"e117l2_client"};
   GXValidFnc[20]={ id: 20, fld:"",grid:15};
   GXValidFnc[21]={ id: 21, fld:"",grid:15};
   GXValidFnc[22]={ id: 22, fld:"UNNAMEDTABLEVHOSIPTALNAME",grid:15};
   GXValidFnc[23]={ id: 23, fld:"",grid:15};
   GXValidFnc[24]={ id: 24, fld:"",grid:15};
   GXValidFnc[25]={ id: 25, fld:"TEXTBLOCKVHOSIPTALNAME", format:0,grid:15};
   GXValidFnc[26]={ id: 26, fld:"",grid:15};
   GXValidFnc[27]={ id: 27, fld:"",grid:15};
   GXValidFnc[28]={ id:28 ,lvl:2,type:"svchar",len:400,dec:0,sign:false,ro:1,isacc:0, multiline:true,grid:15,gxgrid:this.TenentsshowContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVHOSIPTALNAME",gxz:"ZV7vHosiptalName",gxold:"OV7vHosiptalName",gxvar:"AV7vHosiptalName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV7vHosiptalName=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV7vHosiptalName=Value},v2c:function(row){gx.fn.setGridControlValue("vVHOSIPTALNAME",row || gx.fn.currentGridRowImpl(15),gx.O.AV7vHosiptalName,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV7vHosiptalName=this.val()},val:function(row){return gx.fn.getGridControlValue("vVHOSIPTALNAME",row || gx.fn.currentGridRowImpl(15))},nac:gx.falseFn};
   GXValidFnc[29]={ id: 29, fld:"",grid:15};
   GXValidFnc[30]={ id: 30, fld:"",grid:15};
   GXValidFnc[31]={ id: 31, fld:"UNNAMEDTABLECONTENTFSTENENTSSHOW",grid:15};
   GXValidFnc[34]={ id: 34, fld:"",grid:15};
   GXValidFnc[35]={ id:35 ,lvl:2,type:"svchar",len:100,dec:0,sign:false,ro:1,isacc:0,grid:15,gxgrid:this.TenentsshowContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vVCODE",gxz:"ZV19vCode",gxold:"OV19vCode",gxvar:"AV19vCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:'text',autoCorrect:"1",v2v:function(Value){if(Value!==undefined)gx.O.AV19vCode=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19vCode=Value},v2c:function(row){gx.fn.setGridControlValue("vVCODE",row || gx.fn.currentGridRowImpl(15),gx.O.AV19vCode,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19vCode=this.val()},val:function(row){return gx.fn.getGridControlValue("vVCODE",row || gx.fn.currentGridRowImpl(15))},nac:gx.falseFn};
   GXValidFnc[36]={ id: 36, fld:"",grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   this.ZV7vHosiptalName = "" ;
   this.OV7vHosiptalName = "" ;
   this.ZV19vCode = "" ;
   this.OV19vCode = "" ;
   this.AV28iReturnUrl = "" ;
   this.AV7vHosiptalName = "" ;
   this.AV19vCode = "" ;
   this.A401BAS_TenantIsDeleted = 0 ;
   this.A395HospitalName = "" ;
   this.A360BAS_TenantTenantCode = "" ;
   this.AV36tUserType = "" ;
   this.AV12iTenantsCode = [ ] ;
   this.Events = {"e117l2_client": ["HOSPITALDISTRICT.CLICK", true] ,"e147l2_client": ["ENTER", true] ,"e157l2_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'TENENTSSHOW_nFirstRecordOnPage'},{av:'TENENTSSHOW_nEOF'},{av:'gx.fn.getCtrlProperty("vVCODE","Visible")',ctrl:'vVCODE',prop:'Visible'},{av:'A401BAS_TenantIsDeleted',fld:'BAS_TENANTISDELETED',pic:'9'},{av:'A395HospitalName',fld:'HOSPITALNAME',pic:''},{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:''},{av:'AV12iTenantsCode',fld:'vITENANTSCODE',pic:''},{av:'AV28iReturnUrl',fld:'vIRETURNURL',pic:'',hsh:true},{av:'AV36tUserType',fld:'vTUSERTYPE',pic:'',hsh:true}],[]];
   this.EvtParms["START"] = [[],[{av:'AV12iTenantsCode',fld:'vITENANTSCODE',pic:''},{av:'AV36tUserType',fld:'vTUSERTYPE',pic:'',hsh:true},{av:'gx.fn.getCtrlProperty("vVCODE","Visible")',ctrl:'vVCODE',prop:'Visible'}]];
   this.EvtParms["TENENTSSHOW.LOAD"] = [[{av:'AV36tUserType',fld:'vTUSERTYPE',pic:'',hsh:true},{av:'A401BAS_TenantIsDeleted',fld:'BAS_TENANTISDELETED',pic:'9'},{av:'A395HospitalName',fld:'HOSPITALNAME',pic:''},{av:'A360BAS_TenantTenantCode',fld:'BAS_TENANTTENANTCODE',pic:''},{av:'AV12iTenantsCode',fld:'vITENANTSCODE',pic:''}],[{av:'AV7vHosiptalName',fld:'vVHOSIPTALNAME',pic:''},{av:'AV19vCode',fld:'vVCODE',pic:''}]];
   this.EvtParms["HOSPITALDISTRICT.CLICK"] = [[{av:'AV19vCode',fld:'vVCODE',pic:''},{av:'AV28iReturnUrl',fld:'vIRETURNURL',pic:'',hsh:true}],[]];
   this.setVCMap("AV36tUserType", "vTUSERTYPE", 0, "svchar", 40, 0);
   this.setVCMap("A401BAS_TenantIsDeleted", "BAS_TENANTISDELETED", 0, "int", 1, 0);
   this.setVCMap("A395HospitalName", "HOSPITALNAME", 0, "svchar", 200, 0);
   this.setVCMap("A360BAS_TenantTenantCode", "BAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("AV12iTenantsCode", "vITENANTSCODE", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV28iReturnUrl", "vIRETURNURL", 0, "svchar", 1000, 0);
   this.setVCMap("AV36tUserType", "vTUSERTYPE", 0, "svchar", 40, 0);
   this.setVCMap("A401BAS_TenantIsDeleted", "BAS_TENANTISDELETED", 0, "int", 1, 0);
   this.setVCMap("A395HospitalName", "HOSPITALNAME", 0, "svchar", 200, 0);
   this.setVCMap("A360BAS_TenantTenantCode", "BAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("AV12iTenantsCode", "vITENANTSCODE", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV36tUserType", "vTUSERTYPE", 0, "svchar", 40, 0);
   this.setVCMap("A401BAS_TenantIsDeleted", "BAS_TENANTISDELETED", 0, "int", 1, 0);
   this.setVCMap("A395HospitalName", "HOSPITALNAME", 0, "svchar", 200, 0);
   this.setVCMap("A360BAS_TenantTenantCode", "BAS_TENANTTENANTCODE", 0, "svchar", 20, 0);
   this.setVCMap("AV12iTenantsCode", "vITENANTSCODE", 0, "Collsvchar", 0, 0);
   TenentsshowContainer.addRefreshingVar({rfrVar:"AV19vCode", rfrProp:"Visible", gxAttId:"Vcode"});
   TenentsshowContainer.addRefreshingVar({rfrVar:"AV36tUserType"});
   TenentsshowContainer.addRefreshingVar({rfrVar:"A401BAS_TenantIsDeleted"});
   TenentsshowContainer.addRefreshingVar({rfrVar:"A395HospitalName"});
   TenentsshowContainer.addRefreshingVar({rfrVar:"A360BAS_TenantTenantCode"});
   TenentsshowContainer.addRefreshingVar({rfrVar:"AV12iTenantsCode"});
   TenentsshowContainer.addRefreshingVar({rfrVar:"AV28iReturnUrl"});
   this.Initialize( );
});
gx.createParentObj(br_choosetenent);