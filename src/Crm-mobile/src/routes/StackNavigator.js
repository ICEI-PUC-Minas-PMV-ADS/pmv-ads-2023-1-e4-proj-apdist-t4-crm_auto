import * as React from "react";
import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";

// As telas que foram colocadas abaixo foi somente para testar as rotas para colocar as telas que foram desenvolvida basta importa la e substituir

import Servicos from "../screen/servicos";
import OS from "../screen/ordemServicos";
import Login from "../screen/login";

const Stack = createNativeStackNavigator();

export default function Rotas() {
  return (
    <Stack.Navigator initialRouteName="Login">
      <Stack.Screen
        name="Login"
        component={Login}
        options={{ headerShown: false }}
      />
      <Stack.Screen
        name="Serviços"
        component={Servicos}
        options={{ headerShown: false }}
      />
      <Stack.Screen name="Ordem de Serviços" component={OS} />
    </Stack.Navigator>
  );
}
