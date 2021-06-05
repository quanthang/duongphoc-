using System;
using DuongsinhCs.controller;
using DuongsinhCs.entity;
using DuongsinhCs.view;
using StreetCRUD.model;

namespace DuongsinhCs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ViewDuongPho viewDuongPho = new ViewDuongPho();
            viewDuongPho.DuongPhoView();
        }
    }
}