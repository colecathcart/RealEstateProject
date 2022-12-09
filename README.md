# Real Estate Browsing Website
**Group 9:**
Cole Cathcart
Sami Taha
Vic (Vu) Phan
Samiha Hoque
Shardar Mohammed Quraishi

## Install/Run instructions
This project was created in visual studio & visual studio code with blazor and is a blazor webassembly project. The following instructions are for use in Visual Studio; VSCode setup requires additional steps that are not covered here (You must use Visual Studio /VSCode to run this webapp, we did not include an executable file in our repository):
1. In visual studio, either clone the project directly from the github url using the built-in github clone option, or download and unpack the zip file and open the folder "CPSC481Project" in visual studio. 
2. Click the green "run" button in the top menu. The webapp should open automatically in a browser page

You should now see the homepage of our application on the browser screen. Our project is a real-estate application where users can search for properties, view listing details, save and compare listings, and book showings. We have designed a minimalist interface that aims to appeal to both experienced buyers and those with less tech or market experience. Here is a guide on how to navigate our app and explore the features we have implemented:

1. **Homepage:** This is the landing page and also our main search page where users can search for properties. There are 3 principle options to search for houses that are to be used seperately: The large **search bar** allows you to search properties by address. Simply enter an address or part of an address and click the search button to see a list of houses with addresses matching your search (your search must exactly match part or all of a house address in the database, otherwise no results will be shown. Try just searching "Drive" or "SW" to see an example of this feature). The **search with filters** button will open a dropdown displaying many options for filtering. Within this menu is another dropdown to display advanced features likely to be used only by experienced users. Please note that not all of the filters have been implemented at this time. The filters that you can currently use are: Price min/max, no. of bed/bathrooms, property type (checkboxes), and year built (contained in the advanced filters dropdown). Once you have selected some filters, press the "search" button at the bottom of the dropdown to see results. Finally, the **explore all listings** button will show you all the listings in our database (please note that you may see some duplicate images of houses). After using one of these search tools, you will be taken to the search results page to see listings. The **saved** button in the top right will take you to the saved listings page. The "help" button will open a modal with a list of tips to use this page.
2. **Search Results:** This is the page where you will see all of the houses your search has turned up. There are many things to do on this page:
    * Listings: Each listing will display an image of the property, the addresss, some shorthand information and some buttons. Clicking on the **address** of the house (styled as a hyperlink) will take you to the house details page for that house (see below). Clicking on the **save** button will add that house to the saved houses list, and you can view it in the saved page (see below). You can click the save button again to un-save this house. Clicking on the "compare" button will take you to the compare page where this house can be easily compared against other houses of the current search (see below)
    * **Sort button:** at the top left of the listings is a sort button that allows you to sort the results in various ways. Please note that only the "price (lowest to highest)" and "price (highest to lowest)" are currently usable
    * Top buttons (navbar): Clicking the "back" button will take you back to the previous page (please note that this button is not currently implemented and will always take you back to the homepage from here). Clicking the "home" button will take you back to the homepage. Clicking the "saved" button will take you to the saved page, where you can see the houses you have saved. Clicking the "help" button will display a modal with a list of tips to use this page
    * "explore all listings" button: At the bottom of the page is another "explore all listings" button which will display all properties in the database if a user is unhappy with their search
    * **Modify Search:** This button will open a smaller version of the dropdown from the homepage which will allow you to modify your search from this page. Note that the same restrictions on usable filters from the homepage apply here. Press the "search" button with some new filters to see the results modified

3. **House Details Page:** This is the page that you will see if you click an address hyperlink from the search results page or saved page. You can see a carousel of images and all details pertaining to this property, along with some additional buttons:
    * **Image carousel:** This carousel displays images of the interior and exterior of the property. To change the main displayed image, select the arrow buttons on either side of the carousel
    * The "share" button will copy a link to your clipboard of this house page, allowing you to easily share it with others (please note that it does not actually copy a link despite the message) 
    * The "save" button will allow you save/unsave this house to the saved page
    * The **book a showing** button open a dropdown containing a form for booking an in-person showing with the realtor of this house. A date and time from the calendar can be selected, and your contact details can be entered to the right. Clicking the "confirm booking" button will close the dropdown and send your booking confirmation over email (please note that nothing will be sent to your email in reality. Also, the calendar is not fully functional. You can only select between December and January, and you can only select the 1st of the month. The availability dates do not change between houses)
    * The **Contact Realtor** button will open a form designed to provide a point of contact between users and realtors, or allow a use to ask a short question to a realtor. You can enter your contact details and message in the fields provided and click "contact realtor" to send the message to the realtor. You will recieve your response from the realtor via email or phone (please note that you will recieve no messages to either email or phone #. The realtor contact info does not change between houses)
    * The navbar home & save buttons function as described on other pages. The back button shown next to the address will take you pack to the previous page (note that like the other back buttons this only goes back to one page, in this case the search results page). The "help" button is not implemented for this page
4. **Saved Page:** You can get to this page by clicking the "saved" button on any other page. Here you will see a list of houses that you have clicked "save" on previously. The **un-save** button will immediately remove this house from the saved page. The **address** link of each house will take you to that house's details page. The other navbar buttons work as described previously, but the back button always takes you back to the search results page and the help button is not implemented.
5. **Compare Page:** You can get to this page by clicking the "compare" button on the search results page. This will bring you to a page where the house you clicked "compare" on will be stickied to the left side of the page showing some expanded info, and the remaining houses from the search results will be scrollable on the right. Clicking **compare** on another house from this list will stick that house to the right side of the page, allowing you to easily compare their features and differences. You can then click **cancel** on the right house to close it and comtinue comparing other houses in the list, while clicking cancel on the left house will exit the compare and return you to the search results page. Clicking the **save** button on any house will save that house to the saved page. The top navbar buttons work in the same way as described previously.





