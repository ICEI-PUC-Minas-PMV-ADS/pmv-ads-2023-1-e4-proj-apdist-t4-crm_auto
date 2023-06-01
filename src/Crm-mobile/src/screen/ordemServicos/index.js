import React from "react";
import { useNavigation } from "@react-navigation/native";
import {
  View,
  Text,
  Image,
  StyleSheet,
  ScrollView,
  Dimensions,
  SafeAreaView,
} from "react-native";

import logo from "../../../assets/img/SVG-CRMobil-removebg.png";

const App = () => {
  const navigation = useNavigation();
  const services = [
    {
      name: "Troca de Óleo",
      value: "R$ 90,00",
      startDate: "13/09/2023",
      deliveryDate: "14/09/2023",
    },
    {
      name: "Troca do Amortecedor",
      value: "R$ 136,00",
      startDate: "13/09/2023",
      deliveryDate: "14/09/2023",
    },
    {
      name: "Troca da Correia Dentada",
      value: "R$ 301,00",
      startDate: "13/09/2023",
      deliveryDate: "14/09/2023",
    },
  ];

  // Função para calcular o valor total da ordem de serviço
  const calculateTotal = () => {
    let total = 0;
    services.forEach((service) => {
      const value = parseFloat(
        service.value.replace("R$", "").replace(",", ".")
      );
      total += value;
    });
    return total.toFixed(2);
  };

  return (
    <SafeAreaView
      style={styles.container}
      behavior={Platform.OS === "ios" ? "padding" : "height"}
    >
      <ScrollView>
        <View style={styles.header}>
          <Image source={logo} style={styles.logo} />
        </View>

        <Text style={styles.placaText}>Placa Veículo: RUH6G42</Text>
        <Text style={styles.ordemText}>
          Ordem de serviço: 1593 Data: 12//09/2023
        </Text>

        <View style={styles.titleContainer}>
          <Text style={styles.titleText}>Itens da Ordem de Serviço</Text>
        </View>

        {services.map((service, index) => (
          <View key={index} style={styles.serviceContainer}>
            {service.name === "Troca de Óleo" ? (
              <Text style={[styles.serviceText, { fontSize: 16 }]}>
                Troca de Óleo
              </Text>
            ) : (
              <Text style={[styles.serviceText, { fontSize: 16 }]}>
                {service.name}
              </Text>
            )}
            <Text style={[styles.serviceText, { fontSize: 14 }]}>
              Valor: {service.value}
            </Text>
            <Text style={[styles.serviceText, { fontSize: 14 }]}>
              Data de Início: {service.startDate}
            </Text>
            <Text style={[styles.serviceText, { fontSize: 14 }]}>
              Previsão de Entrega: {service.deliveryDate}
            </Text>
          </View>
        ))}

        <View style={styles.footer}>
          <Text style={styles.totalText}>
            Valor Total da OS: R$ {calculateTotal()}
          </Text>
        </View>
      </ScrollView>
    </SafeAreaView>
  );
};

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: "#e6e6e6",
    margin: 0,
  },
  header: {
    height: 120,
    backgroundColor: "#0F6CBD",
    justifyContent: "center",
    alignItems: "center",
  },
  footer: {
    height: 100,
    backgroundColor: "#0F6CBD",
    justifyContent: "center",
    alignItems: "center",
    borderRadius: 6,
  },
  placaText: {
    fontSize: 16,
    fontWeight: "bold",
    alignSelf: "center",
    marginTop: 10,
  },
  ordemText: {
    fontSize: 16,
    fontWeight: "bold",
    alignSelf: "center",
    marginTop: 0,
  },
  titleContainer: {
    backgroundColor: "#B0C4DE",
    marginVertical: 30,
    paddingHorizontal: 20,
  },
  titleText: {
    fontSize: 20,
    fontWeight: "bold",
    alignSelf: "center",
    marginVertical: 10,
  },
  logo: {
    width: 50,
    height: 50,
  },
  serviceContainer: {
    marginVertical: 40,
  },
  serviceText: {
    fontSize: 12,
    fontWeight: "bold",
    marginLeft: 15,
  },
  totalText: {
    fontSize: 19,
    fontWeight: "bold",
    color: "white",
  },
});

export default App;
