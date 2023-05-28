import React from "react";
import { useNavigation } from "@react-navigation/native";
import {
  Text,
  KeyboardAvoidingView,
  TextInput,
  StyleSheet,
  TouchableOpacity,
  Dimensions,
  Image,
  SafeAreaView,
  View,
  ScrollView,
} from "react-native";

import logo from "../../../assets/img/SVG-CRMobil-removebg.png";

export default function Servicos() {
  const navigation = useNavigation();
  return (
    <SafeAreaView
      style={styles.container}
      behavior={Platform.OS === "ios" ? "padding" : "height"}
    >
      <View style={styles.logoContainer}>
        <Image source={logo} style={[styles.logo, { tintColor: "#00385e" }]} />
      </View>

      <Text style={styles.titulo}>Serviços</Text>

      <View style={styles.container}>
        <ScrollView>
          <TouchableOpacity style={styles.botao}>
            <Text
              style={styles.textoBotao}
              onPress={() => navigation.navigate("TelaB")}
            >
              Serviço 1
            </Text>
          </TouchableOpacity>
          <TouchableOpacity style={styles.botao}>
            <Text
              style={styles.textoBotao}
              onPress={() => navigation.navigate("TelaB")}
            >
              Serviço 2
            </Text>
          </TouchableOpacity>
        </ScrollView>
      </View>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "#e6e6e6",
  },

  titulo: {
    textAlign: "center",
    fontSize: 30,
    lineHeight: 46,
    fontWeight: "bold",
    padding: 20,
    marginLeft: 10,
  },
  logoContainer: {
    width: "100%",
    alignItems: "flex-end",
    marginRight: 30,
    paddingTop: 20,
  },
  logo: {
    marginBottom: 16,
    width: 32,
    height: 32,
  },

  botao: {
    marginTop: 16,
    backgroundColor: "#005691",
    paddingVertical: 16,
    borderRadius: 6,
    width: Dimensions.get("window").width - 60, // Adjust the width based on your requirements
  },
  textoBotao: {
    textAlign: "center",
    color: "#fff",
    fontSize: 16,
    lineHeight: 26,
    fontWeight: "bold",
  },
});
