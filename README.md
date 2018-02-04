# LibPhoneNumber ASP .Net Web API implementation

This project shows a simple example on how LibPhoneNumber can be used to parse phone numbers easily.   
This project has 2 endpoints: [POST] /api/libphone and [GET] /api/libphone/GetString/{string}.   
The [GET] endpoint allows you to pass a value in the URI while the [POST] requires you to submit a value in the request body, with the content type: application/json   
## Getting Started

### Prerequisites

Need to have Visual Studio installed. Note: This project has only been tested with Visual Studio Enterprise 2017.

### Installing

1. Clone the repo and open the project file in Visual Studio.    
2. Build solution.   

## Running the tests

For testing I recommend [Fiddler](https://www.telerik.com/fiddler).    

Steps for testing:   

1. In visual studio Debug->"start without debugging"   
2. Make note of the url that your API is running on (will open in your browser).   
3. In Fiddler click on the composer tab.   
4. Input your API request by filling out the fields.   
5. On the left side you will see the api response.   

