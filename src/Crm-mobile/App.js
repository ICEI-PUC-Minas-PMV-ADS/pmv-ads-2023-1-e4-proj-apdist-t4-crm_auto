import { StyleSheet, StatusBar } from "react-native";
import { NavigationContainer } from "@react-navigation/native";

import Rotas from "./src/routes/StackNavigator";
import { SafeAreaView } from "react-native-safe-area-context";

export default function App() {
  return (
    <NavigationContainer>
      <StatusBar />
      <Rotas />
    </NavigationContainer>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#fff",
    alignItems: "center",
    justifyContent: "center",
  },
});
