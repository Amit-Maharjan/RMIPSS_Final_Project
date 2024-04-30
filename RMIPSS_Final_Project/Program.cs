// See https://aka.ms/new-console-template for more information
using RMIPSS_Final_Project.Controller;
using RMIPSS_Final_Project.JSON;

ReferralFormHandler referralFormHandler = new ReferralFormHandler();
referralFormHandler.saveReferralForm(JSONModel.studentJson);

referralFormHandler.getReferralForm();