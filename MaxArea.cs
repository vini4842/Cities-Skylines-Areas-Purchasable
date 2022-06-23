using System;
using System.IO;
using System.Reflection;
using ICities;
using UnityEngine;

namespace MaxAreaMod
{


     public class MaxArea: IUserMod
     {
          public void OnLoad()
          {

          }

          public void OnUnload()
          {
          }

          public string Name
          {
               get { return "All Areas purchaseable"; }
          }

          public string Description
          {
               get { return "Purchase up to 25 areas instead of 9"; }
          }
     }

     public class MaxAreaForGood: IAreasExtension
     {
	   public void OnCreated(IAreas areas)
  	   {
		areas.maxAreaCount = 25;
	   } 

    	   public void OnReleased()
	   {
			
	   } 

	   public bool OnCanUnlockArea(int x, int z, bool originalResult)
	   {
		return originalResult;
	   }
		
	   public int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
 	   {
		return originalPrice;
	   }
	
	   public void OnUnlockArea(int x, int z)
	   {
		
	   }
    	  
      }
} 