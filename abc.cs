private bool testing()

        {

            cr = new CR();
 
            isSupported = false;
 
            if (cr != null)

            {

                if (cr.CENVersion >= CENVersion.CEN_VERSION_3_10)

                {

                        colouredGuidanceLightsSupported = true;

                }

            }
 
            

            return isSupported;

        }
