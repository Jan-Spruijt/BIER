using MailChimp.Net;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace LogicLayerLibrary
{
    class MailSender
    {
        private const string ApiKey = "0df6bb2bb91134eb558a8babca621beb-us10";
        private const string RequestListId = "8ed78fbd5c";
        private const int RequestTemplateId = 370309; // Request substitution template ID
        private const int IncidentBeginTemplateId = 373733; // Incident begin template ID
        private const int IncidentEndTemplateId = 373741; // Incident end template ID
        private MailChimpManager _mailChimpManager = new MailChimpManager(ApiKey);
        
        private Setting _campaignSettingsExchange = new Setting
        {
            ReplyTo = "BierCgi@outlook.com",
            FromName = "Proftaak groep 3",
            Title = "Exchange request",
            SubjectLine = "A Co-Worker wants to make a request for substitution",
        };

        private Setting _campaignSettingsStartIncident = new Setting
        {
            ReplyTo = "BierCgi@outlook.com",
            FromName = "Proftaak groep 3",
            Title = "Incident status",
            SubjectLine = "We have started working on your incident.",
        };

        private Setting _campaignSettingsEndIncident = new Setting
        {
            ReplyTo = "BierCgi@outlook.com",
            FromName = "Proftaak groep 3",
            Title = "Incident status",
            SubjectLine = "We have successfully solved your incident.",
        };

        public void CreateAndSendRequest()
        {
            string html = "";
            var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = _campaignSettingsExchange,
                Recipients = new Recipient { ListId = RequestListId },
                Type = CampaignType.Regular
            }).Result;
            var timeStr = DateTime.Now.ToString();
            var content = _mailChimpManager.Content.AddOrUpdateAsync(
             campaign.Id,
             new ContentRequest()
             {
                 Template = new ContentTemplate
                 {
                     Id = RequestTemplateId,
                     Sections = new Dictionary<string, object>()
                {
       { "body_content", html },
       { "preheader_leftcol_content", $"<p>{timeStr}</p>" }
                }
                 }
             }).Result;
            _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
        }

        public void CreateAndSendIncidentStart()
        {
            string html = "";
            var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = _campaignSettingsStartIncident,
                Recipients = new Recipient { ListId = RequestListId },
                Type = CampaignType.Regular
            }).Result;
            var timeStr = DateTime.Now.ToString();
            var content = _mailChimpManager.Content.AddOrUpdateAsync(
             campaign.Id,
             new ContentRequest()
             {
                 Template = new ContentTemplate
                 {
                     Id = IncidentBeginTemplateId,
                     Sections = new Dictionary<string, object>()
                {
       { "body_content", html },
       { "preheader_leftcol_content", $"<p>{timeStr}</p>" }
                }
                 }
             }).Result;
            _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
        }

        public void CreateAndSendIncidentComplete()
        {
            string html = "";
            var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
            {
                Settings = _campaignSettingsEndIncident,
                Recipients = new Recipient { ListId = RequestListId },
                Type = CampaignType.Regular
            }).Result;
            var timeStr = DateTime.Now.ToString();
            var content = _mailChimpManager.Content.AddOrUpdateAsync(
             campaign.Id,
             new ContentRequest()
             {
                 Template = new ContentTemplate
                 {
                     Id = IncidentEndTemplateId,
                     Sections = new Dictionary<string, object>()
                {
       { "body_content", html },
       { "preheader_leftcol_content", $"<p>{timeStr}</p>" }
                }
                 }
             }).Result;
            _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
        }

        public List<Template> GetAllTemplates()
          => _mailChimpManager.Templates.GetAllAsync().Result.ToList();
        public List<List> GetAllMailingLists()
          => _mailChimpManager.Lists.GetAllAsync().Result.ToList();
        public Content GetTemplateDefaultContent(string templateId)
          => (Content)_mailChimpManager.Templates.GetDefaultContentAsync(templateId).Result;
    }
}
