# SwissChoco

![SwissChoco Store](https://user-images.githubusercontent.com/7337672/52379074-4d626880-2a61-11e9-9744-cdd1d4fc0a43.jpg)

## Company Background

SwissChoco was a small family based company and now they have been bought out and they would like to invest in a new system.
The company oversees production of chocolates, from various manufacturers and then they distribute the chocolate.
They specalise in certain manufacturers at the moment but are looking to expand their accquisition. At the moment, they oversee/purchase from Lindt & Sprüngli as well as Milka.
SwissChoco currently documents any overseen production/stock on paper and since they want to expand their reach, they require a new system.

## Stakeholder Input

- Katie, a distribution manager at SwissChoco contacted me in regard to this project, she is the key stakeholder.
- The distribution managers need to have an overview of the system and any overseen production and the total stock of the chocolate.
- The accounts team need to know what orders have been placed and also access to the stock so they can make the necessary changes.
- I was informed by Katie that SwissChoco would like an ordering system for customers, but that seems like a separate project entirely and is not compulsory.

## Current System

- Currently SwissChoco uses a combination of a paper based system for storing the overseen chocolates and a spreadsheet for storing the chocolate stock.
- The distribution managers currently have an internal memo on all the overseen chocolates.
- The account managers log orders by invoice on pieces of paper and update the internal spreadsheet for total stock.
- This system is rather inconvenient as the staff must coordinate themselves to ensure that they don't overwrite others data entry.
- The new system will make use of transaction files to store the day-to-day data and update the master file periodically every 24hours.

## Scope

- The new system will need to store details of any overseen manufacturing, as well as new orders and the total stock level. This will be stored in a database.
- Orders will need to be sorted by date and stock will have to correlate to the specific products already being traded.
- Order invoices will need to be printed out as SwissChoco sends invoices via the postal system.
- Clients need to be stored as SwissChoco needs to contact them about order fulfillment.
- Factory employees will need to be able to enter any new stock that has been received from manufacturers.
- New chocolates must have CRUD views for overseen manufacturing and any chocolates being traded, as SwissChoco may opt not to sell specific products or may wish to modify details about the products.
- The stock system should be a real-time transaction based system so chocolates are not sold more than once.
