﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HTMLDataGrabber
{
    public class DataGrabber
    {
        private string _url;
        
        public void setPage(string url)
        {
            _url = url;
        }

        public string getTextById(string id)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);
            HtmlNode node = doc.GetElementbyId(id);
            return node.InnerText;
        }

        public List<string> getTextListByXpath(string xpath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);
            HtmlNodeCollection nodes = doc.DocumentNode.SelectNodes(xpath);
            List<string> list = new List<string>();
            foreach (HtmlNode node in nodes)
            {
                list.Add(node.InnerText);
            }
            return list;
        }

        public string getTextByXpath(string xpath)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(_url);
            HtmlNode node = doc.DocumentNode.SelectSingleNode(xpath);
            return node.InnerText;
        }

        public byte[] DownloadImage(string imageUrl)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Download the image data
                    byte[] imageData = client.DownloadData(imageUrl);
                    return imageData;
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the download
                Console.WriteLine("Error downloading image: " + ex.Message);
                return null;
            }
        }
    }
}