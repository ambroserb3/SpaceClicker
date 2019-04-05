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
        public static Resources EarthResourceGeneration(){
            return new Resources(new int[] {10,10,10,5,5,0});
        }
        public static Resources WaterResourceGeneration(){
            return new Resources(new int[] {10,10,10,5,5,0});
        }
        public static Resources SandResourceGeneration(){
            return new Resources(new int[] {10,10,10,5,5,0});
        }
        public static Resources DarkResourceGeneration(){
            return new Resources(new int[] {10,10,10,5,5,0});
        }
        public static Resources BuildingResourceOptimizer(string planetName, int[] buildings){
            if(buildings.Length != BuildingView.BUILDING_NAMES.Length)
                return null;
            if(planetName == "Earth-Planet")
                return new Resources(new int[]{buildings[0] * 5, buildings[1] * 4, buildings[2] * 4, buildings[3] * 3, buildings[4] * 3, buildings[5] * 4});
            if(planetName == "Water-Planet")
                return  new Resources(new int[]{buildings[0] * 3, buildings[1] * 3, buildings[2] * 2, buildings[3] * 4, buildings[4] * 2, buildings[5] * 3});
            if(planetName == "Sand-Planet")
                return  new Resources(new int[]{buildings[0] * 2, buildings[1] * 4, buildings[2] * 3, buildings[3] * 2, buildings[4] * 1, buildings[5] * 4});
            if(planetName == "Dark-Planet")
                return  new Resources(new int[]{buildings[0] * 0, buildings[1] * 2, buildings[2] * 1, buildings[3] * 1, buildings[4] * 4, buildings[5] * 2});
            return null;

        }
        public static Resources GetPlanetResourceGeneration(string planetName){
            if(planetName == "Earth-Planet")
                return EarthResourceGeneration();
            if(planetName == "Water-Planet")
                return WaterResourceGeneration();
            if(planetName == "Sand-Planet")
                return SandResourceGeneration();
            if(planetName == "Dark-Planet")
                return DarkResourceGeneration();
            return null;
        }
        public static Resources GetOptimizedPlanetGeneration(string planetName, int[] buildings){
            Resources planetResources = GetPlanetResourceGeneration(planetName);
            Resources optimizedBuildingResources = BuildingResourceOptimizer(planetName, buildings);
            return planetResources.addResources(optimizedBuildingResources);
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
