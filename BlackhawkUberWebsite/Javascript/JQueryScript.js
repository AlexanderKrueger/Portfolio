$(document)
.ready
(
  function()
  {
    $("#form_submit").click(function() { $("#jquery_form").validate(); });
    $("#jquery_form")
    .validate
    ({
      rules:
        {
          form_first_name:
            {
              required: true
            },
          form_last_name:
            {
              required: true
            },
          form_address:
            {
              required: true
            },
          form_city:
            {
              required: true
            },
          form_state:
            {
              required: true
            },
          radioGroup1:
            {
              required: true
            },
          form_zip:
            {
              pattern:"(([0-9]{5}[ ][0-9]{4})|([0-9]{5}))",
              required: true
            },
          form_email:
            {
              email:true,
              required: true
            },
          form_phone:
            {
              pattern: "(([(][0-9]{3}[)]( |)[0-9]{3}-[0-9]{4})|([0-9]{3}-[0-9]{3}-[0-9]{4}))",
              required: true
            },
          form_username:
            {
              pattern: "[0-9]{9}",
              required: true
            },
          form_password:
            {
              required: true
            }
        },
      messages:
        {
          form_first_name:
            {
              required: "first name is required"
            },
          form_last_name:
            {
              required: "last name is required"
            },
          form_address:
            {
              required: "address is required"
            },
          form_city:
            {
              required: "city is required"
            },
          form_state:
            {
              required: "state is required"
            },
          radioGroup1:
            {
              required: "please select a radio button"
            },
          form_zip:
            {
              pattern:"Please follow zip format: nnnnn Or nnnnn nnnn",
              required: "zip code is required"
            },
          form_email:
            {
              email:"invalid email, follow format: i.e. 'thing@domaion.net'",
              required: "email is required"
            },
          form_phone:
            {
              pattern: "this is not a valid phone number",
              required: "phone number is required"
            },
          form_username:
            {
              pattern: "BTC ID must be 9 numeric characters",
              required: "BTC ID is required"
            },
          form_password:
            {
              required: "BTC password is required"
            }
        }
    });
  }
);