﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultaCEP
{
    public class MontaBancoCEP
    {

        public List<ViaCEP> BancoVIACEP()
        {
            List<ViaCEP> ListCEP = new List<ViaCEP>();
            ConsultaVIACEP RetornoConsultaviaCEP = new ConsultaVIACEP();
            ViaCEP oViacep = new ViaCEP();

            String ListaCEP = "06716530;" +
                            "05108040;" +
                            "06142050;" +
                            "06683170;" +
                            "06186073;" +
                            "06286020;" +
                            "06286010;" +
                            "06016004;" +
                            "06322200;" +
                            "06385830;" +
                            "06436360;" +
                            "05366220;" +
                            "06018060;" +
                            "06090014;" +
                            "06110020;" +
                            "06083250;" +
                            "06018130;" +
                            "06093060;" +
                            "06110010;" +
                            "06018050;" +
                            "06018160;" +
                            "06093100;" +
                            "06083260;" +
                            "06093000;" +
                            "06013006;" +
                            "06093003;" +
                            "06013003;" +
                            "06093006;" +
                            "06013000;" +
                            "06093008;" +
                            "06013050;" +
                            "06097140;" +
                            "06093050;" +
                            "06018170;" +
                            "06018230;" +
                            "06097060;" +
                            "06093090;" +
                            "06093902;" +
                            "06018110;" +
                            "06010030;" +
                            "06090050;" +
                            "06090030;" +
                            "06090902;" +
                            "06090035;" +
                            "06016006;" +
                            "06110002;" +
                            "06097050;" +
                            "06018070;" +
                            "06110070;" +
                            "06083270;" +
                            "06010100;" +
                            "06018040;" +
                            "06010080;" +
                            "06013030;" +
                            "06013900;" +
                            "06086100;" +
                            "06010067;" +
                            "06110040;" +
                            "06016000;" +
                            "06016901;" +
                            "06016900;" +
                            "06010000;" +
                            "06016004;" +
                            "06010004;" +
                            "06010007;" +
                            "06016008;" +
                            "06090080;" +
                            "06010110;" +
                            "06010040;" +
                            "06097010;" +
                            "06090070;" +
                            "06090090;" +
                            "06086010;" +
                            "06018140;" +
                            "06010130;" +
                            "06097120;" +
                            "06016030;" +
                            "06010010;" +
                            "06097040;" +
                            "06090130;" +
                            "06090120;" +
                            "06016040;" +
                            "06016045;" +
                            "06010160;" +
                            "06110090;" +
                            "06010170;" +
                            "06086110;" +
                            "06010020;" +
                            "06010060;" +
                            "06010065;" +
                            "06010070;" +
                            "06010120;" +
                            "06013010;" +
                            "06013020;" +
                            "06013040;" +
                            "06016070;" +
                            "06016075;" +
                            "06018020;" +
                            "06018025;" +
                            "06018030;" +
                            "06018035;" +
                            "06018090;" +
                            "06018095;" +
                            "06018100;" +
                            "06018120;" +
                            "06018210;" +
                            "06018900;" +
                            "06018901;" +
                            "06018902;" +
                            "06018903;" +
                            "06086000;" +
                            "06086025;" +
                            "06086030;" +
                            "06086080;" +
                            "06086090;" +
                            "06090000;" +
                            "06090040;" +
                            "06090060;" +
                            "06090110;" +
                            "06093010;" +
                            "06093015;" +
                            "06093020;" +
                            "06093030;" +
                            "06093070;" +
                            "06093900;" +
                            "06093901;" +
                            "06093903;" +
                            "06097070;" +
                            "06097090;" +
                            "06097095;" +
                            "06097100;" +
                            "06097105;" +
                            "06097110;" +
                            "06097130;" +
                            "06097900;" +
                            "06110006;" +
                            "06110110;";

            string[] CEP = ListaCEP.Split(";");

            foreach (var cepaPesquisar in CEP)
            {
                try
                {
                    oViacep = RetornoConsultaviaCEP.Consulta(cepaPesquisar);
                    ListCEP.Add(oViacep);
                    Console.Write(".");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocorreu um erro na pesquisa do cep:" + cepaPesquisar);
                    Console.WriteLine(ex.Message.ToString());

                }
            }

            return ListCEP;
        }


    }
}