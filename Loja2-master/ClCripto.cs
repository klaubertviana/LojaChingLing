namespace LojaCL {

    class ClCripto {

        public string Base64Encode ( string textoencode ) {
            var textoencodebytes = System.Text.Encoding.UTF8.GetBytes(textoencode);
            return System.Convert.ToBase64String ( textoencodebytes );
        }

        public string Base64Decode ( string textodecode ) {
            var textocodebytes = System.Convert.FromBase64String(textodecode);
            return System.Text.Encoding.UTF8.GetString ( textocodebytes );

        }

    }
}
