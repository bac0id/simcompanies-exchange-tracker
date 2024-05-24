#  Sim Companies Exchange Tracker

The Real-time Exchange Tracker of the [Sim Companies](https://www.simcompanies.com) on .NET 6.0 platform, based on [official API](https://www.simcompanies.com/articles/api). 

![screenshot](screenshot-1.png)

## Introduction

Sim Companies(SC) is an online company and product management game<sup>[1]</sup>. In SC, players buy and sell products on an open market. The price of product fluctuates with the demand of players. To make more profit, players like to trade with better price. So it's important to know the price of the product. 

## Related works

Related works in the field of tracking Sim Companies' exchange prices have been found to have limitations that hinder their effectiveness. The existing market page in SC provides only a snapshot of the prices at the time the page is opened, and it displays the price of only one type of product at a time. Although the market page can be refreshed every 20 seconds, it fails to provide historical price data.

An alternative solution is provided by Simco Tools<sup>[2]</sup>, a third-party website that utilizes the SC official API to retrieve and record data locally. However, due to the API rules of SC, the data is fetched only every 5 minutes<sup>[3]</sup>, resulting in a delay and lack of real-time information.

## Features

To address these shortcomings, in this repo, a Real-time Exchange Tracker is proposed and implemented with the following features: 

- Auto refresh the exchange information, with customizable refresh interval.
- Customize the list of your favourite products.
- Record recent and historic lowest/highest price.
- Change the color of text to notify if the current price of a product is lower than min/average price.

## How to use

1. Unzip the [releases file](https://github.com/bac0id/simcompanies-exchange-tracker/releases). 
3. Run the executive file `Sim Companies Exchange Tracker.exe`. 
3. Configuration. Add the [ID](docs/product-id-list.md) of your favourite products in list, and the other config as well. 
4. Wait for the first data update for few seconds. You may see the result like the screenshot above. 
5. If you wanna quit but save the recorded prices so far, click "Data-Save history" menu in program. 
6. If you wanna retrieve this data, click "Data-Load history". 

## License

This repository is under MIT License. 

![icon](https://d1fxy698ilbz6u.cloudfront.net/static/images/favico/favicon.ico)

The icon of executive file is a trademark of [Sim Companies](https://www.simcompanies.com) and is licensed by [Sim Companies](https://www.simcompanies.com). 

## References

\[1] Sim Companies. https://www.simcompanies.com

\[2] Simco Tools. https://www.simcotools.app

\[3] Sim Companies API Guide. https://www.simcompanies.com/articles/api
