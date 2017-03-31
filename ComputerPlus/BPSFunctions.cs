﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using British_Policing_Script.API;
using British_Policing_Script;
using Rage;

namespace ComputerPlus
{
    static class BPSFunctions
    {
        static internal BritishPersona GetBritishPedPersonaForPed(Ped ped)
        {
            return Functions.GetBritishPersona(ped);
        }

        static internal VehicleRecords GetBritishVehicleRecordsForVehicle(Vehicle vehicle)
        {
            return Functions.GetVehicleRecords(vehicle);
        }

        static internal bool IsInsuredPedForVehicle()
        {

        }

        static internal BritishPersona CastPersona(LSPD_First_Response.Engine.Scripting.Entities.Persona PedPersona)
        {
            return PedPersona as British_Policing_Script.BritishPersona;
        }

        static internal BritishPersona CastPersona(System.Object PedPersona)
        {
            return PedPersona as British_Policing_Script.BritishPersona;
        }

        static internal VehicleRecords CastVehiclePersona(System.Object persona)
        {
            return persona as British_Policing_Script.VehicleRecords;
        }


        static internal String CastLicenseStatusToString(BritishPersona persona)
        {
            switch (persona.LicenceStatus)
            {
                case British_Policing_Script.BritishPersona.LicenceStatuses.Disqualified: return "Disqualified";
                case British_Policing_Script.BritishPersona.LicenceStatuses.Expired: return "Expired";
                case British_Policing_Script.BritishPersona.LicenceStatuses.Revoked: return "Revoked";
                default: return "Valid";
            }
        }

        static internal bool IsLicenseStatusValid(BritishPersona persona)        
        {
            switch (persona.LicenceStatus)
            {
                case British_Policing_Script.BritishPersona.LicenceStatuses.Disqualified:
                case British_Policing_Script.BritishPersona.LicenceStatuses.Expired:
                case British_Policing_Script.BritishPersona.LicenceStatuses.Revoked: return false;
                default: return true;
            }
        }


    }
}