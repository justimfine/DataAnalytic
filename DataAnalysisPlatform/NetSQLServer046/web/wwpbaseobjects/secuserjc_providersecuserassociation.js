/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 12:1:16.67
*/
gx.evt.autoSkip = false;
gx.define('wwpbaseobjects.secuserjc_providersecuserassociation', false, function () {
   this.ServerClass =  "wwpbaseobjects.secuserjc_providersecuserassociation" ;
   this.PackageName =  "GeneXus.Programs" ;
   this.setObjectType("web");
   this.hasEnterEvent = true;
   this.skipOnEnter = false;
   this.autoRefresh = true;
   this.fullAjax = true;
   this.supportAjaxEvents =  true ;
   this.ajaxSecurityToken =  true ;
   this.SetStandaloneVars=function()
   {
      this.AV21AddedKeyList=gx.fn.getControlValue("vADDEDKEYLIST") ;
      this.AV23AddedDscList=gx.fn.getControlValue("vADDEDDSCLIST") ;
      this.AV22NotAddedKeyList=gx.fn.getControlValue("vNOTADDEDKEYLIST") ;
      this.AV24NotAddedDscList=gx.fn.getControlValue("vNOTADDEDDSCLIST") ;
      this.A6SecUserId=gx.fn.getIntegerValue("SECUSERID",',') ;
      this.AV8SecUserId=gx.fn.getIntegerValue("vSECUSERID",',') ;
      this.A87JC_ProviderID=gx.fn.getIntegerValue("JC_PROVIDERID",',') ;
      this.AV12JC_ProviderSecUser=gx.fn.getControlValue("vJC_PROVIDERSECUSER") ;
      this.AV9JC_ProviderID=gx.fn.getIntegerValue("vJC_PROVIDERID",',') ;
   };
   this.e13482_client=function()
   {
      return this.executeServerEvent("ENTER", true, null, false, false);
   };
   this.e14482_client=function()
   {
      return this.executeServerEvent("'DISASSOCIATE SELECTED'", true, null, false, false);
   };
   this.e15482_client=function()
   {
      return this.executeServerEvent("'ASSOCIATE SELECTED'", true, null, false, false);
   };
   this.e16482_client=function()
   {
      return this.executeServerEvent("'ASSOCIATE ALL'", true, null, false, false);
   };
   this.e17482_client=function()
   {
      return this.executeServerEvent("'DISASSOCIATE ALL'", true, null, false, false);
   };
   this.e18482_client=function()
   {
      return this.executeServerEvent("VASSOCIATEDRECORDS.DBLCLICK", true, null, false, true);
   };
   this.e19482_client=function()
   {
      return this.executeServerEvent("VNOTASSOCIATEDRECORDS.DBLCLICK", true, null, false, true);
   };
   this.e21481_client=function()
   {
      return this.executeServerEvent("CANCEL", true, null, false, false);
   };
   this.GXValidFnc = [];
   var GXValidFnc = this.GXValidFnc ;
   this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54];
   this.GXLastCtrlId =54;
   GXValidFnc[2]={ id: 2, fld:"",grid:0};
   GXValidFnc[3]={ id: 3, fld:"LAYOUTMAINTABLE",grid:0};
   GXValidFnc[4]={ id: 4, fld:"",grid:0};
   GXValidFnc[5]={ id: 5, fld:"",grid:0};
   GXValidFnc[6]={ id: 6, fld:"TABLEMAIN",grid:0};
   GXValidFnc[7]={ id: 7, fld:"",grid:0};
   GXValidFnc[8]={ id: 8, fld:"",grid:0};
   GXValidFnc[9]={ id: 9, fld:"TABLEFULLCONTENT",grid:0};
   GXValidFnc[10]={ id: 10, fld:"",grid:0};
   GXValidFnc[11]={ id: 11, fld:"",grid:0};
   GXValidFnc[12]={ id: 12, fld:"TABLENOTASSOCIATED",grid:0};
   GXValidFnc[13]={ id: 13, fld:"",grid:0};
   GXValidFnc[14]={ id: 14, fld:"",grid:0};
   GXValidFnc[15]={ id: 15, fld:"NOTASSOCIATEDRECORDSTITLE", format:0,grid:0};
   GXValidFnc[16]={ id: 16, fld:"",grid:0};
   GXValidFnc[17]={ id: 17, fld:"",grid:0};
   GXValidFnc[18]={ id: 18, fld:"",grid:0};
   GXValidFnc[19]={ id:19 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNOTASSOCIATEDRECORDS",gxz:"ZV26NotAssociatedRecords",gxold:"OV26NotAssociatedRecords",gxvar:"AV26NotAssociatedRecords",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"listbx",v2v:function(Value){if(Value!==undefined)gx.O.AV26NotAssociatedRecords=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV26NotAssociatedRecords=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vNOTASSOCIATEDRECORDS",gx.O.AV26NotAssociatedRecords)},c2v:function(){if(this.val()!==undefined)gx.O.AV26NotAssociatedRecords=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vNOTASSOCIATEDRECORDS",',')},nac:gx.falseFn,evt2:"e19482_client"};
   GXValidFnc[20]={ id: 20, fld:"",grid:0};
   GXValidFnc[21]={ id: 21, fld:"UNNAMEDTABLEASSOCIATIONBUTTONS",grid:0};
   GXValidFnc[22]={ id: 22, fld:"",grid:0};
   GXValidFnc[23]={ id: 23, fld:"",grid:0};
   GXValidFnc[24]={ id: 24, fld:"",grid:0};
   GXValidFnc[25]={ id: 25, fld:"IMAGEASSOCIATEALL",grid:0,evt:"e16482_client"};
   GXValidFnc[26]={ id: 26, fld:"",grid:0};
   GXValidFnc[27]={ id: 27, fld:"IMAGEASSOCIATESELECTED",grid:0,evt:"e15482_client"};
   GXValidFnc[28]={ id: 28, fld:"",grid:0};
   GXValidFnc[29]={ id: 29, fld:"IMAGEDISASSOCIATESELECTED",grid:0,evt:"e14482_client"};
   GXValidFnc[30]={ id: 30, fld:"",grid:0};
   GXValidFnc[31]={ id: 31, fld:"IMAGEDISASSOCIATEALL",grid:0,evt:"e17482_client"};
   GXValidFnc[32]={ id: 32, fld:"",grid:0};
   GXValidFnc[33]={ id: 33, fld:"TABLEASSOCIATED",grid:0};
   GXValidFnc[34]={ id: 34, fld:"",grid:0};
   GXValidFnc[35]={ id: 35, fld:"",grid:0};
   GXValidFnc[36]={ id: 36, fld:"ASSOCIATEDRECORDSTITLE", format:0,grid:0};
   GXValidFnc[37]={ id: 37, fld:"",grid:0};
   GXValidFnc[38]={ id: 38, fld:"",grid:0};
   GXValidFnc[39]={ id: 39, fld:"",grid:0};
   GXValidFnc[40]={ id:40 ,lvl:0,type:"int",len:18,dec:0,sign:false,pic:"ZZZZZZZZZZZZZZZZZZ",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vASSOCIATEDRECORDS",gxz:"ZV25AssociatedRecords",gxold:"OV25AssociatedRecords",gxvar:"AV25AssociatedRecords",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"listbx",v2v:function(Value){if(Value!==undefined)gx.O.AV25AssociatedRecords=gx.num.intval(Value)},v2z:function(Value){if(Value!==undefined)gx.O.ZV25AssociatedRecords=gx.num.intval(Value)},v2c:function(){gx.fn.setComboBoxValue("vASSOCIATEDRECORDS",gx.O.AV25AssociatedRecords)},c2v:function(){if(this.val()!==undefined)gx.O.AV25AssociatedRecords=gx.num.intval(this.val())},val:function(){return gx.fn.getIntegerValue("vASSOCIATEDRECORDS",',')},nac:gx.falseFn,evt2:"e18482_client"};
   GXValidFnc[41]={ id: 41, fld:"",grid:0};
   GXValidFnc[42]={ id: 42, fld:"",grid:0};
   GXValidFnc[43]={ id: 43, fld:"",grid:0};
   GXValidFnc[44]={ id: 44, fld:"",grid:0};
   GXValidFnc[45]={ id: 45, fld:"BTNCONFIRM",grid:0};
   GXValidFnc[46]={ id: 46, fld:"",grid:0};
   GXValidFnc[47]={ id: 47, fld:"BTNCANCEL",grid:0};
   GXValidFnc[48]={ id: 48, fld:"",grid:0};
   GXValidFnc[49]={ id: 49, fld:"",grid:0};
   GXValidFnc[50]={ id: 50, fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};
   GXValidFnc[51]={ id:51 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vADDEDKEYLISTXML",gxz:"ZV17AddedKeyListXml",gxold:"OV17AddedKeyListXml",gxvar:"AV17AddedKeyListXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV17AddedKeyListXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV17AddedKeyListXml=Value},v2c:function(){gx.fn.setControlValue("vADDEDKEYLISTXML",gx.O.AV17AddedKeyListXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV17AddedKeyListXml=this.val()},val:function(){return gx.fn.getControlValue("vADDEDKEYLISTXML")},nac:gx.falseFn};
   GXValidFnc[52]={ id:52 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNOTADDEDKEYLISTXML",gxz:"ZV18NotAddedKeyListXml",gxold:"OV18NotAddedKeyListXml",gxvar:"AV18NotAddedKeyListXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV18NotAddedKeyListXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV18NotAddedKeyListXml=Value},v2c:function(){gx.fn.setControlValue("vNOTADDEDKEYLISTXML",gx.O.AV18NotAddedKeyListXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV18NotAddedKeyListXml=this.val()},val:function(){return gx.fn.getControlValue("vNOTADDEDKEYLISTXML")},nac:gx.falseFn};
   GXValidFnc[53]={ id:53 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vADDEDDSCLISTXML",gxz:"ZV19AddedDscListXml",gxold:"OV19AddedDscListXml",gxvar:"AV19AddedDscListXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV19AddedDscListXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV19AddedDscListXml=Value},v2c:function(){gx.fn.setControlValue("vADDEDDSCLISTXML",gx.O.AV19AddedDscListXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV19AddedDscListXml=this.val()},val:function(){return gx.fn.getControlValue("vADDEDDSCLISTXML")},nac:gx.falseFn};
   GXValidFnc[54]={ id:54 ,lvl:0,type:"vchar",len:2097152,dec:0,sign:false,ro:0,multiline:true,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vNOTADDEDDSCLISTXML",gxz:"ZV20NotAddedDscListXml",gxold:"OV20NotAddedDscListXml",gxvar:"AV20NotAddedDscListXml",ucs:[],op:[],ip:[],
						nacdep:[],ctrltype:"edit",v2v:function(Value){if(Value!==undefined)gx.O.AV20NotAddedDscListXml=Value},v2z:function(Value){if(Value!==undefined)gx.O.ZV20NotAddedDscListXml=Value},v2c:function(){gx.fn.setControlValue("vNOTADDEDDSCLISTXML",gx.O.AV20NotAddedDscListXml,0)},c2v:function(){if(this.val()!==undefined)gx.O.AV20NotAddedDscListXml=this.val()},val:function(){return gx.fn.getControlValue("vNOTADDEDDSCLISTXML")},nac:gx.falseFn};
   this.AV26NotAssociatedRecords = 0 ;
   this.ZV26NotAssociatedRecords = 0 ;
   this.OV26NotAssociatedRecords = 0 ;
   this.AV25AssociatedRecords = 0 ;
   this.ZV25AssociatedRecords = 0 ;
   this.OV25AssociatedRecords = 0 ;
   this.AV17AddedKeyListXml = "" ;
   this.ZV17AddedKeyListXml = "" ;
   this.OV17AddedKeyListXml = "" ;
   this.AV18NotAddedKeyListXml = "" ;
   this.ZV18NotAddedKeyListXml = "" ;
   this.OV18NotAddedKeyListXml = "" ;
   this.AV19AddedDscListXml = "" ;
   this.ZV19AddedDscListXml = "" ;
   this.OV19AddedDscListXml = "" ;
   this.AV20NotAddedDscListXml = "" ;
   this.ZV20NotAddedDscListXml = "" ;
   this.OV20NotAddedDscListXml = "" ;
   this.AV26NotAssociatedRecords = 0 ;
   this.AV25AssociatedRecords = 0 ;
   this.AV17AddedKeyListXml = "" ;
   this.AV18NotAddedKeyListXml = "" ;
   this.AV19AddedDscListXml = "" ;
   this.AV20NotAddedDscListXml = "" ;
   this.AV8SecUserId = 0 ;
   this.A87JC_ProviderID = 0 ;
   this.A6SecUserId = 0 ;
   this.A89JC_ProviderName = "" ;
   this.AV21AddedKeyList = [ ] ;
   this.AV23AddedDscList = [ ] ;
   this.AV22NotAddedKeyList = [ ] ;
   this.AV24NotAddedDscList = [ ] ;
   this.AV12JC_ProviderSecUser = {SecUserId:0,JC_ProviderID:0,SecUserName:"",JC_ProviderName:"",Mode:"",Initialized:0,SecUserId_Z:0,JC_ProviderID_Z:0,SecUserName_Z:"",JC_ProviderName_Z:"",JC_ProviderName_N:0} ;
   this.AV9JC_ProviderID = 0 ;
   this.addEventHandler("dblclick", "vASSOCIATEDRECORDS", this.e18482_client);
   this.addEventHandler("dblclick", "vNOTASSOCIATEDRECORDS", this.e19482_client);
   this.Events = {"e13482_client": ["ENTER", true] ,"e14482_client": ["'DISASSOCIATE SELECTED'", true] ,"e15482_client": ["'ASSOCIATE SELECTED'", true] ,"e16482_client": ["'ASSOCIATE ALL'", true] ,"e17482_client": ["'DISASSOCIATE ALL'", true] ,"e18482_client": ["VASSOCIATEDRECORDS.DBLCLICK", true] ,"e19482_client": ["VNOTASSOCIATEDRECORDS.DBLCLICK", true] ,"e21481_client": ["CANCEL", true]};
   this.EvtParms["REFRESH"] = [[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true}],[{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''}]];
   this.EvtParms["START"] = [[{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true},{av:'A89JC_ProviderName',fld:'JC_PROVIDERNAME',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''}],[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'gx.fn.getCtrlProperty("vADDEDKEYLISTXML","Visible")',ctrl:'vADDEDKEYLISTXML',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vNOTADDEDKEYLISTXML","Visible")',ctrl:'vNOTADDEDKEYLISTXML',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vADDEDDSCLISTXML","Visible")',ctrl:'vADDEDDSCLISTXML',prop:'Visible'},{av:'gx.fn.getCtrlProperty("vNOTADDEDDSCLISTXML","Visible")',ctrl:'vNOTADDEDDSCLISTXML',prop:'Visible'},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]];
   this.EvtParms["ENTER"] = [[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'A6SecUserId',fld:'SECUSERID',pic:'ZZZ9'},{av:'AV8SecUserId',fld:'vSECUSERID',pic:'ZZZ9',hsh:true},{av:'A87JC_ProviderID',fld:'JC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{av:'AV12JC_ProviderSecUser',fld:'vJC_PROVIDERSECUSER',pic:''},{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'}],[{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV12JC_ProviderSecUser',fld:'vJC_PROVIDERSECUSER',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''}]];
   this.EvtParms["'DISASSOCIATE SELECTED'"] = [[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}],[{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["'ASSOCIATE SELECTED'"] = [[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}],[{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["'ASSOCIATE ALL'"] = [[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}],[{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}]];
   this.EvtParms["'DISASSOCIATE ALL'"] = [[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}],[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["VASSOCIATEDRECORDS.DBLCLICK"] = [[{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}],[{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EvtParms["VNOTASSOCIATEDRECORDS.DBLCLICK"] = [[{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''}],[{av:'AV9JC_ProviderID',fld:'vJC_PROVIDERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21AddedKeyList',fld:'vADDEDKEYLIST',pic:''},{av:'AV23AddedDscList',fld:'vADDEDDSCLIST',pic:''},{av:'AV22NotAddedKeyList',fld:'vNOTADDEDKEYLIST',pic:''},{av:'AV24NotAddedDscList',fld:'vNOTADDEDDSCLIST',pic:''},{av:'AV17AddedKeyListXml',fld:'vADDEDKEYLISTXML',pic:''},{av:'AV19AddedDscListXml',fld:'vADDEDDSCLISTXML',pic:''},{av:'AV18NotAddedKeyListXml',fld:'vNOTADDEDKEYLISTXML',pic:''},{av:'AV20NotAddedDscListXml',fld:'vNOTADDEDDSCLISTXML',pic:''},{ctrl:'vASSOCIATEDRECORDS'},{av:'AV25AssociatedRecords',fld:'vASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'},{ctrl:'vNOTASSOCIATEDRECORDS'},{av:'AV26NotAssociatedRecords',fld:'vNOTASSOCIATEDRECORDS',pic:'ZZZZZZZZZZZZZZZZZZ'}]];
   this.EnterCtrl = ["BTNCONFIRM"];
   this.setVCMap("AV21AddedKeyList", "vADDEDKEYLIST", 0, "Collint", 0, 0);
   this.setVCMap("AV23AddedDscList", "vADDEDDSCLIST", 0, "Collsvchar", 0, 0);
   this.setVCMap("AV22NotAddedKeyList", "vNOTADDEDKEYLIST", 0, "Collint", 0, 0);
   this.setVCMap("AV24NotAddedDscList", "vNOTADDEDDSCLIST", 0, "Collsvchar", 0, 0);
   this.setVCMap("A6SecUserId", "SECUSERID", 0, "int", 4, 0);
   this.setVCMap("AV8SecUserId", "vSECUSERID", 0, "int", 4, 0);
   this.setVCMap("A87JC_ProviderID", "JC_PROVIDERID", 0, "int", 18, 0);
   this.setVCMap("AV12JC_ProviderSecUser", "vJC_PROVIDERSECUSER", 0, "JC_ProviderSecUser", 0, 0);
   this.setVCMap("AV9JC_ProviderID", "vJC_PROVIDERID", 0, "int", 18, 0);
   this.Initialize( );
});
gx.createParentObj(wwpbaseobjects.secuserjc_providersecuserassociation);