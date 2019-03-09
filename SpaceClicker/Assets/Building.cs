using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Code.Buildings{
    public class Building 
    {
        protected int[] resourceGeneration;

        public Building(int[] resourceGeneration){
            this.resourceGeneration = resourceGeneration;
        }
        public override string ToString(){
            string st = "";
            for(int i = 0; i < resourceGeneration.Length; i++){
                st += (i + ": " + resourceGeneration[i]);
            }
            return "Building with resource generation of:" + st;
        }
        
    }
}