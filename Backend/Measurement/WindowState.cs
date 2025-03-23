using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackendCS.Measurement
{
   public interface WindowState
   {

   }
   public class HomeWindow : WindowState
   {
      private static HomeWindow instance;
      private HomeWindow() { }
      public static HomeWindow getHomeWindow()
      {
         if (instance == null)
         {
            instance = new HomeWindow();
         }
         return instance;
      }


   }


   public class MotionWindow : WindowState
   {
      private static MotionWindow instance;
      private MotionWindow() { }
      public static MotionWindow getMotionWindow()
      {
         if (instance == null)
         {
            instance = new MotionWindow();
         }
         return instance;
      }


   }


   public class HeartWindow : WindowState
   {
      private static HeartWindow instance;
      private HeartWindow() { }
      public static HeartWindow getHeartWindow()
      {
         if (instance == null)
         {
            instance = new HeartWindow();
         }
         return instance;
      }

   }


   public class EnvironmentWindow : WindowState
   {
      private static EnvironmentWindow instance;
      private EnvironmentWindow() { }
      public static EnvironmentWindow getEnvironmentWindow()
      {
         if (instance == null)
         {
            instance = new EnvironmentWindow();
         }
         return instance;
      }

   }
}
