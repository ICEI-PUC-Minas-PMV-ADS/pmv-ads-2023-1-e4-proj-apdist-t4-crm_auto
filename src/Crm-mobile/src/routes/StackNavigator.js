import * as React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";

// As telas que foram colocadas abaixo foi somente para testar as rotas para colocar as telas que foram desenvolvida basta importa la e substituir

import TelaA from "../screen/telaA";
import TelaB from "../screen/telaB";
import Login from "../screen/login";

const Stack = createNativeStackNavigator();

export default function Rotas() {
  return (
    <Stack.Navigator initialRouteName="Login">
      <Stack.Screen name="Login" component={Login} />
      <Stack.Screen name="TelaA" component={TelaA} />
      <Stack.Screen name="TelaB" component={TelaB} />
    </Stack.Navigator>
  );
}
