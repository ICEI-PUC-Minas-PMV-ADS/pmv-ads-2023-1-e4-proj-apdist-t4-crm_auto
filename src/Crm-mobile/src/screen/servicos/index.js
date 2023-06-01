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
  FlatList,
} from "react-native";

import logo from "../../../assets/img/SVG-CRMobil-removebg.png";

const data = [
  {
    id: "1",
    name: "OS:1591 Placa Veículo: RUH6G42",
  },
  { id: "2", name: "OS:1592  Placa Veículo: MAI6M22" },
  { id: "3", name: "OS:1593  Placa Veículo: POL6G18" },
  { id: "4", name: "OS:1593  Placa Veículo: POL6G18" },
  { id: "5", name: "OS:1593  Placa Veículo: POL6G18" },
  { id: "6", name: "OS:1593  Placa Veículo: POL6G18" },
  { id: "7", name: "OS:1593  Placa Veículo: POL6G18" },
  { id: "8", name: "OS:1593  Placa Veículo: POL6G18" },

  // Adicione mais itens conforme necessário
];

const Item = ({ name }) => {
  const navigation = useNavigation();
  return (
    <TouchableOpacity
      style={styles.item}
      onPress={() => navigation.navigate("Ordem de Serviços")}
    >
      <Text style={styles.itemText}>{name}</Text>
      <Text style={styles.statusText}>Concluído: 14/09/2023</Text>
    </TouchableOpacity>
  );
};

export default function Servicos() {
  return (
    <SafeAreaView
      style={styles.container}
      behavior={Platform.OS === "ios" ? "padding" : "height"}
    >
      <View style={styles.container}>
        <ScrollView>
          <View style={styles.logoContainer}>
            <Image
              source={logo}
              style={[styles.logo, { tintColor: "#00385e" }]}
            />
          </View>

          <Text style={styles.titulo}>Serviços</Text>

          <FlatList
            style={styles.list}
            data={data}
            renderItem={({ item }) => <Item name={item.name} />}
            keyExtractor={(item) => item.id}
          />
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
    fontSize: 35,
    lineHeight: 46,
    fontWeight: "bold",
    padding: 20,
    marginLeft: 10,
  },
  logoContainer: {
    width: "100%",
    alignItems: "center",
    paddingTop: 40,
  },
  logo: {
    marginBottom: 10,
    width: 50,
    height: 50,
  },

  list: {
    width: "100%",
  },
  item: {
    backgroundColor: "#0F6CBD",
    borderRadius: 6,
    padding: 20,
    marginBottom: 35,
    width: Dimensions.get("window").width - 50, // Adjust the width based on your requirements
  },
  itemText: {
    fontSize: 25,
    lineHeight: 40,
    color: "white",
  },
  statusText: {
    color: "#e6e6e6",
  },
});
