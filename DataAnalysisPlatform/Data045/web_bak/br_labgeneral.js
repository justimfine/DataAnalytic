/*!   GeneXus C# 16_0_0-127771 on 2/27/2020 9:35:0.82
*/
gx.evt.autoSkip=!1;gx.define("br_labgeneral",!0,function(n){this.ServerClass="br_labgeneral";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){};this.Valid_Br_labid=function(){try{var n=gx.util.balloon.getNew("BR_LABID");this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0};this.e133i2_client=function(){return this.executeServerEvent("ENTER",!0,null,!1,!1)};this.e143i2_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];var t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143,144,145,146,147,148,149,150,151,152];this.GXLastCtrlId=152;t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"LAYOUTMAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"TRANSACTIONDETAIL_TABLEATTRIBUTES",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[12]={id:12,fld:"UNNAMEDTABLEBR_LAB_TESTNAME",grid:0};t[13]={id:13,fld:"",grid:0};t[14]={id:14,fld:"",grid:0};t[15]={id:15,fld:"TEXTBLOCKBR_LAB_TESTNAME",format:0,grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTNAME",gxz:"Z104BR_Lab_TestName",gxold:"O104BR_Lab_TestName",gxvar:"A104BR_Lab_TestName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A104BR_Lab_TestName=n)},v2z:function(n){n!==undefined&&(gx.O.Z104BR_Lab_TestName=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTNAME",gx.O.A104BR_Lab_TestName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A104BR_Lab_TestName=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_TESTNAME")},nac:gx.falseFn};t[19]={id:19,fld:"",grid:0};t[20]={id:20,fld:"UNNAMEDTABLEBR_LAB_TESTENGNAME",grid:0};t[21]={id:21,fld:"",grid:0};t[22]={id:22,fld:"",grid:0};t[23]={id:23,fld:"TEXTBLOCKBR_LAB_TESTENGNAME",format:0,grid:0};t[24]={id:24,fld:"",grid:0};t[25]={id:25,fld:"",grid:0};t[26]={id:26,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTENGNAME",gxz:"Z261BR_Lab_TestEngName",gxold:"O261BR_Lab_TestEngName",gxvar:"A261BR_Lab_TestEngName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A261BR_Lab_TestEngName=n)},v2z:function(n){n!==undefined&&(gx.O.Z261BR_Lab_TestEngName=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTENGNAME",gx.O.A261BR_Lab_TestEngName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A261BR_Lab_TestEngName=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_TESTENGNAME")},nac:gx.falseFn};t[27]={id:27,fld:"",grid:0};t[28]={id:28,fld:"",grid:0};t[29]={id:29,fld:"UNNAMEDTABLEBR_LAB_AGE",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,fld:"TEXTBLOCKBR_LAB_AGE",format:0,grid:0};t[33]={id:33,fld:"",grid:0};t[34]={id:34,fld:"",grid:0};t[35]={id:35,lvl:0,type:"int",len:3,dec:0,sign:!1,pic:"ZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_AGE",gxz:"Z262BR_Lab_Age",gxold:"O262BR_Lab_Age",gxvar:"A262BR_Lab_Age",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A262BR_Lab_Age=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z262BR_Lab_Age=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_LAB_AGE",gx.O.A262BR_Lab_Age,0)},c2v:function(){this.val()!==undefined&&(gx.O.A262BR_Lab_Age=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_LAB_AGE",",")},nac:gx.falseFn};t[36]={id:36,fld:"",grid:0};t[37]={id:37,fld:"UNNAMEDTABLEBR_LAB_DIAG",grid:0};t[38]={id:38,fld:"",grid:0};t[39]={id:39,fld:"",grid:0};t[40]={id:40,fld:"TEXTBLOCKBR_LAB_DIAG",format:0,grid:0};t[41]={id:41,fld:"",grid:0};t[42]={id:42,fld:"",grid:0};t[43]={id:43,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_DIAG",gxz:"Z263BR_Lab_Diag",gxold:"O263BR_Lab_Diag",gxvar:"A263BR_Lab_Diag",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A263BR_Lab_Diag=n)},v2z:function(n){n!==undefined&&(gx.O.Z263BR_Lab_Diag=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_DIAG",gx.O.A263BR_Lab_Diag,0)},c2v:function(){this.val()!==undefined&&(gx.O.A263BR_Lab_Diag=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_DIAG")},nac:gx.falseFn};t[44]={id:44,fld:"",grid:0};t[45]={id:45,fld:"",grid:0};t[46]={id:46,fld:"UNNAMEDTABLEBR_LAB_SPECIMENSOURCE",grid:0};t[47]={id:47,fld:"",grid:0};t[48]={id:48,fld:"",grid:0};t[49]={id:49,fld:"TEXTBLOCKBR_LAB_SPECIMENSOURCE",format:0,grid:0};t[50]={id:50,fld:"",grid:0};t[51]={id:51,fld:"",grid:0};t[52]={id:52,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_SPECIMENSOURCE",gxz:"Z106BR_Lab_SpecimenSource",gxold:"O106BR_Lab_SpecimenSource",gxvar:"A106BR_Lab_SpecimenSource",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A106BR_Lab_SpecimenSource=n)},v2z:function(n){n!==undefined&&(gx.O.Z106BR_Lab_SpecimenSource=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_SPECIMENSOURCE",gx.O.A106BR_Lab_SpecimenSource,0)},c2v:function(){this.val()!==undefined&&(gx.O.A106BR_Lab_SpecimenSource=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_SPECIMENSOURCE")},nac:gx.falseFn};t[53]={id:53,fld:"",grid:0};t[54]={id:54,fld:"UNNAMEDTABLEBR_LAB_SPECIMENDATE",grid:0};t[55]={id:55,fld:"",grid:0};t[56]={id:56,fld:"",grid:0};t[57]={id:57,fld:"TEXTBLOCKBR_LAB_SPECIMENDATE",format:0,grid:0};t[58]={id:58,fld:"",grid:0};t[59]={id:59,fld:"",grid:0};t[60]={id:60,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_SPECIMENDATE",gxz:"Z105BR_Lab_SpecimenDate",gxold:"O105BR_Lab_SpecimenDate",gxvar:"A105BR_Lab_SpecimenDate",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A105BR_Lab_SpecimenDate=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z105BR_Lab_SpecimenDate=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_LAB_SPECIMENDATE",gx.O.A105BR_Lab_SpecimenDate,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A105BR_Lab_SpecimenDate=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_LAB_SPECIMENDATE")},nac:gx.falseFn};this.declareDomainHdlr(60,function(){});t[61]={id:61,fld:"",grid:0};t[62]={id:62,fld:"",grid:0};t[63]={id:63,fld:"UNNAMEDTABLEBR_LAB_RECEIVINGTIME",grid:0};t[64]={id:64,fld:"",grid:0};t[65]={id:65,fld:"",grid:0};t[66]={id:66,fld:"TEXTBLOCKBR_LAB_RECEIVINGTIME",format:0,grid:0};t[67]={id:67,fld:"",grid:0};t[68]={id:68,fld:"",grid:0};t[69]={id:69,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RECEIVINGTIME",gxz:"Z264BR_Lab_ReceivingTime",gxold:"O264BR_Lab_ReceivingTime",gxvar:"A264BR_Lab_ReceivingTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A264BR_Lab_ReceivingTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z264BR_Lab_ReceivingTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_LAB_RECEIVINGTIME",gx.O.A264BR_Lab_ReceivingTime,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A264BR_Lab_ReceivingTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_LAB_RECEIVINGTIME")},nac:gx.falseFn};this.declareDomainHdlr(69,function(){});t[70]={id:70,fld:"",grid:0};t[71]={id:71,fld:"UNNAMEDTABLEBR_LAB_REPORTTIME",grid:0};t[72]={id:72,fld:"",grid:0};t[73]={id:73,fld:"",grid:0};t[74]={id:74,fld:"TEXTBLOCKBR_LAB_REPORTTIME",format:0,grid:0};t[75]={id:75,fld:"",grid:0};t[76]={id:76,fld:"",grid:0};t[77]={id:77,lvl:0,type:"dtime",len:10,dec:8,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_REPORTTIME",gxz:"Z265BR_Lab_ReportTime",gxold:"O265BR_Lab_ReportTime",gxvar:"A265BR_Lab_ReportTime",dp:{f:0,st:!0,wn:!1,mf:!1,pic:"99/99/9999 99:99:99",dec:8},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A265BR_Lab_ReportTime=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z265BR_Lab_ReportTime=gx.fn.toDatetimeValue(n))},v2c:function(){gx.fn.setControlValue("BR_LAB_REPORTTIME",gx.O.A265BR_Lab_ReportTime,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A265BR_Lab_ReportTime=gx.fn.toDatetimeValue(this.val()))},val:function(){return gx.fn.getDateTimeValue("BR_LAB_REPORTTIME")},nac:gx.falseFn};this.declareDomainHdlr(77,function(){});t[78]={id:78,fld:"",grid:0};t[79]={id:79,fld:"",grid:0};t[80]={id:80,fld:"UNNAMEDTABLEBR_LAB_RESULTQUAL",grid:0};t[81]={id:81,fld:"",grid:0};t[82]={id:82,fld:"",grid:0};t[83]={id:83,fld:"TEXTBLOCKBR_LAB_RESULTQUAL",format:0,grid:0};t[84]={id:84,fld:"",grid:0};t[85]={id:85,fld:"",grid:0};t[86]={id:86,lvl:0,type:"svchar",len:500,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RESULTQUAL",gxz:"Z109BR_Lab_ResultQual",gxold:"O109BR_Lab_ResultQual",gxvar:"A109BR_Lab_ResultQual",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A109BR_Lab_ResultQual=n)},v2z:function(n){n!==undefined&&(gx.O.Z109BR_Lab_ResultQual=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_RESULTQUAL",gx.O.A109BR_Lab_ResultQual,0)},c2v:function(){this.val()!==undefined&&(gx.O.A109BR_Lab_ResultQual=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_RESULTQUAL")},nac:gx.falseFn};t[87]={id:87,fld:"",grid:0};t[88]={id:88,fld:"",grid:0};t[89]={id:89,fld:"UNNAMEDTABLEBR_LAB_RESULTUNIT",grid:0};t[90]={id:90,fld:"",grid:0};t[91]={id:91,fld:"",grid:0};t[92]={id:92,fld:"TEXTBLOCKBR_LAB_RESULTUNIT",format:0,grid:0};t[93]={id:93,fld:"",grid:0};t[94]={id:94,fld:"",grid:0};t[95]={id:95,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RESULTUNIT",gxz:"Z111BR_Lab_ResultUnit",gxold:"O111BR_Lab_ResultUnit",gxvar:"A111BR_Lab_ResultUnit",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A111BR_Lab_ResultUnit=n)},v2z:function(n){n!==undefined&&(gx.O.Z111BR_Lab_ResultUnit=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_RESULTUNIT",gx.O.A111BR_Lab_ResultUnit,0)},c2v:function(){this.val()!==undefined&&(gx.O.A111BR_Lab_ResultUnit=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_RESULTUNIT")},nac:gx.falseFn};t[96]={id:96,fld:"",grid:0};t[97]={id:97,fld:"UNNAMEDTABLEBR_LAB_ABNIND",grid:0};t[98]={id:98,fld:"",grid:0};t[99]={id:99,fld:"",grid:0};t[100]={id:100,fld:"TEXTBLOCKBR_LAB_ABNIND",format:0,grid:0};t[101]={id:101,fld:"",grid:0};t[102]={id:102,fld:"",grid:0};t[103]={id:103,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_ABNIND",gxz:"Z112BR_Lab_AbnInd",gxold:"O112BR_Lab_AbnInd",gxvar:"A112BR_Lab_AbnInd",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A112BR_Lab_AbnInd=n)},v2z:function(n){n!==undefined&&(gx.O.Z112BR_Lab_AbnInd=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_ABNIND",gx.O.A112BR_Lab_AbnInd,0)},c2v:function(){this.val()!==undefined&&(gx.O.A112BR_Lab_AbnInd=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_ABNIND")},nac:gx.falseFn};t[104]={id:104,fld:"",grid:0};t[105]={id:105,fld:"",grid:0};t[106]={id:106,fld:"UNNAMEDTABLEBR_LAB_NORMRANGELOW",grid:0};t[107]={id:107,fld:"",grid:0};t[108]={id:108,fld:"",grid:0};t[109]={id:109,fld:"TEXTBLOCKBR_LAB_NORMRANGELOW",format:0,grid:0};t[110]={id:110,fld:"",grid:0};t[111]={id:111,fld:"",grid:0};t[112]={id:112,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_NORMRANGELOW",gxz:"Z113BR_Lab_NormRangeLow",gxold:"O113BR_Lab_NormRangeLow",gxvar:"A113BR_Lab_NormRangeLow",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A113BR_Lab_NormRangeLow=n)},v2z:function(n){n!==undefined&&(gx.O.Z113BR_Lab_NormRangeLow=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_NORMRANGELOW",gx.O.A113BR_Lab_NormRangeLow,0)},c2v:function(){this.val()!==undefined&&(gx.O.A113BR_Lab_NormRangeLow=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_NORMRANGELOW")},nac:gx.falseFn};t[113]={id:113,fld:"",grid:0};t[114]={id:114,fld:"",grid:0};t[115]={id:115,fld:"UNNAMEDTABLEBR_LAB_TESTMETHOD",grid:0};t[116]={id:116,fld:"",grid:0};t[117]={id:117,fld:"",grid:0};t[118]={id:118,fld:"TEXTBLOCKBR_LAB_TESTMETHOD",format:0,grid:0};t[119]={id:119,fld:"",grid:0};t[120]={id:120,fld:"",grid:0};t[121]={id:121,lvl:0,type:"svchar",len:40,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTMETHOD",gxz:"Z115BR_Lab_TestMethod",gxold:"O115BR_Lab_TestMethod",gxvar:"A115BR_Lab_TestMethod",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A115BR_Lab_TestMethod=n)},v2z:function(n){n!==undefined&&(gx.O.Z115BR_Lab_TestMethod=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTMETHOD",gx.O.A115BR_Lab_TestMethod,0)},c2v:function(){this.val()!==undefined&&(gx.O.A115BR_Lab_TestMethod=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_TESTMETHOD")},nac:gx.falseFn};t[122]={id:122,fld:"",grid:0};t[123]={id:123,fld:"UNNAMEDTABLEBR_LAB_INSTRUMENTCODE",grid:0};t[124]={id:124,fld:"",grid:0};t[125]={id:125,fld:"",grid:0};t[126]={id:126,fld:"TEXTBLOCKBR_LAB_INSTRUMENTCODE",format:0,grid:0};t[127]={id:127,fld:"",grid:0};t[128]={id:128,fld:"",grid:0};t[129]={id:129,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_INSTRUMENTCODE",gxz:"Z118BR_Lab_InstrumentCode",gxold:"O118BR_Lab_InstrumentCode",gxvar:"A118BR_Lab_InstrumentCode",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A118BR_Lab_InstrumentCode=n)},v2z:function(n){n!==undefined&&(gx.O.Z118BR_Lab_InstrumentCode=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_INSTRUMENTCODE",gx.O.A118BR_Lab_InstrumentCode,0)},c2v:function(){this.val()!==undefined&&(gx.O.A118BR_Lab_InstrumentCode=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_INSTRUMENTCODE")},nac:gx.falseFn};t[130]={id:130,fld:"",grid:0};t[131]={id:131,fld:"",grid:0};t[132]={id:132,fld:"UNNAMEDTABLEBR_LAB_INSTRUMENTNAME",grid:0};t[133]={id:133,fld:"",grid:0};t[134]={id:134,fld:"",grid:0};t[135]={id:135,fld:"TEXTBLOCKBR_LAB_INSTRUMENTNAME",format:0,grid:0};t[136]={id:136,fld:"",grid:0};t[137]={id:137,fld:"",grid:0};t[138]={id:138,lvl:0,type:"svchar",len:200,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_INSTRUMENTNAME",gxz:"Z117BR_Lab_InstrumentName",gxold:"O117BR_Lab_InstrumentName",gxvar:"A117BR_Lab_InstrumentName",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A117BR_Lab_InstrumentName=n)},v2z:function(n){n!==undefined&&(gx.O.Z117BR_Lab_InstrumentName=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_INSTRUMENTNAME",gx.O.A117BR_Lab_InstrumentName,0)},c2v:function(){this.val()!==undefined&&(gx.O.A117BR_Lab_InstrumentName=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_INSTRUMENTNAME")},nac:gx.falseFn};t[139]={id:139,fld:"",grid:0};t[140]={id:140,fld:"UNNAMEDTABLEBR_LAB_RESULTNUM",grid:0};t[141]={id:141,fld:"",grid:0};t[142]={id:142,fld:"",grid:0};t[143]={id:143,fld:"TEXTBLOCKBR_LAB_RESULTNUM",format:0,grid:0};t[144]={id:144,fld:"",grid:0};t[145]={id:145,fld:"",grid:0};t[146]={id:146,lvl:0,type:"svchar",len:500,dec:0,sign:!1,ro:1,multiline:!0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_RESULTNUM",gxz:"Z110BR_Lab_ResultNum",gxold:"O110BR_Lab_ResultNum",gxvar:"A110BR_Lab_ResultNum",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A110BR_Lab_ResultNum=n)},v2z:function(n){n!==undefined&&(gx.O.Z110BR_Lab_ResultNum=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_RESULTNUM",gx.O.A110BR_Lab_ResultNum,0)},c2v:function(){this.val()!==undefined&&(gx.O.A110BR_Lab_ResultNum=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_RESULTNUM")},nac:gx.falseFn};t[147]={id:147,fld:"",grid:0};t[148]={id:148,fld:"",grid:0};t[149]={id:149,fld:"HTML_BOTTOMAUXILIARCONTROLS",grid:0};t[150]={id:150,lvl:0,type:"int",len:18,dec:0,sign:!1,pic:"ZZZZZZZZZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:this.Valid_Br_labid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LABID",gxz:"Z101BR_LabID",gxold:"O101BR_LabID",gxvar:"A101BR_LabID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A101BR_LabID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z101BR_LabID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_LABID",gx.O.A101BR_LabID,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A101BR_LabID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_LABID",",")},nac:gx.falseFn};this.declareDomainHdlr(150,function(){});t[151]={id:151,lvl:0,type:"int",len:10,dec:0,sign:!1,pic:"ZZZZZZZZZZ",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_TESTID",gxz:"Z102BR_Lab_TestID",gxold:"O102BR_Lab_TestID",gxvar:"A102BR_Lab_TestID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A102BR_Lab_TestID=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z102BR_Lab_TestID=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("BR_LAB_TESTID",gx.O.A102BR_Lab_TestID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A102BR_Lab_TestID=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("BR_LAB_TESTID",",")},nac:gx.falseFn};t[152]={id:152,lvl:0,type:"svchar",len:100,dec:0,sign:!1,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"BR_LAB_SAMPLEID",gxz:"Z224BR_Lab_SampleID",gxold:"O224BR_Lab_SampleID",gxvar:"A224BR_Lab_SampleID",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A224BR_Lab_SampleID=n)},v2z:function(n){n!==undefined&&(gx.O.Z224BR_Lab_SampleID=n)},v2c:function(){gx.fn.setControlValue("BR_LAB_SAMPLEID",gx.O.A224BR_Lab_SampleID,0)},c2v:function(){this.val()!==undefined&&(gx.O.A224BR_Lab_SampleID=this.val())},val:function(){return gx.fn.getControlValue("BR_LAB_SAMPLEID")},nac:gx.falseFn};this.A104BR_Lab_TestName="";this.Z104BR_Lab_TestName="";this.O104BR_Lab_TestName="";this.A261BR_Lab_TestEngName="";this.Z261BR_Lab_TestEngName="";this.O261BR_Lab_TestEngName="";this.A262BR_Lab_Age=0;this.Z262BR_Lab_Age=0;this.O262BR_Lab_Age=0;this.A263BR_Lab_Diag="";this.Z263BR_Lab_Diag="";this.O263BR_Lab_Diag="";this.A106BR_Lab_SpecimenSource="";this.Z106BR_Lab_SpecimenSource="";this.O106BR_Lab_SpecimenSource="";this.A105BR_Lab_SpecimenDate=gx.date.nullDate();this.Z105BR_Lab_SpecimenDate=gx.date.nullDate();this.O105BR_Lab_SpecimenDate=gx.date.nullDate();this.A264BR_Lab_ReceivingTime=gx.date.nullDate();this.Z264BR_Lab_ReceivingTime=gx.date.nullDate();this.O264BR_Lab_ReceivingTime=gx.date.nullDate();this.A265BR_Lab_ReportTime=gx.date.nullDate();this.Z265BR_Lab_ReportTime=gx.date.nullDate();this.O265BR_Lab_ReportTime=gx.date.nullDate();this.A109BR_Lab_ResultQual="";this.Z109BR_Lab_ResultQual="";this.O109BR_Lab_ResultQual="";this.A111BR_Lab_ResultUnit="";this.Z111BR_Lab_ResultUnit="";this.O111BR_Lab_ResultUnit="";this.A112BR_Lab_AbnInd="";this.Z112BR_Lab_AbnInd="";this.O112BR_Lab_AbnInd="";this.A113BR_Lab_NormRangeLow="";this.Z113BR_Lab_NormRangeLow="";this.O113BR_Lab_NormRangeLow="";this.A115BR_Lab_TestMethod="";this.Z115BR_Lab_TestMethod="";this.O115BR_Lab_TestMethod="";this.A118BR_Lab_InstrumentCode="";this.Z118BR_Lab_InstrumentCode="";this.O118BR_Lab_InstrumentCode="";this.A117BR_Lab_InstrumentName="";this.Z117BR_Lab_InstrumentName="";this.O117BR_Lab_InstrumentName="";this.A110BR_Lab_ResultNum="";this.Z110BR_Lab_ResultNum="";this.O110BR_Lab_ResultNum="";this.A101BR_LabID=0;this.Z101BR_LabID=0;this.O101BR_LabID=0;this.A102BR_Lab_TestID=0;this.Z102BR_Lab_TestID=0;this.O102BR_Lab_TestID=0;this.A224BR_Lab_SampleID="";this.Z224BR_Lab_SampleID="";this.O224BR_Lab_SampleID="";this.A104BR_Lab_TestName="";this.A261BR_Lab_TestEngName="";this.A262BR_Lab_Age=0;this.A263BR_Lab_Diag="";this.A106BR_Lab_SpecimenSource="";this.A105BR_Lab_SpecimenDate=gx.date.nullDate();this.A264BR_Lab_ReceivingTime=gx.date.nullDate();this.A265BR_Lab_ReportTime=gx.date.nullDate();this.A109BR_Lab_ResultQual="";this.A111BR_Lab_ResultUnit="";this.A112BR_Lab_AbnInd="";this.A113BR_Lab_NormRangeLow="";this.A115BR_Lab_TestMethod="";this.A118BR_Lab_InstrumentCode="";this.A117BR_Lab_InstrumentName="";this.A110BR_Lab_ResultNum="";this.A101BR_LabID=0;this.A102BR_Lab_TestID=0;this.A224BR_Lab_SampleID="";this.Events={e133i2_client:["ENTER",!0],e143i2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV8BR_LabID",fld:"vBR_LABID",pic:"ZZZZZZZZZZZZZZZZZZ"}],[]];this.EvtParms.LOAD=[[],[{av:'gx.fn.getCtrlProperty("BR_LABID","Visible")',ctrl:"BR_LABID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_LAB_TESTID","Visible")',ctrl:"BR_LAB_TESTID",prop:"Visible"},{av:'gx.fn.getCtrlProperty("BR_LAB_SAMPLEID","Visible")',ctrl:"BR_LAB_SAMPLEID",prop:"Visible"}]];this.Initialize()})