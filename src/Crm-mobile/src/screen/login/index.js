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
} from "react-native";

import logo from "../../../assets/img/SVG-CRMobil-removebg.png";

export default function Login() {
  const navigation = useNavigation();

  return (
    <KeyboardAvoidingView
      style={styles.container}
      behavior={Platform.OS === "ios" ? "padding" : "height"}
    >
      <Image source={logo} style={[styles.logo, { tintColor: "#00385e" }]} />
      <TextInput style={styles.textInput} placeholder="Digite seu E-mail" />
      <TextInput style={styles.textInput} placeholder="Digite sua Senha" />
      <TouchableOpacity style={styles.botao}>
        <Text
          style={styles.textoBotao}
          onPress={() => navigation.navigate("TelaA")}
        >
          Entrar
        </Text>
      </TouchableOpacity>
    </KeyboardAvoidingView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
    backgroundColor: "#e6e6e6",
  },
  textInput: {
    borderWidth: 1,
    borderColor: "#cccccc",
    width: Dimensions.get("window").width - 60, // Adjust the width based on your requirements
    margin: 16,
    padding: 20,
    borderRadius: 5,
    textAlign: "center",
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
  logo: {
    marginBottom: 16,
    width: 80,
    height: 80,
  },
});
