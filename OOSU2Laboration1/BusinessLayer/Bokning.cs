﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Bokning
    {
		
		public List<Faktura> FakturaLista = new List<Faktura>();
		

		Expedit Expedit { get; set; }
		Medlem Medlem { get; set; }


		public List<Bok> LånadeBöcker = new List<Bok>();
		
		public List<Bok> ÅterlämnadeBöcker = new List<Bok>();
		

		private string bokningsNummer;
		public string BokningsNummer
		{
			get { return bokningsNummer; }
			private set { bokningsNummer = value; }
		}

		//DateTime.Now.ToString("dd/MM/yyyy")
		private DateTime startDatum;
		public DateTime StartDatum
		{
			get { return startDatum; }
			private set { startDatum = value; }
		}
		//DateTime.AddMonths(Int32) Method
		private DateTime slutDatum;
		public DateTime SlutDatum
		{
			get { return slutDatum; }
			private set { slutDatum = value; }
		}

		private DateTime återlämningsDatum;
		public DateTime ÅterlämningsDatum
		{
			get { return återlämningsDatum; }
			private set { återlämningsDatum = value; }
		}

		public Bokning(string bokningsnummer, DateTime startDatum, DateTime slutDatum, Expedit expedit, Medlem medlem, List<Bok> lånadeBöcker)
		{
			BokningsNummer = bokningsnummer;
			StartDatum = startDatum;
			SlutDatum = slutDatum;
			Expedit = expedit;
			Medlem = medlem;
			LånadeBöcker = lånadeBöcker;
		}
		
	}
}
