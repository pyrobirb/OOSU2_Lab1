﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Bok
    {

		public List<Bokning> BokningsLista = new List<Bokning>();

		private string ISBNnummer;
		public string ISBNNummer
		{
			get { return ISBNnummer; }
			set { ISBNnummer = value; }
		}

		private string titel;
		public string Titel
		{
			get { return titel; }
			set { titel = value; }
		}

		private string författare;
		public string Författare
		{
			get { return författare; }
			set { författare = value; }
		}


		//ta bort?
		private bool utlånad;
		public bool Utlånad
		{
			get { return utlånad; }
			set { utlånad = value; }
		}

		private int bokID;
		public int BokID
		{
			get { return bokID; }
			set { bokID = value; }
		}

		public string BokTitelFörfattare
		{
			get { return ISBNNummer + " " + Författare + " - " + Titel; }
		}

		public Bok(string isbnnr, string titel, string författare, bool utlånad, int bokID, List<Bokning> bokningslista)
		{
			ISBNNummer = isbnnr;
			Titel = titel;
			Författare = författare;
			Utlånad = utlånad;
			BokID = bokID;
			BokningsLista = bokningslista;
		}
		
	}
}
