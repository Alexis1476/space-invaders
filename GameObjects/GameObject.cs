﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SpaceInvaders
{
    class GameObject
    {
        #region Attributs
        /// <summary>
        /// Position sur l'axe X de la console
        /// </summary>
        int _posX;
        /// <summary>
        /// Position sur l'axe Y de la console
        /// </summary>
        int _posY;
        /// <summary>
        /// Image de l'objet faite avec des caractères
        /// </summary>
        string _chars;
        /// <summary>
        /// Largeur de l'objet
        /// </summary>
        int _widthChars;
        #endregion

        #region Constructeurs
        public GameObject(int posX, int posY, string chars)
        {
            _posX = posX;
            _posY = posY;
            _chars = chars;
            _widthChars = CalculateCharsWidth(_chars);
        }
        #endregion

        #region Getteurs et setteurs
        public int PosX
        {
            get { return _posX; }
            set { _posX = value; }
        }
        public int PosY
        {
            get { return _posY; }
            set { _posY = value; }
        }
        public int Widthchars
        {
            get { return _widthChars; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Calcule la largeur des caractères de l'objet
        /// </summary>
        /// <param name="chars">Caractères de l'objet</param>
        /// <returns>Largeur de l'objet</returns>
        private int CalculateCharsWidth(string chars)
        {
            string line = "";
            using (StringReader reader = new StringReader(chars))
            {      
                line = reader.ReadLine();
                return line.Length;
            }
        }
        #endregion
    }
}
