using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code{
    public class Resources{
        // RESOURCES:
        // 0 : WATER
        // 1 : FOOD
        // 2 : POWER
        // 3 : TITANIUM
        // 4 : IRIDIUM
        // 5 : KHYBERIUM

        public static int NUM_OF_RESOURCES = 6;
        private int[] resources;

        public Resources(){
            resources = new int[NUM_OF_RESOURCES];
            for(int i = 0; i < resources.Length; i++)
                resources[i] = 0;
        }
        public Resources(int[] resourcesArray){
            resources = new int[NUM_OF_RESOURCES];
            for(int i = 0; i < resources.Length; i++){
                resources[i] = resourcesArray[i];
            }
        }
        public int[] GetResources(){
            return resources;
        }
        public Resources addResources(Resources addedResources){
            for(int i = 0; i < resources.Length; i++){
                resources[i] += addedResources.GetResources()[i];
            }
            return new Resources(resources);
        }

        public void removeResources(Resources removedResources){
            for(int i = 0; i < resources.Length; i++){
                resources[i] -= removedResources.GetResources()[i];
            }
        }
        public int GetWater(){
            return resources[0];
        }
        public int GetFood(){
            return resources[1];
        }
        public int GetPower(){
            return resources[2];
        }
        public int GetTitanium(){
            return resources[3];
        }
        public int GetIridium(){
            return resources[4];
        }
        public int GetKhyber(){
            return resources[5];
        }
        public void SetWater(int water){
            resources[0] = water;
        }
        public void SetFood(int food){
            resources[1] = food;
        }
        public void SetPower(int power){
            resources[2] = power;
        }
        public void SetTitanium(int titanium){
            resources[3] = titanium;
        }
        public void SetIridium(int iridium){
            resources[4] = iridium;
        }
        public void SetKhyber(int khyber){
            resources[5] = khyber;
        }

    }
}
